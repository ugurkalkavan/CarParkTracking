using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class DataAccess
    {

        public List<TicketModel> GetTickets()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {

                
                var output = connection.Query<TicketModel>($"select * from Tickets ").ToList();

                return output;
            }

        }

        public CardModel GetCardKullanimda(string card_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {

                
                var output = connection.Query<CardModel>($"select * from Cards where Card_ID ='{ card_id}' and Status='Kullanimda'").SingleOrDefault();

                
                return output;
            }

        }

        public CardModel GetCardVarmı(string card_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {


                var output = connection.Query<CardModel>($"select * from Cards where Card_ID ='{ card_id}'").SingleOrDefault();


                return output;
            }

        }

        public List<TicketModel> GetTicketToCalculate(string card_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {


                var output = connection.Query<TicketModel>($"select * from Tickets as T,Cards as C where C.Card_ID ='{card_id}'  and C.Card_ID=T.Card_ID and T.Ticket_Status='Acik' ").ToList();


                return output;
            }
        }


        public TicketModel GetTicketOfMissinCard(String plaka)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {


                var output = connection.Query<TicketModel>($"select * from Tickets as T,Cards as C where T.License_Plate ='{plaka}' and Status = 'Kullanimda 'and C.Card_ID=T.Card_ID").SingleOrDefault();

                return output;
            }

        }


        public void AddCard(String card_id,string status)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {

                List<CardModel> kart = new List<CardModel>();

                kart.Add(new CardModel { Card_ID = card_id, Status = status });

                connection.Execute("dbo.Procedure_AddCard @card_id,@status", kart); 
            }
        }

        public void CreateTicket(string license_plate, String card_id, string vehicle_type, string vehicle_process, int vehicle_extra, DateTime check_in)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {

                List<TicketModel> bilet = new List<TicketModel>();

                bilet.Add(new TicketModel { License_Plate=license_plate, Card_ID = card_id, Vehicle_Type = vehicle_type, Vehicle_Process=vehicle_process, Vehicle_Extra= vehicle_extra,Check_in = check_in });

                connection.Execute("dbo.Procedure_CreateTicket @License_Plate,@Card_ID,@Vehicle_Type,@Vehicle_Process,@Vehicle_Extra,@Check_in", bilet);
            }
        }

        public void UpdateTicketPrice(TicketModel bilet)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {


                connection.Execute("dbo.Procedure_Ticket_update @Ticket_ID,@Check_out,@Price", bilet);
            }
        }

        public void UpdateCardStatusBosta(CardModel kart)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {
                

                connection.Execute("dbo.Procedure_Card_updateAsBosta @Card_ID", kart);
            }
        }

        public void UpdateCardStatusKullanimda(CardModel kart)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OtoparkDB")))
            {


                connection.Execute("dbo.Procedure_Card_updateAsKullanimda @Card_ID", kart);
            }
        }


    }
}
