
namespace AppApteki
{
    partial class FormDobavChangeTovar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDobavChangeTovar));
            this.butSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBAbout = new System.Windows.Forms.TextBox();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.linkChangePhoto = new System.Windows.Forms.LinkLabel();
            this.picTovar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Khaki;
            this.butSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(173, 385);
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
            this.panel1.Controls.Add(this.butChange);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 64);
            this.panel1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // butChange
            // 
            this.butChange.BackColor = System.Drawing.Color.Khaki;
            this.butChange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butChange.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butChange.Location = new System.Drawing.Point(561, 12);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(94, 35);
            this.butChange.TabIndex = 27;
            this.butChange.Text = "Изменить";
            this.butChange.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Цена за штуку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Наименование:";
            // 
            // tBAbout
            // 
            this.tBAbout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAbout.Location = new System.Drawing.Point(120, 279);
            this.tBAbout.Multiline = true;
            this.tBAbout.Name = "tBAbout";
            this.tBAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBAbout.Size = new System.Drawing.Size(187, 92);
            this.tBAbout.TabIndex = 52;
            // 
            // tBPrice
            // 
            this.tBPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPrice.Location = new System.Drawing.Point(120, 238);
            this.tBPrice.Multiline = true;
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(187, 27);
            this.tBPrice.TabIndex = 51;
            this.tBPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPrice_KeyPress);
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBName.Location = new System.Drawing.Point(120, 195);
            this.tBName.Multiline = true;
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(187, 27);
            this.tBName.TabIndex = 50;
            // 
            // linkChangePhoto
            // 
            this.linkChangePhoto.AutoSize = true;
            this.linkChangePhoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkChangePhoto.Location = new System.Drawing.Point(156, 173);
            this.linkChangePhoto.Name = "linkChangePhoto";
            this.linkChangePhoto.Size = new System.Drawing.Size(111, 19);
            this.linkChangePhoto.TabIndex = 64;
            this.linkChangePhoto.TabStop = true;
            this.linkChangePhoto.Text = "Изменить фото";
            this.linkChangePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePhoto_LinkClicked);
            // 
            // picTovar
            // 
            this.picTovar.Location = new System.Drawing.Point(153, 70);
            this.picTovar.Name = "picTovar";
            this.picTovar.Size = new System.Drawing.Size(114, 100);
            this.picTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTovar.TabIndex = 65;
            this.picTovar.TabStop = false;
            // 
            // FormDobavChangeTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(330, 432);
            this.Controls.Add(this.picTovar);
            this.Controls.Add(this.linkChangePhoto);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBAbout);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.tBName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(346, 471);
            this.Name = "FormDobavChangeTovar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDobavChangeTovar";
            this.Load += new System.EventHandler(this.FormDobavChangeTovar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBAbout;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.LinkLabel linkChangePhoto;
        private System.Windows.Forms.PictureBox picTovar;
    }
}