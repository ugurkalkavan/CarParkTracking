using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{ 
    public class CardModel
    {
        
        

        public String Card_ID { get; set; }
        public String Status { get; set; }


        public string Fullinfo
        {
            get
            {
                return $"{Card_ID} {Status} ";
            }

        }

    }
}
