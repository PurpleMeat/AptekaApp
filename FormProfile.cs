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
using System.IO;
using Microsoft.VisualBasic;

namespace AppApteki
{
    public partial class FormProfile : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        int otmena;
        public FormProfile()
        {
            InitializeComponent();
            butBack.DialogResult = DialogResult.Cancel;
            tBChangeLog.Hide(); tBChangeFam.Hide(); tBChangeNam.Hide(); tBChangeOtch.Hide(); tBChangeTel.Hide(); butSaveChange.Hide(); butCancel.Hide();

            ShowData();
            if(PersInfo.bytes == null)            
                pictureProfile2.Image = Properties.Resources.profile;            
            else
                setPicture(PersInfo.bytes);

            
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkChangePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            byte[] picBytes;
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    picBytes = File.ReadAllBytes(fileName);

                    try
                    {
                        setPicture(picBytes);
                        string sql = "update Пользователи set Фото = @Data where Логин ='" + PersInfo.Login + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@Data", picBytes);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        PersInfo.bytes = picBytes;

                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Выберите фото!");
                    }   

                }               
                
            }
        }

        private void setPicture(byte[] b) //из массива байтов делает картинку
        {            
                var ms = new System.IO.MemoryStream(b);
                var img = Image.FromStream(ms);
                pictureProfile2.Image = img;           
           
        }

        private void ShowData()
        {
            labLogin.Text = PersInfo.Login;
            labName.Text = PersInfo.Name;
            labFamil.Text = PersInfo.Famil;
            labOtch.Text = PersInfo.Otch;
            labTel.Text = PersInfo.Telef;
        }

        private void butRedact_Click(object sender, EventArgs e)
        {
            tBChangeLog.Show(); tBChangeFam.Show(); tBChangeNam.Show(); tBChangeOtch.Show(); tBChangeTel.Show();
            butSaveChange.Show(); butCancel.Show();

            butPassRedact.Hide(); butRedact.Hide();

            tBChangeLog.Text = PersInfo.Login;
            tBChangeFam.Text = PersInfo.Famil;
            tBChangeNam.Text = PersInfo.Name;
            tBChangeOtch.Text = PersInfo.Otch;
            tBChangeTel.Text = PersInfo.Telef;
        }

        private void UpdateData()
        {
            if (otmena == 1)
            {
                tBChangeLog.Hide(); tBChangeFam.Hide(); tBChangeNam.Hide(); tBChangeOtch.Hide(); tBChangeTel.Hide(); butSaveChange.Hide(); butCancel.Hide();

                butPassRedact.Show(); butRedact.Show();
                otmena = 0;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update Пользователи set Логин='" + tBChangeLog.Text + "', Фамилия ='" + tBChangeFam.Text + "', Имя='" + tBChangeNam.Text + "', Отчество='" + tBChangeOtch.Text + "', Телефон='" + tBChangeTel.Text + "' where Логин='" + PersInfo.Login + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Данные успешно изменены!");
                PersInfo.Login = tBChangeLog.Text;
                PersInfo.Famil = tBChangeFam.Text;
                PersInfo.Name = tBChangeNam.Text;
                PersInfo.Otch = tBChangeOtch.Text;
                PersInfo.Telef = tBChangeTel.Text;

                ShowData();

                tBChangeLog.Hide(); tBChangeFam.Hide(); tBChangeNam.Hide(); tBChangeOtch.Hide(); tBChangeTel.Hide(); butSaveChange.Hide(); butCancel.Hide();

                butPassRedact.Show(); butRedact.Show();
            }          
        }

        private void butSaveChange_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrEmpty(tBChangeLog.Text) || string.IsNullOrEmpty(tBChangeFam.Text) || string.IsNullOrEmpty(tBChangeNam.Text) || string.IsNullOrEmpty(tBChangeTel.Text))
            {
                MessageBox.Show("заполните все поля!");
            }
            else if (tBChangeLog.Text == PersInfo.Login ) //если не менял логин и телефон
            { 
                if (tBChangeTel.Text == PersInfo.Telef)
                {
                    UpdateData(); 
                }
                else 
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(Телефон) from Пользователи where Телефон='" + tBChangeTel.Text + "' ", con);

                    string x = cmd.ExecuteScalar().ToString();
                    con.Close();

                    if (x == "1")
                    {
                        MessageBox.Show("Пользователь с таким номером телефона уже существует! Попробуйте еще раз.");
                    }
                    else { UpdateData(); }
                }
            }
            else //если поменял логин
            {
                if (tBChangeLog.TextLength < 3)
                {
                    MessageBox.Show("Логин должен быть не менее 3 символов!");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(Логин) from Пользователи where Логин='" + tBChangeLog.Text + "'", con);

                    string x = cmd.ExecuteScalar().ToString();
                    con.Close();

                    if (x == "1")
                    { MessageBox.Show("Пользователь с таким логином уже существует! Попробуйте еще раз."); }
                    else if (tBChangeTel.Text == PersInfo.Telef)
                    {
                        UpdateData();
                    }
                    else //если поменял телефон
                    {
                        con.Open();
                        cmd = new SqlCommand("select count(Телефон) from Пользователи where Телефон='" + tBChangeTel.Text + "' ", con);

                        x = cmd.ExecuteScalar().ToString();
                        con.Close();

                        if (x == "1")
                        {
                            MessageBox.Show("Пользователь с таким номером телефона уже существует! Попробуйте еще раз.");
                        }
                        else { UpdateData(); }

                    }
                }
            }      

        }

        private void butPassRedact_Click(object sender, EventArgs e)
        {     
           
            InputBox.InputBox inp = new InputBox.InputBox("Изменение пароля!");
            
            if (inp.ShowDialog() == DialogResult.OK)
            {

                if (String.IsNullOrEmpty(inp.GetoldPass()) || String.IsNullOrEmpty(inp.GetNewPass()))
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {  
                    if (inp.GetNewPass().Length < 8)
                    {
                        MessageBox.Show("Пароль должен быть не менее 8 символов!");
                    }
                    else
                    {
                        string oP = inp.GetoldPass();
                        SqlCommand cmd = new SqlCommand("select count(Логин) from Пользователи where Логин='" + PersInfo.Login + "' and Пароль='" + oP + "'", con);
                        con.Open();
                        if (cmd.ExecuteScalar().ToString() == "1")
                        {
                            if (inp.GetNewPass().Length < 8)
                            {
                                MessageBox.Show("Пароль должен иметь длину не менее 8 символов!");
                                con.Close();
                            }
                            else
                            {
                                cmd = new SqlCommand("update Пользователи set Пароль='" + inp.GetNewPass() + "' where Логин = '" + PersInfo.Login + "'", con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Пароль успешно изменен!");
                                PersInfo.Pass = inp.GetNewPass();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Проверьте правильность пароля!");
                            con.Close();
                        }
                    }
                }
            }
            

            
        }

        private void tBChangeLog_KeyPress(object sender, KeyPressEventArgs e)
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

        private void butCancel_Click(object sender, EventArgs e)
        {
            otmena = 1;
            UpdateData();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
