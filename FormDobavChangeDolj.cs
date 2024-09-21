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
    public partial class FormDobavChangeDolj : Form
    {
        int i; string dolj;

        SqlConnection con = new SqlConnection(ConString.connection);
        public FormDobavChangeDolj()
        {
            InitializeComponent();
            i = 1;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Добавление должности";
        }

        public FormDobavChangeDolj(string name)
        {
            InitializeComponent();
            i = 0;
            dolj = name;

            tBDolj.Text = name;

            this.Text = "Изменение должности";
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (Proverka() == 0)
            {
                if (i == 1)
                {
                    con.Open();
                    string query = "insert into Должности(Название_должности) values('" + tBDolj.Text + "')";

                    SqlCommand db = new SqlCommand(query, con);

                    db.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Данные добавлены!");
                    butSave.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else if(i == 0)
                {                       
                    con.Open();
                    string query = "update Должности set Название_должности= '" + tBDolj.Text + "' where Название_должности = '" + dolj + "' ";

                    SqlCommand db = new SqlCommand(query, con);
                    try
                    {
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
            if (string.IsNullOrWhiteSpace(tBDolj.Text) )
            {
                MessageBox.Show("Введите данные в поля!");
                return 1;
            }
            else return 0;
        }

        private void FormDobavChangeDolj_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
