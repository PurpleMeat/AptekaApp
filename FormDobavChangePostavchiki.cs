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
    public partial class FormDobavChangePostavchiki : Form
    {
        int i; string kod;
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormDobavChangePostavchiki()
        {
            InitializeComponent();          
            i = 1;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Добавление поставщика";

        }
        public FormDobavChangePostavchiki(string name, string adres, string id)
        {
            InitializeComponent();
            i = 0;

            kod = id;
            tBName.Text = name;
            tBAdress.Text = adres;

            this.Text = "Изменение поставщика";

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                if (i == 1)
                {
                    con.Open();
                    string query = "insert into Поставщики(Наименование_поставщика, Адрес_поставщика) values('" + tBName.Text + "', '" + tBAdress.Text + "' )";

                    SqlCommand db = new SqlCommand(query, con);

                    db.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные добавлены!");
                    butSave.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else if (i == 0)
                {
                    con.Open();
                    string query = "update Поставщики set Наименование_поставщика= '" + tBName.Text + "', Адрес_поставщика='" + tBAdress.Text + "' where Код_поставщика = '" + kod + "' ";

                    SqlCommand db = new SqlCommand(query, con);

                    db.ExecuteNonQuery();
                    con.Close();
                    i = 1;
                    MessageBox.Show("Данные изменены!");
                    butSave.DialogResult = DialogResult.OK;
                    this.Close();
                }


            }
        }

        private int Proverka()
        {
            if (string.IsNullOrWhiteSpace(tBName.Text) || string.IsNullOrWhiteSpace(tBAdress.Text))
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else return 0;
        }

        private void FormDobavChangePostavchiki_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
