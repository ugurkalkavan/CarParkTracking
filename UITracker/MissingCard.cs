using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace UITracker
{
     
    public partial class MissingCard : Form
    {
        readonly UserForm f2 = new UserForm();
        public MissingCard()
        {
            InitializeComponent();

            this.AcceptButton = button_Onay;
            this.CancelButton = button_iptal;
            

        }
        public void ClearForm()
        {
            textBox_plaka.Text = "34";

            label_tarife2.Text = "";
            label_extra2.Text = "";
            label_checkin2.Text = "";
            label_time2.Text = "";
            label_price2.Text = "";


            numericUpDown_ekucret.Value = numericUpDown_ekucret.Minimum;
            numericUpDown_ekucret.Enabled = false;

            checkBox_otoparkücreti.Checked = false;
            checkBox_otoparkücreti.Enabled = false;

        }
        public TicketModel biletforcheckbox = new TicketModel();
        public TicketModel biletiver(TicketModel verilecekbilet)
        {
            biletforcheckbox = verilecekbilet;

            return biletforcheckbox;
        }

        private bool ValidateForm()
        {
            //False olarak initiliaze edildi
            Boolean ValidateFormOutput = false;
            // döngü başladı
            while (true)
            {

                //Plaka için regex
                Regex patternForPlaka = new Regex(@"^[[a-zA-Z0-9]{1,}[ ][[a-zA-Z0-9]{1,}[ ][[a-zA-Z0-9]{1,}$");
                //Regex patternForPlaka = new Regex(@"^[a-zA-Z]{1,4}[ ][a-zA-Z]{1,4}[ ][a-zA-Z]{1,4}$");
                if (patternForPlaka.IsMatch(textBox_plaka.Text))
                {
                    //MessageBox.Show("OK");
                    ValidateFormOutput = true;
                }
                else
                {
                    MessageBox.Show("Plaka uygun değil!");
                    ValidateFormOutput = false;
                    return ValidateFormOutput;
                }

                return ValidateFormOutput;
            }
        }
        private void Button_Ara_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                DataAccess da = new DataAccess();
                string PlakaOfMissingCard = textBox_plaka.Text;

              

                TicketModel bilet = new TicketModel();
                bilet = da.GetTicketOfMissinCard(PlakaOfMissingCard);


                if (bilet!=null)
                {
                    numericUpDown_ekucret.Enabled = true;
                    checkBox_otoparkücreti.Enabled = true;

                    CalculateModel cm = new CalculateModel();

                    int fiyat = cm.CalculatePrice(bilet);
                    bilet.Price = fiyat;

                    label_tarife2.Text = bilet.Vehicle_Process;

                    var koleksiyon = cm.UmaskEncryption(bilet.Vehicle_Extra);
                    List<string> koleksiyondizisi = new List<string>();

                    foreach (var r in koleksiyon)
                    {
                        if (r == 5)
                        {
                            koleksiyondizisi.Add("Boya Koruma");
                            //label_extra2.Text += "Zift Temizleme";
                        }
                        ///////////////////////
                        if (r == 4)
                        {
                            koleksiyondizisi.Add("Zift Temizleme");
                            //label_extra2.Text += "Boya Koruma";
                        }
                        ///////////////////////
                        if (r == 3)
                        {
                            koleksiyondizisi.Add("Pasta Cila");
                            //label_extra2.Text += "Pasta Cila";
                        }
                        ///////////////////////
                        if (r == 2)
                        {
                            koleksiyondizisi.Add("Kuaför");
                            //label_extra2.Text += "Kuaför";
                        }
                        ///////////////////////
                        if (r == 1)
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

                    label_price2.Text = (fiyat + numericUpDown_ekucret.Minimum).ToString() + " TL";

                    ///////////////////

                    biletiver(bilet);
                }
                else
                {
                    MessageBox.Show("Bu plakaya ait Bilet yok");
                }


                

            }

        }


        public Boolean onay = false;
        private void Button_Onay_Click(object sender, EventArgs e)
        {
            if (biletforcheckbox.Card_ID != null)
            {
                onay = true;


                this.Close();

                


            }
            else
            {
                MessageBox.Show("Onaylanacak Bilet yok");
            }

            
        }
        //TODO Onaylanacak birşey yok 
        private void CheckBox_otoparkücreti_CheckedChanged(object sender, EventArgs e)
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

        private void TextBox_plaka_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }


    }
}
