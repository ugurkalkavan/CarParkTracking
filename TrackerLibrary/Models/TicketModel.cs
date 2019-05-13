using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TicketModel : CardModel
    {
        public TicketModel()
        {
        }

        public int Ticket_ID { get; set; }
        public String License_Plate { get; set; }
        
        public String Vehicle_Type { get; set; }
        public String Vehicle_Process { get; set; }
        public int Vehicle_Extra { get; set; }
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        public int Price { get; set; }
        public String Ticket_Status { get; set; }

        public string Fullinfo
        { get
            {
                return $"{Ticket_ID} -- {License_Plate} -- {Card_ID} -- {Vehicle_Type} -- {Vehicle_Process} -- {Vehicle_Extra} -- {Check_in} -- {Check_out} -- {Price}";
            }

        }



       




    }
}
