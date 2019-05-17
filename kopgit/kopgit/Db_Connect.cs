using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;
using System.Configuration;
using System.Text;
using System.IO;
namespace anaekran
{
    public class Db_Connect
    {
       
        public static string GetConnectionString()
        {  return ConfigurationManager.ConnectionStrings["baglan"].ConnectionString.ToString(); ;
        }
       

       public static SqlDataReader Sql_DataReader(string queryString)
       {
            SqlConnection.ClearAllPools();

            SqlDataReader dr = null;
            SqlConnection baglanti = new SqlConnection(GetConnectionString());

            SqlCommand komut = new SqlCommand(queryString, baglanti);
            baglanti.Open();

            dr = komut.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
       }

    }
}