using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace UITracker
{
    public partial class UserForm : Form
    {
        

        public UserForm()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel1.BringToFront();
        }

        public void UpdateForm( TicketModel bilet)
        {

            this.panel1.Visible = false;

            CalculateModel da = new CalculateModel();

            label_plaka2.Text = bilet.License_Plate;
            label_tarife2.Text = bilet.Vehicle_Process;



            var koleksiyon = da.UmaskEncryption(bilet.Vehicle_Extra);
            List<string> koleksiyondizisi = new List<string>();


            foreach (var e in koleksiyon)
            {
                if (e == 5)
                {
                    koleksiyondizisi.Add("Zift Temizleme");
                    //label_extra2.Text += "Zift Temizleme";
                }
                ///////////////////////
                if (e == 4)
                {
                    koleksiyondizisi.Add("Boya Koruma");
                    //label_extra2.Text += "Boya Koruma";
                }
                ///////////////////////
                if (e == 3)
                {
                    koleksiyondizisi.Add("Pasta Cila");
                    //label_extra2.Text += "Pasta Cila";
                }
                ///////////////////////
                if (e == 2)
                {
                    koleksiyondizisi.Add("Kuaför");
                    //label_extra2.Text += "Kuaför";
                }
                ///////////////////////
                if (e == 1)
                {
                    koleksiyondizisi.Add("Motor Yıkama");
                    //label_extra2.Text += "Motor Yıkama";
                }
            }

            var str = string.Join<string>(",", koleksiyondizisi);
            label_extra2.Text = str;

            label_checkin2.Text = bilet.Check_in.ToString();

            TimeSpan span = bilet.Check_out.Subtract(bilet.Check_in);

            

            label_time2.Text = span.Days.ToString("0") + " Gün " + span.Hours.ToString("00") + " saat " + span.Minutes.ToString("00") + " dk " + span.Seconds.ToString("00") + " sn ";

            label_price2.Text = bilet.Price.ToString() + " TL";

            ///////////////////

            saniye = 0;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;

        }

        int saniye = 0;
     

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if ((saniye >= 7))
            {
                panel1.Visible = true;
                panel1.BringToFront();

                saniye = 0;

            }

            saniye++;
            label_date.Text = saniye.ToString();
        }
    }
}
