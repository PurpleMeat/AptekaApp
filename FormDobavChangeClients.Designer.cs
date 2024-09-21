
namespace AppApteki
{
    partial class FormDobavChangeClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDobavChangeClients));
            this.tBTelefon = new System.Windows.Forms.MaskedTextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.tBOtch = new System.Windows.Forms.TextBox();
            this.tBFamil = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkChangePhoto = new System.Windows.Forms.LinkLabel();
            this.pictureBoxClient = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).BeginInit();
            this.SuspendLayout();
            // 
            // tBTelefon
            // 
            this.tBTelefon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBTelefon.Location = new System.Drawing.Point(370, 237);
            this.tBTelefon.Mask = "+9(999) 000-0000";
            this.tBTelefon.Name = "tBTelefon";
            this.tBTelefon.Size = new System.Drawing.Size(197, 25);
            this.tBTelefon.TabIndex = 64;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Khaki;
            this.butSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(389, 311);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 35);
            this.butSave.TabIndex = 63;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 84);
            this.panel1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(273, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(273, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Логин:";
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPassword.Location = new System.Drawing.Point(370, 268);
            this.tBPassword.Multiline = true;
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(197, 27);
            this.tBPassword.TabIndex = 53;
            this.tBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_Login_KeyPress);
            // 
            // tBOtch
            // 
            this.tBOtch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBOtch.Location = new System.Drawing.Point(370, 204);
            this.tBOtch.Multiline = true;
            this.tBOtch.Name = "tBOtch";
            this.tBOtch.Size = new System.Drawing.Size(197, 27);
            this.tBOtch.TabIndex = 52;
            // 
            // tBFamil
            // 
            this.tBFamil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBFamil.Location = new System.Drawing.Point(370, 138);
            this.tBFamil.Multiline = true;
            this.tBFamil.Name = "tBFamil";
            this.tBFamil.Size = new System.Drawing.Size(197, 27);
            this.tBFamil.TabIndex = 51;
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBName.Location = new System.Drawing.Point(370, 171);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(197, 27);
            this.tBName.TabIndex = 50;
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLogin.Location = new System.Drawing.Point(370, 105);
            this.tBLogin.Multiline = true;
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(197, 27);
            this.tBLogin.TabIndex = 49;
            this.tBLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_Login_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.linkChangePhoto);
            this.panel2.Controls.Add(this.pictureBoxClient);
            this.panel2.Location = new System.Drawing.Point(-2, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 286);
            this.panel2.TabIndex = 65;
            // 
            // linkChangePhoto
            // 
            this.linkChangePhoto.AutoSize = true;
            this.linkChangePhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkChangePhoto.Location = new System.Drawing.Point(74, 233);
            this.linkChangePhoto.Name = "linkChangePhoto";
            this.linkChangePhoto.Size = new System.Drawing.Size(111, 19);
            this.linkChangePhoto.TabIndex = 66;
            this.linkChangePhoto.TabStop = true;
            this.linkChangePhoto.Text = "Изменить фото";
            this.linkChangePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePhoto_LinkClicked);
            // 
            // pictureBoxClient
            // 
            this.pictureBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxClient.Location = new System.Drawing.Point(24, 11);
            this.pictureBoxClient.Name = "pictureBoxClient";
            this.pictureBoxClient.Size = new System.Drawing.Size(214, 215);
            this.pictureBoxClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClient.TabIndex = 29;
            this.pictureBoxClient.TabStop = false;
            // 
            // FormDobavChangeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(579, 361);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tBTelefon);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.tBOtch);
            this.Controls.Add(this.tBFamil);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(595, 400);
            this.Name = "FormDobavChangeClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDobavChangeClients";
            this.Load += new System.EventHandler(this.FormDobavChangeClients_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tBTelefon;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.TextBox tBOtch;
        private System.Windows.Forms.TextBox tBFamil;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxClient;
        private System.Windows.Forms.LinkLabel linkChangePhoto;
    }
}