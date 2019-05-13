using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Text.RegularExpressions;
using RawInput_dll;

namespace UITracker
{
    public partial class UserControl1 : UserControl
    {
        private readonly RawInput _rawinput;
        const bool CaptureOnlyInForeground = true;
        readonly UserForm f2 = new UserForm();

        readonly PriceConfirmationForm f3 = new PriceConfirmationForm();
        readonly MissingCard f4 = new MissingCard();
        public UserControl1()
        {
            InitializeComponent();
           
            f2.Show();

    
            _rawinput = new RawInput(Handle, CaptureOnlyInForeground);

            ///_rawinput.AddMessageFilter();   // Adding a message filter will cause keypresses to be handled
            //Win32.DeviceAudit();            // Writes a file DeviceAudit.txt to the current directory

            _rawinput.KeyPressed += OnKeyPressed;



            //DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //dataGridView1.Columns.Add(chk);
            //chk.HeaderText = "Yıkama Bitti";
            //chk.Name = "chk";

            KuyrukUpdate();

        }

        bool check = true;
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            //lbHandle.Text = e.KeyPressEvent.DeviceHandle.ToString();
            //lbType.Text = e.KeyPressEvent.DeviceType;
            //lbName.Text = e.KeyPressEvent.DeviceName;
            //lbDescription.Text = e.KeyPressEvent.Name;

            //lbKey.Text = e.KeyPressEvent.VKey.ToString(CultureInfo.InvariantCulture);
            //lbNumKeyboards.Text = _rawinput.NumberOfKeyboards.ToString(CultureInfo.InvariantCulture);
            //lbVKey.Text = e.KeyPressEvent.VKeyName;
            //lbSource.Text = e.KeyPressEvent.Source;
            //lbKeyPressState.Text = e.KeyPressEvent.KeyPressState;
            //lbMessage.Text = string.Format("0x{0:X4} ({0})", e.KeyPressEvent.Message);


            if (e.KeyPressEvent.Name == "HID Keyboard Device")
            {
                if (check)
                {
                    textBox_seri.ReadOnly = false;
                    textBox_seri.Focus();

                    if (textBox_seri.TextLength == 10 && e.KeyPressEvent.VKeyName == "ENTER" && e.KeyPressEvent.KeyPressState == "BREAK")
                    {
                        check = false;
                        textBox_seri.ReadOnly = true;
                    }
                }
                else
                {
                    textBox_seri.ReadOnly = false;
                    textBox_seri.Text = "";
                    textBox_seri.Focus();
                    check = true;
                }
            }          
        }
        private void ClearForm()
        {
            textBox_seri.ReadOnly = true;
            textBox_plaka.Enabled = true;
            // groupboxs enable true
            groupBox_aracIslemleri.Enabled = true;
            groupBox_aractipi.Enabled = true;
            groupBox_saat.Enabled = true;
            groupBox_extra.Enabled = true;


            textBox_plaka.Text = "34";
            textBox_seri.Text = "";

            // Arac tipi checked false

            radioButton_Binek.Checked = true;
            radioButton_SUV.Checked = false;
            radioButton_Jeep.Checked = false;
            radioButton_Motor.Checked = false;

            // Otopark işlemleri checked false
            radioButton_otopark.Checked = true;
            radioButton_ic.Checked = false;
            radioButton_dıs.Checked = false;
            radioButton_icdıs.Checked = false;

            // Ekstra işlemler checked false
            foreach (int s in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(s, CheckState.Unchecked);
            }

            KuyrukUpdate();
        }
        private bool CheckCard()
        {
            bool CheckCardOutput=false;

            //DataAccess için nesne oluşturuldu.
            DataAccess da = new DataAccess();

            CardModel Kart = new CardModel();

            Kart = da.GetCardKullanimda(textBox_seri.Text);

            

            if (Kart!=null)
            {
                CheckCardOutput = true;
            }


            return CheckCardOutput;
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

            // döngü başladı
            //while (true)
            //{
            //    //CardID için regex
            //    Regex patternForCardID = new Regex(@"^[0-9]{10}$");
            //    if (patternForCardID.IsMatch(textBox_seri.Text))
            //    {
            //        ValidateFormOutput = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Card ID uygun değil!");
            //        ValidateFormOutput = false;
            //        return ValidateFormOutput;
            //    }

            //    //Plaka için regex
            //    Regex patternForPlaka = new Regex(@"^[0-9]{1,2}[ ][a-zA-Z]{1,4}[ ][0-9]{1,4}$");
            //    //Regex patternForPlaka = new Regex(@"^[a-zA-Z]{1,4}[ ][a-zA-Z]{1,4}[ ][a-zA-Z]{1,4}$");
            //    if (patternForPlaka.IsMatch(textBox_plaka.Text))
            //    {
            //        //MessageBox.Show("OK");
            //        ValidateFormOutput = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Plaka uygun değil!");
            //        ValidateFormOutput = false;
            //        return ValidateFormOutput;
            //    }
            //    // return form uygunlugu
            //    return ValidateFormOutput;
            //}
        }
        
        private void Button_Sıfırla_Click(object sender, EventArgs e)
        {
            ClearForm();  
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.label_saat.Text = DateTime.Now.ToString();
        }

