using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppApteki
{
    public partial class ClientsForm : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public ClientsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void ClientsForm_Load(object sender, EventArgs e)
        {           
            this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);

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
                   
                    string query = "delete from Пользователи where Логин ='" + id+"' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);
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
            FormDobavChangeClients f1 = new FormDobavChangeClients();
            if (f1.ShowDialog() == DialogResult.OK)
                this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);
            else
                this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);

            dataGridView1.ClearSelection();

        }

       
        private void butChange_Click(object sender, EventArgs e)
        {
            string log, fam, nam, otch, tel, pas; byte[] pic;
            try
            {
                log = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                fam = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                nam = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                otch = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tel = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                pas = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                pic = (byte[])dataGridView1.SelectedRows[0].Cells[7].Value;

                FormDobavChangeClients f1 = new FormDobavChangeClients(log, fam, nam, otch, tel, pas, pic);
                if (f1.ShowDialog() == DialogResult.OK)
                    this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);
                else 
                    this.allClientsTableAdapter1.Fill(this.appteki2DataSet1.AllClients);

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
            allClientsBindingSource.Filter ="[Фамилия] LIKE'" + tBPoisk.Text + "%'";
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
