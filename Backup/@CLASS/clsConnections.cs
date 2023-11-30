using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class clsConnections
	{
		//database connection
		public static OleDbConnection CN	= new OleDbConnection();

		public void setConnection(string sLocation, string sDBName, string sPassword)
		{
			string sProvider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sLocation + sDBName + ";Persist Security Info=False;Jet OLEDB:Database Password=" + sPassword; 
			CN.ConnectionString=sProvider;
			CN.Open();
		}
	}
}
