using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppApteki
{
    public partial class FormRegist : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormRegist()
        {
            InitializeComponent();
            butBack.DialogResult = DialogResult.Cancel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void butBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void butRegist_Click(object sender, EventArgs e)
        {

            if (Proverka() == 0)
            {
                con.Open();
                try
                {
                    var path = $"{Directory.GetCurrentDirectory()}\\avatar.jpg";
                    byte[] bytes = File.ReadAllBytes(path);

                    string query2 = "insert into Пользователи(Логин, Фамилия, Имя, Отчество, Телефон, Роль, Пароль, Фото) values(@log, @fam, @nam, @otch, @tel, 'Клиент', @pas, @pic)";
                    SqlCommand cmd3 = new SqlCommand(query2, con);

                    cmd3.Parameters.AddWithValue("@log", tBLogin.Text);

                    cmd3.Parameters.AddWithValue("@fam", tBFamil.Text);
                    cmd3.Parameters.AddWithValue("@nam", tBName.Text);
                    cmd3.Parameters.AddWithValue("@otch", tBOtch.Text);
                    cmd3.Parameters.AddWithValue("@tel", tBTelefon.Text);
                    cmd3.Parameters.AddWithValue("@pas", tBPass.Text);
                    cmd3.Parameters.AddWithValue("@pic", bytes);


                    cmd3.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Регистрация прошла успешно!");
                    //butRegist.DialogResult = DialogResult.OK;

                    this.Close();
                }

                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Ошибка, проверьте данные!");
                    con.Close();
                }
            }                
            
        }         
        private int Proverka()
        {
            if (string.IsNullOrWhiteSpace(tBLogin.Text) || string.IsNullOrWhiteSpace(tBFamil.Text)
                || string.IsNullOrWhiteSpace(tBName.Text) || string.IsNullOrWhiteSpace(tBTelefon.Text) || string.IsNullOrWhiteSpace(tBPass.Text))
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else if (tBPass.TextLength < 8)
            {
                MessageBox.Show("Пароль должен иметь длину не менее 8 символов!");
                return 1;
            }
            else
            {
                if (tBLogin.TextLength < 3)
                {
                    MessageBox.Show("Логин должен быть не менее 3 символов!");
                    return 1;
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(Логин) from Пользователи where Логин='" + tBLogin.Text + "' ", con);

                    string x = cmd.ExecuteScalar().ToString();
                    con.Close();

                    if (x == "1")
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует! Попробуйте еще раз.");
                        return 1;
                    }
                    con.Open();
                    cmd = new SqlCommand("select count(Телефон) from Пользователи where Телефон='" + tBTelefon.Text + "' ", con);

                    x = cmd.ExecuteScalar().ToString();
                    con.Close();
                    if (x == "1")
                    {
                        MessageBox.Show("Пользователь с таким номером телефона уже существует! Попробуйте еще раз.");
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private void tBPass_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (Keys)e.KeyChar == Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '+' || e.KeyChar == '-'
                || e.KeyChar == '_')
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Допустимы только латинские буквы и цифры, а также +, - и _!");
            }
        }
    }
}
