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
    public partial class SotrudnikiForm : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public SotrudnikiForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }        
        private void SotrudnikiForm_Load(object sender, EventArgs e)
        {
            this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);

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
                   
                    string query = "delete from Пользователи where Логин = '" + id + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);
                    dataGridView1.ClearSelection();
                }

            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Выберите какую строчку удалить!");
                con.Close();
            }
        }
        private void butDobav_Click(object sender, EventArgs e)
        {
            FormDobavDelSotrudniki f1 = new FormDobavDelSotrudniki();
            
            if (f1.ShowDialog() == DialogResult.OK)
                this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);
            else
                this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);

            dataGridView1.ClearSelection();
        }       
        
        private void button1_Click(object sender, EventArgs e)
        {
            string log, fam, nam, otch, tel, pas, dolj, mestoRab; byte[] img;

            try
            {
                log = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fam = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nam = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                otch = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tel = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
              
                pas = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();               
                dolj = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                mestoRab = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                img = (byte[])dataGridView1.SelectedRows[0].Cells[9].Value;

                FormDobavDelSotrudniki f1 = new FormDobavDelSotrudniki(log, fam, nam, otch, tel, pas, dolj, mestoRab, img);

                if (f1.ShowDialog() == DialogResult.OK)
                    this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);
                else
                    this.sotrudAllTableAdapter.Fill(this.appteki2DataSet1.SotrudAll);

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
            sotrudAllBindingSource.Filter = "[Фамилия] LIKE '"+tBPoisk.Text+"%' ";
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
