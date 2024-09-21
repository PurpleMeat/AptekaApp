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
    public partial class FormDobavChangeSclad : Form
    {
        int i; string numSclad, nameApteka; string kodApteka;
        SqlConnection con = new SqlConnection(ConString.connection);

        public FormDobavChangeSclad()
        {
            InitializeComponent();
            i= 1;

            this.Text = "Добавление склада";

        }

        public FormDobavChangeSclad(string kodSclad, string adrs, string apteka)
        {
            InitializeComponent();
            i = 0;

            numSclad = kodSclad;

            tBNumSclad.Text = kodSclad;
            tBAdres.Text = adrs;
            nameApteka = apteka;

            this.Text = "Изменение склада";

        }

        private void getKodApteka()
        {
            SqlCommand cmd = new SqlCommand("select Код_аптеки from Аптеки where Название='"+cBNameApteka.Text+"' ", con);
            con.Open();
            kodApteka =cmd.ExecuteScalar().ToString();
            con.Close();

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                getKodApteka();
                if (i == 1)
                {
                    con.Open();
                    string query = "insert into Склады(Адрес_склада, Код_аптеки) values('" + tBAdres.Text + "', '" +kodApteka + "' )";

                    SqlCommand db = new SqlCommand(query, con);
                    try
                    {
                        db.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Данные добавлены!");

                        butSave.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Ошибка, проверьте данные!");
                    }
                }

                else if (i == 0)
                {
                    con.Open();
                    string query = "update Склады set  Адрес_склада='" + tBAdres.Text + "', Код_аптеки='" + kodApteka + "' where Код_склада = '" + numSclad +"' ";

                    SqlCommand db = new SqlCommand(query, con);
                    try
                    {
                        db.ExecuteNonQuery();
                        con.Close();
                        i = 1;
                        MessageBox.Show("Данные изменены!");

                        butSave.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Ошибка, проверьте данные!");
                    }
                }
            }
        }

        private void FormDobavChangeSclad_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.аптекиTableAdapter.Fill(this.appteki2DataSet.Аптеки);            

            if (i == 0)
            {                
                cBNameApteka.Text = nameApteka;
            }
        }

        private int Proverka()
        {
            if (string.IsNullOrWhiteSpace(tBAdres.Text))
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else
            {                 
                return 0;
            }
           

            
        }
    }
}
