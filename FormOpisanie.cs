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
    public partial class FormOpisanie : Form
    {
        string kodT;
        SqlConnection con = new SqlConnection(ConString.connection);
        public FormOpisanie(byte[] img, string name, string kod)
        {
            InitializeComponent();
            butBack.DialogResult = DialogResult.Cancel;

            LoadData(img,name,kod);
            kodT = kod;
        }
        
        private void butBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(byte[] pi, string name, string k)
        {
            string price="0", about="ybyggh";
            con.Open();
            SqlCommand cmd =new SqlCommand("select Цена, Описание from Товары where Код_товара='"+k+"'", con);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                price = reader.GetValue(0).ToString();
                about = reader.GetValue(1).ToString();
            }
            con.Close();



            pictureBoxTovar.Image =setPic(pi);
            labelName.Text = name;
            labelPrice.Text = price + " руб.";
            labelAbout.Text = about;
            

        }

        private Image setPic(byte[] pi)
        {
            var ms = new System.IO.MemoryStream(pi);
            var img = Image.FromStream(ms);
            return img;
        }

        private void butDobavKorzina_Click(object sender, EventArgs e)
        {           
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Код_товара) from Корзина where Код_товара = '" + kodT + "' and Код_клиента ='" + PersInfo.Login + "' ", con);
            string count = cmd.ExecuteScalar().ToString();
            if (count == "0")
            {
                cmd = new SqlCommand("insert into Корзина(Код_клиента, Код_товара) values('" + PersInfo.Login + "', '" + kodT + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Товар в корзине.");
            }
            else if (count == "1")
            {
                MessageBox.Show("Товар уже есть в корзине.");
                con.Close();
            }
        }

        private void FormOpisanie_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
