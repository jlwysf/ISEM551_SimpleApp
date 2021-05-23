using System;
using System.Data;
//using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class DADemographicsInformation
    {
        public static DataSet GetDemographicsUsingDBWithConfig()
        {
            string SqlConnection = "Server=localhost;Database=ISEM551;Uid=root;Pwd=root";
            MySqlConnection connection = new MySqlConnection(SqlConnection);
            connection.Open();
            MySqlCommand cmd;
            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM isem_users";
                dt.Load(cmd.ExecuteReader());
                dsGetDemographicsReport.Tables.Add(dt);
                //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                //DataSet ds = new DataSet();
                //adap.Fill(ds);
                //dt.Load(adap);
                //dsGetDemographicsReport.Tables.Add(adap);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }

            
            return dsGetDemographicsReport;
            //return dt;



            //SqlConnection connection;
            //var cs = ConfigurationManager.ConnectionStrings["DemographicsConnection_DEV"].ConnectionString;
            //connection.Open();

            //string sql = null;
            //sql = "";
            //SqlCommand command;
            //command = new SqlCommand(sql, connection);

            //SqlDataReader datareader;
            //datareader = command.ExecuteReader();

            //dt.Load(dataReader);
            //dsGetDemographicsReport.Tables.Add(dt);

            //datareader.Close();
            //command.Dispose();
            //connection.Close();

        }
    }
}
