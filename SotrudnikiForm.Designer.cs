﻿
namespace AppApteki
{
    partial class SotrudnikiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SotrudnikiForm));
            this.butDobav = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBPoisk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.sotrudAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appteki2DataSet1 = new AppApteki.Appteki2DataSet();
            this.sotrudAllTableAdapter = new AppApteki.Appteki2DataSetTableAdapters.SotrudAllTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // butDobav
            // 
            this.butDobav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDobav.BackColor = System.Drawing.Color.Khaki;
            this.butDobav.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butDobav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDobav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDobav.Location = new System.Drawing.Point(926, 132);
            this.butDobav.Name = "butDobav";
            this.butDobav.Size = new System.Drawing.Size(94, 35);
            this.butDobav.TabIndex = 1;
            this.butDobav.Text = "Добавить";
            this.butDobav.UseVisualStyleBackColor = false;
            this.butDobav.Click += new System.EventHandler(this.butDobav_Click);
            // 
            // butDel
            // 
            this.butDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDel.BackColor = System.Drawing.Color.Khaki;
            this.butDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDel.Location = new System.Drawing.Point(926, 91);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(94, 35);
            this.butDel.TabIndex = 2;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = false;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.butBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tBPoisk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 85);
            this.panel1.TabIndex = 11;
            // 
            // butBack
            // 
            this.butBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butBack.BackColor = System.Drawing.Color.Khaki;
            this.butBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBack.Location = new System.Drawing.Point(926, 27);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(94, 35);
            this.butBack.TabIndex = 40;
            this.butBack.Text = "Назад";
            this.butBack.UseVisualStyleBackColor = false;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(83, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Поиск по фамилии:";
            // 
            // tBPoisk
            // 
            this.tBPoisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPoisk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBPoisk.Location = new System.Drawing.Point(83, 47);
            this.tBPoisk.Multiline = true;
            this.tBPoisk.Name = "tBPoisk";
            this.tBPoisk.Size = new System.Drawing.Size(494, 23);
            this.tBPoisk.TabIndex = 38;
            this.tBPoisk.TextChanged += new System.EventHandler(this.tBfilter_TextChanged);
            this.tBPoisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPoisk_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppApteki.Properties.Resources.Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(926, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(208)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.sotrudAllBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.RowTemplate.Height = 90;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(908, 295);
            this.dataGridView1.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn7.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn9.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn10.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn11.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Роль";
            this.dataGridViewTextBoxColumn12.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn13.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn14.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Место работы";
            this.dataGridViewTextBoxColumn15.HeaderText = "Место работы";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Фото";
            this.dataGridViewImageColumn1.HeaderText = "Фото";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // sotrudAllBindingSource
            // 
            this.sotrudAllBindingSource.DataMember = "SotrudAll";
            this.sotrudAllBindingSource.DataSource = this.appteki2DataSet1;
            // 
            // appteki2DataSet1
            // 
            this.appteki2DataSet1.DataSetName = "Appteki2DataSet";
            this.appteki2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudAllTableAdapter
            // 
            this.sotrudAllTableAdapter.ClearBeforeFill = true;
            // 
            // SotrudnikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1030, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butDobav);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SotrudnikiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.SotrudnikiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appteki2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butDobav;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.DataGridViewTextBoxColumn кодсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддолжностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодаптекиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn логинDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn парольDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBPoisk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Appteki2DataSet appteki2DataSet;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn рольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.Button butBack;
        private Appteki2DataSet appteki2DataSet1;
        private System.Windows.Forms.BindingSource sotrudAllBindingSource;
        private Appteki2DataSetTableAdapters.SotrudAllTableAdapter sotrudAllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}