using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using System.Data.SqlClient;

namespace UITracker
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        

        private void UserControl2_Load(object sender, EventArgs e)
        {
            AdminPanelTabloUpdate();
        }


        public void AdminPanelTabloUpdate()
        {
            string connectionString = Helper.CnnVal("OtoparkDB");
            string sql = "SELECT License_Plate,Vehicle_Type,Vehicle_Process,Check_in,Check_out,Price FROM Tickets ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Tickets_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Tickets_table";

            dataGridView1.Columns[0].HeaderText = "Plaka";
            dataGridView1.Columns[1].HeaderText = "Araç Tipi";
            dataGridView1.Columns[2].HeaderText = "Araç İşlem";
            dataGridView1.Columns[3].HeaderText = "Giriş Saati";
            dataGridView1.Columns[4].HeaderText = "Çıkış Saati";
            dataGridView1.Columns[5].HeaderText = "Ücret";

            if (dataGridView1 != null)
            {
                for (int count = 0; (count <= (dataGridView1.Rows.Count - 1)); count++)
                {
                    dataGridView1.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }

        }

        private void Button_Yenile_Click(object sender, EventArgs e)
        {
            AdminPanelTabloUpdate();
        }
    }
}
