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
	public class FORMBarrowedBooks_Barrowers : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static string sBookNumber;
		public static FORMBarrowedBooks_Barrowers publicHistory;
		
		OleDbDataAdapter daHistory = new OleDbDataAdapter();
		DataSet dsHistory = new DataSet();

		private System.Windows.Forms.Button bttReload;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		public System.Windows.Forms.ListView lvBooks;
		private System.Windows.Forms.ColumnHeader chBarrowed;
		private System.Windows.Forms.ColumnHeader chReturned;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader chCourse;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.ColumnHeader ChBarrowerID;
		private System.Windows.Forms.ColumnHeader chBarrowerName;

		private System.ComponentModel.Container components = null;

		public FORMBarrowedBooks_Barrowers(){InitializeComponent();}

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
			this.bttReload = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.lvBooks = new System.Windows.Forms.ListView();
			this.ChBarrowerID = new System.Windows.Forms.ColumnHeader();
			this.chBarrowerName = new System.Windows.Forms.ColumnHeader();
			this.chCourse = new System.Windows.Forms.ColumnHeader();
			this.chBarrowed = new System.Windows.Forms.ColumnHeader();
			this.chReturned = new System.Windows.Forms.ColumnHeader();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbLevel = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// bttReload
			// 
			this.bttReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttReload.Location = new System.Drawing.Point(471, 414);
			this.bttReload.Name = "bttReload";
			this.bttReload.Size = new System.Drawing.Size(80, 25);
			this.bttReload.TabIndex = 243;
			this.bttReload.Text = "&Reload";
			this.bttReload.Click += new System.EventHandler(this.bttReload_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(6, 400);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(632, 2);
			this.ctrlSeparator1.TabIndex = 241;
			// 
			// lvBooks
			// 
			this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.ChBarrowerID,
																					  this.chBarrowerName,
																					  this.chCourse,
																					  this.chBarrowed,
																					  this.chReturned});
			this.lvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBooks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBooks.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBooks.FullRowSelect = true;
			this.lvBooks.GridLines = true;
			this.lvBooks.HideSelection = false;
			this.lvBooks.HoverSelection = true;
			this.lvBooks.Location = new System.Drawing.Point(6, 36);
			this.lvBooks.MultiSelect = false;
			this.lvBooks.Name = "lvBooks";
			this.lvBooks.Size = new System.Drawing.Size(630, 332);
			this.lvBooks.TabIndex = 240;
			this.lvBooks.View = System.Windows.Forms.View.Details;
			// 
			// ChBarrowerID
			// 
			this.ChBarrowerID.Text = "Barrower ID";
			this.ChBarrowerID.Width = 150;
			// 
			// chBarrowerName
			// 
			this.chBarrowerName.Text = "Barrower Name";
			this.chBarrowerName.Width = 300;
			// 
			// chCourse
			// 
			this.chCourse.Text = "Course";
			this.chCourse.Width = 150;
			// 
			// chBarrowed
			// 
			this.chBarrowed.Text = "Date Barrowed";
			this.chBarrowed.Width = 300;
			// 
			// chReturned
			// 
			this.chReturned.Text = "Date Returned";
			this.chReturned.Width = 300;
			// 
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(4, 34);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(635, 336);
			this.picFill.TabIndex = 239;
			this.picFill.TabStop = false;
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.Location = new System.Drawing.Point(384, 414);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(80, 25);
			this.bttnSearch.TabIndex = 244;
			this.bttnSearch.Text = "&Search";
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(559, 414);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 242;
			this.bttnCancel.Text = "&Cancel";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-2, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 20);
			this.label1.TabIndex = 238;
			this.label1.Text = "  Barrowers History Viewer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbLevel
			// 
			this.cbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbLevel.Location = new System.Drawing.Point(488, 376);
			this.cbLevel.Name = "cbLevel";
			this.cbLevel.Size = new System.Drawing.Size(152, 21);
			this.cbLevel.TabIndex = 249;
			this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(421, 378);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 17);
			this.label10.TabIndex = 248;
			this.label10.Text = "Select Level:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 378);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 17);
			this.label8.TabIndex = 246;
			this.label8.Text = "School Year:";
			// 
			// cbYear
			// 
			this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbYear.Location = new System.Drawing.Point(80, 376);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(232, 21);
			this.cbYear.TabIndex = 247;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			// 
			// FORMBarrowedBooks_Barrowers
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(644, 446);
			this.Controls.Add(this.cbLevel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.bttReload);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.lvBooks);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBarrowedBooks_Barrowers";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Barrowers History Viewer";
			this.Load += new System.EventHandler(this.FORMBarrowedBooks_Barrowers_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowedBooks_Barrowers_Load(object sender, System.EventArgs e)
		{
			//Set the Icon on Listview.
			lvBooks.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daHistory = new OleDbDataAdapter("",clsConnections.CN);

			//Set the Combo Box
			sFunctions.FillCombo(cbYear,"SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC","tblSchoolYear",1);
			sFunctions.FillCombo(cbLevel,"SELECT * FROM tblLevel ORDER BY LevelName ASC","tblLevel",1);
			
			//Set to Load Books History
			loadBooks("SELECT tblBarrowed.BookNo, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblBarrowed.DateBarrowed, tblBarrowed.DateRetured, [YearStart] & ' - ' & [YearEnd] AS SY, tblLevel.LevelName FROM tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN (tblCourse RIGHT JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblBarrowed.BookNo LIKE '" + sBookNumber + "' ORDER BY tblBarrowers.BarrowerID ASC");

			publicHistory =this;
		}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;
			string sDateBarrowed;
			string sDateDue;

			daHistory.SelectCommand.CommandText = sSQL;

			dsHistory.Clear();
			daHistory.Fill(dsHistory,"tblBarrowed");

			totalRow = dsHistory.Tables["tblBarrowed"].Rows.Count -1;
			
			lvBooks.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBooks.Items.Add(new ListViewItem("" + dsHistory.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(1).ToString(),21));
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(3).ToString());
			
				sDateBarrowed = dsHistory.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(4).ToString();
				sDateBarrowed = Convert.ToDateTime(sDateBarrowed).ToString("MMMM dd, yyyy");
				lvBooks.Items[i].SubItems.Add(sDateBarrowed);

				sDateDue = dsHistory.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(5).ToString();
				sDateDue = Convert.ToDateTime(sDateDue).ToString("MMMM dd, yyyy");
				lvBooks.Items[i].SubItems.Add(sDateDue);
			}
			if (lvBooks.Items.Count > 0)
			{
				try
				{
					lvBooks.Items[0].Focused=true;
					lvBooks.Items[0].Selected = true;
					lvBooks.Items[0].EnsureVisible();
					lvBooks.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			loadBooks("SELECT tblBarrowed.BookNo, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblBarrowed.DateBarrowed, tblBarrowed.DateRetured, [YearStart] & ' - ' & [YearEnd] AS SY, tblLevel.LevelName FROM tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN (tblCourse RIGHT JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblBarrowed.BookNo LIKE '" + sBookNumber + "' AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBarrowers.BarrowerID ASC");
		}

		private void cbYear_SelectedIndexChanged(object sender, System.EventArgs e){bttReload_Click(sender, e);}

		private void cbLevel_SelectedIndexChanged(object sender, System.EventArgs e){bttReload_Click(sender, e);}

		private void bttReload_Click(object sender, System.EventArgs e)
		{
			loadBooks("SELECT tblBarrowed.BookNo, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblBarrowed.DateBarrowed, tblBarrowed.DateRetured, [YearStart] & ' - ' & [YearEnd] AS SY, tblLevel.LevelName FROM tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN (tblCourse RIGHT JOIN (tblBarrowers RIGHT JOIN tblBarrowed ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID) ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblBarrowed.BookNo LIKE '" + sBookNumber + "' ORDER BY tblBarrowers.BarrowerID ASC");
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBrwHstry = "History 1";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

	}
}
