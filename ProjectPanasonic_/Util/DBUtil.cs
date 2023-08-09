using System;
using System.Collections.Generic;
using System.Configuration;
//using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraExport.Xls;

namespace BakimModul.Util
{
    public class DBUtil
    {
        public enum DbTypes { Bakim, Logo, Oracle };


        public DBUtil()
        {
            //_cn = new SqlConnection();
            //_cnLogo = new SqlConnection();
            //_cnLogoSys = new SqlConnection();
        }

        public static SqlConnection GetConnection()
        {
            return getConnection(DbTypes.Bakim);
        }
        public static SqlConnection getConnectionSql()
        {
            return getConnectionSql(DbTypes.Oracle);
        }

        public static SqlConnection getConnection()
        {
            string connectionString = "MyConnectionString"; // Veritabanı bağlantı dizesini buraya yazın
            return new SqlConnection(connectionString);
        }
        public static SqlConnection getConnection(DbTypes pDbTypes)
        {
            SqlConnection cn = new SqlConnection();
            switch (pDbTypes)
            {
                case DbTypes.Logo:
                    cn.ConnectionString = ConfigurationManager.ConnectionStrings["LogoDB"].ToString();
                    break;
                case DbTypes.Oracle:
                    cn.ConnectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ToString();
                    break;
                default:
                    cn.ConnectionString = ConfigurationManager.ConnectionStrings["BakimDB"].ToString();
                    break;
            }
            cn.Open();
            return cn;
        }
        public static SqlConnection getConnectionSql(DbTypes pDbTypes)
        {
            SqlConnection cn = new SqlConnection();
            switch (pDbTypes)
            {
                case DbTypes.Logo:
                    cn.ConnectionString = ConfigurationManager.ConnectionStrings["LogoDB"].ToString();
                    break;
                case DbTypes.Oracle:
                    cn.ConnectionString = ProjectPanasonic_.Properties.Settings.Default.ProjectPanasonicConnectionString;
                    break;
                default:
                    cn.ConnectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ToString();
                    break;
            }
            try
            {
                cn.Open();
            }
            catch (Exception e)
            {
                string hata = e.ToString();
            }

            return cn;
        }
    }
}
