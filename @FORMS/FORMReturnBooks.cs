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
	public class FORMReturnBooks : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMReturnBooks publicReturnedList;
		
		OleDbDataAdapter daReturnedList = new OleDbDataAdapter();
		DataSet dsReturnedList = new DataSet();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.ColumnHeader chBookNOs;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		private System.Windows.Forms.ColumnHeader chDateBarrowed;
		private System.Windows.Forms.ColumnHeader chDateDue;
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.TabControl tabCategory;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnPrint;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ListView lvReturned;
		private System.Windows.Forms.ColumnHeader chDateReturned;
		private System.Windows.Forms.ColumnHeader chBarrowerID;
		private System.Windows.Forms.ColumnHeader chBarrowerName;

		private static FORMReturnBooks sForm = null;
		public static FORMReturnBooks  Instance()
		{
			if(sForm==null)
			{
				sForm = new FORMReturnBooks();
			}
			return sForm;
		}

		public FORMReturnBooks(){InitializeComponent();}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null){components.Dispose();}
			}
			base.Dispose( disposing );
			sForm = null;
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMReturnBooks));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.lvReturned = new System.Windows.Forms.ListView();
			this.chBookNOs = new System.Windows.Forms.ColumnHeader();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.chBarrowerID = new System.Windows.Forms.ColumnHeader();
			this.chBarrowerName = new System.Windows.Forms.ColumnHeader();
			this.chDateBarrowed = new System.Windows.Forms.ColumnHeader();
			this.chDateDue = new System.Windows.Forms.ColumnHeader();
			this.chDateReturned = new System.Windows.Forms.ColumnHeader();
			this.lblContains = new System.Windows.Forms.Label();
			this.tabCategory = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnPrint = new System.Windows.Forms.Button();
			this.cbLevel = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 16;
			this.picLOGO.TabStop = false;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.BackColor = System.Drawing.Color.Transparent;
			this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblHeader.ForeColor = System.Drawing.Color.White;
			this.lblHeader.Location = new System.Drawing.Point(40, 4);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(133, 22);
			this.lblHeader.TabIndex = 15;
			this.lblHeader.Text = "Returned Books";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 14;
			this.picHeader.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(9, 470);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 19);
			this.label7.TabIndex = 114;
			this.label7.Text = "Returned Books:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(545, 503);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 48);
			this.label3.TabIndex = 109;
			this.label3.Text = "&Search";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.ForeColor = System.Drawing.Color.Black;
			this.bttnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnSearch.Location = new System.Drawing.Point(542, 461);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 108;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(596, 503);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 105;
			this.label2.Text = "&Reload";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnReload
			// 
			this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReload.ForeColor = System.Drawing.Color.Black;
			this.bttnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnReload.Location = new System.Drawing.Point(591, 461);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 104;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(641, 503);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 72);
			this.label8.TabIndex = 103;
			this.label8.Text = "&Cancel";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(638, 461);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 102;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// lvReturned
			// 
			this.lvReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvReturned.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.chBookNOs,
																						 this.chBookTitle,
																						 this.chBarrowerID,
																						 this.chBarrowerName,
																						 this.chDateBarrowed,
																						 this.chDateDue,
																						 this.chDateReturned});
			this.lvReturned.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvReturned.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvReturned.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvReturned.FullRowSelect = true;
			this.lvReturned.GridLines = true;
			this.lvReturned.HideSelection = false;
			this.lvReturned.Location = new System.Drawing.Point(12, 96);
			this.lvReturned.MultiSelect = false;
			this.lvReturned.Name = "lvReturned";
			this.lvReturned.Size = new System.Drawing.Size(659, 352);
			this.lvReturned.TabIndex = 101;
			this.lvReturned.View = System.Windows.Forms.View.Details;
			// 
			// chBookNOs
			// 
			this.chBookNOs.Text = "Book Number";
			this.chBookNOs.Width = 200;
			// 
			// chBookTitle
			// 
			this.chBookTitle.Text = "BookTitle";
			this.chBookTitle.Width = 500;
			// 
			// chBarrowerID
			// 
			this.chBarrowerID.Text = "Barrower ID";
			this.chBarrowerID.Width = 150;
			// 
			// chBarrowerName
			// 
			this.chBarrowerName.Text = "Barrower Name";
			this.chBarrowerName.Width = 200;
			// 
			// chDateBarrowed
			// 
			this.chDateBarrowed.Text = "Date Barrowed";
			this.chDateBarrowed.Width = 150;
			// 
			// chDateDue
			// 
			this.chDateDue.Text = "Date Due";
			this.chDateDue.Width = 150;
			// 
			// chDateReturned
			// 
			this.chDateReturned.Text = "Date Returned";
			this.chDateReturned.Width = 150;
			// 
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(9, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(321, 17);
			this.lblContains.TabIndex = 100;
			this.lblContains.Text = "This contains all information about the returned books. ";
			// 
			// tabCategory
			// 
			this.tabCategory.Controls.Add(this.tabPage1);
			this.tabCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabCategory.ItemSize = new System.Drawing.Size(121, 21);
			this.tabCategory.Location = new System.Drawing.Point(3, 34);
			this.tabCategory.Name = "tabCategory";
			this.tabCategory.SelectedIndex = 0;
			this.tabCategory.Size = new System.Drawing.Size(676, 421);
			this.tabCategory.TabIndex = 99;
			this.tabCategory.SelectedIndexChanged += new System.EventHandler(this.tabCategory_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(668, 392);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "All Category";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(498, 503);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 48);
			this.label1.TabIndex = 116;
			this.label1.Text = "&Print";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnPrint
			// 
			this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPrint.ForeColor = System.Drawing.Color.Black;
			this.bttnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnPrint.Location = new System.Drawing.Point(495, 461);
			this.bttnPrint.Name = "bttnPrint";
			this.bttnPrint.Size = new System.Drawing.Size(40, 40);
			this.bttnPrint.TabIndex = 115;
			this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
			// 
			// cbLevel
			// 
			this.cbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbLevel.Location = new System.Drawing.Point(478, 64);
			this.cbLevel.Name = "cbLevel";
			this.cbLevel.Size = new System.Drawing.Size(192, 23);
			this.cbLevel.TabIndex = 120;
			this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(403, 69);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 17);
			this.label10.TabIndex = 119;
			this.label10.Text = "Select Level:";
			// 
			// cbYear
			// 
			this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbYear.Location = new System.Drawing.Point(91, 63);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(219, 23);
			this.cbYear.TabIndex = 118;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 17);
			this.label5.TabIndex = 117;
			this.label5.Text = "School Year:";
			// 
			// FORMReturnBooks
			// 
			this.AcceptButton = this.bttnPrint;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.cbLevel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bttnPrint);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.lvReturned);
			this.Controls.Add(this.tabCategory);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMReturnBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Returned Books";
			this.Load += new System.EventHandler(this.FORMReturnBooks_Load);
			this.tabCategory.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMReturnBooks_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daReturnedList= new OleDbDataAdapter("",clsConnections.CN);

			//Set the Combo Box
			sFunctions.FillCombo(cbYear,"SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC","tblSchoolYear",1);
			sFunctions.FillCombo(cbLevel,"SELECT * FROM tblLevel ORDER BY LevelName ASC","tblLevel",1);

			//Set the Tab Control
			setTabControl();
		
			//Load List of Barrowed Books
			loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=Yes ORDER BY tblBooks.BookNo ASC");
		
			publicReturnedList = this;
		}

		protected void setImages()
		{
			lvReturned.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnPrint.Image	 = MDIFORM.i32x32.Images[11];
			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void loadBarrowed(string sSQL)
		{
			long totalRow =0;
			string sDateBarrowed;
			string sDateDue;
			string sDateReturned;

			daReturnedList.SelectCommand.CommandText = sSQL;

			dsReturnedList.Clear();
			daReturnedList.Fill(dsReturnedList,"tblBarrowed");

			totalRow = dsReturnedList.Tables["tblBarrowed"].Rows.Count -1;
			
			lvReturned.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvReturned.Items.Add(new ListViewItem("" + dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(0).ToString(),20));
				lvReturned.Items[i].SubItems.Add("" + dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(1).ToString());
				lvReturned.Items[i].SubItems.Add("" + dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(2).ToString());
				lvReturned.Items[i].SubItems.Add("" + dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(3).ToString());

				sDateBarrowed = dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(4).ToString();
				sDateBarrowed = Convert.ToDateTime(sDateBarrowed).ToString("MMMM dd, yyyy");
				lvReturned.Items[i].SubItems.Add(sDateBarrowed);	
				
				sDateDue = dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(5).ToString();
				sDateDue = Convert.ToDateTime(sDateDue).ToString("MMMM dd, yyyy");
				lvReturned.Items[i].SubItems.Add(sDateDue);

				sDateReturned = dsReturnedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(6).ToString();
				sDateReturned = Convert.ToDateTime(sDateReturned).ToString("MMMM dd, yyyy");
				lvReturned.Items[i].SubItems.Add(sDateReturned);

			}
			if (lvReturned.Items.Count > 0)
			{
				try
				{
					lvReturned.Items[0].Focused=true;
					lvReturned.Items[0].Selected = true;
					lvReturned.Items[0].EnsureVisible();
					lvReturned.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			if(tabCategory.SelectedTab.Text.Equals("All Category"))
			{
				loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=Yes AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
			}
			else
			{
				loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND CategoryName LIKE '" + tabCategory.SelectedTab.Text + "' AND (tblBarrowed.Returned)=Yes AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
			}	
		}

		public void setTabControl()
		{
			sFunctions.FillTabControls(tabCategory,"SELECT CategoryName FROM tblCategory ORDER BY CategoryName ASC","tblCategory","All Category");
		}

		private void tabCategory_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(tabCategory.TabPages.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=Yes ORDER BY tblBooks.BookNo ASC");
				}
				else
				{
					loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblBarrowed.DateRetured, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND CategoryName LIKE '" + tabCategory.SelectedTab.Text + "' AND (tblBarrowed.Returned)=Yes ORDER BY tblBooks.BookNo ASC");
				}			
			}
		}

		private void cbYear_SelectedIndexChanged(object sender, System.EventArgs e){tabCategory_SelectedIndexChanged(sender,e);}

		private void cbLevel_SelectedIndexChanged(object sender, System.EventArgs e){tabCategory_SelectedIndexChanged(sender,e);}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			setTabControl();
			tabCategory_SelectedIndexChanged(sender, e);
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks = "Returned";
			FORMSearch sForm  = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnPrint_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
