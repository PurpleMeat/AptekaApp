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
    public partial class FormDobavChangeTovar : Form
    {
        int i; int numT; byte[] picBytes;

        SqlConnection con = new SqlConnection(ConString.connection);
        public FormDobavChangeTovar()
        {
            InitializeComponent();
            i = 1;

            StandartPic();
            butSave.DialogResult = DialogResult.OK;

            this.Text = "Добавление товара";
        }     


        public FormDobavChangeTovar(string num, string name, string price, string about, byte[] pic)
        {
            numT = Convert.ToInt32(num);
            i = 0;
            InitializeComponent();


            butSave.DialogResult = DialogResult.OK;

            double pr = Convert.ToDouble(price);
            tBName.Text = name;
            tBPrice.Text = pr.ToString();
            tBAbout.Text = about;

            picBytes = pic;
            var ms = new System.IO.MemoryStream(picBytes);
            var img = Image.FromStream(ms);
            picTovar.Image = img;

            this.Text = "Изменение товара";

        }
        private void StandartPic() //устанавливается картинка по умолчанию при добавлении, если не выбрано другое фото
        {
            var path = $"{Directory.GetCurrentDirectory()}\\lekar.jpg";
            picBytes = File.ReadAllBytes(path);
            var ms = new System.IO.MemoryStream(picBytes);
            var img = Image.FromStream(ms);
            picTovar.Image = img;

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                if (i == 1)
                {
                    if (NazvanieTovarCheck() == 0)
                    {
                        try
                        {
                            con.Open();
                            string query = "insert into Товары( Наименование, Цена, Описание, Фото) values( '" + tBName.Text + "', " + Convert.ToInt32(tBPrice.Text) + ", '" + tBAbout.Text + "', @Data)";
                                                      
                            SqlCommand db = new SqlCommand(query, con);

                            db.Parameters.AddWithValue("@Data", picBytes);

                            db.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Данные добавлены!");

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
                    try
                    {
                        con.Open();
                        string query = "update Товары set Наименование = '" + tBName.Text + "', Цена = '" + tBPrice.Text +
                            "', Описание='" + tBAbout.Text + "', Фото=@Data where Код_товара = '" + numT + "' ";

                        SqlCommand db = new SqlCommand(query, con);

                        db.Parameters.AddWithValue("@Data", picBytes);

                        db.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Данные изменены!");
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
            if (string.IsNullOrWhiteSpace(tBPrice.Text) || string.IsNullOrWhiteSpace(tBName.Text))
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else return 0;
        }

        private int NazvanieTovarCheck()
        {
            SqlCommand cmd = new SqlCommand("select count(Наименование) from Товары where Наименование='"+tBName.Text+"' ", con);
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count == 1)
            {
                MessageBox.Show("Товар с таким названием уже существует!");
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void tBPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
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
                        picTovar.Image = img;                  

                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Выберите фото!");
                    }

                }

            
        }

        private void FormDobavChangeTovar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    } 
} 
