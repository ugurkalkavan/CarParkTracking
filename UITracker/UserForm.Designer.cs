namespace UITracker
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_plaka2 = new System.Windows.Forms.Label();
            this.label_tarife2 = new System.Windows.Forms.Label();
            this.label_plaka1 = new System.Windows.Forms.Label();
            this.label_tarife1 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_price1 = new System.Windows.Forms.Label();
            this.label_price2 = new System.Windows.Forms.Label();
            this.label_time1 = new System.Windows.Forms.Label();
            this.label_time2 = new System.Windows.Forms.Label();
            this.label_checkin1 = new System.Windows.Forms.Label();
            this.label_checkin2 = new System.Windows.Forms.Label();
            this.label_extra1 = new System.Windows.Forms.Label();
            this.label_extra2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.Size = new System.Drawing.Size(1059, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36272F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63728F));
            this.tableLayoutPanel2.Controls.Add(this.label_plaka2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_tarife2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_plaka1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_tarife1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_date, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label_price1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_price2, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label_time1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_time2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_checkin1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_checkin2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_extra1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_extra2, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 210);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 340);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label_plaka2
            // 
            this.label_plaka2.AutoSize = true;
            this.label_plaka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaka2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_plaka2.Location = new System.Drawing.Point(516, 0);
            this.label_plaka2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plaka2.Name = "label_plaka2";
            this.label_plaka2.Size = new System.Drawing.Size(275, 48);
            this.label_plaka2.TabIndex = 10;
            this.label_plaka2.Text = "plaka gelecek";
            // 
            // label_tarife2
            // 
            this.label_tarife2.AutoSize = true;
            this.label_tarife2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tarife2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_tarife2.Location = new System.Drawing.Point(516, 48);
            this.label_tarife2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tarife2.Name = "label_tarife2";
            this.label_tarife2.Size = new System.Drawing.Size(269, 48);
            this.label_tarife2.TabIndex = 13;
            this.label_tarife2.Text = "tarife gelecek";
            // 
            // label_plaka1
            // 
            this.label_plaka1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_plaka1.AutoSize = true;
            this.label_plaka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_plaka1.Location = new System.Drawing.Point(371, 0);
            this.label_plaka1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_plaka1.Name = "label_plaka1";
            this.label_plaka1.Size = new System.Drawing.Size(137, 48);
            this.label_plaka1.TabIndex = 17;
            this.label_plaka1.Text = "Plaka:";
            // 
            // label_tarife1
            // 
            this.label_tarife1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tarife1.AutoSize = true;
            this.label_tarife1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tarife1.Location = new System.Drawing.Point(368, 48);
            this.label_tarife1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tarife1.Name = "label_tarife1";
            this.label_tarife1.Size = new System.Drawing.Size(140, 48);
            this.label_tarife1.TabIndex = 14;
            this.label_tarife1.Text = "Tarife:";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(3, 288);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(46, 17);
            this.label_date.TabIndex = 10;
            this.label_date.Text = "label1";
            // 
            // label_price1
            // 
            this.label_price1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_price1.AutoSize = true;
            this.label_price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price1.ForeColor = System.Drawing.Color.Red;
            this.label_price1.Location = new System.Drawing.Point(191, 240);
            this.label_price1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price1.Name = "label_price1";
            this.label_price1.Size = new System.Drawing.Size(317, 48);
            this.label_price1.TabIndex = 16;
            this.label_price1.Text = "Otopark Ücreti:";
            // 
            // label_price2
            // 
            this.label_price2.AutoSize = true;
            this.label_price2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price2.ForeColor = System.Drawing.Color.Red;
            this.label_price2.Location = new System.Drawing.Point(516, 240);
            this.label_price2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price2.Name = "label_price2";
            this.label_price2.Size = new System.Drawing.Size(281, 48);
            this.label_price2.TabIndex = 21;
            this.label_price2.Text = "ücret gelecek";
            // 
            // label_time1
            // 
            this.label_time1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time1.AutoSize = true;
            this.label_time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time1.Location = new System.Drawing.Point(388, 192);
            this.label_time1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time1.Name = "label_time1";
            this.label_time1.Size = new System.Drawing.Size(120, 48);
            this.label_time1.TabIndex = 19;
            this.label_time1.Text = "Süre:";
            // 
            // label_time2
            // 
            this.label_time2.AutoSize = true;
            this.label_time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_time2.Location = new System.Drawing.Point(516, 192);
            this.label_time2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time2.Name = "label_time2";
            this.label_time2.Size = new System.Drawing.Size(328, 39);
            this.label_time2.TabIndex = 20;
            this.label_time2.Text = "kalınan süre gelecek";
            // 
            // label_checkin1
            // 
            this.label_checkin1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_checkin1.AutoSize = true;
            this.label_checkin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkin1.Location = new System.Drawing.Point(281, 144);
            this.label_checkin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_checkin1.Name = "label_checkin1";
            this.label_checkin1.Size = new System.Drawing.Size(227, 48);
            this.label_checkin1.TabIndex = 18;
            this.label_checkin1.Text = "Giriş Saati:";
            // 
            // label_checkin2
            // 
            this.label_checkin2.AutoSize = true;
            this.label_checkin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_checkin2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_checkin2.Location = new System.Drawing.Point(516, 144);
            this.label_checkin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_checkin2.Name = "label_checkin2";
            this.label_checkin2.Size = new System.Drawing.Size(288, 39);
            this.label_checkin2.TabIndex = 15;
            this.label_checkin2.Text = "giriş saati gelecek";
            // 
            // label_extra1
            // 
            this.label_extra1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_extra1.AutoSize = true;
            this.label_extra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_extra1.Location = new System.Drawing.Point(315, 96);
            this.label_extra1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_extra1.Name = "label_extra1";
            this.label_extra1.Size = new System.Drawing.Size(193, 48);
            this.label_extra1.TabIndex = 22;
            this.label_extra1.Text = "Ek İşlem:";
            // 
            // label_extra2
            // 
            this.label_extra2.AutoSize = true;
            this.label_extra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_extra2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_extra2.Location = new System.Drawing.Point(516, 96);
            this.label_extra2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_extra2.Name = "label_extra2";
            this.label_extra2.Size = new System.Drawing.Size(329, 48);
            this.label_extra2.TabIndex = 23;
            this.label_extra2.Text = "ek işlem gelecek";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_extra1;
        private System.Windows.Forms.Label label_extra2;
    }
}