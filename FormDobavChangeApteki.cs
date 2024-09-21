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
    public partial class FormDobavChangeApteki : Form
    {
        int i; string kodAppteki;
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormDobavChangeApteki()
        {
            InitializeComponent();            
            i = 1;
           

            this.Text = "Добавление аптеки";
        }

        public FormDobavChangeApteki(string kod, string name, string adres)
        {
            InitializeComponent();
            i = 0;
            kodAppteki = kod;

            tBNazvanie.Text = name;
            tBAdress.Text = adres;

            this.Text = "Изменение аптеки";

        }       

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                if (i == 1)
                {
                    if (Proverka() == 0)
                    {
                        con.Open();
                        string query = "insert into Аптеки(Название, Адрес) values('" + tBNazvanie.Text + "', '" + tBAdress.Text + "' )";

                        SqlCommand db = new SqlCommand(query, con);

                        db.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Данные добавлены!");
                        butSave.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
                else if (i == 0)
                {
                    con.Open();
                    string query = "update Аптеки set Название= '" + tBNazvanie.Text + "', Адрес='" + tBAdress.Text + "' where Код_аптеки = '" + kodAppteki + "' ";

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

        private int Proverka()
        {
            if (string.IsNullOrWhiteSpace(tBNazvanie.Text) || string.IsNullOrWhiteSpace(tBAdress.Text))
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else return 0;
        }

        private void FormDobavChangeApteki_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
