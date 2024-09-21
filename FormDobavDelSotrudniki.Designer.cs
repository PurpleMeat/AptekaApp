
namespace AppApteki
{
    partial class FormDobavDelSotrudniki
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDobavDelSotrudniki));
            this.cBDolj = new System.Windows.Forms.ComboBox();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appteki2DataSet = new AppApteki.Appteki2DataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSave = new System.Windows.Forms.Button();
            this.tBTelefon = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkChangePhoto = new System.Windows.Forms.LinkLabel();
            this.pictureBoxSotrud = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cBMestoRab = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cBApteka = new System.Windows.Forms.ComboBox();
            this.должностиTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.ДолжностиTableAdapter();
            this.аптекиTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.АптекиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSotrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBDolj
            // 
            this.cBDolj.DataSource = this.должностиBindingSource;
            this.cBDolj.DisplayMember = "Название_должности";
            this.cBDolj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDolj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBDolj.FormattingEnabled = true;
            this.cBDolj.Location = new System.Drawing.Point(367, 291);
            this.cBDolj.Name = "cBDolj";
            this.cBDolj.Size = new System.Drawing.Size(189, 27);
            this.cBDolj.TabIndex = 44;
            this.cBDolj.ValueMember = "Название_должности";
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.appteki2DataSet;
            // 
            // appteki2DataSet
            // 
            this.appteki2DataSet.DataSetName = "Appteki2DataSet";
            this.appteki2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(255, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(255, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Должность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(255, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(255, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(255, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(255, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Логин:";
            // 
            // tBPassword
            // 
            this.tBPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPassword.Location = new System.Drawing.Point(367, 256);
            this.tBPassword.Multiline = true;
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(189, 27);
            this.tBPassword.TabIndex = 35;
            this.tBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_Login_KeyPress);
            // 
            // tBOtch
            // 
            this.tBOtch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBOtch.Location = new System.Drawing.Point(367, 192);
            this.tBOtch.Multiline = true;
            this.tBOtch.Name = "tBOtch";
            this.tBOtch.Size = new System.Drawing.Size(189, 27);
            this.tBOtch.TabIndex = 33;
            // 
            // tBFamil
            // 
            this.tBFamil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBFamil.Location = new System.Drawing.Point(367, 126);
            this.tBFamil.Multiline = true;
            this.tBFamil.Name = "tBFamil";
            this.tBFamil.Size = new System.Drawing.Size(189, 27);
            this.tBFamil.TabIndex = 32;
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBName.Location = new System.Drawing.Point(367, 159);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(189, 27);
            this.tBName.TabIndex = 31;
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLogin.Location = new System.Drawing.Point(367, 93);
            this.tBLogin.Multiline = true;
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(189, 27);
            this.tBLogin.TabIndex = 30;
            this.tBLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_Login_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 87);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Khaki;
            this.butSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(367, 398);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 35);
            this.butSave.TabIndex = 47;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // tBTelefon
            // 
            this.tBTelefon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBTelefon.Location = new System.Drawing.Point(367, 225);
            this.tBTelefon.Mask = "+9(999) 000-0000";
            this.tBTelefon.Name = "tBTelefon";
            this.tBTelefon.Size = new System.Drawing.Size(189, 25);
            this.tBTelefon.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.linkChangePhoto);
            this.panel2.Controls.Add(this.pictureBoxSotrud);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 364);
            this.panel2.TabIndex = 49;
            // 
            // linkChangePhoto
            // 
            this.linkChangePhoto.AutoSize = true;
            this.linkChangePhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkChangePhoto.Location = new System.Drawing.Point(69, 249);
            this.linkChangePhoto.Name = "linkChangePhoto";
            this.linkChangePhoto.Size = new System.Drawing.Size(111, 19);
            this.linkChangePhoto.TabIndex = 65;
            this.linkChangePhoto.TabStop = true;
            this.linkChangePhoto.Text = "Изменить фото";
            this.linkChangePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePhoto_LinkClicked);
            // 
            // pictureBoxSotrud
            // 
            this.pictureBoxSotrud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSotrud.Location = new System.Drawing.Point(11, 22);
            this.pictureBoxSotrud.Name = "pictureBoxSotrud";
            this.pictureBoxSotrud.Size = new System.Drawing.Size(214, 215);
            this.pictureBoxSotrud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSotrud.TabIndex = 28;
            this.pictureBoxSotrud.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(561, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(255, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Место работы:";
            // 
            // cBMestoRab
            // 
            this.cBMestoRab.DataSource = this.аптекиBindingSource;
            this.cBMestoRab.DisplayMember = "Адрес";
            this.cBMestoRab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMestoRab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBMestoRab.FormattingEnabled = true;
            this.cBMestoRab.Location = new System.Drawing.Point(367, 324);
            this.cBMestoRab.Name = "cBMestoRab";
            this.cBMestoRab.Size = new System.Drawing.Size(189, 27);
            this.cBMestoRab.TabIndex = 51;
            this.cBMestoRab.ValueMember = "Адрес";
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.appteki2DataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(255, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Аптека:";
            // 
            // cBApteka
            // 
            this.cBApteka.DataSource = this.аптекиBindingSource;
            this.cBApteka.DisplayMember = "Название";
            this.cBApteka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cBApteka.Enabled = false;
            this.cBApteka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBApteka.FormattingEnabled = true;
            this.cBApteka.Location = new System.Drawing.Point(367, 359);
            this.cBApteka.Name = "cBApteka";
            this.cBApteka.Size = new System.Drawing.Size(189, 27);
            this.cBApteka.TabIndex = 53;
            this.cBApteka.ValueMember = "Название";
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // FormDobavDelSotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(563, 445);
            this.Controls.Add(this.cBApteka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBMestoRab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tBTelefon);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBDolj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
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
            this.MaximumSize = new System.Drawing.Size(579, 484);
            this.Name = "FormDobavDelSotrudniki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDobavDelSotrudniki";
            this.Load += new System.EventHandler(this.FormDobavDelSotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSotrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBDolj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.MaskedTextBox tBTelefon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBMestoRab;
        private System.Windows.Forms.PictureBox pictureBoxSotrud;
        private System.Windows.Forms.LinkLabel linkChangePhoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBApteka;
        private Appteki2DataSet appteki2DataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private Appteki2DataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private Appteki2DataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
    }
}