using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAMCWebNetCore.Models
{
    public class AppointmentContext
    {
        public string ConnectionString { get; set; }

        public AppointmentContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public AppointmentContext()
        {
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Appointment> GetAllAppointments()
        {
            List<Appointment> List = new List<Appointment>();
            using (MySqlConnection DbConn = GetConnection())
            {
                DbConn.Open();
                StringBuilder Sb = new StringBuilder();
                Sb.Append("SELECT * FROM samc_appointment ");

                MySqlCommand Cmd = new MySqlCommand(Sb.ToString(), DbConn);
                using (MySqlDataReader Dr = Cmd.ExecuteReader() )
                {
                    while (Dr.Read())
                    {
                        List.Add(new Appointment()
                        {
                            AppointmentID = Dr.GetString("AppointmentID"), //Dr["AppointmentID"].ToString(),
                            EmpID = Dr.GetString("EmpID"), //Dr["EmpID"].ToString(),
                            EmpName = Dr.GetString("EmpName"), //Dr["EmpName"].ToString(),
                            CustomerID = Dr.GetString("CustomerID"), //Dr["CustomerID"].ToString(),
                            CustomerName = Dr.GetString("CustomerName"), //Dr["CustomerName"].ToString(),
                            AppointmentTime = Dr.GetDateTime("AppointmentTime"), //Convert.ToDateTime(Dr["AppointmentTime"])
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

        public void AddNewAppointment(Appointment appointment)
        {
            List<Appointment> List = new List<Appointment>();
            using (MySqlConnection DbConn = GetConnection())
            {
                DbConn.Open();
                StringBuilder Sb = new StringBuilder();
                Sb.Append("");
            }

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand("spAddEmployee", con);
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    cmd.Parameters.AddWithValue("@Name", employee.Name);
            //    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
            //    cmd.Parameters.AddWithValue("@Department", employee.Department);
            //    cmd.Parameters.AddWithValue("@City", employee.City);

            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
                       
        }

        //public List<Customer> SearchCustomer()
        //{
        //     //.Append("SELECT a.CustomerID, a.SaluteCode, a.SaluteName, CustomerName, NRICPassportNo, AddressLine1, AddressLine2, AddressLine3, AddressLine4, TelNo, MobileNo, Email, ")
        //     //   .Append("PetID, PetName, PetDOB, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, SexCode, SexName, StatusCode, StatusName ")
        //     //   .Append("FROM samc_customer a ")
        //     //   .Append("INNER JOIN samc_pet b ON a.CustomerID = b.CustomerID ")
        //     //   .Append("WHERE a.CustomerID = @CustomerID OR a.NRICPassportNo = @NRICPassportNo ")
        //}

    }
}
