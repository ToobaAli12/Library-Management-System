using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace LibrarySystem
{
	public class FORMViewer : System.Windows.Forms.Form
	{
		//STRING VARIABLES
		public static string sDeploy;
		public static string sSchoolYear;
		public static string sCategory;
		public static string sBookNO;
		public static string sBookTitle;
		public static string sISBN;
		public static string sSQL;
		public static string sTable;

		//PARAMETER VARIABLES
		CrystalDecisions.Shared.ParameterValues pvCollection= new CrystalDecisions.Shared.ParameterValues();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvInstName= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvInstAddress= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvInstContacts= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvSchoolYear= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvCategory= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvPrepared= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvBookNumber= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvBookTitle= new CrystalDecisions.Shared.ParameterDiscreteValue();
		CrystalDecisions.Shared.ParameterDiscreteValue pdvISBN= new CrystalDecisions.Shared.ParameterDiscreteValue();

		clsFunctions execRpt = new clsFunctions();

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crviewer;

		private System.ComponentModel.Container components = null;

		public FORMViewer(){InitializeComponent();}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null){components.Dispose();}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMViewer));
			this.crviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crviewer
			// 
			this.crviewer.ActiveViewIndex = -1;
			this.crviewer.DisplayGroupTree = false;
			this.crviewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crviewer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.crviewer.Location = new System.Drawing.Point(0, 0);
			this.crviewer.Name = "crviewer";
			this.crviewer.ReportSource = null;
			this.crviewer.ShowCloseButton = false;
			this.crviewer.ShowGroupTreeButton = false;
			this.crviewer.Size = new System.Drawing.Size(632, 478);
			this.crviewer.TabIndex = 0;
			// 
			// FORMViewer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(632, 478);
			this.Controls.Add(this.crviewer);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FORMViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Viewer";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FORMViewer_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMViewer_Load(object sender, System.EventArgs e)
		{
			if(sDeploy == "Librarians"){setLibrarians();}
			else if(sDeploy == "Barrowers"){setBarrowers();}
			else if(sDeploy == "Barrowers Fines"){setBarrowers_Fines();}
			else if(sDeploy == "Books List"){setBooks();}
			else if(sDeploy == "Books All"){setBooksAll();}
			else if(sDeploy == "Barrowed Books"){setBarrowed();}
			else if(sDeploy == "Due Books"){setDueBooks();}
			else if(sDeploy == "Returned Books"){setReturned();}
			else if(sDeploy == "Inventory"){setInventory();}
			else if(sDeploy == "Adjustments"){setAdjustments();}
		}

		protected void setLibrarians()
		{
			dsLibrarians dsReport = new dsLibrarians();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptLibrarians rptViewer = new rptLibrarians();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setBarrowers()
		{
			dsBarrowers dsReport = new dsBarrowers();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptBarrowers rptViewer = new rptBarrowers();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvSchoolYear.Value = "School Year: " + sSchoolYear;
			pvCollection.Add(pdvSchoolYear);
			rptViewer.DataDefinition.ParameterFields["SchoolYear"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setBarrowers_Fines()
		{
			dsBarrowers_Fines dsReport = new dsBarrowers_Fines();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptBarrowers_Fines rptViewer = new rptBarrowers_Fines();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvSchoolYear.Value = "School Year: " + sSchoolYear;
			pvCollection.Add(pdvSchoolYear);
			rptViewer.DataDefinition.ParameterFields["SchoolYear"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setBooks()
		{
			dsBooks dsReport = new dsBooks();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptBooks rptViewer = new rptBooks();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvCategory.Value = "Category: " + sCategory;
			pvCollection.Add(pdvCategory);
			rptViewer.DataDefinition.ParameterFields["CategoryName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setBooksAll()
		{
			dsBooks dsReport = new dsBooks();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptBooks_All rptViewer = new rptBooks_All();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvCategory.Value = "All Categories";
			pvCollection.Add(pdvCategory);
			rptViewer.DataDefinition.ParameterFields["CategoryName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setBarrowed()
		{
			dsBarrowed dsReport = new dsBarrowed();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptBarrowedBooks rptViewer = new rptBarrowedBooks();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvSchoolYear.Value = "School Year: " + sSchoolYear;
			pvCollection.Add(pdvSchoolYear);
			rptViewer.DataDefinition.ParameterFields["SchoolYear"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setDueBooks()
		{
			dsDueBooks dsReport = new dsDueBooks();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptDueBooks rptViewer = new rptDueBooks();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvSchoolYear.Value = "School Year: " + sSchoolYear;
			pvCollection.Add(pdvSchoolYear);
			rptViewer.DataDefinition.ParameterFields["SchoolYear"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setReturned()
		{
			dsReturned dsReport = new dsReturned();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptReturnedBooks rptViewer = new rptReturnedBooks();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvSchoolYear.Value = "School Year: " + sSchoolYear;
			pvCollection.Add(pdvSchoolYear);
			rptViewer.DataDefinition.ParameterFields["SchoolYear"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setInventory()
		{
			dsInventory dsReport = new dsInventory();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptInventory rptViewer = new rptInventory();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}

		protected void setAdjustments()
		{
			dsAdjustment dsReport = new dsAdjustment();

			DataSet ds = execRpt.GetReport(dsReport,sSQL,sTable);
			rptAdjustments rptViewer = new rptAdjustments();

			pdvInstName.Value = clsVariables.sINSTITUTION;
			pvCollection.Add(pdvInstName);
			rptViewer.DataDefinition.ParameterFields["InsitutionName"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();
			
			pdvInstAddress.Value = clsVariables.sADDRESSS;
			pvCollection.Add(pdvInstAddress);
			rptViewer.DataDefinition.ParameterFields["InstitutionAddress"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvInstContacts.Value = "Phone Number: " + clsVariables.sPHONENUMBER + "  and  " + "Fax Number: " + clsVariables.sFAXNUMBER;
			pvCollection.Add(pdvInstContacts);
			rptViewer.DataDefinition.ParameterFields["ContactNumber"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvBookNumber.Value = "Book Number: " + sBookNO;
			pvCollection.Add(pdvBookNumber);
			rptViewer.DataDefinition.ParameterFields["BookNO"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvBookTitle.Value = "Book Title: " + sBookTitle;
			pvCollection.Add(pdvBookTitle);
			rptViewer.DataDefinition.ParameterFields["BookTitle"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvISBN.Value = "ISBN: " + sISBN;
			pvCollection.Add(pdvISBN);
			rptViewer.DataDefinition.ParameterFields["ISBN"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			pdvPrepared.Value = clsVariables.sLibrarianName;
			pvCollection.Add(pdvPrepared);
			rptViewer.DataDefinition.ParameterFields["Prepared"].ApplyCurrentValues(pvCollection);
			pvCollection.Clear();

			rptViewer.SetDataSource(ds);
			crviewer.ReportSource = rptViewer;
		}
	}
}
