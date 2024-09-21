using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.IO;

namespace AppApteki
{
    public partial class Avtorization : Form
    {        
        public Avtorization()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           

        }

        SqlConnection con = new SqlConnection(ConString.connection);

        private void butVxod_Click(object sender, EventArgs e)
        {            

            if (string.IsNullOrWhiteSpace(tbLogin.Text) || string.IsNullOrWhiteSpace(tbPass.Text)) 
            {
                MessageBox.Show("Заполните все поля!","Предупреждение");
            }
            else
            {
                RoleSearch();
              
            }
        }

        private void openText_CheckedChanged(object sender, EventArgs e)
        {
            if (openText.Checked)
                tbPass.UseSystemPasswordChar = true;
            else
                tbPass.UseSystemPasswordChar = false;
        }    

        private void linkRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormRegist reg = new FormRegist();

            this.Hide();
            if (reg.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else if (reg.ShowDialog()==DialogResult.OK)
                this.Show();

        }

        private void RoleSearch()
        {        
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Логин) from Пользователи where Логин='" + tbLogin.Text + "' AND Пароль='" + tbPass.Text + "' and Роль='Клиент'", con);
            string k = cmd.ExecuteScalar().ToString();
            con.Close();
            
            if (k == "1")
            {
                ClientVhod(0);
            }
            else
            {
            
                con.Open();
                cmd = new SqlCommand("select count(Логин) from Пользователи where Логин='" + tbLogin.Text + "' AND Пароль='" + tbPass.Text + "' and Роль='Сотрудник' ", con);
                string s = cmd.ExecuteScalar().ToString();
                con.Close();
                if (s == "1")
                {                    
                ClientVhod(1);
                }
                else { MessageBox.Show("Пользователь не найден! Попробуйте еще раз."); }
            
               
            }            
          
          
        }
       
        void ClientVhod(int r)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Пользователи where Логин='" + tbLogin.Text + "' and Пароль='" + tbPass.Text + "' ", con);

            SqlDataReader reader = cmd.ExecuteReader(); //читает инфу в запросе        

            while (reader.Read())
            {

                PersInfo.Login = reader.GetString(0);
                PersInfo.Famil = reader.GetString(1);
                PersInfo.Name = reader.GetString(2);
                PersInfo.Otch = reader.GetString(3);
                PersInfo.Telef = reader.GetString(4);
                PersInfo.Rol = reader.GetString(5);
                PersInfo.Pass = reader.GetString(6);
                             
            }
            con.Close();
            GetPict(tbLogin.Text);

            tbLogin.Text = "";
            tbPass.Text = "";
            openText.Checked = false;

            if (r == 0) //если клиент
            {

                FormForClient cl = new FormForClient(); this.Hide();

                if (cl.ShowDialog() == DialogResult.No)
                    this.Show();
                else
                    this.Close();
            }
            else if(r==1) //если сотрудник
            {
                con.Open();
                cmd = new SqlCommand("select Должность from Сотрудники_Должности join Пользователи on Пользователи.Логин = Сотрудники_Должности.Код_сотрудника where Логин = '" + PersInfo.Login+ "'", con);
                string res = cmd.ExecuteScalar().ToString();
                con.Close();

                if (res == "Администратор")
                { 
                    AllMain a1 = new AllMain();
                    this.Hide();

                    if (a1.ShowDialog() == DialogResult.No)
                        this.Show();
                    else
                        this.Close();
                }
                else //остальные сотруднкии как клиенты
                {
                    FormForClient cl = new FormForClient(); this.Hide();

                    if (cl.ShowDialog() == DialogResult.No)
                        this.Show();
                    else
                        this.Close();
                }
            }
            
        }

        void SotrudVhod()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Пользователи where Логин='" + tbLogin.Text + "' and Пароль='" + tbPass.Text + "' ", con);

            SqlDataReader reader = cmd.ExecuteReader();        

            while (reader.Read())
            {

                PersInfo.Login = reader.GetString(0);
                PersInfo.Famil = reader.GetString(1);
                PersInfo.Name = reader.GetString(2);
                PersInfo.Otch = reader.GetString(3);
                PersInfo.Telef = reader.GetString(4);
                PersInfo.Rol = reader.GetString(5);
                PersInfo.Pass = reader.GetString(6);

            }
            con.Close();
            GetPict(tbLogin.Text);

            tbLogin.Text = "";
            tbPass.Text = "";


        }

        public void GetPict(string log) //получаем массив байтов картинки
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Фото from Пользователи where Логин ='"+log+"' ", con); ;
            try
            {
                byte[] bytes2 = (byte[])cmd.ExecuteScalar();
                con.Close();

                PersInfo.bytes = bytes2;
            }
            catch (System.InvalidCastException) //если фото отсутсвует по какой-то причине
            {
                con.Close();
                var path = $"{Directory.GetCurrentDirectory()}\\avatar.jpg";             
                    byte[] bytes = File.ReadAllBytes(path);

                cmd = new SqlCommand("update Пользователи set Фото =@pic where Логин ='" + log + "' ", con);
                cmd.Parameters.AddWithValue("@pic", bytes);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                PersInfo.bytes = bytes;                
                
            }

        }

        private void Avtorization_Load(object sender, EventArgs e)
        {
            
        }

        private void tbPass_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (Keys)e.KeyChar == Keys.Back || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar=='+' || e.KeyChar=='-'
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
