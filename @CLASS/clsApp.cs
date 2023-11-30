using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace LibrarySystem
{
	public class clsApp
	{
		public static bool APP_CONNECTED=false;

		public static bool havePrevInstance()
		{
			try
			{
				if(System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1 )
				{
					return true;
				}
				else{return false;}
			}
			catch(Exception ex){return false;}
		}

		public static void shell(string strShell, string sText)
		{
			try{System.Diagnostics.Process.Start(strShell);}
			catch(Exception ex)
			{
				MessageBox.Show("No " + sText + " installed in the system.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
