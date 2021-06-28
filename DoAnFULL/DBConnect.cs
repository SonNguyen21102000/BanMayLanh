using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DoAnFULL
{
    class DBConnect
    {
        private SqlConnection connect;
        private string strConnect, strServerName, strDataBaseName, strUserName, strPassword;
        private DataSet dataSet;
        public string StrServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }

        public string StrDataBaseName
        {
            get { return strDataBaseName; }
            set { strDataBaseName = value; }
        }

        public string StrUserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }

        public string StrPassword
        {
            get { return strPassword; }
            set { strPassword = value; }
        }

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }

        public string StrConnection
        {
            get { return strConnect; }
            set { strConnect = value; }
        }

        public DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

        public DBConnect()
        {
            StrServerName = @"DESKTOP-2ILVFNR\SQLEXPRESS";
            StrDataBaseName = "QLBANHANG";
            StrUserName = "sa"; //@"DESKTOP-4H2CDN2\Admin";
            StrPassword = "sa2012";
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName + ";Integrated Security=True";
            //StrServerName = @"A207A_PC03";
            //StrDataBaseName = "QLSINHVIEN";
            //StrUserName = "sa";
            //StrPassword = "sa2008";
            //StrConnection = @"Data Source=A207A_PC03;Initial Catalog=QLSINHVIEN;User ID=sa;Password=sa2008";
            Connect = new SqlConnection(StrConnection);
            DataSet = new DataSet(StrDataBaseName);
        }

        public DBConnect(string pStrCon, string dataSetName)
        {
            StrServerName = @"DESKTOP-2ILVFNR\SQLEXPRESS";
            StrDataBaseName = dataSetName;
            StrUserName = "sa"; //@"DESKTOP-4H2CDN2\Admin";
            StrPassword = "sa2012";
            StrConnection = "@" + pStrCon;
            Connect = new SqlConnection();
            Connect.ConnectionString = StrConnection;
            DataSet = new DataSet(dataSetName);
        }

        public DBConnect(string strServerName, string strDataBaseName, string strUserName, string strPassword)
        {
            StrServerName = strServerName;
            StrDataBaseName = strDataBaseName;
            StrUserName = strUserName;
            StrPassword = strPassword;
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName + ";Integrated Security=True";
            //StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName;
            //StrConnection += ";User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection();
            Connect.ConnectionString = StrConnection;
            DataSet = new DataSet(strDataBaseName);
        }

        public void openConnection()
        {
            if (Connect.State == ConnectionState.Closed)
                Connect.Open();
        }

        public void closeConnection()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
        }

        public void disposeConnection()
        {
            if (Connect.State == ConnectionState.Open)
                Connect.Close();
            Connect.Dispose();
        }

        public void updateToDataBase(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = strSQL;
            cmd.ExecuteNonQuery();
            closeConnection();
        }

        public int getCount(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = strSQL;
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }

        public bool checkForExistence(string strSQL)
        {
            return getCount(strSQL) > 0 ? true : false;

            //int count = getCount(strSQL);
            //if (count > 0)
            //    return true;
            //return false;
        }

        public SqlDataReader getDataReader(string strSQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect;
            cmd.CommandText = strSQL;
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataAdapter getDataAdapter(string strSQL, string tableName)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, Connect);
            ada.Fill(DataSet, tableName);
            closeConnection();
            return ada;
        }

        public DataTable getDataTable(string strSQL)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, Connect);
            ada.Fill(DataSet);
            closeConnection();
            return DataSet.Tables[0];
        }

        public DataTable getDataTable(string strSQL, string tableName)
        {
            openConnection();
            SqlDataAdapter ada = new SqlDataAdapter(strSQL, Connect);
            ada.Fill(DataSet, tableName);
            closeConnection();
            return DataSet.Tables[tableName];
        }
    }
}
