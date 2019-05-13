namespace UITracker
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_kayıpkart = new System.Windows.Forms.Button();
            this.groupBox_extra = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox_seri = new System.Windows.Forms.TextBox();
            this.label_rfidKartNumarası = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox_plaka = new System.Windows.Forms.TextBox();
            this.label_plaka = new System.Windows.Forms.Label();
            this.groupBox_aracIslemleri = new System.Windows.Forms.GroupBox();
            this.radioButton_cilali = new System.Windows.Forms.RadioButton();
            this.radioButton_icdıs = new System.Windows.Forms.RadioButton();
            this.radioButton_otopark = new System.Windows.Forms.RadioButton();
            this.radioButton_ic = new System.Windows.Forms.RadioButton();
            this.radioButton_dıs = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox_saat = new System.Windows.Forms.GroupBox();
            this.label_saat = new System.Windows.Forms.Label();
            this.groupBox_aractipi = new System.Windows.Forms.GroupBox();
            this.radioButton_Motor = new System.Windows.Forms.RadioButton();
            this.radioButton_Jeep = new System.Windows.Forms.RadioButton();
            this.radioButton_SUV = new System.Windows.Forms.RadioButton();
            this.radioButton_Binek = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.groupBox_extra.SuspendLayout();
            this.groupBox_aracIslemleri.SuspendLayout();
            this.groupBox_saat.SuspendLayout();
            this.groupBox_aractipi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_kayıpkart);
            this.panel3.Controls.Add(this.groupBox_extra);
            this.panel3.Controls.Add(this.textBox_seri);
            this.panel3.Controls.Add(this.label_rfidKartNumarası);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.textBox_plaka);
            this.panel3.Controls.Add(this.label_plaka);
            this.panel3.Controls.Add(this.groupBox_aracIslemleri);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.groupBox_saat);
            this.panel3.Controls.Add(this.groupBox_aractipi);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 615);
            this.panel3.TabIndex = 9;
            // 
            // button_kayıpkart
            // 
            this.button_kayıpkart.BackColor = System.Drawing.Color.DarkGray;
            this.button_kayıpkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button_kayıpkart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_kayıpkart.Location = new System.Drawing.Point(451, 509);
            this.button_kayıpkart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_kayıpkart.Name = "button_kayıpkart";
            this.button_kayıpkart.Size = new System.Drawing.Size(217, 36);
            this.button_kayıpkart.TabIndex = 14;
            this.button_kayıpkart.Text = "Kayıp Kart";
            this.button_kayıpkart.UseVisualStyleBackColor = false;
            this.button_kayıpkart.Click += new System.EventHandler(this.Button_kayıpkart_Click);
            // 
            // groupBox_extra
            // 
            this.groupBox_extra.Controls.Add(this.checkedListBox1);
            this.groupBox_extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_extra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox_extra.Location = new System.Drawing.Point(360, 321);
            this.groupBox_extra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_extra.Name = "groupBox_extra";
            this.groupBox_extra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_extra.Size = new System.Drawing.Size(308, 184);
            this.groupBox_extra.TabIndex = 12;
            this.groupBox_extra.TabStop = false;
            this.groupBox_extra.Text = "Ekstra İşlemler";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Motor Yıkama",
            "Kuaför",
            "Pasta Cila",
            "Boya Koruma",
            "Zift Temizleme"});
            this.checkedListBox1.Location = new System.Drawing.Point(5, 27);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(297, 138);
            this.checkedListBox1.TabIndex = 0;
            // 
            // textBox_seri
            // 
            this.textBox_seri.BackColor = System.Drawing.Color.White;
            this.textBox_seri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_seri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox_seri.Location = new System.Drawing.Point(43, 41);
            this.textBox_seri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_seri.MaxLength = 10;
            this.textBox_seri.Name = "textBox_seri";
            this.textBox_seri.ReadOnly = true;
            this.textBox_seri.Size = new System.Drawing.Size(301, 21);
            this.textBox_seri.TabIndex = 9;
            this.textBox_seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_seri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_seri_KeyDown);
            // 
            // label_rfidKartNumarası
            // 
            this.label_rfidKartNumarası.AutoSize = true;
            this.label_rfidKartNumarası.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_rfidKartNumarası.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_rfidKartNumarası.Location = new System.Drawing.Point(75, 12);
            this.label_rfidKartNumarası.Name = "label_rfidKartNumarası";
            this.label_rfidKartNumarası.Size = new System.Drawing.Size(212, 24);
            this.label_rfidKartNumarası.TabIndex = 10;
            this.label_rfidKartNumarası.Text = "RFID Kart Seri Numarası";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DarkGray;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_clear.Location = new System.Drawing.Point(35, 434);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(173, 33);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Sıfırla";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Button_Sıfırla_Click);
            // 
            // textBox_plaka
            // 
            this.textBox_plaka.BackColor = System.Drawing.Color.White;
            this.textBox_plaka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox_plaka.Location = new System.Drawing.Point(45, 105);
            this.textBox_plaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_plaka.Name = "textBox_plaka";
            this.textBox_plaka.Size = new System.Drawing.Size(301, 21);
            this.textBox_plaka.TabIndex = 2;
            this.textBox_plaka.Tag = "";
            this.textBox_plaka.Text = "34";
            this.textBox_plaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_plaka.TextChanged += new System.EventHandler(this.textBox_plaka_TextChanged);
            // 
            // label_plaka
            // 
            this.label_plaka.AutoSize = true;
            this.label_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_plaka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_plaka.Location = new System.Drawing.Point(168, 74);
            this.label_plaka.Name = "label_plaka";
            this.label_plaka.Size = new System.Drawing.Size(55, 24);
            this.label_plaka.TabIndex = 3;
            this.label_plaka.Text = "Plaka";
            // 
            // groupBox_aracIslemleri
            // 
            this.groupBox_aracIslemleri.Controls.Add(this.radioButton_cilali);
            this.groupBox_aracIslemleri.Controls.Add(this.radioButton_icdıs);
            this.groupBox_aracIslemleri.Controls.Add(this.radioButton_otopark);
            this.groupBox_aracIslemleri.Controls.Add(this.radioButton_ic);
            this.groupBox_aracIslemleri.Controls.Add(this.radioButton_dıs);
            this.groupBox_aracIslemleri.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_aracIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_aracIslemleri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox_aracIslemleri.Location = new System.Drawing.Point(360, 141);
            this.groupBox_aracIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_aracIslemleri.Name = "groupBox_aracIslemleri";
            this.groupBox_aracIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_aracIslemleri.Size = new System.Drawing.Size(308, 175);
            this.groupBox_aracIslemleri.TabIndex = 0;
            this.groupBox_aracIslemleri.TabStop = false;
            this.groupBox_aracIslemleri.Text = "Arac İşlemleri";
            // 
            // radioButton_cilali
            // 
            this.radioButton_cilali.AutoSize = true;
            this.radioButton_cilali.Location = new System.Drawing.Point(19, 137);
            this.radioButton_cilali.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_cilali.Name = "radioButton_cilali";
            this.radioButton_cilali.Size = new System.Drawing.Size(136, 28);
            this.radioButton_cilali.TabIndex = 7;
            this.radioButton_cilali.Text = "Cilalı Yıkama";
            this.radioButton_cilali.UseVisualStyleBackColor = true;
            // 
            // radioButton_icdıs
            // 
            this.radioButton_icdıs.AutoSize = true;
            this.radioButton_icdıs.Location = new System.Drawing.Point(19, 110);
            this.radioButton_icdıs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_icdıs.Name = "radioButton_icdıs";
            this.radioButton_icdıs.Size = new System.Drawing.Size(143, 28);
            this.radioButton_icdıs.TabIndex = 6;
            this.radioButton_icdıs.Text = "İç-Dış Yıkama";
            this.radioButton_icdıs.UseVisualStyleBackColor = true;
            // 
            // radioButton_otopark
            // 
            this.radioButton_otopark.AutoSize = true;
            this.radioButton_otopark.Checked = true;
            this.radioButton_otopark.Location = new System.Drawing.Point(19, 26);
            this.radioButton_otopark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_otopark.Name = "radioButton_otopark";
            this.radioButton_otopark.Size = new System.Drawing.Size(97, 28);
            this.radioButton_otopark.TabIndex = 5;
            this.radioButton_otopark.TabStop = true;
            this.radioButton_otopark.Text = "Otopark";
            this.radioButton_otopark.UseVisualStyleBackColor = true;
            // 
            // radioButton_ic
            // 
            this.radioButton_ic.AutoSize = true;
            this.radioButton_ic.Location = new System.Drawing.Point(19, 53);
            this.radioButton_ic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_ic.Name = "radioButton_ic";
            this.radioButton_ic.Size = new System.Drawing.Size(111, 28);
            this.radioButton_ic.TabIndex = 3;
            this.radioButton_ic.Text = "İç Yıkama";
            this.radioButton_ic.UseVisualStyleBackColor = true;
            // 
            // radioButton_dıs
            // 
            this.radioButton_dıs.AutoSize = true;
            this.radioButton_dıs.Location = new System.Drawing.Point(19, 81);
            this.radioButton_dıs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_dıs.Name = "radioButton_dıs";
            this.radioButton_dıs.Size = new System.Drawing.Size(123, 28);
            this.radioButton_dıs.TabIndex = 4;
            this.radioButton_dıs.Text = "Dış Yıkama";
            this.radioButton_dıs.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatAppearance.BorderSize = 15;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_save.Location = new System.Drawing.Point(35, 493);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(311, 52);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox_saat
            // 
            this.groupBox_saat.Controls.Add(this.label_saat);
            this.groupBox_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_saat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox_saat.Location = new System.Drawing.Point(35, 321);
            this.groupBox_saat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_saat.Name = "groupBox_saat";
            this.groupBox_saat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_saat.Size = new System.Drawing.Size(312, 57);
            this.groupBox_saat.TabIndex = 4;
            this.groupBox_saat.TabStop = false;
            this.groupBox_saat.Text = "Saat";
            // 
            // label_saat
            // 
            this.label_saat.AutoSize = true;
            this.label_saat.Location = new System.Drawing.Point(16, 27);
            this.label_saat.Name = "label_saat";
            this.label_saat.Size = new System.Drawing.Size(46, 24);
            this.label_saat.TabIndex = 5;
            this.label_saat.Text = "Saat";
            // 
            // groupBox_aractipi
            // 
            this.groupBox_aractipi.Controls.Add(this.radioButton_Motor);
            this.groupBox_aractipi.Controls.Add(this.radioButton_Jeep);
            this.groupBox_aractipi.Controls.Add(this.radioButton_SUV);
            this.groupBox_aractipi.Controls.Add(this.radioButton_Binek);
            this.groupBox_aractipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox_aractipi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox_aractipi.Location = new System.Drawing.Point(35, 140);
            this.groupBox_aractipi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_aractipi.Name = "groupBox_aractipi";
            this.groupBox_aractipi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_aractipi.Size = new System.Drawing.Size(312, 176);
            this.groupBox_aractipi.TabIndex = 1;
            this.groupBox_aractipi.TabStop = false;
            this.groupBox_aractipi.Text = "Arac Tipi";
            // 
            // radioButton_Motor
            // 
            this.radioButton_Motor.AutoSize = true;
            this.radioButton_Motor.Location = new System.Drawing.Point(19, 112);
            this.radioButton_Motor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Motor.Name = "radioButton_Motor";
            this.radioButton_Motor.Size = new System.Drawing.Size(79, 28);
            this.radioButton_Motor.TabIndex = 3;
            this.radioButton_Motor.Text = "Motor";
            this.radioButton_Motor.UseVisualStyleBackColor = true;
            // 
            // radioButton_Jeep
            // 
            this.radioButton_Jeep.AutoSize = true;
            this.radioButton_Jeep.Location = new System.Drawing.Point(19, 81);
            this.radioButton_Jeep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Jeep.Name = "radioButton_Jeep";
            this.radioButton_Jeep.Size = new System.Drawing.Size(73, 28);
            this.radioButton_Jeep.TabIndex = 2;
            this.radioButton_Jeep.Text = "Jeep";
            this.radioButton_Jeep.UseVisualStyleBackColor = true;
            // 
            // radioButton_SUV
            // 
            this.radioButton_SUV.AutoSize = true;
            this.radioButton_SUV.Location = new System.Drawing.Point(19, 54);
            this.radioButton_SUV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_SUV.Name = "radioButton_SUV";
            this.radioButton_SUV.Size = new System.Drawing.Size(69, 28);
            this.radioButton_SUV.TabIndex = 1;
            this.radioButton_SUV.Text = "SUV";
            this.radioButton_SUV.UseVisualStyleBackColor = true;
            // 
            // radioButton_Binek
            // 
            this.radioButton_Binek.AutoSize = true;
            this.radioButton_Binek.Checked = true;
            this.radioButton_Binek.Location = new System.Drawing.Point(19, 27);
            this.radioButton_Binek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Binek.Name = "radioButton_Binek";
            this.radioButton_Binek.Size = new System.Drawing.Size(78, 28);
            this.radioButton_Binek.TabIndex = 0;
            this.radioButton_Binek.TabStop = true;
            this.radioButton_Binek.Text = "Binek";
            this.radioButton_Binek.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(787, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(652, 901);
            this.dataGridView1.TabIndex = 17;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1503, 968);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox_extra.ResumeLayout(false);
            this.groupBox_aracIslemleri.ResumeLayout(false);
            this.groupBox_aracIslemleri.PerformLayout();
            this.groupBox_saat.ResumeLayout(false);
            this.groupBox_saat.PerformLayout();
            this.groupBox_aractipi.ResumeLayout(false);
            this.groupBox_aractipi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_seri;
        private System.Windows.Forms.Label label_rfidKartNumarası;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox_plaka;
        private System.Windows.Forms.Label label_plaka;
        private System.Windows.Forms.GroupBox groupBox_aracIslemleri;
        private System.Windows.Forms.RadioButton radioButton_ic;
        private System.Windows.Forms.RadioButton radioButton_dıs;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox_saat;
        private System.Windows.Forms.Label label_saat;
        private System.Windows.Forms.GroupBox groupBox_aractipi;
        private System.Windows.Forms.RadioButton radioButton_Jeep;
        private System.Windows.Forms.RadioButton radioButton_SUV;
        private System.Windows.Forms.RadioButton radioButton_Binek;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton_otopark;
        private System.Windows.Forms.GroupBox groupBox_extra;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton_Motor;
        private System.Windows.Forms.RadioButton radioButton_icdıs;
        private System.Windows.Forms.RadioButton radioButton_cilali;
        private System.Windows.Forms.Button button_kayıpkart;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn licensePlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleExtraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
