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
    public partial class TovariForm : Form
    {
        SqlConnection con = new SqlConnection(ConString.connection);
        public TovariForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void TovariForm_Load(object sender, EventArgs e)
        {          
            this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);

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

                    string query = "delete from Товары where Код_товара =" + id + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные удалены!");
                    con.Close();
                    this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);
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
            FormDobavChangeTovar f1 = new FormDobavChangeTovar();


            if (f1.ShowDialog() == DialogResult.OK)            
                this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);
            else
                this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);

            dataGridView1.ClearSelection();            
        }

        int i = 1;
        string id;
        private void button1_Click(object sender, EventArgs e)
        {
            string id;  string nam; string price; string about; byte[] pic;
            try
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                nam = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                price = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                about = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                pic = (byte[])dataGridView1.SelectedRows[0].Cells[4].Value;

                FormDobavChangeTovar f1 = new FormDobavChangeTovar(id, nam, price, about, pic);

                if (f1.ShowDialog() == DialogResult.OK)
                    this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);
                else
                    this.товарыTableAdapter1.Fill(this.appteki2DataSet1.Товары);

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
            товарыBindingSource.Filter= "[Наименование] LIKE'" + tBPoisk.Text + "%'";
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
