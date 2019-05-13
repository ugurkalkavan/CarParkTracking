namespace UITracker
{
    partial class PriceConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceConfirmationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_plaka2 = new System.Windows.Forms.Label();
            this.label_tarife2 = new System.Windows.Forms.Label();
            this.label_plaka1 = new System.Windows.Forms.Label();
            this.label_tarife1 = new System.Windows.Forms.Label();
            this.label_price1 = new System.Windows.Forms.Label();
            this.label_price2 = new System.Windows.Forms.Label();
            this.label_time1 = new System.Windows.Forms.Label();
            this.label_time2 = new System.Windows.Forms.Label();
            this.label_checkin1 = new System.Windows.Forms.Label();
            this.label_checkin2 = new System.Windows.Forms.Label();
            this.label_extra1 = new System.Windows.Forms.Label();
            this.label_extra2 = new System.Windows.Forms.Label();
            this.button_Onay = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.label_ekucret = new System.Windows.Forms.Label();
            this.checkBox_otoparkücreti = new System.Windows.Forms.CheckBox();
            this.numericUpDown_ekucret = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ekucret)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 582);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label_plaka2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_tarife2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_plaka1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_tarife1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_price1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_price2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_time1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_time2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_checkin1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_checkin2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_extra1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_extra2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_Onay, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.button_iptal, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.label_ekucret, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_otoparkücreti, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_ekucret, 1, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 184);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 394);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label_plaka2
            // 
            this.label_plaka2.AutoSize = true;
            this.label_plaka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaka2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_plaka2.Location = new System.Drawing.Point(197, 0);
            this.label_plaka2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plaka2.Name = "label_plaka2";
            this.label_plaka2.Size = new System.Drawing.Size(169, 29);
            this.label_plaka2.TabIndex = 10;
            this.label_plaka2.Text = "plaka gelecek";
            // 
            // label_tarife2
            // 
            this.label_tarife2.AutoSize = true;
            this.label_tarife2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tarife2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_tarife2.Location = new System.Drawing.Point(197, 29);
            this.label_tarife2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tarife2.Name = "label_tarife2";
            this.label_tarife2.Size = new System.Drawing.Size(164, 29);
            this.label_tarife2.TabIndex = 13;
            this.label_tarife2.Text = "tarife gelecek";
            // 
            // label_plaka1
            // 
            this.label_plaka1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_plaka1.AutoSize = true;
            this.label_plaka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaka1.Location = new System.Drawing.Point(105, 0);
            this.label_plaka1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plaka1.Name = "label_plaka1";
            this.label_plaka1.Size = new System.Drawing.Size(84, 29);
            this.label_plaka1.TabIndex = 17;
            this.label_plaka1.Text = "Plaka:";
            // 
            // label_tarife1
            // 
            this.label_tarife1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tarife1.AutoSize = true;
            this.label_tarife1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tarife1.Location = new System.Drawing.Point(105, 29);
            this.label_tarife1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tarife1.Name = "label_tarife1";
            this.label_tarife1.Size = new System.Drawing.Size(84, 29);
            this.label_tarife1.TabIndex = 14;
            this.label_tarife1.Text = "Tarife:";
            // 
            // label_price1
            // 
            this.label_price1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_price1.AutoSize = true;
            this.label_price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price1.ForeColor = System.Drawing.Color.Red;
            this.label_price1.Location = new System.Drawing.Point(4, 145);
            this.label_price1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price1.Name = "label_price1";
            this.label_price1.Size = new System.Drawing.Size(185, 29);
            this.label_price1.TabIndex = 16;
            this.label_price1.Text = "Toplam Ücret:";
            // 
            // label_price2
            // 
            this.label_price2.AutoSize = true;
            this.label_price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price2.ForeColor = System.Drawing.Color.Red;
            this.label_price2.Location = new System.Drawing.Point(197, 145);
            this.label_price2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price2.Name = "label_price2";
            this.label_price2.Size = new System.Drawing.Size(177, 29);
            this.label_price2.TabIndex = 21;
            this.label_price2.Text = "ücret gelecek";
            // 
            // label_time1
            // 
            this.label_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time1.AutoSize = true;
            this.label_time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time1.Location = new System.Drawing.Point(116, 116);
            this.label_time1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time1.Name = "label_time1";
            this.label_time1.Size = new System.Drawing.Size(73, 29);
            this.label_time1.TabIndex = 19;
            this.label_time1.Text = "Süre:";
            // 
            // label_time2
            // 
            this.label_time2.AutoSize = true;
            this.label_time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_time2.Location = new System.Drawing.Point(197, 116);
            this.label_time2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time2.Name = "label_time2";
            this.label_time2.Size = new System.Drawing.Size(245, 29);
            this.label_time2.TabIndex = 20;
            this.label_time2.Text = "kalınan süre gelecek";
            // 
            // label_checkin1
            // 
            this.label_checkin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_checkin1.AutoSize = true;
            this.label_checkin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkin1.Location = new System.Drawing.Point(52, 87);
            this.label_checkin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_checkin1.Name = "label_checkin1";
            this.label_checkin1.Size = new System.Drawing.Size(137, 29);
            this.label_checkin1.TabIndex = 18;
            this.label_checkin1.Text = "Giriş Saati:";
            // 
            // label_checkin2
            // 
            this.label_checkin2.AutoSize = true;
            this.label_checkin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkin2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_checkin2.Location = new System.Drawing.Point(197, 87);
            this.label_checkin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_checkin2.Name = "label_checkin2";
            this.label_checkin2.Size = new System.Drawing.Size(216, 29);
            this.label_checkin2.TabIndex = 15;
            this.label_checkin2.Text = "giriş saati gelecek";
            // 
            // label_extra1
            // 
            this.label_extra1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_extra1.AutoSize = true;
            this.label_extra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_extra1.Location = new System.Drawing.Point(71, 58);
            this.label_extra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_extra1.Name = "label_extra1";
            this.label_extra1.Size = new System.Drawing.Size(118, 29);
            this.label_extra1.TabIndex = 22;
            this.label_extra1.Text = "Ek İşlem:";
            // 
            // label_extra2
            // 
            this.label_extra2.AutoSize = true;
            this.label_extra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_extra2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_extra2.Location = new System.Drawing.Point(197, 58);
            this.label_extra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_extra2.Name = "label_extra2";
            this.label_extra2.Size = new System.Drawing.Size(203, 29);
            this.label_extra2.TabIndex = 23;
            this.label_extra2.Text = "ek işlem gelecek";
            // 
            // button_Onay
            // 
            this.button_Onay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Onay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Onay.Location = new System.Drawing.Point(313, 349);
            this.button_Onay.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button_Onay.Name = "button_Onay";
            this.button_Onay.Size = new System.Drawing.Size(130, 35);
            this.button_Onay.TabIndex = 26;
            this.button_Onay.Text = "Onayla";
            this.button_Onay.UseVisualStyleBackColor = true;
            this.button_Onay.Click += new System.EventHandler(this.Button_Onay_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iptal.Location = new System.Drawing.Point(449, 349);
            this.button_iptal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(130, 35);
            this.button_iptal.TabIndex = 29;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.Button_iptal_Click);
            // 
            // label_ekucret
            // 
            this.label_ekucret.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ekucret.AutoSize = true;
            this.label_ekucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ekucret.Location = new System.Drawing.Point(97, 282);
            this.label_ekucret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ekucret.Name = "label_ekucret";
            this.label_ekucret.Size = new System.Drawing.Size(92, 25);
            this.label_ekucret.TabIndex = 28;
            this.label_ekucret.Text = "Ek Ücret:";
            // 
            // checkBox_otoparkücreti
            // 
            this.checkBox_otoparkücreti.AutoSize = true;
            this.checkBox_otoparkücreti.Location = new System.Drawing.Point(196, 220);
            this.checkBox_otoparkücreti.Name = "checkBox_otoparkücreti";
            this.checkBox_otoparkücreti.Size = new System.Drawing.Size(152, 21);
            this.checkBox_otoparkücreti.TabIndex = 30;
            this.checkBox_otoparkücreti.Text = "Otopark Ücreti İptal";
            this.checkBox_otoparkücreti.UseVisualStyleBackColor = true;
            this.checkBox_otoparkücreti.CheckedChanged += new System.EventHandler(this.CheckBox_otoparkücreti_CheckedChanged);
            // 
            // numericUpDown_ekucret
            // 
            this.numericUpDown_ekucret.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_ekucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_ekucret.Location = new System.Drawing.Point(196, 279);
            this.numericUpDown_ekucret.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_ekucret.Name = "numericUpDown_ekucret";
            this.numericUpDown_ekucret.Size = new System.Drawing.Size(130, 30);
            this.numericUpDown_ekucret.TabIndex = 31;
            this.numericUpDown_ekucret.TextChanged += new System.EventHandler(this.NumericUpDown_ekucret_TextChanged);
            this.numericUpDown_ekucret.ValueChanged += new System.EventHandler(this.NumericUpDown_ekucret_ValueChanged);
            // 
            // PriceConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PriceConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ücret Onay Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ekucret)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_plaka2;
        private System.Windows.Forms.Label label_tarife2;
        private System.Windows.Forms.Label label_checkin2;
        private System.Windows.Forms.Label label_price1;
        private System.Windows.Forms.Label label_plaka1;
        private System.Windows.Forms.Label label_tarife1;
        private System.Windows.Forms.Label label_checkin1;
        private System.Windows.Forms.Label label_time1;
        private System.Windows.Forms.Label label_time2;
        private System.Windows.Forms.Label label_price2;
        private System.Windows.Forms.Label label_extra1;
        private System.Windows.Forms.Label label_extra2;
        private System.Windows.Forms.Label label_ekucret;
        private System.Windows.Forms.Button button_Onay;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.CheckBox checkBox_otoparkücreti;
        private System.Windows.Forms.NumericUpDown numericUpDown_ekucret;
    }
}