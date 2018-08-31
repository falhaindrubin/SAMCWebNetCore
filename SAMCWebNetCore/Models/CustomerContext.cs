using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SAMCWebNetCore.Models
{
    public class CustomerContext
    {
        public string ConnectionString { get; set; }

        public CustomerContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public CustomerContext()
        {
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Customer> SearchCustomer()
        {
            List<Customer> List = new List<Customer>();

            using (MySqlConnection DbConn = GetConnection())
            {
                DbConn.Open();
                StringBuilder Sb = new StringBuilder();
                Sb.Append("SELECT * FROM samc_appointment ");
                Sb.Append("SELECT a.CustomerID, a.SaluteCode, a.SaluteName, CustomerName, NRICPassportNo, AddressLine1, AddressLine2, AddressLine3, AddressLine4, TelNo, MobileNo, Email, ");
                Sb.Append("PetID, PetName, PetDOB, AnimalTypeCode, AnimalTypeName, BreedCode, BreedName, SexCode, SexName, StatusCode, StatusName ");
                Sb.Append("FROM samc_customer a ");
                Sb.Append("INNER JOIN samc_pet b ON a.CustomerID = b.CustomerID ");
                Sb.Append("WHERE a.CustomerID = @CustomerID OR a.NRICPassportNo = @NRICPassportNo ");

                MySqlCommand Cmd = new MySqlCommand(Sb.ToString(), DbConn);
                using (MySqlDataReader Dr = Cmd.ExecuteReader())
                {
                    while (Dr.Read())
                    {
                        List.Add(new Customer()                 
                        {
                            CustomerID  = Dr.GetString("CustomerID"),
                            SaluteCode = Dr.GetString("SaluteCode"),
                            SaluteName = Dr.GetString("SaluteName"),
                            CustomerName = Dr.GetString("CustomerName"),
                            NRICPassportNo = Dr.GetString("NRICPassportNo"),
                            AddressLine1 = Dr.GetString("AddressLine1"),
                            AddressLine2 = Dr.GetString("AddressLine2"),
                            AddressLine3 = Dr.GetString("AddressLine3"),
                            AddressLine4 = Dr.GetString("AddressLine4"),
                            TelNo = Dr.GetString("TelNo"),
                            MobileNo = Dr.GetString("MobileNo"), //Dr["EmpID"].ToString(),
                            Email = Dr.GetString("Email")
                        });
                    }
                }
            }

            return List;
        }

        internal void SearchCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
