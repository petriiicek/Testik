using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanik_Test_DB_20220503
{
    class SqlRepozitar
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=databaze_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Faktura> GetFaktura()
        {
            List<Faktura> faktura = new List<Faktura>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Faktura";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            var faktury = new Faktura()
                            {
                                id = Convert.ToInt32(sqlDataReader["id"]),
                                datum = Convert.ToDateTime(sqlDataReader["datum"]),
                                cislo = Convert.ToInt32(sqlDataReader["cislo"]),
                                odberatel = Convert.ToString(sqlDataReader["odberatel"]),
                                nazev = Convert.ToString(sqlDataReader["nazev"]),
                                pocet = Convert.ToInt32(sqlDataReader["pocet"]),
                                cena = Convert.ToSingle(sqlDataReader["cena"]),

                            };
                            faktura.Add(faktury);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return faktura;
        }
    }
}