using System;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class clsStart
	{
		[STAThread]
		static void Main() 
		{
			if(clsApp.havePrevInstance()==false)
			{
				Application.Run(new Do_FIRST());
				Application.Run(new LOGSCREEN());//Load the Login- Screen.
				if(clsApp.APP_CONNECTED==true){Application.Run(new MDI());}	//Load the Main Form.
			}
			else
			{
				MessageBox.Show("The application is already running.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}

	}
}
