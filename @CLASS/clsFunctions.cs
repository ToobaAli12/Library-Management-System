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
	public class clsFunctions: LibrarySystem.clsConnections
	{	

		public void setOleDbCommand(OleDbCommand cmd, string sCommand, string sParameters, string sMatch)
		{
			//Set the delete command
			cmd = new OleDbCommand(sCommand,CN);
			cmd.Parameters.Add(sParameters,OleDbType.Char);

			cmd.Parameters[sParameters].Value = sMatch;
						
			cmd.ExecuteNonQuery();
		}

		//Filter if Recort is Exist in the Table.
		public static bool recordExist(string sSQL,string sTable)
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter(sSQL,CN);
			DataSet ds = new DataSet();
			da.Fill(ds,sTable);

			totalRow = Convert.ToInt32(ds.Tables[sTable].Rows.Count);
			if(totalRow > 0){return true;}
			else{return false;}
		}

		//Message for empty textbox
		public static void isTextEmptyMsg(string sField)
		{
			MessageBox.Show(sField + " is empty.Please check it!","Library Management System".ToUpper(),MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
		}

		//Fill TabControls.
		public void FillTabControls(TabControl tb, string sSQL,string sTable,string sFirstItem)
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter(sSQL,CN);
			DataSet ds = new DataSet();
			da.Fill(ds,sTable);

			totalRow = ds.Tables[sTable].Rows.Count -1;

			tb.TabPages.Clear();
			if(sFirstItem != "") tb.TabPages.Add(new TabPage(sFirstItem));
			for(int i = 0; i <= totalRow; i++)tb.TabPages.Add(new TabPage("" + ds.Tables[sTable].Rows[i].ItemArray.GetValue(0).ToString()));
			if(tb.TabPages.Count > 0 ) tb.SelectedIndex=0;
		}

		//Fill Combo Box.
		public void FillCombo(ComboBox cb, string sSQL, string sTable, int sNum)
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter(sSQL,CN);
			DataSet ds = new DataSet();
			da.Fill(ds,sTable);

			totalRow = ds.Tables[sTable].Rows.Count -1;

			cb.Items.Clear();
			for(int i = 0; i <= totalRow; i++)cb.Items.Add("" + ds.Tables[sTable].Rows[i].ItemArray.GetValue(sNum).ToString());
			if(cb.Items.Count > 1 ) cb.SelectedIndex=0;
		}

		public void CreateDirectory(string sFolder)
		{
			if(Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + sFolder) == false)
			{
		
				Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + sFolder);
			}
		}

		public DataSet GetReport(DataSet ds, string sSQL, string sTable)
		{
			DataSet rtnDs = ds;
			FillDataSet(rtnDs, sSQL, sTable);
			return rtnDs;
		}

		protected DataSet FillDataSet(DataSet dset, string sSQL, string tbl)
		{
			OleDbCommand cmd = new OleDbCommand (sSQL,clsConnections.CN);
			OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);

			try{adapter.Fill(dset,tbl);}
			catch(Exception ex){}

			return dset;

		}
	}
}
