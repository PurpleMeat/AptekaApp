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
    public partial class AptekiForm : Form
    {
        public AptekiForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        SqlConnection con = new SqlConnection(ConString.connection);

        private void AptekiForm_Load(object sender, EventArgs e)
        {           
            this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            butBack.DialogResult = DialogResult.Cancel;

            dataGridView1.ClearSelection();
        }        
       
        private void butDel_Click(object sender, EventArgs e)
        {
            try
            {
               string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверенны что хотите удалить эти данные?", "Внимание!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    con.Open();                                       
                    string query = "delete from Аптеки where Код_аптеки ='" + id+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);
                    dataGridView1.ClearSelection();
                }
                
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите какую строчку удалить!");
            }
        }
        private void butDobav_Click(object sender, EventArgs e)
        {
            FormDobavChangeApteki f1 = new FormDobavChangeApteki();
            this.Hide();

            if (f1.ShowDialog() == DialogResult.OK)
                this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);
            else
                this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);

            this.Show();

            dataGridView1.ClearSelection();
        }     

        private void butChange_Click(object sender, EventArgs e)
        {
            string kod, name, adres;

            kod = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            adres = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            FormDobavChangeApteki f1 = new FormDobavChangeApteki(kod,name,adres);

            if (f1.ShowDialog() == DialogResult.OK)
                this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);
            else
                this.аптекиTableAdapter1.Fill(this.appteki2DataSet1.Аптеки);

            dataGridView1.ClearSelection();
        }
        private void tBfilter_TextChanged(object sender, EventArgs e)
        {
            аптекиBindingSource.Filter = "[Название] LIKE '" + tBPoisk.Text + "%' ";
            dataGridView1.ClearSelection();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBPoisk_KeyPress(object sender, KeyPressEventArgs e)
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

