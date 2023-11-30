using System;
using System.Data;
using System.Data.OleDb;

namespace LibrarySystem
{
	public class clsInstitutionSetup
	{
		public static void setINSTITUTION()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblLibrarySetup.InstitutionName, tblLibrarySetup.ContactName, " + 
				"[tblLibrarySetup.StreetAddr] & ', ' & [tblZipCodeList.CityTown] & ',  ' & [tblZipCodeList.Province] & ', ' & [tblZipCodeList.ZipCode] AS Address," + 
				"tblLibrarySetup.PhoneNumber, tblLibrarySetup.FaxNumber, tblLibrarySetup.EmailAddr, tblLibrarySetup.Website FROM tblZipCodeList RIGHT JOIN tblLibrarySetup " + 
				"ON tblZipCodeList.ZipCode = tblLibrarySetup.ZipCode",clsConnections.CN);
			
			DataSet ds = new DataSet();
			da.Fill(ds,"tblLibrarySetup");

			totalRow = ds.Tables["tblLibrarySetup"].Rows.Count -1;

			clsVariables.sINSTITUTION = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(0).ToString();
			clsVariables.sCONTACTNAME = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(1).ToString();
			clsVariables.sADDRESSS    = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(2).ToString();
			clsVariables.sPHONENUMBER = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(3).ToString();
			clsVariables.sFAXNUMBER   = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(4).ToString();
			clsVariables.sEMAILADDRESS= ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(5).ToString();
			clsVariables.sWEBSITE	  = ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(6).ToString();
		}

	}
}
