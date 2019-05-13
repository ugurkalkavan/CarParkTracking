using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class CalculateModel
    {
        
        public TicketModel Ticket { get; set; }

        public List<int> UmaskEncryption(int maskOfExtra)
        {
            int a = 0;
            List<int> umasklistesi = new List<int>();

            while (maskOfExtra != 0)
            {
                while ((int)Math.Pow(2, a) <= maskOfExtra)
                {
                    a++;
                }
                umasklistesi.Add(a);


                maskOfExtra -= (int)Math.Pow(2, a - 1);
                a = 0;
            }

            return umasklistesi;
        }

        public int CalculateOtoparkPrice(TicketModel ticket)
        {
            int OtoparkPrice = 0;

            ticket.Check_out = DateTime.Now;



            TimeSpan span = ticket.Check_out.Subtract(ticket.Check_in);


            double t_hour = (span.Hours);

            
            double howManyDay = (span.Days);


            OtoparkPrice +=(int) howManyDay * 35;


            if (ticket.Vehicle_Type == "Binek" || ticket.Vehicle_Type == "SUV" || ticket.Vehicle_Type == "Jeep")
            {
                if (t_hour < 1)
                {
                    OtoparkPrice += 13;
                }
                else if (t_hour < 2)
                {
                    OtoparkPrice += 16;
                }
                else if (t_hour < 3)
                {
                    OtoparkPrice += 19;
                }
                else if (t_hour < 4)
                {
                    OtoparkPrice += 22;
                }
                else if (t_hour < 5)
                {
                    OtoparkPrice += 25;
                }
                else if (t_hour < 6)
                {
                    OtoparkPrice += 28;
                }
                else
                {
                    OtoparkPrice += 35;
                }
            }
            else if (ticket.Vehicle_Type == "Motor")
            {
                OtoparkPrice = 10;
            }
            /////////////////Zamandan kısma

            if (ticket.Vehicle_Process == "Iç Yikama" && t_hour < 2 && howManyDay < 1)
            {
                OtoparkPrice -= OtoparkPrice;
            }

            if (ticket.Vehicle_Process == "Dis Yikama" && t_hour < 2 && howManyDay < 1)
            {
                OtoparkPrice -= OtoparkPrice;
            }

            if (ticket.Vehicle_Process == "Iç-Dis Yikama" && t_hour < 3 && howManyDay < 1)
            {
                OtoparkPrice -= OtoparkPrice;
            }
            if (ticket.Vehicle_Process == "Cilali Yikama" && t_hour < 3 && howManyDay < 1)
            {
                OtoparkPrice -= OtoparkPrice;
            }



            return OtoparkPrice;
        }

        public int CalculateYıkamaPrice(TicketModel ticket)
        {
            //Yıkama İşlemleri hesaplama



            int YıkamaPrice = 0;


            if (ticket.Vehicle_Type == "Binek")
            {
                if (ticket.Vehicle_Process == "Iç Yikama")
                {
                    YıkamaPrice = 20;
                }
                else if (ticket.Vehicle_Process == "Dis Yikama")
                {
                    YıkamaPrice = 25;
                }
                else if (ticket.Vehicle_Process == "Iç-Dis Yikama")
                {
                    YıkamaPrice = 35;
                }
                else if (ticket.Vehicle_Process == "Cilali Yikama")
                {
                    YıkamaPrice = 50;
                }
            }
            else
            if (ticket.Vehicle_Type == "SUV")
            {
                if (ticket.Vehicle_Process == "Iç Yikama")
                {
                    YıkamaPrice = 20;
                }
                else if (ticket.Vehicle_Process == "Dis Yikama")
                {
                    YıkamaPrice = 30;
                }
                else if (ticket.Vehicle_Process == "Iç-Dis Yikama")
                {
                    YıkamaPrice = 40;
                }
                else if (ticket.Vehicle_Process == "Cilali Yikama")
                {
                    YıkamaPrice = 55;
                }
            }
            else
            if (ticket.Vehicle_Type == "Jeep")
            {
                if (ticket.Vehicle_Process == "Iç Yikama")
                {
                    YıkamaPrice = 25;
                }
                else if (ticket.Vehicle_Process == "Dis Yikama")
                {
                    YıkamaPrice = 30;
                }
                else if (ticket.Vehicle_Process == "Iç-Dis Yikama")
                {
                    YıkamaPrice = 45;
                }
                else if (ticket.Vehicle_Process == "Cilali Yıkama")
                {
                    YıkamaPrice = 60;
                }
            }
            else
            if (ticket.Vehicle_Type == "Motor")
            {
                YıkamaPrice = 25;
            }


            return YıkamaPrice;


        }

        public int CalculateExtraPrice(TicketModel ticket)
        {
            int ExtraPrice = 0;


            ///////////////////////


            foreach (var u in UmaskEncryption(ticket.Vehicle_Extra))
            {
                if (u == 5)
                {
                    ExtraPrice += 150;
                }
                ///////////////////////
                if (u == 4)
                {
                    ExtraPrice += 150;
                }
                ///////////////////////
                if (u == 3)
                {
                    ExtraPrice += 350;
                }
                ///////////////////////
                if (u == 2)
                {
                    ExtraPrice += 300;
                }
                ///////////////////////
                if (u == 1)
                {
                    ExtraPrice += 80;
                }
            }



            return ExtraPrice;

        }
            public int CalculatePrice(TicketModel ticket)
        {
            int PriceOutput = 0;


            PriceOutput = CalculateOtoparkPrice(ticket) + CalculateYıkamaPrice(ticket) + CalculateExtraPrice(ticket);




            return PriceOutput;
        }
    }
}
