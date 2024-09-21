using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppApteki
{
    public partial class AllMain : Form
    {
        public AllMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //нельзя изменить размер окна

            var ms = new System.IO.MemoryStream(PersInfo.bytes);
            var img = Image.FromStream(ms);
            pictureProfile.Image = img;

        }

        private void butSotrudniki_Click(object sender, EventArgs e)
        {
            SotrudnikiForm stF = new SotrudnikiForm();
            this.Hide();
            if (stF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
            
        }

        private void butPostavchiki_Click(object sender, EventArgs e)
        {
            PostavchikiForm postavchikiF = new PostavchikiForm();
            
            this.Hide();
            if (postavchikiF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
        }

        private void butZakazi_Click(object sender, EventArgs e)
        {
            ZakaziForm sakasiF = new ZakaziForm();
            this.Hide();
            if (sakasiF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
            
        }

        private void butApteki_Click(object sender, EventArgs e)
        {
            AptekiForm apF = new AptekiForm();

            this.Hide();
            if (apF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();

            
        }
        private void butDoljnosti_Click(object sender, EventArgs e)
        {
            DoljnostiForm dolF = new DoljnostiForm();
            this.Hide();
            if (dolF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
            
        }

        private void butClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientF = new ClientsForm();
            this.Hide();
            if (clientF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
            
        }

        private void butScladi_Click(object sender, EventArgs e)
        {
            ScladiForm sclF = new ScladiForm();
            this.Hide();
            if (sclF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
        }

        private void butPostavki_Click(object sender, EventArgs e)
        {
            PostavkiForm postavkiF = new PostavkiForm();
            this.Hide();
            if (postavkiF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
        }

        private void butTovari_Click(object sender, EventArgs e)
        {
            TovariForm tovariF = new TovariForm();
            this.Hide();
            if (tovariF.ShowDialog() == DialogResult.Cancel)
                this.Show();
            else
                this.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.No;

            this.Close();
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
            FormProfile prof = new FormProfile();

            this.Hide();
            if (prof.ShowDialog() == DialogResult.Cancel) 
                this.Show();
            else
                this.Show();

            var ms = new System.IO.MemoryStream(PersInfo.bytes);
            var img = Image.FromStream(ms);
            pictureProfile.Image = img;
        }
    }
}
