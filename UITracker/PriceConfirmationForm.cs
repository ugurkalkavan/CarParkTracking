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
    public partial class PriceConfirmationForm : Form
    {       
        public PriceConfirmationForm()
        {
            InitializeComponent();

            


            this.AcceptButton = button_Onay;
            this.CancelButton = button_iptal;
        }

        public TicketModel biletforcheckbox = new TicketModel();
        public TicketModel biletiver(TicketModel verilecekbilet)
        {
            biletforcheckbox = verilecekbilet;

            return biletforcheckbox;
        }

        public void UpdateForm( TicketModel bilet)
        {
            numericUpDown_ekucret.Value = 0;
            checkBox_otoparkücreti.Checked = false;

            CalculateModel da = new CalculateModel();

            int fiyat = da.CalculatePrice(bilet);
            bilet.Price = fiyat;

            label_plaka2.Text = bilet.License_Plate;
            label_tarife2.Text = bilet.Vehicle_Process;

            var koleksiyon = da.UmaskEncryption(bilet.Vehicle_Extra);
            List<string> koleksiyondizisi = new List<string>();

            foreach (var e in koleksiyon)
            {
                if (e == 5)
                {
                    koleksiyondizisi.Add("Boya Koruma");
                    //label_extra2.Text += "Zift Temizleme";
                }
                ///////////////////////
                if (e == 4)
                {
                    koleksiyondizisi.Add("Zift Temizleme");
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

            label_price2.Text = fiyat.ToString() + " TL";

            ///////////////////

            biletiver(bilet);
        }

        public Boolean onay = false;
        private void Button_Onay_Click(object sender, EventArgs e)
        {
            onay = true;
           

            this.Close();

        }

        public void CheckBox_otoparkücreti_CheckedChanged(object sender, EventArgs e)
        {
            CalculateModel da = new CalculateModel();

            int fiyat = da.CalculatePrice(biletforcheckbox);

            if (checkBox_otoparkücreti.Checked)
            {
                biletforcheckbox.Price = (fiyat - da.CalculateOtoparkPrice(biletforcheckbox) + (int)numericUpDown_ekucret.Value);
                label_price2.Text = biletforcheckbox.Price.ToString() + " TL";
            }
            else
            {
                biletforcheckbox.Price = fiyat + (int)numericUpDown_ekucret.Value;
                label_price2.Text = biletforcheckbox.Price.ToString() + " TL";
            }
        }

        private void NumericUpDown_ekucret_ValueChanged(object sender, EventArgs e)
        {
            CalculateModel da = new CalculateModel();
            int fiyat;
            if (checkBox_otoparkücreti.Checked)
            {
                fiyat = da.CalculatePrice(biletforcheckbox) - da.CalculateOtoparkPrice(biletforcheckbox);
            }
            else
            {
                fiyat = da.CalculatePrice(biletforcheckbox);
            }

            biletforcheckbox.Price = fiyat + (int)numericUpDown_ekucret.Value;
            label_price2.Text = biletforcheckbox.Price.ToString() + " TL";  
        }
        private void NumericUpDown_ekucret_TextChanged(object sender, EventArgs e)
        {
            CalculateModel da = new CalculateModel();
            int fiyat;
            if (checkBox_otoparkücreti.Checked)
            {
                fiyat = da.CalculatePrice(biletforcheckbox) - da.CalculateOtoparkPrice(biletforcheckbox);
            }
            else
            {
                fiyat = da.CalculatePrice(biletforcheckbox);
            }

            biletforcheckbox.Price = fiyat + (int)numericUpDown_ekucret.Value;
            label_price2.Text = biletforcheckbox.Price.ToString() + " TL";
        }

        private void Button_iptal_Click(object sender, EventArgs e)
        {

        }
    }
}
