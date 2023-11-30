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
	public class FORMBarrowedBooks : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdUpdateBook;
		OleDbCommand cmdDelete;

		public static FORMBarrowedBooks publicBarrowedList;
		
		OleDbDataAdapter daBarrowedList = new OleDbDataAdapter();
		DataSet dsBarrowedList = new DataSet();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bttnAddNew;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.ColumnHeader chBookNOs;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.TabControl tabCategory;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ColumnHeader chDateBarrowed;
		private System.Windows.Forms.ColumnHeader chDateDue;
		private System.Windows.Forms.Button bttnReturned;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.ListView lvBarrowed;
		private System.Windows.Forms.ColumnHeader chBarrowerID;
		private System.Windows.Forms.ColumnHeader chBarrowerName;

		private static FORMBarrowedBooks sForm = null;
		public static FORMBarrowedBooks  Instance()
		{
			if(sForm==null){sForm = new FORMBarrowedBooks();}

			return sForm;
		}

		public FORMBarrowedBooks(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBarrowedBooks));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.bttnReturned = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.lvBarrowed = new System.Windows.Forms.ListView();
			this.chBookNOs = new System.Windows.Forms.ColumnHeader();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.chBarrowerID = new System.Windows.Forms.ColumnHeader();
			this.chBarrowerName = new System.Windows.Forms.ColumnHeader();
			this.chDateBarrowed = new System.Windows.Forms.ColumnHeader();
			this.chDateDue = new System.Windows.Forms.ColumnHeader();
			this.lblContains = new System.Windows.Forms.Label();
			this.tabCategory = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cbLevel = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 10;
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
			this.lblHeader.Size = new System.Drawing.Size(137, 22);
			this.lblHeader.TabIndex = 9;
			this.lblHeader.Text = "Barrowed Books";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 8;
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
			this.label7.Size = new System.Drawing.Size(120, 19);
			this.label7.TabIndex = 98;
			this.label7.Text = "Barrowed Books:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(403, 504);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 32);
			this.label5.TabIndex = 97;
			this.label5.Text = "&New";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnAddNew.ForeColor = System.Drawing.Color.Black;
			this.bttnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnAddNew.Location = new System.Drawing.Point(399, 462);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(40, 40);
			this.bttnAddNew.TabIndex = 96;
			this.bttnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(452, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 95;
			this.label6.Text = "&Return";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnReturned
			// 
			this.bttnReturned.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReturned.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnReturned.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReturned.ForeColor = System.Drawing.Color.Black;
			this.bttnReturned.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnReturned.Location = new System.Drawing.Point(447, 462);
			this.bttnReturned.Name = "bttnReturned";
			this.bttnReturned.Size = new System.Drawing.Size(40, 40);
			this.bttnReturned.TabIndex = 94;
			this.bttnReturned.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReturned.Click += new System.EventHandler(this.bttnReturned_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(499, 504);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 48);
			this.label3.TabIndex = 93;
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
			this.bttnSearch.Location = new System.Drawing.Point(495, 462);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 92;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(547, 504);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 48);
			this.label4.TabIndex = 91;
			this.label4.Text = "&Delete";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnDelete
			// 
			this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnDelete.ForeColor = System.Drawing.Color.Black;
			this.bttnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnDelete.Location = new System.Drawing.Point(543, 462);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(40, 40);
			this.bttnDelete.TabIndex = 90;
			this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(596, 504);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 89;
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
			this.bttnReload.Location = new System.Drawing.Point(591, 462);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 88;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(641, 504);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 87;
			this.label1.Text = "&Cancel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(638, 462);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 86;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// lvBarrowed
			// 
			this.lvBarrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBarrowed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.chBookNOs,
																						 this.chBookTitle,
																						 this.chBarrowerID,
																						 this.chBarrowerName,
																						 this.chDateBarrowed,
																						 this.chDateDue});
			this.lvBarrowed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBarrowed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBarrowed.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBarrowed.FullRowSelect = true;
			this.lvBarrowed.GridLines = true;
			this.lvBarrowed.HideSelection = false;
			this.lvBarrowed.Location = new System.Drawing.Point(12, 96);
			this.lvBarrowed.MultiSelect = false;
			this.lvBarrowed.Name = "lvBarrowed";
			this.lvBarrowed.Size = new System.Drawing.Size(659, 352);
			this.lvBarrowed.TabIndex = 85;
			this.lvBarrowed.View = System.Windows.Forms.View.Details;
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
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(9, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(327, 17);
			this.lblContains.TabIndex = 84;
			this.lblContains.Text = "This contains all information about the barrowed books. ";
			// 
			// tabCategory
			// 
			this.tabCategory.Controls.Add(this.tabPage1);
			this.tabCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabCategory.ItemSize = new System.Drawing.Size(121, 21);
			this.tabCategory.Location = new System.Drawing.Point(3, 35);
			this.tabCategory.Name = "tabCategory";
			this.tabCategory.SelectedIndex = 0;
			this.tabCategory.Size = new System.Drawing.Size(676, 421);
			this.tabCategory.TabIndex = 83;
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
			// cbLevel
			// 
			this.cbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbLevel.Location = new System.Drawing.Point(478, 66);
			this.cbLevel.Name = "cbLevel";
			this.cbLevel.Size = new System.Drawing.Size(192, 23);
			this.cbLevel.TabIndex = 106;
			this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(403, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 17);
			this.label10.TabIndex = 105;
			this.label10.Text = "Select Level:";
			// 
			// cbYear
			// 
			this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbYear.Location = new System.Drawing.Point(91, 65);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(219, 23);
			this.cbYear.TabIndex = 104;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 17);
			this.label8.TabIndex = 103;
			this.label8.Text = "School Year:";
			// 
			// FORMBarrowedBooks
			// 
			this.AcceptButton = this.bttnAddNew;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.cbLevel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bttnReturned);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bttnDelete);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.lvBarrowed);
			this.Controls.Add(this.tabCategory);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMBarrowedBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Barrowed Books";
			this.Load += new System.EventHandler(this.FORMBarrowedBooks_Load);
			this.tabCategory.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowedBooks_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daBarrowedList= new OleDbDataAdapter("",clsConnections.CN);

			//Set the Combo Box
			sFunctions.FillCombo(cbYear,"SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC","tblSchoolYear",1);
			sFunctions.FillCombo(cbLevel,"SELECT * FROM tblLevel ORDER BY LevelName ASC","tblLevel",1);

			//Set the Tab Control
			setTabControl();
		
			//Load List of Barrowed Books
			loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=No ORDER BY tblBooks.BookNo ASC");

			publicBarrowedList = this;
		}

		protected void setImages()
		{
			lvBarrowed.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnAddNew.Image = MDIFORM.i32x32.Images[13];
			bttnReturned.Image = MDIFORM.i32x32.Images[19];
			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnDelete.Image = MDIFORM.i32x32.Images[16];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void loadBarrowed(string sSQL)
		{
			long totalRow =0;
			string sDateBarrowed;
			string sDateDue;

			daBarrowedList.SelectCommand.CommandText = sSQL;

			dsBarrowedList.Clear();
			daBarrowedList.Fill(dsBarrowedList,"tblBarrowed");

			totalRow = dsBarrowedList.Tables["tblBarrowed"].Rows.Count -1;
			
			lvBarrowed.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBarrowed.Items.Add(new ListViewItem("" + dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(0).ToString(),20));
				lvBarrowed.Items[i].SubItems.Add("" + dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(1).ToString());
				lvBarrowed.Items[i].SubItems.Add("" + dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBarrowed.Items[i].SubItems.Add("" + dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(3).ToString());

				sDateBarrowed = dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(4).ToString();
				sDateBarrowed = Convert.ToDateTime(sDateBarrowed).ToString("MMMM dd, yyyy");
				lvBarrowed.Items[i].SubItems.Add(sDateBarrowed);	
				
				sDateDue = dsBarrowedList.Tables["tblBarrowed"].Rows[i].ItemArray.GetValue(5).ToString();
				sDateDue = Convert.ToDateTime(sDateDue).ToString("MMMM dd, yyyy");
				lvBarrowed.Items[i].SubItems.Add(sDateDue);

			}
			if (lvBarrowed.Items.Count > 0)
			{
				try
				{
					lvBarrowed.Items[0].Focused=true;
					lvBarrowed.Items[0].Selected = true;
					lvBarrowed.Items[0].EnsureVisible();
					lvBarrowed.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			if(tabCategory.SelectedTab.Text.Equals("All Category"))
			{
				loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=No AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
			}
			else
			{
				loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND CategoryName LIKE '" + tabCategory.SelectedTab.Text + "' AND (tblBarrowed.Returned)=No AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
			}			
		}

		public void reload_current()
		{
			try
			{
				int lvw_pos;
				
				lvw_pos=lvBarrowed.FocusedItem.Index;

				setLoading();		
			
				if(lvBarrowed.Items.Count != 0 && lvBarrowed.Items.Count-1 >= lvw_pos)
				{
					lvBarrowed.Items[lvBarrowed.FocusedItem.Index].Selected =false;
					lvBarrowed.Items[lvBarrowed.FocusedItem.Index].Focused=false;

					lvBarrowed.Items[lvw_pos].Focused=true;
					lvBarrowed.Items[lvw_pos].Selected = true;
					lvBarrowed.Items[lvw_pos].EnsureVisible();
					
				}
				lvw_pos = 0;
				
			}
			catch(ArgumentOutOfRangeException aooreE){}

			catch(NullReferenceException nreE){}

			catch(IOException ioeE){MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message,clsVariables.sMSGBOX,MessageBoxButtons.OK ,MessageBoxIcon.Error);}
		}

		public void setTabControl()
		{
			sFunctions.FillTabControls(tabCategory,"SELECT CategoryName FROM tblCategory ORDER BY CategoryName ASC","tblCategory","All Category");
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void cbLevel_SelectedIndexChanged(object sender, System.EventArgs e){tabCategory_SelectedIndexChanged(sender,e);}

		private void cbYear_SelectedIndexChanged(object sender, System.EventArgs e){tabCategory_SelectedIndexChanged(sender,e);}

		private void tabCategory_SelectedIndexChanged(object sender, System.EventArgs e){setLoading();}

		public void setLoading()
		{
			if(tabCategory.TabPages.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND (tblBarrowed.Returned)=No ORDER BY tblBooks.BookNo ASC");
				}
				else
				{
					loadBarrowed("SELECT tblBooks.BookNo, tblBooks.BookTitle, tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowed.DateBarrowed, tblBarrowed.DateDue, tblCategory.CategoryName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM (tblSchoolYear RIGHT JOIN (tblLevel RIGHT JOIN tblBarrowers ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) RIGHT JOIN (tblCategory INNER JOIN (tblBooks INNER JOIN tblBarrowed ON tblBooks.BookNo = tblBarrowed.BookNo) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblBarrowers.BarrowerID = tblBarrowed.BarrowerID WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND CategoryName LIKE '" + tabCategory.SelectedTab.Text + "' AND (tblBarrowed.Returned)=No ORDER BY tblBooks.BookNo ASC");
				}			
			}
		}
		private void bttnReload_Click(object sender, System.EventArgs e) 
		{
			setTabControl();
			tabCategory_SelectedIndexChanged(sender, e);
		}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			FORMBarrowedBooks_New.sSY	 = cbYear.Text;
			FORMBarrowedBooks_New.sLevel = cbLevel.Text;
			FORMBarrowedBooks_New sForm  = new FORMBarrowedBooks_New();
			sForm.ShowDialog();
		}

		private void bttnReturned_Click(object sender, System.EventArgs e)
		{
			if(lvBarrowed.Items.Count > 0)
			{
				try
				{
					FORMBarrowedBooks_Returned.sBookID = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[0].Text;
					FORMBarrowedBooks_Returned.sBookTitle = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[1].Text;
					FORMBarrowedBooks_Returned.sBarrowerID = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[2].Text;
					FORMBarrowedBooks_Returned.sBarrowerName = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[3].Text;
					FORMBarrowedBooks_Returned.sDTBrrwd = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[4].Text;
					FORMBarrowedBooks_Returned.sDTDue = lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[5].Text;
					FORMBarrowedBooks_Returned sForm = new FORMBarrowedBooks_Returned();
					sForm.ShowDialog();

				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else{MessageBox.Show("No record/book to return.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}

		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks = "Records";
			FORMSearch sForm  = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lvBarrowed.Items.Count > 0)
				{
					if(MessageBox.Show("This will permanently delete the selected record. Do you want to continue?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
					{
						try
						{
							cmdDelete = new OleDbCommand("DELETE FROM tblBarrowed WHERE BookNo = @getBookNo AND BarrowerID = @getBarrowerID AND DateBarrowed =@getDateBarrowed AND DateDue = @getDateDue",clsConnections.CN);
							cmdDelete.Parameters.Add("@getBookNo",OleDbType.VarChar);
							cmdDelete.Parameters.Add("@getBarrowerID",OleDbType.VarChar);
							cmdDelete.Parameters.Add("@getDateBarrowed",OleDbType.Date);
							cmdDelete.Parameters.Add("@getDateDue",OleDbType.Date);

							cmdDelete.Parameters["@getBookNo"].Value =lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[0].Text;
							cmdDelete.Parameters["@getBarrowerID"].Value =lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[2].Text;
							cmdDelete.Parameters["@getDateBarrowed"].Value =lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[4].Text;
							cmdDelete.Parameters["@getDateDue"].Value =lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[5].Text;

							long iBarrowed=0;
							long iTotal=0;
							long totalRow =0;

							//Set the Data Adapter
							OleDbDataAdapter da = new OleDbDataAdapter("SELECT BookNo, Barrowed FROM tblBooks WHERE tblBooks.BookNo LIKE '" + lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[0].Text + "' ",clsConnections.CN);
							DataSet ds = new DataSet();
							da.Fill(ds,"tblBooks");

							totalRow = ds.Tables["tblBooks"].Rows.Count -1;

							iBarrowed = Convert.ToInt32(ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString());
							iTotal = iBarrowed - 1;

							cmdUpdateBook = new OleDbCommand("UPDATE tblBooks SET Barrowed = @getBarrowed WHERE BookNo LIKE '" + lvBarrowed.Items[lvBarrowed.FocusedItem.Index].SubItems[0].Text + "' " ,clsConnections.CN);
							cmdUpdateBook.Parameters.Add("@getBarrowed",OleDbType.Double);
							cmdUpdateBook.Parameters["@getBarrowed"].Value		= iTotal;
				
							cmdUpdateBook.ExecuteNonQuery();
							cmdDelete.ExecuteNonQuery();

						}
						catch(Exception ex){MessageBox.Show(ex.Message ,clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}
						
						int lvw_pos;
						lvw_pos=lvBarrowed.FocusedItem.Index;

						tabCategory_SelectedIndexChanged(sender, e);
						
						if(lvBarrowed.Items.Count != 0 && lvBarrowed.Items.Count -1 >= lvw_pos)
						{
							lvBarrowed.Items[lvBarrowed.FocusedItem.Index].Selected =false;
							lvBarrowed.Items[lvBarrowed.FocusedItem.Index].Focused=false;

							lvBarrowed.Items[lvw_pos].Focused=true;
							lvBarrowed.Items[lvw_pos].Selected = true;
							lvBarrowed.Items[lvw_pos].EnsureVisible();
						}
						lvw_pos = 0;
					}
				}
				else{MessageBox.Show("No record to delete.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
			}
			catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
			
			catch(NullReferenceException nreE){}		
		}
	}
}
