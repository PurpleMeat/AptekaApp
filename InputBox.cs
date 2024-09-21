using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputBox
{
    public class InputBox : Form
    {
        
        private readonly TextBox _textBox;
        private readonly TextBox _textBox2;
        

        public InputBox(string title = "", bool isDigits = false)
        {
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Size = new Size(300, 170);
            Text = title;

            _textBox2 = new TextBox
            {
                Size = new Size(250, 25),
                Font = new Font(DefaultFont, FontStyle.Regular),
                Location = new Point(20, 70),
                Text = ""
            };
            _textBox = new TextBox
            {
                Size = new Size(250, 25),
                Font = new Font(DefaultFont, FontStyle.Regular),
                Location = new Point(20, 30),
                Text = ""
            };

            if (isDigits)
            {
                _textBox.KeyPress += SetOnlyDigits;
                _textBox2.KeyPress += SetOnlyDigits;
            }

            Controls.Add(_textBox);
            Controls.Add(_textBox2);

            _textBox.Show();
            _textBox2.Show();

            _textBox.KeyPress += textBox_KeyPress;
            _textBox2.KeyPress += textBox_KeyPress;

            var label = new Label
            {
                AutoSize = false,
                Size = new Size(250, 25)
            };
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.Location = new Point(20, 55);
            label.Text = "Введите новый пароль:";

            var label2 = new Label
            {
                AutoSize = false,
                Size = new Size(250, 25)
            };
            label2.Font = new Font(label.Font, FontStyle.Regular);
            label2.Location = new Point(20, 10);
            label2.Text = "Введите пароль:";

            Controls.Add(label);
            Controls.Add(label2);

            label.Show();
            label2.Show();

            var buttonOk = new Button
            {
                Size = new Size(80, 25),
                Location = new Point(105, 95),
                DialogResult = DialogResult.OK,
                Text = "Oк"
            };

            Controls.Add(buttonOk);

            buttonOk.Show();

            var buttonCancel = new Button
            {
                Size = new Size(80, 25),
                Location = new Point(190, 95),
                Text = "Отмена"
            };

            Controls.Add(buttonCancel);

            buttonCancel.Show();

            buttonCancel.Click += buttonCancel_Click;
            this.Icon = Icon.FromHandle(AppApteki.Properties.Resources.pillIcon.GetHicon());
        }

        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }
            DialogResult = DialogResult.OK;

            Close();
        }

        public void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetWindow()
        {
            ShowDialog();
        }
        public string GetoldPass()
        {
            return _textBox.Text;
                //ShowDialog() != DialogResult.OK ? null : _textBox.Text;
        }
        public string GetNewPass()
        {
            return _textBox2.Text;
        }

        public void SetOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputBox";
            this.ResumeLayout(false);

        }
         
    }
}