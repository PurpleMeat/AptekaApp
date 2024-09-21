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

namespace AppApteki
{
    public partial class FormKorzina : Form
    {
        List<string> listCheck = new List<string> { };
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormKorzina(FormWindowState w)
        {
            InitializeComponent();
            loaddata();
            this.WindowState = w;
        }

        private void FormKorzina_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ClearSelection();
           

        }
        private void loaddata()
        {

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(250, 250); 
            SqlCommand cmd = new SqlCommand("select Фото, Наименование, Цена from Товары join Корзина on Корзина.Код_товара=Товары.Код_товара where Код_клиента='"+PersInfo.Login+"' ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < 1; i++)
                {
                    int k = dataGridView1.Rows.Add();

                    
                    byte[] bytes = (byte[])reader.GetValue(0);

                    var ms = new System.IO.MemoryStream(bytes);
                    var img = Image.FromStream(ms);                               
                    imageList.Images.Add(img);

                    dataGridView1.Rows[k].Cells[1].Value = imageList.Images[k]; //фото                    
                    dataGridView1.Rows[k].Cells[2].Value = reader.GetValue(1); //наименование товара
                    dataGridView1.Rows[k].Cells[3].Value = reader.GetValue(2); //цена  
                }
            }
            con.Close();
            dataGridView1.ClearSelection();
        }        

        private void butDel_Click(object sender, EventArgs e)
        {
            string kodDelete;
            string[] delList;
            SqlCommand cmd;

            delList = listCheck.ToArray();//из листа в массив для цикла
            listCheck.Clear();

            if (delList.Length == 0)
            {
                MessageBox.Show("Выберите товары для удаления!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы уверенны что хотите удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    for (int i = 0; i < delList.Length; i++)
                    {
                        con.Open();
                        cmd = new SqlCommand("select Код_товара from Товары where Наименование = '" + delList[i] + "' ", con);
                        kodDelete = cmd.ExecuteScalar().ToString();
                        cmd = new SqlCommand("delete from Корзина where Код_клиента='" + PersInfo.Login + "' and Код_товара='" + kodDelete + "' ", con);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    dataGridView1.Rows.Clear();
                    loaddata();
                    MessageBox.Show("Товары успешно удалены.");


                }
            }

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butZakaz_Click(object sender, EventArgs e)
        {
            string[] zakazList;
            zakazList = listCheck.ToArray();
            int[] kodList = new int[zakazList.Length]; //пустой массив

            if (zakazList.Length == 0)
            {
                MessageBox.Show("Выберите товары для заказа!");
            }
            else
            {
                for (int i = 0; i < zakazList.Length; i++) //берем и ищем коды товаров
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Код_товара from Товары where Наименование = '" + zakazList[i] + "' ", con);
                    kodList[i] = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    con.Close();
                }

                ZakazClient zc = new ZakazClient(kodList);
                this.Hide();
                if (zc.ShowDialog() == DialogResult.OK)
                    this.Show();
                else
                    this.Show();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                var q2 = dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue;
           
           
            
                // сначала меняет флажок чекбокса
                if (Convert.ToBoolean(q2) == true)
                {
                    dataGridView1.SelectedRows[0].Cells[0].Value = false;

                }
                else if (Convert.ToBoolean(q2) == false)
                {
                    dataGridView1.SelectedRows[0].Cells[0].Value = true;

                }
            
           
                q2 = dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue;

            //проверяет чекбокс

            if (Convert.ToBoolean(q2) == true)
            {
                if (listCheck.Contains(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) == true) // чтобы не добавлялся несколько раз в лист
                {

                }
                else
                {
                    listCheck.Add(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());  //в список на удление                 
                } 
            }
            
            else if (Convert.ToBoolean(q2) == false)
            {
                for (int i = 0; i < listCheck.Count; i++)
                {
                    int indx;
                    if (listCheck.Contains(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) == true) //проверить есть ли в списке, и если есть, то убирает в нем значение
                    {
                        indx = listCheck.IndexOf(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        listCheck.RemoveAt(indx);

                    }

                }
            }

            dataGridView1.ClearSelection();           
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
                
        }
    }
}
