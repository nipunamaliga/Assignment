using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace StudentRegistration
{
    public class DBHandler:IDisposable
    {

        private SqlConnection dbCon = new SqlConnection();
        private string dataBaseName = String.Empty;
        private int connectionTimeOut = 50;
        private string dataSource = String.Empty;
        public string connStr = String.Empty;


        public DBHandler()
        {
            connStr = "User ID=" + ConfigurationManager.AppSettings.Get("UserName") + ";Password=" +
                ConfigurationManager.AppSettings.Get("Password").ToString() + ";Initial Catalog=" + ConfigurationManager.AppSettings.Get("DBName") +
                ";Data Source=" + ConfigurationManager.AppSettings.Get("dataSource") + ";Persist Security Info= true;";

            OpenConn();
        }

        public void OpenConn()
        {
            try
            {
                if (dbCon.State == ConnectionState.Closed)
                {
                    dbCon.ConnectionString = connStr;
                    dbCon.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            if (dbCon.State != ConnectionState.Closed)
            {
                dbCon.Close();
                dbCon.Dispose();
            } 
        }

        public SqlConnection DBConn
        {
            get { return dbCon; }
        }

        private SqlCommand newCommand(string SQLstring, CommandType cmdType)
        {
            SqlCommand cmd = new SqlCommand(SQLstring, dbCon);
            cmd.CommandTimeout = connectionTimeOut;
            cmd.CommandType = cmdType;
            return cmd;
        }

        public void CallSp(string spName, SqlParameter[] paraList)
        {
            try
            {
                SqlCommand cmd = newCommand(spName, CommandType.StoredProcedure);
                foreach (SqlParameter sqlpara in paraList)
                {
                    cmd.Parameters.AddWithValue(sqlpara.ParameterName, sqlpara.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long GetNextNo(string field,string table)
        {
            string strSelect;
            long lastNo;
            SqlDataReader dataReader;

            try
            {
                strSelect = "SELECT MAX(" + field + ") FROM " + table;
                SqlCommand sqlcmd = newCommand(strSelect, CommandType.Text);
                dataReader = sqlcmd.ExecuteReader();

                dataReader.Read();
                lastNo = dataReader.GetValue(0) == DBNull.Value ? 1 : dataReader.GetInt64(0);
                dataReader.Close();
                return ++lastNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
