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
    public partial class DoljnostiForm : Form
    {
        public DoljnostiForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        SqlConnection con = new SqlConnection(ConString.connection);

        private void DoljnostiForm_Load(object sender, EventArgs e)
        {
            this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);

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
                    string query = "delete from Должности where Название_должности like '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);
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
            FormDobavChangeDolj f1 = new FormDobavChangeDolj();

            if (f1.ShowDialog() == DialogResult.OK)
                this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);
            else
                this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);

            dataGridView1.ClearSelection();
        }
        
        private void butChange_Click(object sender, EventArgs e)
        {
            try
            {      
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                FormDobavChangeDolj f1 = new FormDobavChangeDolj(id);

                if (f1.ShowDialog() == DialogResult.OK)
                    this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);
                else
                    this.должностиTableAdapter1.Fill(this.appteki2DataSet1.Должности);

                dataGridView1.ClearSelection();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите какую строчку изменить!");
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Выберите одну строку!");
            }
            
            
        }
        
        private void tBfilter_TextChanged(object sender, EventArgs e)
        {
            должностиBindingSource.Filter = "[Название_должности] LIKE '"+tBPoisk.Text+"%' ";
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
