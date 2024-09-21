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
    public partial class ZakaziForm : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public ZakaziForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void ZakaziForm_Load(object sender, EventArgs e)
        {      
            this.tovariInZakazTableAdapter.Fill(this.appteki2DataSet.TovariInZakaz);
            this.summaAllZakazTableAdapter.Fill(this.appteki2DataSet.SummaAllZakaz);
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;


            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            butBack.DialogResult = DialogResult.Cancel;

            dataGridView2.Visible = false;
            butViewZakaz.Visible = false;
            butViewTovariZakaz.Visible = true;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
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
                   

                    string query = "delete from Заказы where Код_заказа = '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.summaAllZakazTableAdapter.Fill(this.appteki2DataSet.SummaAllZakaz);
                    dataGridView1.ClearSelection();
        
                }

            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите какую строчку удалить!");
            }
        }   
       
        private void tBfilter_TextChanged(object sender, EventArgs e)
        {
            summaAllZakazBindingSource.Filter = "[Фамилия] LIKE'" + tBPoisk.Text + "%'";
            tovariInZakazBindingSource.Filter = "[Фамилия] LIKE'" + tBPoisk.Text + "%'";
            dataGridView1.ClearSelection();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butViewZakaz_Click(object sender, EventArgs e)
        {
            butViewTovariZakaz.Visible = true;
            butViewZakaz.Visible = false;
            butDel.Visible = true;

            dataGridView2.Visible = false;
            dataGridView2.ClearSelection();
            dataGridView1.Visible = true; 
            
        }

        private void butViewTovariZakaz_Click(object sender, EventArgs e)
        {
            butViewTovariZakaz.Visible = false;
            butViewZakaz.Visible = true;
            butDel.Visible = false;

            dataGridView2.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.Visible = false;
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
