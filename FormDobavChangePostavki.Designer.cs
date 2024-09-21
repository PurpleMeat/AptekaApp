
namespace AppApteki
{
    partial class FormDobavChangePostavki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDobavChangePostavki));
            this.cBTovar = new System.Windows.Forms.ComboBox();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appteki2DataSet = new AppApteki.Appteki2DataSet();
            this.cBNamePostavsh = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBCount = new System.Windows.Forms.TextBox();
            this.cBSclad = new System.Windows.Forms.ComboBox();
            this.scladiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBAdresSclad = new System.Windows.Forms.ComboBox();
            this.поставщикиTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.ПоставщикиTableAdapter();
            this.товарыTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.ТоварыTableAdapter();
            this.scladiTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.ScladiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBTovar
            // 
            this.cBTovar.DataSource = this.товарыBindingSource;
            this.cBTovar.DisplayMember = "Наименование";
            this.cBTovar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTovar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBTovar.FormattingEnabled = true;
            this.cBTovar.Location = new System.Drawing.Point(133, 132);
            this.cBTovar.Name = "cBTovar";
            this.cBTovar.Size = new System.Drawing.Size(229, 27);
            this.cBTovar.TabIndex = 49;
            this.cBTovar.ValueMember = "Наименование";
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.appteki2DataSet;
            // 
            // appteki2DataSet
            // 
            this.appteki2DataSet.DataSetName = "Appteki2DataSet";
            this.appteki2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cBNamePostavsh
            // 
            this.cBNamePostavsh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.поставщикиBindingSource, "Наименование_поставщика", true));
            this.cBNamePostavsh.DataSource = this.поставщикиBindingSource;
            this.cBNamePostavsh.DisplayMember = "Наименование_поставщика";
            this.cBNamePostavsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNamePostavsh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBNamePostavsh.FormattingEnabled = true;
            this.cBNamePostavsh.Location = new System.Drawing.Point(133, 99);
            this.cBNamePostavsh.Name = "cBNamePostavsh";
            this.cBNamePostavsh.Size = new System.Drawing.Size(229, 27);
            this.cBNamePostavsh.TabIndex = 48;
            this.cBNamePostavsh.ValueMember = "Наименование_поставщика";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.appteki2DataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Адрес склада:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Дата поставки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Товар";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Поставщик";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 84);
            this.panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
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
            this.butSave.Location = new System.Drawing.Point(118, 311);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(142, 35);
            this.butSave.TabIndex = 30;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Склад:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Количество";
            // 
            // tBCount
            // 
            this.tBCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBCount.Location = new System.Drawing.Point(133, 263);
            this.tBCount.MaxLength = 5;
            this.tBCount.Multiline = true;
            this.tBCount.Name = "tBCount";
            this.tBCount.Size = new System.Drawing.Size(229, 27);
            this.tBCount.TabIndex = 54;
            this.tBCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCount_KeyPress);
            // 
            // cBSclad
            // 
            this.cBSclad.DataSource = this.scladiBindingSource;
            this.cBSclad.DisplayMember = "Код_склада";
            this.cBSclad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBSclad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBSclad.FormattingEnabled = true;
            this.cBSclad.Location = new System.Drawing.Point(133, 197);
            this.cBSclad.Name = "cBSclad";
            this.cBSclad.Size = new System.Drawing.Size(229, 27);
            this.cBSclad.TabIndex = 55;
            this.cBSclad.ValueMember = "Код_склада";
            // 
            // scladiBindingSource
            // 
            this.scladiBindingSource.DataMember = "Scladi";
            this.scladiBindingSource.DataSource = this.appteki2DataSet;
            // 
            // cBAdresSclad
            // 
            this.cBAdresSclad.DataSource = this.scladiBindingSource;
            this.cBAdresSclad.DisplayMember = "Адрес_склада";
            this.cBAdresSclad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cBAdresSclad.Enabled = false;
            this.cBAdresSclad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBAdresSclad.FormattingEnabled = true;
            this.cBAdresSclad.Location = new System.Drawing.Point(133, 230);
            this.cBAdresSclad.Name = "cBAdresSclad";
            this.cBAdresSclad.Size = new System.Drawing.Size(229, 27);
            this.cBAdresSclad.TabIndex = 56;
            this.cBAdresSclad.ValueMember = "Адрес_склада";
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // scladiTableAdapter
            // 
            this.scladiTableAdapter.ClearBeforeFill = true;
            // 
            // FormDobavChangePostavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(376, 368);
            this.Controls.Add(this.cBAdresSclad);
            this.Controls.Add(this.cBSclad);
            this.Controls.Add(this.tBCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cBTovar);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.cBNamePostavsh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(392, 407);
            this.Name = "FormDobavChangePostavki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDobavChangePostavki";
            this.Load += new System.EventHandler(this.FormDobavChangePostavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scladiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBTovar;
        private System.Windows.Forms.ComboBox cBNamePostavsh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBCount;
        private System.Windows.Forms.ComboBox cBSclad;
        private System.Windows.Forms.ComboBox cBAdresSclad;
        private Appteki2DataSet appteki2DataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Appteki2DataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private Appteki2DataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.BindingSource scladiBindingSource;
        private Appteki2DataSetTableAdapters.ScladiTableAdapter scladiTableAdapter;
    }
}