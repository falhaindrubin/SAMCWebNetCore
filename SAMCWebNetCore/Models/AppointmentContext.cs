using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text;

namespace SAMCWebNetCore.Models
{
    public class AppointmentContext
    {
        public string ConnectionString { get; set; }       

        public AppointmentContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Appointment> GetAllAppointment()
        {
            StringBuilder Sb = new StringBuilder();
            List<Appointment> List = new List<Appointment>();            

            using (MySqlConnection DbConn = GetConnection())
            {                
                DbConn.Open();
                Sb.Append("SELECT * FROM samc_appointment ");
                MySqlCommand Cmd = new MySqlCommand(Sb.ToString(), DbConn);
                using (MySqlDataReader Dr = Cmd.ExecuteReader())
                {
                    while (Dr.Read())
                    {
                        List.Add(new Appointment()
                        {
                            AppointmentID = Dr.GetString("AppointmentID"),
                            EmpID = Dr.GetString("EmpID"),
                            EmpName = Dr.GetString("EmpName"),
                            CustomerID = Dr.GetString("CustomerID"),
                            CustomerName = Dr.GetString("CustomerName"),
                            AppointmentTime = Dr.GetDateTime("AppointmentTime"),
                            CreatedBy = Dr.GetString("CreatedBy"),
                            DateCreated = Dr.GetDateTime("DateCreated"),
                            ModifiedBy = Dr.GetString("ModifiedBy"),
                            DateModified = Dr.GetDateTime("DateModified")
                        });
                    }
                }
            }

            return List;
        }

    }
}