        string radiogroup1, radiogroup2;
        int maskOfExtra;
        private void WhichRbChecked()
        {

            List<RadioButton> radiolistesi = new List<RadioButton>();

            radiolistesi.Add(radioButton_Binek);
            radiolistesi.Add(radioButton_SUV);
            radiolistesi.Add(radioButton_Jeep);
            radiolistesi.Add(radioButton_Motor);

            foreach (var rb in radiolistesi)
            {
                if (rb.Checked)
                {
                    radiogroup1 = rb.Text;
                }
            }
            //MessageBox.Show(radiogroup1);

            radiolistesi.Add(radioButton_otopark);
            radiolistesi.Add(radioButton_ic);
            radiolistesi.Add(radioButton_dıs);
            radiolistesi.Add(radioButton_icdıs);
            radiolistesi.Add(radioButton_cilali);
            foreach (var rb in radiolistesi)
            {
                if (rb.Checked)
                {
                    radiogroup2 = rb.Text;
                }
            }
            //MessageBox.Show(radiogroup2);


            maskOfExtra=0;

            foreach (int s in checkedListBox1.CheckedIndices)
            {
                
                maskOfExtra += (int)Math.Pow(2,s);
            }

            //MessageBox.Show(maskOfExtra.ToString());

            //UmaskEncryption(maskOfExtra);

        } 
        private void textBox_seri_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox_seri.Text.Length >= 10)
            {
                //textBox_plaka.Enabled = true;
                //groupBox_aracIslemleri.Enabled = true;
                //groupBox_aractipi.Enabled = true;
                //groupBox_saat.Enabled = true;
                //groupBox_extra.Enabled = true;

                //textBox_seri.ReadOnly = true;
                //textBox_plaka.Focus();

                //Boolean ValidateCardOutput;
                //CardID için regex
                //Regex patternForCardID = new Regex(@"^[0-9]{10}$");
                //if (patternForCardID.IsMatch(textBox_seri.Text))
                //{
                //    ValidateCardOutput = true;
                //}
                //else
                //{
                //    MessageBox.Show("Card ID uygun değil!");
                //    ValidateCardOutput = false;
                //}

                if (CheckCard())
                {

                    //DataAccess için nesne oluşturuldu.
                    DataAccess da = new DataAccess();

                    //List<CardModel> Kartlar = new List<CardModel>();

                    //Kartlar = da.GetCard(textBox_seri.Text);

                    //CardModel Kart = new CardModel();
                    //Kart = Kartlar[0];


                    List<TicketModel> Biletler = new List<TicketModel>();

                    Biletler = da.GetTicketToCalculate(textBox_seri.Text);

                    TicketModel bilet = new TicketModel();

                    bilet = Biletler[0];



                    //CalculateModel cm = new CalculateModel();

                    //MessageBox.Show("Fiyat: " + cm.CalculatePrice(bilet).ToString());



                    f3.UpdateForm(bilet);
                    f3.ShowDialog();

                    


                    if (f3.onay)
                    {
                        f2.UpdateForm(f3.biletforcheckbox);
                        da.UpdateTicketPrice(f3.biletforcheckbox);
                        da.UpdateCardStatusBosta(da.GetCardKullanimda(f3.biletforcheckbox.Card_ID));
                        f3.onay = false;
                    }
                    



                    ClearForm();
                }

            }
        }

        
       

        private void textBox_plaka_TextChanged(object sender, EventArgs e)
        {
            TextBox currentContainer = ((TextBox)sender);
            int caretPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = caretPosition++;
        }
        

        public  void KuyrukUpdate()
        {
            string connectionString = Helper.CnnVal("OtoparkDB");
            string sql = "SELECT License_Plate,Vehicle_Type,Vehicle_Process,Check_in FROM Tickets where Ticket_Status='Acık'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Tickets_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tickets_table";

            dataGridView1.Columns[0].HeaderText="Plaka";
            dataGridView1.Columns[1].HeaderText = "Araç Tipi";
            dataGridView1.Columns[2].HeaderText = "Araç İşlem";
            dataGridView1.Columns[3].HeaderText = "Giriş Saati";

            if (dataGridView1 != null)
            {
                for (int count = 0; (count <= (dataGridView1.Rows.Count - 1)); count++)
                {
                    dataGridView1.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }

        }


        private void Button_kayıpkart_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            f4.ClearForm();
            f4.ShowDialog();
            if (f4.onay)
            {
                f2.UpdateForm(f4.biletforcheckbox);


                //////////
                da.UpdateTicketPrice(f4.biletforcheckbox);
                da.UpdateCardStatusBosta(da.GetCardKullanimda(f4.biletforcheckbox.Card_ID));

                f4.onay = false;
            }
            KuyrukUpdate();


        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            //Radiobuttonlar belirlendi.
            WhichRbChecked();

            //Form uygun mu kontrol et.
            if (ValidateForm())
            {
                //DataAccess için nesne oluşturuldu.
                DataAccess da = new DataAccess();


                CardModel KartKullanılmısmı = da.GetCardVarmı(textBox_seri.Text);

                if (KartKullanılmısmı!=null)
                {
                    da.UpdateCardStatusKullanimda(KartKullanılmısmı);
                }
                else
                {
                    ///////// Burası Card Ekleme database
                    da.AddCard(textBox_seri.Text, "Kullanimda");
                }

                

                ///////// Burası Ticket Ekleme database
                da.CreateTicket(textBox_plaka.Text, textBox_seri.Text,
                    radiogroup1, radiogroup2, maskOfExtra, DateTime.Parse(label_saat.Text));

                //Başarılı Mesajı verildi.
                MessageBox.Show(textBox_plaka.Text + " plakalı aracın bileti başarıyla oluşturuldu!");

                //Form Sıfırlandı.
                ClearForm();
            }
            KuyrukUpdate();
        }

        
    }
}
