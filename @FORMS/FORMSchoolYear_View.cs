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
	public class FORMSchoolYear_View : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sSYSelect;

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMSchoolYear_View publicSYList;
		
		OleDbDataAdapter daSYList = new OleDbDataAdapter();
		DataSet dsSYList = new DataSet();

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader chLevel;
		private System.Windows.Forms.ColumnHeader chIndex;
		private System.Windows.Forms.Button bttnSelect;
		private System.Windows.Forms.Button bttnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;

		private System.ComponentModel.Container components = null;

		public FORMSchoolYear_View(){InitializeComponent();}

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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.chLevel = new System.Windows.Forms.ColumnHeader();
			this.chIndex = new System.Windows.Forms.ColumnHeader();
			this.bttnSelect = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(4, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(224, 248);
			this.pictureBox1.TabIndex = 41;
			this.pictureBox1.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chLevel,
																						this.chIndex});
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.ForeColor = System.Drawing.Color.Navy;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(5, 9);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(223, 249);
			this.listView1.TabIndex = 42;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// chLevel
			// 
			this.chLevel.Text = "School Year";
			this.chLevel.Width = 200;
			// 
			// chIndex
			// 
			this.chIndex.Text = "";
			this.chIndex.Width = 0;
			// 
			// bttnSelect
			// 
			this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSelect.Location = new System.Drawing.Point(26, 274);
			this.bttnSelect.Name = "bttnSelect";
			this.bttnSelect.Size = new System.Drawing.Size(100, 25);
			this.bttnSelect.TabIndex = 220;
			this.bttnSelect.Text = "&Select";
			this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(130, 274);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(100, 25);
			this.bttnCancel.TabIndex = 219;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(5, 267);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(224, 2);
			this.ctrlSeparator1.TabIndex = 221;
			// 
			// FORMSchoolYear_View
			// 
			this.AcceptButton = this.bttnSelect;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(234, 304);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.bttnSelect);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMSchoolYear_View";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select School Year";
			this.Load += new System.EventHandler(this.FORMSchoolYear_View_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMSchoolYear_View_Load(object sender, System.EventArgs e)
		{
			//Set Images
			listView1.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daSYList= new OleDbDataAdapter("",clsConnections.CN);

			loadSchoolYear();
			publicSYList=this;
		}

		public void loadSchoolYear()
		{
			long totalRow =0;
			daSYList.SelectCommand.CommandText = "SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC";

			dsSYList.Clear();
			daSYList.Fill(dsSYList,"tblSchoolYear");

			totalRow = dsSYList.Tables["tblSchoolYear"].Rows.Count -1;
			
			listView1.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				listView1.Items.Add(new ListViewItem("" + dsSYList.Tables["tblSchoolYear"].Rows[i].ItemArray.GetValue(1).ToString(),18));
				listView1.Items[i].SubItems.Add("" + dsSYList.Tables["tblSchoolYear"].Rows[i].ItemArray.GetValue(0).ToString());
			}
			if (listView1.Items.Count > 0)
			{
				try
				{
					listView1.Items[0].Focused=true;
					listView1.Items[0].Selected = true;
					listView1.Items[0].EnsureVisible();
					listView1.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		private void bttnSelect_Click(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count > 0)
			{
				try
				{
					if(sSYSelect == "Barrowers")
					{
						FORMBarrowers_Modify.publicBarrowerList.setSchoolYear(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text);
					}
					else if(sSYSelect == "Report List")
					{
						FORMViewer.sDeploy = "Barrowers";
						FORMViewer.sSchoolYear = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sSQL = "SELECT [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, " + 
							"tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress " +
							"FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) " + 
							"ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode " +
							"WHERE tblSchoolYear.IndexSY = " + listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text + " " +
							"ORDER BY [YearStart] & ' - ' & [YearEnd] ASC, tblCourse.CourseName ASC, tblLevel.LevelName ASC, tblBarrowers.BarrowerID ASC";
						FORMViewer.sTable = "tblBarrowers";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}
					else if(sSYSelect == "Report Fines")
					{
						FORMViewer.sDeploy = "Barrowers Fines";
						FORMViewer.sSchoolYear = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sSQL = "SELECT [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName, tblBarrowed.Returned, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, Sum(tblBarrowed.Fines) AS TotalFines " +
							"FROM tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN (tblCourse RIGHT JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear " +
							"GROUP BY [YearStart] & ' - ' & [YearEnd], tblCourse.CourseName, tblLevel.LevelName, tblBarrowed.Returned, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] " +
							"HAVING ((([YearStart] & ' - ' & [YearEnd])='" + listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text + "') AND ((tblBarrowed.Returned)=Yes) AND ((Sum(tblBarrowed.Fines))<>0)) " +
							"ORDER BY [YearStart] & ' - ' & [YearEnd] ASC, tblCourse.CourseName ASC, tblLevel.LevelName ASC, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] ASC";
						FORMViewer.sTable = "tblBarrowers";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}
					else if(sSYSelect == "Report Barrowed Books")
					{
						FORMViewer.sDeploy = "Barrowed Books";
						FORMViewer.sSchoolYear = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sSQL = "SELECT [YearStart] & ' - ' & [YearEnd] AS SY, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.Returned " +
							"FROM tblSchoolYear RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear " +
							"WHERE ((([YearStart] & ' - ' & [YearEnd])='" + listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text + "') AND ((tblBarrowed.Returned)=No)) " +
							"ORDER BY [YearStart] & ' - ' & [YearEnd] ASC, tblBooks.BookNo ASC";
						FORMViewer.sTable = "tblBarrowed";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}
					else if(sSYSelect == "Report Due Books")//Report Returned Books
					{
						FORMViewer.sDeploy = "Due Books";
						FORMViewer.sSchoolYear = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sSQL = "SELECT [YearStart] & ' - ' & [YearEnd] AS SY, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblBarrowed.DelayedDays, tblBarrowed.Returned " +
						"FROM tblSchoolYear RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear " +
						"WHERE ((([YearStart] & ' - ' & [YearEnd])='" + listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text + "') AND ((tblBarrowed.DateDue)<=Now()) AND ((tblBarrowed.Returned)=No)) " +
						"ORDER BY tblBooks.BookNo ASC";
						FORMViewer.sTable = "tblBarrowed";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}
					else if(sSYSelect == "Report Returned Books")
					{
						FORMViewer.sDeploy = "Returned Books";
						FORMViewer.sSchoolYear = listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sSQL = "SELECT [YearStart] & ' - ' & [YearEnd] AS SY, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblBarrowed.DelayedDays, tblBarrowed.Returned " +
						"FROM tblSchoolYear RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear " +
						"WHERE ((([YearStart] & ' - ' & [YearEnd])='" + listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text + "') AND ((tblBarrowed.Returned)=Yes)) " +
						"ORDER BY tblBooks.BookNo ASC";
						FORMViewer.sTable = "tblBarrowed";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}
					this.Close();
				}
				catch(Exception ex){}
			}
			else{MessageBox.Show("No records to preview. Pls try again",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e){bttnSelect_Click(sender, e);}
	}
}
