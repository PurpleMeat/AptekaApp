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
    public partial class FormForClient : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormForClient()
        {
            InitializeComponent();

            var ms = new System.IO.MemoryStream(PersInfo.bytes);
            var img = Image.FromStream(ms);
            pictureProfile.Image = img;    

            dataGridView1.ClearSelection();           

        }   
        private void pictureProfile_Click(object sender, EventArgs e)
        {
            FormProfile prof = new FormProfile();

            this.Hide();
            if (prof.ShowDialog() == DialogResult.Cancel)
                this.Show();

            var ms = new System.IO.MemoryStream(PersInfo.bytes); 
            var img = Image.FromStream(ms);
            pictureProfile.Image = img;


        }        
     
        private void LoadData2()
        {
            ImageList imageList = new ImageList();

            // устанавливаем размер изображений
            imageList.ImageSize = new Size(250, 250);
            // создадим пустое изображение (просто белая заливка)
            Bitmap emptyImage = new Bitmap(130, 130);
            Button but = new Button();
            but.Name = "butBox";
            but.Size = new Size(50, 50);
         
            but.BackColor = Color.LightGreen;
            

            SqlCommand cmd = new SqlCommand("select Фото, Наименование,Цена, Код_товара from Товары ", con); 
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < 1; i++)
                {
                    int k = dataGridView1.Rows.Add();

                    for (int j = 0; j < 2; j++)
                    {                      

                        if (j == 0)
                        {
                            if (reader.GetValue(j) == System.DBNull.Value || reader.GetValue(0).ToString() == "NULL") //если картинки в базе данных по какой-то причине нет
                            {
                                
                                imageList.Images.Add(emptyImage);

                                dataGridView1.Rows[k].Cells[j].Value = imageList.Images[k];
                            }
                            else
                            {
                                byte[] bytes = (byte[])reader.GetValue(j);

                                var ms = new System.IO.MemoryStream(bytes);
                                var img = Image.FromStream(ms);
                                
                                imageList.Images.Add(img);
                                dataGridView1.Rows[k].Cells[j].Value = imageList.Images[k];
                            }

                        }
                        else
                        {
                            dataGridView1.Rows[k].Cells[1].Value = reader.GetValue(j); //наименование товара
                            dataGridView1.Rows[k].Cells[2].Value = reader.GetValue(2); //цена
                            dataGridView1.Rows[k].Cells[3].Style.BackColor = Color.LightGreen;
                            dataGridView1.Rows[k].Cells[3].Style.SelectionBackColor = Color.LightGreen;          //цвет кнопки!              
                            dataGridView1.Rows[k].Cells[3].Value = but;

                            dataGridView1.Rows[k].Cells[4].Value = reader.GetValue(2); //присваивает код товара
                        }


                    }
                }
            }
            con.Close();

           
        }

        private void FormForClient_Load(object sender, EventArgs e)
        {

            this.товарыTableAdapter.Fill(this.appteki2DataSet.Товары);          

            setDat();

            radioButName.Checked = true;

        }
        private void setDat()
        {
            dataGridView1.ClearSelection();
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++) // делает кнопки в строках цветными
            {
                dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Khaki;
                dataGridView1.Rows[i].Cells[3].Style.SelectionBackColor = Color.Khaki;                  
                
            }           
    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string kod;
            if (e.ColumnIndex == 3)
            {
                
                kod = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                con.Open();
                SqlCommand cmd = new SqlCommand("select count(Код_товара) from Корзина where Код_товара = '" + kod + "' and Код_клиента ='"+PersInfo.Login+"' ", con);
                string count = cmd.ExecuteScalar().ToString();
                if (count == "0")
                {
                    cmd = new SqlCommand("insert into Корзина(Код_клиента, Код_товара) values('" + PersInfo.Login + "', '" + kod + "')", con);
                   
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Товар в корзине.");
                }
                else if(count == "1")
                {
                    MessageBox.Show("Товар уже есть в корзине.");
                    con.Close();
                }

                dataGridView1.ClearSelection();
            }
            else if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex==2)
            {
                byte[] photo; string name;
                photo = (byte[])dataGridView1.SelectedRows[0].Cells[0].Value;
                name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                kod = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                FormOpisanie fo = new FormOpisanie(photo, name, kod); //перебрасывает на подробное описание товара
                this.Hide();

                if (fo.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
                else
                    this.Show();

                
                dataGridView1.ClearSelection();
            }
        }

        private void picKorzina_Click(object sender, EventArgs e)
        {
            FormKorzina fk = new FormKorzina(this.WindowState);
            this.Hide();
            if (fk.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }      

        }

        private void radButSortirovka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButName.Checked == true)
            {               
                dataGridView1.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Ascending); // по возрастанию сортировка
                setDat();
            }
            else if(radioButNameDec.Checked == true)
            {
                dataGridView1.Sort(dataGridViewTextBoxColumn2, ListSortDirection.Descending); //по убыванию
                setDat();
            }
            else if (radioButPrice.Checked == true)
            {
                dataGridView1.Sort(dataGridViewTextBoxColumn3, ListSortDirection.Ascending); //по возрастанию цена
                setDat();
            }
            else if(radioButPriceDec.Checked == true)
            {
                dataGridView1.Sort(dataGridViewTextBoxColumn3, ListSortDirection.Descending); // по убыванию
                setDat();
            } 
            

        }


        private void textBoxPoisk_TextChanged(object sender, EventArgs e)
        {
          товарыBindingSource.Filter = "[Наименование] LIKE'" + textBoxPoisk.Text + "%'";
          
           setDat();
           dataGridView1.ClearSelection();          

        }       

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.No;

            this.Close();   
        }

        private void textBoxPoisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || (Keys)e.KeyChar == Keys.Back
                || e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= 'А' && e.KeyChar <= 'Я'
                || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Допустимы только латинские и русские буквы, а также цифры!");
            }
        }
    }
     
 }     

    

