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
    public partial class ZakazClient : Form
    {
        int[] kodTovar; string kodZakaz;
        SqlConnection con = new SqlConnection(ConString.connection);       
        public ZakazClient(int[] array)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            butZakaz.DialogResult = DialogResult.OK;

            kodTovar = array;

            labfam.Text = PersInfo.Famil;
            labname.Text = PersInfo.Name;
            labotch.Text = PersInfo.Otch;           


            labdate.Text = DateTime.Today.ToShortDateString();


            loaddata();

        }

        private void loaddata()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(250, 250);
            for (int t = 0; t < kodTovar.Length; t++)
            {
                SqlCommand cmd = new SqlCommand("select Наименование, Цена from Товары where Код_товара='" + kodTovar[t] + "' ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < 1; i++)
                    {
                        int k = dataGridView1.Rows.Add();

                        dataGridView1.Rows[k].Cells[0].Value = reader.GetValue(0); //наименование товара
                        dataGridView1.Rows[k].Cells[1].Value = reader.GetValue(1); //цена
                        dataGridView1.Rows[k].Cells[2].Value = "1";                                                          
                        
                    }
                }
                con.Close();
            }
        }

        private void ZakazClient_Load(object sender, EventArgs e)
        {           
            this.аптекиTableAdapter.Fill(this.appteki2DataSet.Аптеки);

        }
        private int PovtorZakaz()
        {
            SqlCommand cmd = new SqlCommand("select count(Код_заказа) from Заказы where Логин_пользователя='" + PersInfo.Login + "' and Дата_заказа='" + labdate.Text + "' and Адрес_заказа='" + cBAdressApteka.Text + "' ", con);
            con.Open();
            if (cmd.ExecuteScalar().ToString() == "1") //если нашел заказ на сегодня у того же клиента, на тот же адрес
            {
                cmd = new SqlCommand("select Код_заказа from Заказы where Логин_пользователя='" + PersInfo.Login + "' and Дата_заказа='" + labdate.Text + "' and Адрес_заказа='" + cBAdressApteka.Text + "' ", con);
                kodZakaz = cmd.ExecuteScalar().ToString();
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0; 
            }
            
        }

        private void butZakaz_Click(object sender, EventArgs e)
        {            
            if (PovtorZakaz()==1)
            {
                addTovarInZakaz();//метод где берется код заказа сегодня и добавляются товары
            }
            else //если нет заказа на сегодня от того же ччеловека, сделает новый заказ
            { 

                SqlCommand cmd = new SqlCommand("insert into Заказы(Логин_пользователя, Дата_заказа, Адрес_заказа) values('"+PersInfo.Login+"', '" + labdate.Text + "', '"+cBAdressApteka.Text+"' )", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                PovtorZakaz(); //возьмет код созданного заказа

                addTovarInZakaz();
                this.Close();
            }            
        }

        private void addTovarInZakaz()
        {
            for(int i =0; i<kodTovar.Length; i++)
            {
                con.Open();

                //Проверка в цикле: и если уже есть такие товары в бд, то нужно добавлять к количеству в таблице
                SqlCommand cmd = new SqlCommand("select count(Код_товара) from Товары_в_заказе where Код_заказа='" + kodZakaz + "' and Код_товара='"+kodTovar[i]+"' ", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (count == 1) //если уже есть такой товар в заказе
                {
                    cmd = new SqlCommand("update Товары_в_заказе set Количество =Количество+'" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' where Код_заказа ='" + kodZakaz + "' and Код_товара ='" + kodTovar[i] + "' ", con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("insert into Товары_в_заказе(Код_заказа, Код_товара, Количество) values('" + kodZakaz + "', '" + kodTovar[i] + "', '" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "' )", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                con.Close();
            }
            MessageBox.Show("Заказ успешно создан!");
            
        }        
        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
