
namespace AppApteki
{
    partial class ZakazClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakazClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.labotch = new System.Windows.Forms.Label();
            this.labfam = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labdate = new System.Windows.Forms.Label();
            this.butZakaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBAdressApteka = new System.Windows.Forms.ComboBox();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appteki2DataSet = new AppApteki.Appteki2DataSet();
            this.cBNameApteka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.аптекиTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.АптекиTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.butBack);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 91);
            this.panel1.TabIndex = 30;
            // 
            // butBack
            // 
            this.butBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butBack.BackColor = System.Drawing.Color.Khaki;
            this.butBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBack.Location = new System.Drawing.Point(688, 26);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(99, 35);
            this.butBack.TabIndex = 36;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 229);
            this.dataGridView1.TabIndex = 31;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 120.6245F;
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 92.04574F;
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column4.FillWeight = 78.23888F;
            this.Column4.HeaderText = "Количество";
            this.Column4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(490, 110);
            this.label6.MaximumSize = new System.Drawing.Size(300, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Заказчик:";
            // 
            // labotch
            // 
            this.labotch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labotch.AutoSize = true;
            this.labotch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labotch.Location = new System.Drawing.Point(564, 173);
            this.labotch.MaximumSize = new System.Drawing.Size(300, 300);
            this.labotch.Name = "labotch";
            this.labotch.Size = new System.Drawing.Size(72, 17);
            this.labotch.TabIndex = 53;
            this.labotch.Text = "Отчество:";
            // 
            // labfam
            // 
            this.labfam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labfam.AutoSize = true;
            this.labfam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labfam.Location = new System.Drawing.Point(564, 110);
            this.labfam.MaximumSize = new System.Drawing.Size(300, 300);
            this.labfam.Name = "labfam";
            this.labfam.Size = new System.Drawing.Size(67, 17);
            this.labfam.TabIndex = 51;
            this.labfam.Text = "Фамилия:";
            // 
            // labname
            // 
            this.labname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labname.Location = new System.Drawing.Point(564, 142);
            this.labname.MaximumSize = new System.Drawing.Size(300, 300);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(39, 17);
            this.labname.TabIndex = 52;
            this.labname.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 212);
            this.label1.MaximumSize = new System.Drawing.Size(300, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Дата заказа:";
            // 
            // labdate
            // 
            this.labdate.AutoSize = true;
            this.labdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labdate.Location = new System.Drawing.Point(564, 212);
            this.labdate.MaximumSize = new System.Drawing.Size(300, 300);
            this.labdate.Name = "labdate";
            this.labdate.Size = new System.Drawing.Size(83, 17);
            this.labdate.TabIndex = 56;
            this.labdate.Text = "Дата заказа";
            // 
            // butZakaz
            // 
            this.butZakaz.BackColor = System.Drawing.Color.Khaki;
            this.butZakaz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butZakaz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butZakaz.Location = new System.Drawing.Point(600, 344);
            this.butZakaz.Name = "butZakaz";
            this.butZakaz.Size = new System.Drawing.Size(99, 35);
            this.butZakaz.TabIndex = 57;
            this.butZakaz.Text = "Заказать";
            this.butZakaz.UseVisualStyleBackColor = false;
            this.butZakaz.Click += new System.EventHandler(this.butZakaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(461, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Адрес аптеки:";
            // 
            // cBAdressApteka
            // 
            this.cBAdressApteka.DataSource = this.аптекиBindingSource;
            this.cBAdressApteka.DisplayMember = "Адрес";
            this.cBAdressApteka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAdressApteka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBAdressApteka.FormattingEnabled = true;
            this.cBAdressApteka.Location = new System.Drawing.Point(567, 259);
            this.cBAdressApteka.Name = "cBAdressApteka";
            this.cBAdressApteka.Size = new System.Drawing.Size(205, 27);
            this.cBAdressApteka.TabIndex = 59;
            this.cBAdressApteka.ValueMember = "Адрес";
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "Аптеки";
            this.аптекиBindingSource.DataSource = this.appteki2DataSet;
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
            this.cBNameApteka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cBNameApteka.Enabled = false;
            this.cBNameApteka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBNameApteka.FormattingEnabled = true;
            this.cBNameApteka.Location = new System.Drawing.Point(567, 292);
            this.cBNameApteka.Name = "cBNameApteka";
            this.cBNameApteka.Size = new System.Drawing.Size(205, 27);
            this.cBNameApteka.TabIndex = 60;
            this.cBNameApteka.ValueMember = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(501, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Аптека:";
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // ZakazClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBNameApteka);
            this.Controls.Add(this.cBAdressApteka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butZakaz);
            this.Controls.Add(this.labdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labotch);
            this.Controls.Add(this.labfam);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 430);
            this.Name = "ZakazClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.Load += new System.EventHandler(this.ZakazClient_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labotch;
        private System.Windows.Forms.Label labfam;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labdate;
        private System.Windows.Forms.Button butZakaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.ComboBox cBAdressApteka;
        private System.Windows.Forms.ComboBox cBNameApteka;
        private System.Windows.Forms.Label label3;
        private Appteki2DataSet appteki2DataSet;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private Appteki2DataSetTableAdapters.АптекиTableAdapter аптекиTableAdapter;
    }
}