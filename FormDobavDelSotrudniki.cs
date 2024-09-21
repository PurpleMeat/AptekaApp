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
    public partial class FormDobavDelSotrudniki : Form
    {
        int i = 0; string login,telef; byte[] picBytes; string dlj, mesto;
        SqlConnection con = new SqlConnection(ConString.connection);

        public FormDobavDelSotrudniki()
        {
            i = 1;
            InitializeComponent();

            cBDolj.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMestoRab.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Text = "Добавление сотрудника";

            StandartPic();

        }       

        public FormDobavDelSotrudniki(string log, string fam, string nam, string otch, string tel, string pas, string dolj, string mestoRab, byte[] pic)
        {
            login = log;
            telef = tel;
            i = 0;
            InitializeComponent();        

            tBLogin.Text =log;
            tBName.Text = nam;
            tBFamil.Text =fam;
            tBOtch.Text = otch;
            tBTelefon.Text = tel;                    
            tBPassword.Text = pas; 
            setPic(pic);
            dlj=dolj;
            mesto = mestoRab;

            this.Text = "Изменение сотрудника";
        }
        private void StandartPic() //устанавливается картинка по умолчанию при добавлении, если не выбрано другое фото
        {
            var path = $"{Directory.GetCurrentDirectory()}\\avatar.jpg";
            picBytes = File.ReadAllBytes(path);
            var ms = new System.IO.MemoryStream(picBytes);
            var img = Image.FromStream(ms);
            pictureBoxSotrud.Image = img;

        }

        private void setPic(byte[] p) //устанавливаем фото из бд
        {
            picBytes = p; 
            var ms = new System.IO.MemoryStream(picBytes);
            var img = Image.FromStream(ms);
            pictureBoxSotrud.Image = img;         

        }        
        private void butSave_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (Proverka() == 0)
                {
                    try
                    {
                        con.Open();
                        string query = "insert into Пользователи(Логин, Фамилия, Имя, Отчество, Телефон, Роль, Пароль, Фото) values('" + tBLogin.Text + "', '" + tBFamil.Text + "', '" + tBName.Text + "', '" + tBOtch.Text + "', '" + tBTelefon.Text + "','Сотрудник', '" + tBPassword.Text + "', @pic )";

                        SqlCommand db = new SqlCommand(query, con);
                        db.Parameters.AddWithValue("@pic", picBytes);

                        db.ExecuteNonQuery();
                        db = new SqlCommand("select Код_аптеки from Аптеки where Адрес='" + cBMestoRab.Text + "' ", con);
                        string ka = db.ExecuteScalar().ToString();

                        db = new SqlCommand("insert into Сотрудники_Должности(Код_сотрудника, Должность, Код_аптеки) values('" + tBLogin.Text + "', '" + cBDolj.Text + "', '" + ka + "')", con);
                        db.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Данные добавлены!");

                        butSave.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Ошибка, проверьте данные!");
                        con.Close();
                    }

                }
            }
            else if (i == 0)
            {
                if (Proverka() == 0)
                {
                    try
                    {
                        con.Open();
                        string query = "update Пользователи set Логин = '" + tBLogin.Text + "', Фамилия = '" + tBFamil.Text + "', Имя = '" + tBName.Text +
                            "', Отчество='" + tBOtch.Text + "', Телефон='" + tBTelefon.Text + "', Пароль='" + tBPassword.Text + "', Фото=@pic where Логин = '" + login + "' ";

                        SqlCommand db = new SqlCommand(query, con);
                        db.Parameters.AddWithValue("@pic", picBytes);
                        db.ExecuteNonQuery();

                        db = new SqlCommand("select Код_аптеки from Аптеки where Адрес='" + cBMestoRab.Text + "' ", con);
                        string ka = db.ExecuteScalar().ToString();

                        db = new SqlCommand("update Сотрудники_Должности set Должность ='" + cBDolj.Text + "', Код_аптеки = '" + ka + "' where Код_сотрудника='" + login + "' ", con);
                        db.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("Данные изменены!");

                        butSave.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Ошибка, проверьте данные!");
                        con.Close();
                    }

                }
            }

        }
        private int Proverka()
        {
            if (string.IsNullOrWhiteSpace(tBLogin.Text) || string.IsNullOrWhiteSpace(tBName.Text) || string.IsNullOrWhiteSpace(tBFamil.Text)
                || string.IsNullOrWhiteSpace(tBTelefon.Text) || string.IsNullOrWhiteSpace(tBPassword.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return 1;
            }
            else if (tBPassword.TextLength < 8)
            {
                MessageBox.Show("Пароль должен быть не мнее 8 символов!");
                return 1;
            }
            else if (tBLogin.Text == login) //если не менял логин
            {
                if (tBTelefon.Text == telef) { return 0; } // и телефон
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(Телефон) from Пользователи where Телефон='" + tBTelefon.Text + "' ", con);

                    string x2 = cmd.ExecuteScalar().ToString();
                    con.Close();

                    if (x2 == "1")
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
            else //если логин пользователь поменял  или добавление
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
                    else if (tBTelefon.Text == telef)
                    {
                        return 0;
                    }
                    else //если менял телефон
                    {
                        con.Open();
                        cmd = new SqlCommand("select count(Телефон) from Пользователи where Телефон='" + tBTelefon.Text + "' ", con);

                        string x2 = cmd.ExecuteScalar().ToString();
                        con.Close();

                        if (x2 == "1")
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

        }

        private void linkChangePhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                picBytes = File.ReadAllBytes(fileName);

                try
                {
                    var ms = new System.IO.MemoryStream(picBytes);
                    var img = Image.FromStream(ms);
                    pictureBoxSotrud.Image = img;                   

                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Выберите фото!");
                }

            }
        }

        private void tBPassword_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (Keys)e.KeyChar == Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '+' || e.KeyChar == '-'
               || e.KeyChar == '_')
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Допустимы только латинские буквы и цbфры, а также +, - и _!");
            }
        }

        private void FormDobavDelSotrudniki_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.аптекиTableAdapter.Fill(this.appteki2DataSet.Аптеки);           
            this.должностиTableAdapter.Fill(this.appteki2DataSet.Должности);

            if (i == 0)
            {
                cBDolj.Text = dlj;
                cBApteka.Text = mesto; 
            }

        }
    }
}
