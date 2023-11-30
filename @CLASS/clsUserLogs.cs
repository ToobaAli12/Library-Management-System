using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace LibrarySystem
{
	public class clsUserLogs: LibrarySystem.clsConnections
	{
		public static void record_login(string sLogin, string sLibrarian_ID)
		{
			try
			{
				//OLEDB COMMAND VARIABLES
				OleDbCommand cmdLogin;

				cmdLogin = new OleDbCommand("INSERT INTO tblUsersLog(LibrarianID,Login) VALUES(@getLibrarianID,@getLogin)",CN);
				cmdLogin.Parameters.Add("@getLibrarianID",OleDbType.VarChar);
				cmdLogin.Parameters.Add("@getLogin",OleDbType.Date);
				cmdLogin.Parameters["@getLibrarianID"].Value = sLibrarian_ID;
				cmdLogin.Parameters["@getLogin"].Value = sLogin;

				cmdLogin.ExecuteNonQuery();

			}
			catch(Exception ex){}
		}

		public static void record_logout(string sLogout, string sLibrarian_ID)
		{
		
			try
			{
				//OLEDB COMMAND VARIABLES
				OleDbCommand cmdLogout;

				cmdLogout = new OleDbCommand("UPDATE tblUsersLog SET Logout =@getLogout WHERE LibrarianID LIKE '" + sLibrarian_ID + "' AND Logout Is Null" ,clsConnections.CN);
				cmdLogout.Parameters.Add("@getLogout",OleDbType.Date);
				cmdLogout.Parameters["@getLogout"].Value = sLogout;

				cmdLogout.ExecuteNonQuery();
			}
			catch(Exception ex){}
	
		}
	}
}
