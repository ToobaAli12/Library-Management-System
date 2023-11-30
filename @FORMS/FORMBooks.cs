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
	public class FORMBooks : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMBooks publicBooksList;
		
		OleDbDataAdapter daBooksList = new OleDbDataAdapter();
		OleDbCommand cmdDelete;
		DataSet dsBooksList = new DataSet();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabCategory;
		private System.Windows.Forms.Label lblContains;
		public System.Windows.Forms.ListView lvBooks;
		private System.Windows.Forms.ColumnHeader chBookNOs;
		private System.Windows.Forms.ColumnHeader chISBN;
		private System.Windows.Forms.ColumnHeader chAuthor;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		private System.Windows.Forms.ColumnHeader chPrice;
		private System.Windows.Forms.ColumnHeader chQTY;
		private System.Windows.Forms.ColumnHeader chBarrowed;
		private System.Windows.Forms.ColumnHeader chAvailable;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnDelete;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bttnAddNew;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button bttnModify;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader chPublished;
		private System.Windows.Forms.ColumnHeader chArrived;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button bttnPrint;

		private static FORMBooks sForm = null;
		public static FORMBooks  Instance()
		{
			if(sForm==null){sForm = new FORMBooks();}

			return sForm;
		}

		public FORMBooks(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBooks));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.tabCategory = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblContains = new System.Windows.Forms.Label();
			this.lvBooks = new System.Windows.Forms.ListView();
			this.chBookNOs = new System.Windows.Forms.ColumnHeader();
			this.chISBN = new System.Windows.Forms.ColumnHeader();
			this.chAuthor = new System.Windows.Forms.ColumnHeader();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.chPublished = new System.Windows.Forms.ColumnHeader();
			this.chArrived = new System.Windows.Forms.ColumnHeader();
			this.chPrice = new System.Windows.Forms.ColumnHeader();
			this.chQTY = new System.Windows.Forms.ColumnHeader();
			this.chBarrowed = new System.Windows.Forms.ColumnHeader();
			this.chAvailable = new System.Windows.Forms.ColumnHeader();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnDelete = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.bttnModify = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.bttnPrint = new System.Windows.Forms.Button();
			this.tabCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 13;
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
			this.lblHeader.Size = new System.Drawing.Size(127, 22);
			this.lblHeader.TabIndex = 12;
			this.lblHeader.Text = "Books Records";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 11;
			this.picHeader.TabStop = false;
			// 
			// tabCategory
			// 
			this.tabCategory.Controls.Add(this.tabPage1);
			this.tabCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabCategory.ItemSize = new System.Drawing.Size(121, 21);
			this.tabCategory.Location = new System.Drawing.Point(4, 35);
			this.tabCategory.Name = "tabCategory";
			this.tabCategory.SelectedIndex = 0;
			this.tabCategory.ShowToolTips = true;
			this.tabCategory.Size = new System.Drawing.Size(676, 421);
			this.tabCategory.TabIndex = 15;
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
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(10, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(268, 17);
			this.lblContains.TabIndex = 17;
			this.lblContains.Text = "This contains all information about the books. ";
			// 
			// lvBooks
			// 
			this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.chBookNOs,
																					  this.chISBN,
																					  this.chAuthor,
																					  this.chBookTitle,
																					  this.chPublished,
																					  this.chArrived,
																					  this.chPrice,
																					  this.chQTY,
																					  this.chBarrowed,
																					  this.chAvailable});
			this.lvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBooks.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBooks.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBooks.FullRowSelect = true;
			this.lvBooks.GridLines = true;
			this.lvBooks.HideSelection = false;
			this.lvBooks.Location = new System.Drawing.Point(13, 64);
			this.lvBooks.MultiSelect = false;
			this.lvBooks.Name = "lvBooks";
			this.lvBooks.Size = new System.Drawing.Size(659, 384);
			this.lvBooks.TabIndex = 68;
			this.lvBooks.View = System.Windows.Forms.View.Details;
			this.lvBooks.DoubleClick += new System.EventHandler(this.lvBooks_DoubleClick);
			// 
			// chBookNOs
			// 
			this.chBookNOs.Text = "Book Number";
			this.chBookNOs.Width = 200;
			// 
			// chISBN
			// 
			this.chISBN.Text = "ISBN";
			this.chISBN.Width = 200;
			// 
			// chAuthor
			// 
			this.chAuthor.Text = "Name of Author";
			this.chAuthor.Width = 200;
			// 
			// chBookTitle
			// 
			this.chBookTitle.Text = "BookTitle";
			this.chBookTitle.Width = 500;
			// 
			// chPublished
			// 
			this.chPublished.Text = "Published";
			this.chPublished.Width = 100;
			// 
			// chArrived
			// 
			this.chArrived.Text = "Date Arrived";
			this.chArrived.Width = 150;
			// 
			// chPrice
			// 
			this.chPrice.Text = "Price";
			this.chPrice.Width = 100;
			// 
			// chQTY
			// 
			this.chQTY.Text = "Quantity";
			this.chQTY.Width = 100;
			// 
			// chBarrowed
			// 
			this.chBarrowed.Text = "Barrowed";
			this.chBarrowed.Width = 100;
			// 
			// chAvailable
			// 
			this.chAvailable.Text = "Available";
			this.chAvailable.Width = 100;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(639, 462);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 69;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(642, 504);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 71;
			this.label1.Text = "&Cancel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(597, 504);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 73;
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
			this.bttnReload.Location = new System.Drawing.Point(592, 462);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 72;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(500, 504);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 48);
			this.label3.TabIndex = 77;
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
			this.bttnSearch.Location = new System.Drawing.Point(496, 462);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 76;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(548, 504);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 48);
			this.label4.TabIndex = 75;
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
			this.bttnDelete.Location = new System.Drawing.Point(544, 462);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(40, 40);
			this.bttnDelete.TabIndex = 74;
			this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(355, 504);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 32);
			this.label5.TabIndex = 81;
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
			this.bttnAddNew.Location = new System.Drawing.Point(352, 462);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(40, 40);
			this.bttnAddNew.TabIndex = 80;
			this.bttnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(403, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 79;
			this.label6.Text = "&Modify";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnModify
			// 
			this.bttnModify.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnModify.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnModify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnModify.ForeColor = System.Drawing.Color.Black;
			this.bttnModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnModify.Location = new System.Drawing.Point(400, 462);
			this.bttnModify.Name = "bttnModify";
			this.bttnModify.Size = new System.Drawing.Size(40, 40);
			this.bttnModify.TabIndex = 78;
			this.bttnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnModify.Click += new System.EventHandler(this.bttnModify_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(10, 470);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 19);
			this.label7.TabIndex = 82;
			this.label7.Text = "Books Records:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(452, 504);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 48);
			this.label8.TabIndex = 136;
			this.label8.Text = "&Print";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnPrint
			// 
			this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPrint.ForeColor = System.Drawing.Color.Black;
			this.bttnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnPrint.Location = new System.Drawing.Point(448, 462);
			this.bttnPrint.Name = "bttnPrint";
			this.bttnPrint.Size = new System.Drawing.Size(40, 40);
			this.bttnPrint.TabIndex = 135;
			this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
			// 
			// FORMBooks
			// 
			this.AcceptButton = this.bttnAddNew;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.bttnPrint);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bttnModify);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bttnDelete);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.lvBooks);
			this.Controls.Add(this.tabCategory);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Books";
			this.Load += new System.EventHandler(this.FORMBooks_Load);
			this.tabCategory.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBooks_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daBooksList= new OleDbDataAdapter("",clsConnections.CN);

			setTabControl();


			loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
		
			publicBooksList=this;
			this.Refresh();
		}
		
		protected void setImages()
		{
			lvBooks.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnAddNew.Image = MDIFORM.i32x32.Images[13];
			bttnModify.Image = MDIFORM.i32x32.Images[14];
			bttnPrint.Image = MDIFORM.i32x32.Images[11];
			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnDelete.Image = MDIFORM.i32x32.Images[16];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void setTabControl(){sFunctions.FillTabControls(tabCategory,"SELECT CategoryName FROM tblCategory ORDER BY CategoryName ASC","tblCategory","All Category");}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;
			string sDateValue;
			string sPrice;
			string sQuantity;
			string sBarrowed;
			string sAvailable;

			daBooksList.SelectCommand.CommandText = sSQL;

			dsBooksList.Clear();
			daBooksList.Fill(dsBooksList,"tblBooks");

			totalRow = dsBooksList.Tables["tblBooks"].Rows.Count -1;
			
			lvBooks.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBooks.Items.Add(new ListViewItem("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(1).ToString(),20));
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(3).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(4).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(5).ToString());
				
				sDateValue = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(6).ToString();
				sDateValue = Convert.ToDateTime(sDateValue).ToString("MMMM dd, yyyy");
				lvBooks.Items[i].SubItems.Add(sDateValue);

				sPrice = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(7).ToString();
				sPrice = Convert.ToDecimal(sPrice).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sPrice);

				sQuantity = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(8).ToString();
				sQuantity = Convert.ToDecimal(sQuantity).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sQuantity);

				sBarrowed = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(9).ToString();
				sBarrowed = Convert.ToDecimal(sBarrowed).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sBarrowed);			
				
				sAvailable = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(10).ToString();
				sAvailable = Convert.ToDecimal(sAvailable).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sAvailable);
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
			if(tabCategory.TabPages.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
				}
				else
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblCategory.CategoryName LIKE '" + tabCategory.SelectedTab.Text  + "' AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBooks.BookNo ASC");
				}			
			}	
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		public void tabCategory_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(tabCategory.TabPages.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
				}
				else
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblCategory.CategoryName LIKE '" + tabCategory.SelectedTab.Text  + "' ORDER BY tblBooks.BookNo ASC");
				}			
			}
		}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			setTabControl();
			tabCategory_SelectedIndexChanged(sender, e);
		}

		private void bttnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lvBooks.Items.Count > 0)
				{
					if(MessageBox.Show("This will permanently delete the selected record. Do you want to continue?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
					{
						try{sFunctions.setOleDbCommand(cmdDelete,"DELETE FROM tblBooks WHERE BookNo = @getBookNo","@getBookNo", lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text);}
						catch(Exception ex){MessageBox.Show(ex.Message ,clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}
						
						int lvw_pos;
						lvw_pos=lvBooks.FocusedItem.Index;

						tabCategory_SelectedIndexChanged(sender, e);
						
						if(lvBooks.Items.Count != 0 && lvBooks.Items.Count -1 >= lvw_pos)
						{
							lvBooks.Items[lvBooks.FocusedItem.Index].Selected =false;
							lvBooks.Items[lvBooks.FocusedItem.Index].Focused=false;

							lvBooks.Items[lvw_pos].Focused=true;
							lvBooks.Items[lvw_pos].Selected = true;
							lvBooks.Items[lvw_pos].EnsureVisible();
						}
						lvw_pos = 0;
					}
				}
				else{MessageBox.Show("No record to delete.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
			}
			catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
			
			catch(NullReferenceException nreE){}		
		}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			FORMBooks_Modify.ADD_STATE = true;
			FORMBooks_Modify sForm = new FORMBooks_Modify();
			sForm.ShowDialog();
		}

		private void bttnModify_Click(object sender, System.EventArgs e)
		{
			if(lvBooks.Items.Count > 0)
			{
				try
				{
					FORMBooks_Modify.ADD_STATE = false;
					FORMBooks_Modify.sBookID = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text;
					FORMBooks_Modify sForm = new FORMBooks_Modify();
					sForm.ShowDialog();
				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else{MessageBox.Show("No record to edit.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks= "Books";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnPrint_Click(object sender, System.EventArgs e)
		{
			if(lvBooks.Items.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					FORMViewer.sDeploy = "Books All";
					FORMViewer.sSQL = "SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] AS Available " +
					"FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex " +
					"GROUP BY tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] " +
					"ORDER BY tblBooks.BookNo ASC";
				}
				else
				{
					FORMViewer.sDeploy = "Books List";
					FORMViewer.sCategory = tabCategory.SelectedTab.Text;
					FORMViewer.sSQL = "SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] AS Available " +
						"FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex " + 
						"GROUP BY tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] " +
						"HAVING (((tblCategory.CategoryName)='" + tabCategory.SelectedTab.Text + "'))" +
						"ORDER BY tblBooks.BookNo ASC";
				}
				try
				{
					FORMViewer.sTable = "tblBooks";
					FORMViewer sForm = new FORMViewer();
					sForm.ShowDialog();
				}
				catch(Exception ex){}

			}
			else{MessageBox.Show("No records to preview. Pls try again",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void lvBooks_DoubleClick(object sender, System.EventArgs e){bttnModify_Click(sender, e);}
	}
}
