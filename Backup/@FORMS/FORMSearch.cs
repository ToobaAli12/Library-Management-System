using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class FORMSearch : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sZipCode;
		public static string sCategory;
		public static string sCourse;
		public static string sLevel;
		public static string sSY;
		public static string sLibriran;
		public static string sBarrower;
		public static string sBooks;
		public static string sBarrowed;
		public static string sBrwHstry;
		public static string sBokHstry;

		//OBJECT VARIABLES
		Object[] objArea	 = new Object[3] { "CityTown",    "Province",  "ZipCode" };
		Object[] objCategory = new Object[2] { "CategoryName","CATDescription" };
		Object[] objCourse   = new Object[2] { "CourseName",  "CourseDescription" };
		Object[] objLevel    = new Object[1] { "LevelName" };
		Object[] objSY	     = new Object[2] { "YearStart", "YearEnd" };
		Object[] objLibriran = new Object[11]{ "LibrarianID", "FirstName", "MiddleName", "LastName", "StreetAddress", "tblZipCodeList.CityTown", "tblZipCodeList.Province", "tblZipCodeList.ZipCode", "ContactNo", "EmailAddress", "UserName"};
		Object[] objBarrower = new Object[10]{ "BarrowerID",  "FirstName", "MiddleName", "LastName", "StreetAddress", "CityTown", "Province", "ZipCode", "ContactNO", "EmailAddress"};
		Object[] objBooks	 = new Object[7] { "BookNo",	  "ISBN",	   "Author",	 "BookTitle","YearPublished", "Price",	  "Qty"};
		Object[] objBarrowed = new Object[2] { "BookNo",	  "BarrowerID"};
		Object[] objBrwHstry = new Object[5] { "tblBarrowers.BarrowerID",  "tblBarrowers.FirstName",  "tblBarrowers.MiddleName",  "tblBarrowers.LastName", "tblCourse.CourseName"};
		Object[] objBokHstry = new Object[3] { "tblBarrowed.BookNo","BookTitle", "CategoryName"};
		Object[] objBokBarwd = new Object[4] { "tblBooks.BookNo","tblBooks.ISBN","tblBooks.BookTitle","tblCategory.CategoryName"};
		Object[] objBrwdList = new Object[6] { "tblBarrowers.BarrowerID", "tblBarrowers.FirstName", "tblBarrowers.MiddleName", "tblBarrowers.LastName", "tblCourse.CourseName", "tblLevel.LevelName"};
		Object[] objBokRcord = new Object[8] { "tblBooks.BookNo", "tblBooks.BookTitle", "tblBarrowers.BarrowerID", "tblBarrowers.FirstName", "tblBarrowers.MiddleName", "tblBarrowers.LastName", "tblBarrowers.CourseName", "tblCategory.CategoryName"};

		private System.Windows.Forms.TextBox txtSearchText;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private LibrarySystem.ctrlSeparator ctrlSeparator3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbLookIn;
		private System.ComponentModel.Container components = null;

		public FORMSearch(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMSearch));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.txtSearchText = new System.Windows.Forms.TextBox();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.cbLookIn = new System.Windows.Forms.ComboBox();
			this.ctrlSeparator3 = new LibrarySystem.ctrlSeparator();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 27;
			this.picLOGO.TabStop = false;
			// 
			// txtSearchText
			// 
			this.txtSearchText.Location = new System.Drawing.Point(8, 88);
			this.txtSearchText.Name = "txtSearchText";
			this.txtSearchText.Size = new System.Drawing.Size(328, 21);
			this.txtSearchText.TabIndex = 25;
			this.txtSearchText.Text = "Enter some text here!";
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Location = new System.Drawing.Point(264, 192);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(72, 24);
			this.bttnCancel.TabIndex = 24;
			this.bttnCancel.Text = "Close";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSearch.Location = new System.Drawing.Point(184, 192);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(72, 24);
			this.btnSearch.TabIndex = 23;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 48);
			this.label1.TabIndex = 28;
			this.label1.Text = "Enter a text which you want to search and select a field where to locate it. Clic" +
				"k \'Cancel\' if you want to cancel searching of records";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 29;
			this.label2.Text = "Search for:";
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 56);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(328, 2);
			this.ctrlSeparator1.TabIndex = 30;
			// 
			// cbLookIn
			// 
			this.cbLookIn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbLookIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLookIn.Location = new System.Drawing.Point(8, 139);
			this.cbLookIn.Name = "cbLookIn";
			this.cbLookIn.Size = new System.Drawing.Size(328, 21);
			this.cbLookIn.TabIndex = 31;
			// 
			// ctrlSeparator3
			// 
			this.ctrlSeparator3.Location = new System.Drawing.Point(8, 184);
			this.ctrlSeparator3.Name = "ctrlSeparator3";
			this.ctrlSeparator3.Size = new System.Drawing.Size(328, 2);
			this.ctrlSeparator3.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 32;
			this.label3.Text = "Look in:";
			// 
			// FORMSearch
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(346, 224);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ctrlSeparator3);
			this.Controls.Add(this.cbLookIn);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.txtSearchText);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.btnSearch);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMSearch";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.FORMSearch_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMSearch_Load(object sender, System.EventArgs e)
		{
			if	   (sZipCode	== "Areas")		{cbLookIn.Items.AddRange(objArea);}
			else if(sCategory	== "Categories"){cbLookIn.Items.AddRange(objCategory);}
			else if(sCourse		== "Courses")	{cbLookIn.Items.AddRange(objCourse);}
			else if(sLevel		== "Levels")	{cbLookIn.Items.AddRange(objLevel);}
			else if(sSY			== "SchoolYear"){cbLookIn.Items.AddRange(objSY);}
			else if(sLibriran	== "Librarian")	{cbLookIn.Items.AddRange(objLibriran);}
			else if(sBarrower	== "Barrowers")	{cbLookIn.Items.AddRange(objBarrower);}
			else if(sBooks		== "Books")		{cbLookIn.Items.AddRange(objBooks);}
			else if(sBooks		== "Adjust")	{cbLookIn.Items.AddRange(objBooks);}
			else if(sBooks		== "Barrowed Books"){cbLookIn.Items.AddRange(objBokBarwd);}
			else if(sBooks		== "Barrowers List"){cbLookIn.Items.AddRange(objBrwdList);}
			else if(sBarrowed	== "Barrowed")	{cbLookIn.Items.AddRange(objBarrowed);}
			else if(sBrwHstry	== "History 1")	{cbLookIn.Items.AddRange(objBrwHstry);}
			else if(sBokHstry	== "History 2")	{cbLookIn.Items.AddRange(objBokHstry);}
			else if(sBooks		== "Returned")	{cbLookIn.Items.AddRange(objBokRcord);}
			else if(sBooks		== "Records")	{cbLookIn.Items.AddRange(objBokRcord);}
			else if(sBooks		== "Due Books")	{cbLookIn.Items.AddRange(objBokRcord);}

			picLOGO.Image = MDIFORM.i32x32.Images[15];
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			if(txtSearchText.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Search Tex");
				txtSearchText.Focus();
			}
			else if(cbLookIn.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Look In");
			}
			else
			{
				if(sLibriran		== "Librarian")
				{
					FORMLibrarian.publcLibrarianList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBarrower	== "Barrowers")
				{
					FORMBarrowers.publicBarrowersList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBooks		== "Books")
				{
					FORMBooks.publicBooksList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}						
				else if(sBooks		== "Barrowed Books")
				{
					FORMBooks_View.publicBooksList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}					
				else if(sBooks		== "Barrowers List")
				{
					FORMBarrowers_View.publicBarrwrList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}				
				else if(sBrwHstry	== "History 1")
				{
					FORMBarrowedBooks_Barrowers.publicHistory.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBokHstry	== "History 2")
				{
					FORMBarrowedBooks_History.publicHistory.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBooks		== "Records")
				{
					FORMBarrowedBooks.publicBarrowedList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}				
				else if(sBooks		== "Due Books")
				{
					FORMDueBooks.publicDueBooksList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBooks		== "Returned")
				{
					FORMReturnBooks.publicReturnedList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sBooks		== "Adjust")
				{
					FORMAdjustments.publicAdjustList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}				
				else if(sZipCode	== "Areas")
				{
					FORMZipCodes.publicZipList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sCategory	== "Categories")
				{
					FORMCategory.publicCatList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sCourse		== "Courses")
				{
					FORMCourses.publicCourseList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sLevel		== "Levels")
				{
					FORMLevel.publicLevList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
				else if(sSY			== "SchoolYear")
				{
					FORMSchoolYear.publicSYList.LoadSearch(cbLookIn.Text, txtSearchText.Text);
				}
			}
		}
	}
}
