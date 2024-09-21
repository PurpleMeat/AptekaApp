
namespace AppApteki
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkChangePic = new System.Windows.Forms.LinkLabel();
            this.pictureProfile2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butRedact = new System.Windows.Forms.Button();
            this.labLogin = new System.Windows.Forms.Label();
            this.labFamil = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labOtch = new System.Windows.Forms.Label();
            this.labTel = new System.Windows.Forms.Label();
            this.butPassRedact = new System.Windows.Forms.Button();
            this.tBChangeLog = new System.Windows.Forms.TextBox();
            this.tBChangeFam = new System.Windows.Forms.TextBox();
            this.tBChangeNam = new System.Windows.Forms.TextBox();
            this.tBChangeOtch = new System.Windows.Forms.TextBox();
            this.butSaveChange = new System.Windows.Forms.Button();
            this.tBChangeTel = new System.Windows.Forms.MaskedTextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 80);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // butBack
            // 
            this.butBack.BackColor = System.Drawing.Color.Khaki;
            this.butBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBack.Location = new System.Drawing.Point(484, 21);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(94, 35);
            this.butBack.TabIndex = 22;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.linkChangePic);
            this.panel2.Controls.Add(this.pictureProfile2);
            this.panel2.Location = new System.Drawing.Point(3, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 307);
            this.panel2.TabIndex = 25;
            // 
            // linkChangePic
            // 
            this.linkChangePic.AutoSize = true;
            this.linkChangePic.Location = new System.Drawing.Point(84, 202);
            this.linkChangePic.Name = "linkChangePic";
            this.linkChangePic.Size = new System.Drawing.Size(86, 13);
            this.linkChangePic.TabIndex = 58;
            this.linkChangePic.TabStop = true;
            this.linkChangePic.Text = "Изменить фото";
            this.linkChangePic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePic_LinkClicked);
            // 
            // pictureProfile2
            // 
            this.pictureProfile2.Location = new System.Drawing.Point(19, 17);
            this.pictureProfile2.Name = "pictureProfile2";
            this.pictureProfile2.Size = new System.Drawing.Size(209, 182);
            this.pictureProfile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfile2.TabIndex = 0;
            this.pictureProfile2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(296, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(281, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(272, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(305, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(277, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Фамилия:";
            // 
            // butRedact
            // 
            this.butRedact.BackColor = System.Drawing.Color.Khaki;
            this.butRedact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRedact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butRedact.Location = new System.Drawing.Point(22, 310);
            this.butRedact.Name = "butRedact";
            this.butRedact.Size = new System.Drawing.Size(219, 35);
            this.butRedact.TabIndex = 51;
            this.butRedact.Text = "Редактировать";
            this.butRedact.UseVisualStyleBackColor = false;
            this.butRedact.Click += new System.EventHandler(this.butRedact_Click);
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLogin.Location = new System.Drawing.Point(368, 108);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(48, 17);
            this.labLogin.TabIndex = 52;
            this.labLogin.Text = "Логин:";
            // 
            // labFamil
            // 
            this.labFamil.AutoSize = true;
            this.labFamil.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFamil.Location = new System.Drawing.Point(368, 149);
            this.labFamil.Name = "labFamil";
            this.labFamil.Size = new System.Drawing.Size(48, 17);
            this.labFamil.TabIndex = 53;
            this.labFamil.Text = "Логин:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.Location = new System.Drawing.Point(368, 190);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 17);
            this.labName.TabIndex = 54;
            this.labName.Text = "Логин:";
            // 
            // labOtch
            // 
            this.labOtch.AutoSize = true;
            this.labOtch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labOtch.Location = new System.Drawing.Point(368, 225);
            this.labOtch.Name = "labOtch";
            this.labOtch.Size = new System.Drawing.Size(48, 17);
            this.labOtch.TabIndex = 55;
            this.labOtch.Text = "Логин:";
            // 
            // labTel
            // 
            this.labTel.AutoSize = true;
            this.labTel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTel.Location = new System.Drawing.Point(368, 265);
            this.labTel.Name = "labTel";
            this.labTel.Size = new System.Drawing.Size(48, 17);
            this.labTel.TabIndex = 56;
            this.labTel.Text = "Логин:";
            // 
            // butPassRedact
            // 
            this.butPassRedact.BackColor = System.Drawing.Color.Khaki;
            this.butPassRedact.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butPassRedact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPassRedact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPassRedact.Location = new System.Drawing.Point(22, 351);
            this.butPassRedact.Name = "butPassRedact";
            this.butPassRedact.Size = new System.Drawing.Size(219, 35);
            this.butPassRedact.TabIndex = 57;
            this.butPassRedact.Text = "Поменять пароль";
            this.butPassRedact.UseVisualStyleBackColor = false;
            this.butPassRedact.Click += new System.EventHandler(this.butPassRedact_Click);
            // 
            // tBChangeLog
            // 
            this.tBChangeLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeLog.Location = new System.Drawing.Point(371, 103);
            this.tBChangeLog.Multiline = true;
            this.tBChangeLog.Name = "tBChangeLog";
            this.tBChangeLog.Size = new System.Drawing.Size(189, 23);
            this.tBChangeLog.TabIndex = 58;
            this.tBChangeLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBChangeLog_KeyPress);
            // 
            // tBChangeFam
            // 
            this.tBChangeFam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeFam.Location = new System.Drawing.Point(371, 144);
            this.tBChangeFam.Multiline = true;
            this.tBChangeFam.Name = "tBChangeFam";
            this.tBChangeFam.Size = new System.Drawing.Size(189, 23);
            this.tBChangeFam.TabIndex = 59;
            // 
            // tBChangeNam
            // 
            this.tBChangeNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeNam.Location = new System.Drawing.Point(371, 184);
            this.tBChangeNam.Multiline = true;
            this.tBChangeNam.Name = "tBChangeNam";
            this.tBChangeNam.Size = new System.Drawing.Size(189, 23);
            this.tBChangeNam.TabIndex = 60;
            // 
            // tBChangeOtch
            // 
            this.tBChangeOtch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeOtch.Location = new System.Drawing.Point(371, 220);
            this.tBChangeOtch.Multiline = true;
            this.tBChangeOtch.Name = "tBChangeOtch";
            this.tBChangeOtch.Size = new System.Drawing.Size(189, 23);
            this.tBChangeOtch.TabIndex = 61;
            // 
            // butSaveChange
            // 
            this.butSaveChange.BackColor = System.Drawing.Color.Khaki;
            this.butSaveChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSaveChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSaveChange.Location = new System.Drawing.Point(332, 297);
            this.butSaveChange.Name = "butSaveChange";
            this.butSaveChange.Size = new System.Drawing.Size(209, 34);
            this.butSaveChange.TabIndex = 63;
            this.butSaveChange.Text = "Сохранить изменения";
            this.butSaveChange.UseVisualStyleBackColor = false;
            this.butSaveChange.Click += new System.EventHandler(this.butSaveChange_Click);
            // 
            // tBChangeTel
            // 
            this.tBChangeTel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBChangeTel.Location = new System.Drawing.Point(371, 257);
            this.tBChangeTel.Mask = "+9(999) 000-0000";
            this.tBChangeTel.Name = "tBChangeTel";
            this.tBChangeTel.Size = new System.Drawing.Size(189, 25);
            this.tBChangeTel.TabIndex = 64;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.Khaki;
            this.butCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(383, 337);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(108, 34);
            this.butCancel.TabIndex = 65;
            this.butCancel.Text = "Отменить";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(599, 407);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.tBChangeTel);
            this.Controls.Add(this.butSaveChange);
            this.Controls.Add(this.tBChangeOtch);
            this.Controls.Add(this.tBChangeNam);
            this.Controls.Add(this.tBChangeFam);
            this.Controls.Add(this.tBChangeLog);
            this.Controls.Add(this.butPassRedact);
            this.Controls.Add(this.labTel);
            this.Controls.Add(this.labOtch);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labFamil);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.butRedact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(615, 446);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль пользователя";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureProfile2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butRedact;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.Label labFamil;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labOtch;
        private System.Windows.Forms.Label labTel;
        private System.Windows.Forms.Button butPassRedact;
        private System.Windows.Forms.LinkLabel linkChangePic;
        private System.Windows.Forms.TextBox tBChangeLog;
        private System.Windows.Forms.TextBox tBChangeFam;
        private System.Windows.Forms.TextBox tBChangeNam;
        private System.Windows.Forms.TextBox tBChangeOtch;
        private System.Windows.Forms.Button butSaveChange;
        private System.Windows.Forms.MaskedTextBox tBChangeTel;
        private System.Windows.Forms.Button butCancel;
    }
}