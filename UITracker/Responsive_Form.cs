using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UITracker
{
    public partial class Responsive_Form : Form
    {
        


        

       

        public Responsive_Form()
        {
            InitializeComponent();
            

        }




        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private bool mouseDown;
        private Point lastLocation;


        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    if (m.Result == (IntPtr)HTCLIENT)
                    {
                        m.Result = (IntPtr)HTCAPTION;
                    }
                    break;
            }
        }

      


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000 | 0x80000 | 0x40000; //WS_MINIMIZEBOX | WS_SYSMENU | WS_SIZEBOX;

                return cp;
            }
        }

        /// <summary>
        /// ///////////////////////
        /// </summary>
        

        private void TableLayoutPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
       
        private void TableLayoutPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void TableLayoutPanel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void TableLayoutPanel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }






        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Tarih: " + DateTime.Now.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        private void Button3_Click_1(object sender, EventArgs e)
        {
            userControl12.BringToFront();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }



   

        int counter = 0;
        private void PictureBox1_Click(object sender, EventArgs e)
        {


            counter++;
            if (counter==3)
            {
                AdminLogin FormAL = new AdminLogin();
                FormAL.Owner = this;
                FormAL.ShowDialog();
                
                counter = 0;
            }
           

        }
        int timer = 0;
        private void Timer2_Tick(object sender, EventArgs e)
        {

            if (timer==5)
            {
                timer = 0;
                counter = 0;
            }
            timer++;
            
        }


        public void LoginAdminForm()
        {

            button_sekme2.Visible = true;
            button_sekme3.Visible = true;
            button_sekme4.Visible = true;
            button_logout.Visible = true;

        }



        private void Button_logout_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Admin'den Çıkmak üzeresiniz.", "Admin Çıkış", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                //do something
                button_sekme2.Visible = false;
                button_sekme3.Visible = false;
                button_sekme4.Visible = false;
                button_logout.Visible = false;
                button_aracgiris.PerformClick();
            }


            
        }
    }
}
