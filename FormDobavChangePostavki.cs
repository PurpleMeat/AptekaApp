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
    public partial class FormDobavChangePostavki : Form
    {
        int i; string kodPostavki, kodPostavchik, kodTovar;
        string nameTovar, sclad, namePost;

        SqlConnection con = new SqlConnection(ConString.connection);
        public FormDobavChangePostavki()
        {
            InitializeComponent();
            i = 1;

            this.Text = "Добавление информации о поставке";
        }

        public FormDobavChangePostavki(string kod, string name_Post, string name_Tovar, DateTime date, string scladd, string count )
        {
            InitializeComponent();
            i = 0;

            kodPostavki = kod;
            namePost = name_Post;
            nameTovar = name_Tovar;            
            dateTimePicker1.Value = date;
            sclad = scladd;            
            tBCount.Text = count;

            this.Text = "Изменение информации о поставке";

        }
        private void getKodPostavchikAndTovar()
        {
            SqlCommand cmd = new SqlCommand("select Код_поставщика from Поставщики where Наименование_поставщика ='"+cBNamePostavsh.Text+"' ", con);
            con.Open();
            kodPostavchik = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("select Код_товара from Товары where Наименование ='"+cBTovar.Text+"' ",con);
            kodTovar = cmd.ExecuteScalar().ToString();
            con.Close();
            
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                getKodPostavchikAndTovar();
                if (i == 1)
                {
                    try
                    {
                        con.Open();
                        string query = "insert into Поставки(Код_поставщика, Код_товара, Дата_поставки, Номер_склада, Количество) values('" + kodPostavchik + "', '" + kodTovar + "', '" + dateTimePicker1.Value.Date.ToString() + "', '" + cBSclad.Text + "', '" + tBCount.Text + "' )";

                        SqlCommand db = new SqlCommand(query, con);

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
                    try
                    {
                        con.Open();
                        string query = "update Поставки set Код_поставщика= '" + kodPostavchik + "', Код_товара='" +
                             kodTovar + "', Дата_поставки='" + dateTimePicker1.Value.Date.ToString() + "', Номер_склада='" +
                             cBSclad.Text + "', Количество='" + tBCount.Text + "' where Номер_поставки = '" + kodPostavki + "' ";

                        SqlCommand db = new SqlCommand(query, con);

                        db.ExecuteNonQuery();
                        con.Close();
                     
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
              if (string.IsNullOrWhiteSpace(tBCount.Text))
              {
                  MessageBox.Show("Введите данные в поля!");
                  return 1;
              }
            return 0;
        }

        private void tBCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void FormDobavChangePostavki_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.scladiTableAdapter.Fill(this.appteki2DataSet.Scladi);
            this.товарыTableAdapter.Fill(this.appteki2DataSet.Товары);         
            this.поставщикиTableAdapter.Fill(this.appteki2DataSet.Поставщики);

            if (i == 0)
            {
                cBNamePostavsh.Text = namePost;
                cBTovar.Text = nameTovar;
                cBSclad.Text = sclad;
            }

        }
    }
}
