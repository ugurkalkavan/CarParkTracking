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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            
            this.AcceptButton = button_Giris;
            this.CancelButton = button_iptal;
            textBox_Username.Select();
        }
   

        
        private void Button_Giris_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text=="kerem" && textBox1.Text=="123")
            {

                (this.Owner as Responsive_Form).LoginAdminForm();
                this.Hide();
                


            }
            else
            {
                label_uyari.Text = "Kullanıcı adı ya da paralo yanlış!";
            }
        }
    }
}
