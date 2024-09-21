
namespace AppApteki
{
    partial class FormDobavChangeSclad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDobavChangeSclad));
            this.appteki2DataSet = new AppApteki.Appteki2DataSet();
            this.cBNameApteka = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBAdres = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSave = new System.Windows.Forms.Button();
            this.аптекиTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.АптекиTableAdapter();
            this.tBNumSclad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appteki2DataSet
            // 
            this.appteki2DataSet.DataSetName = "Appteki2DataSet";
            this.appteki2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBNameApteka
            // 
            this.cBNameApteka.DataSource = this.аптекиBindingSource;
            this.cBNameApteka.DisplayMember = "Название";
            this.cBNameApteka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNameApteka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBNameApteka.FormattingEnabled = true;
            this.cBNameApteka.Location = new System.Drawing.Point(129, 230);
            this.cBNameApteka.Name = "cBNameApteka";
            this.cBNameApteka.Size = new System.Drawing.Size(196, 27);
            this.cBNameApteka.TabIndex = 40;
            this.cBNameApteka.ValueMember = "Название";
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.appteki2DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Аптека:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Номер склада:";
            // 
            // tBAdres
            // 
            this.tBAdres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAdres.Location = new System.Drawing.Point(129, 149);
            this.tBAdres.Multiline = true;
            this.tBAdres.Name = "tBAdres";
            this.tBAdres.Size = new System.Drawing.Size(196, 63);
            this.tBAdres.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 84);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.Color.Khaki;
            this.butSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(129, 289);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 35);
            this.butSave.TabIndex = 43;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // tBNumSclad
            // 
            this.tBNumSclad.Enabled = false;
            this.tBNumSclad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBNumSclad.Location = new System.Drawing.Point(129, 101);
            this.tBNumSclad.Multiline = true;
            this.tBNumSclad.Name = "tBNumSclad";
            this.tBNumSclad.Size = new System.Drawing.Size(196, 27);
            this.tBNumSclad.TabIndex = 44;
            // 
            // FormDobavChangeSclad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(361, 354);
            this.Controls.Add(this.tBNumSclad);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBNameApteka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBAdres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(377, 393);
            this.Name = "FormDobavChangeSclad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDobavChangeSclad";
            this.Load += new System.EventHandler(this.FormDobavChangeSclad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBNameApteka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAdres;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSave;
        private Appteki2DataSet appteki2DataSet;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private Appteki2DataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
        private System.Windows.Forms.TextBox tBNumSclad;
    }
}