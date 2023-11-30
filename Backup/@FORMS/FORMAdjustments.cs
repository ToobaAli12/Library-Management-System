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
	public class FORMAdjustments : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMAdjustments publicAdjustList;
		
		OleDbDataAdapter daAdjustList = new OleDbDataAdapter();
		DataSet dsAdjustList = new DataSet();

		private System.Windows.Forms.ColumnHeader chBarrowed;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ColumnHeader chAvailable;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.Label lblHeader;
		public System.Windows.Forms.ListView lvBooks;
		private System.Windows.Forms.ColumnHeader chBookNOs;
		private System.Windows.Forms.ColumnHeader chISBN;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		private System.Windows.Forms.ColumnHeader chQTY;
		private System.Windows.Forms.TabControl tabCategory;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Button bttnAdjust;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnHistory;
		private System.ComponentModel.Container components = null;

		public FORMAdjustments(){InitializeComponent();}

		private static FORMAdjustments sForm = null;
		public static FORMAdjustments  Instance()
		{
			if(sForm==null){sForm = new FORMAdjustments();}

			return sForm;
		}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMAdjustments));
			this.chBarrowed = new System.Windows.Forms.ColumnHeader();
			this.label7 = new System.Windows.Forms.Label();
			this.chAvailable = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.bttnAdjust = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.lblContains = new System.Windows.Forms.Label();
			this.lblHeader = new System.Windows.Forms.Label();
			this.lvBooks = new System.Windows.Forms.ListView();
			this.chBookNOs = new System.Windows.Forms.ColumnHeader();
			this.chISBN = new System.Windows.Forms.ColumnHeader();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.chQTY = new System.Windows.Forms.ColumnHeader();
			this.tabCategory = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnHistory = new System.Windows.Forms.Button();
			this.tabCategory.SuspendLayout();
			this.SuspendLayout();
			// 
			// chBarrowed
			// 
			this.chBarrowed.Text = "Total Barrowed";
			this.chBarrowed.Width = 200;
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
			this.label7.Size = new System.Drawing.Size(141, 19);
			this.label7.TabIndex = 101;
			this.label7.Text = "Monitoring Records:";
			// 
			// chAvailable
			// 
			this.chAvailable.Text = "Available";
			this.chAvailable.Width = 100;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(453, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 98;
			this.label6.Text = "&Adjust";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnAdjust
			// 
			this.bttnAdjust.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAdjust.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnAdjust.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnAdjust.ForeColor = System.Drawing.Color.Black;
			this.bttnAdjust.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdjust.Image")));
			this.bttnAdjust.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnAdjust.Location = new System.Drawing.Point(448, 462);
			this.bttnAdjust.Name = "bttnAdjust";
			this.bttnAdjust.Size = new System.Drawing.Size(40, 40);
			this.bttnAdjust.TabIndex = 97;
			this.bttnAdjust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnAdjust.Click += new System.EventHandler(this.bttnAdjust_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(548, 504);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 48);
			this.label3.TabIndex = 96;
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
			this.bttnSearch.Location = new System.Drawing.Point(544, 462);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 95;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(597, 504);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 92;
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
			this.bttnReload.TabIndex = 91;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(642, 504);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 90;
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
			this.bttnCancel.Location = new System.Drawing.Point(639, 462);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 89;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(10, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(348, 17);
			this.lblContains.TabIndex = 87;
			this.lblContains.Text = "This contains all information about the adjustment of books.";
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
			this.lblHeader.Size = new System.Drawing.Size(161, 22);
			this.lblHeader.TabIndex = 84;
			this.lblHeader.Text = "Monitoring Records";
			// 
			// lvBooks
			// 
			this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.chBookNOs,
																					  this.chISBN,
																					  this.chBookTitle,
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
			this.lvBooks.TabIndex = 88;
			this.lvBooks.View = System.Windows.Forms.View.Details;
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
			// chBookTitle
			// 
			this.chBookTitle.Text = "BookTitle";
			this.chBookTitle.Width = 500;
			// 
			// chQTY
			// 
			this.chQTY.Text = "Total Quantity";
			this.chQTY.Width = 200;
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
			this.tabCategory.TabIndex = 86;
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
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 85;
			this.picLOGO.TabStop = false;
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 83;
			this.picHeader.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(501, 504);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 103;
			this.label4.Text = "&History";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnHistory
			// 
			this.bttnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnHistory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnHistory.ForeColor = System.Drawing.Color.Black;
			this.bttnHistory.Image = ((System.Drawing.Image)(resources.GetObject("bttnHistory.Image")));
			this.bttnHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnHistory.Location = new System.Drawing.Point(496, 462);
			this.bttnHistory.Name = "bttnHistory";
			this.bttnHistory.Size = new System.Drawing.Size(40, 40);
			this.bttnHistory.TabIndex = 102;
			this.bttnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnHistory.Click += new System.EventHandler(this.bttnHistory_Click);
			// 
			// FORMAdjustments
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bttnHistory);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bttnAdjust);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bttnSearch);
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
			this.Name = "FORMAdjustments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Books Monitoring";
			this.Load += new System.EventHandler(this.FORMAdjustments_Load);
			this.tabCategory.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMAdjustments_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daAdjustList= new OleDbDataAdapter("",clsConnections.CN);

			setTabControl();


			loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
		
			publicAdjustList = this;
		}

		protected void setImages()
		{
			lvBooks.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void setTabControl(){sFunctions.FillTabControls(tabCategory,"SELECT CategoryName FROM tblCategory ORDER BY CategoryName ASC","tblCategory","All Category");}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;
			string sQuantity;
			string sBarrowed;
			string sAvailable;

			daAdjustList.SelectCommand.CommandText = sSQL;

			dsAdjustList.Clear();
			daAdjustList.Fill(dsAdjustList,"tblBooks");

			totalRow = dsAdjustList.Tables["tblBooks"].Rows.Count -1;
			
			lvBooks.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBooks.Items.Add(new ListViewItem("" + dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(1).ToString(),20));
				lvBooks.Items[i].SubItems.Add("" + dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(3).ToString());
				
				sQuantity = dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(4).ToString();
				sQuantity = Convert.ToDecimal(sQuantity).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sQuantity);

				sBarrowed = dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(5).ToString();
				sBarrowed = Convert.ToDecimal(sBarrowed).ToString("0,0");
				lvBooks.Items[i].SubItems.Add(sBarrowed);	
				
				sAvailable = dsAdjustList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(6).ToString();
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

		public void tabCategory_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(tabCategory.TabPages.Count > 0)
			{
				if(tabCategory.SelectedTab.Text.Equals("All Category"))
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
				}
				else
				{
					loadBooks("SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblCategory.CategoryName LIKE '" + tabCategory.SelectedTab.Text  + "' ORDER BY tblBooks.BookNo ASC");
				}			
			}
		}

		private void bttnAdjust_Click(object sender, System.EventArgs e)
		{
			if(lvBooks.Items.Count > 0)
			{
				try
				{
					FORMAdjustments_Modify.sBookID = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text;
					FORMAdjustments_Modify.sISBN = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[1].Text;
					FORMAdjustments_Modify.sBookTitle = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[2].Text;
					FORMAdjustments_Modify.sQuantity = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[3].Text;
					FORMAdjustments_Modify.sBarrowed = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[4].Text;
					FORMAdjustments_Modify.sAvailable = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[5].Text;
					FORMAdjustments_Modify sForm = new FORMAdjustments_Modify();
					sForm.ShowDialog();
				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else{MessageBox.Show("No record to edit.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			setTabControl();
			tabCategory_SelectedIndexChanged(sender, e);
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks= "Adjust";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnHistory_Click(object sender, System.EventArgs e)
		{
			if(lvBooks.Items.Count > 0)
			{
				try
				{
					if(MessageBox.Show("Do you want to print the list of adjustments in the selected record?",clsVariables.sMSGBOX,MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.No)
					{
						FORMBooks_Monitoring.sBookNumber = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text;
						FORMBooks_Monitoring sForm = new FORMBooks_Monitoring();
						sForm.ShowDialog();
					}
					else
					{
						FORMViewer.sDeploy = "Adjustments";
						FORMViewer.sBookNO = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text;
						FORMViewer.sBookTitle = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[2].Text;
						FORMViewer.sISBN = lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[1].Text;
						FORMViewer.sSQL = "SELECT tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblAdjustments.DateAdjust " +
							"FROM tblLibrarian INNER JOIN (tblCategory RIGHT JOIN (tblBooks RIGHT JOIN tblAdjustments ON tblBooks.BookNo = tblAdjustments.BookNumber) ON tblCategory.IndexCategory = tblBooks.CategoryIndex) ON tblLibrarian.LibrarianID = tblAdjustments.AdjustBy " +
							"WHERE tblBooks.BookNo LIKE '" + lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text + "' " +
							"ORDER BY tblLibrarian.LibrarianID ASC";
						FORMViewer.sTable = "tblAdjustments";
						FORMViewer sForm = new FORMViewer();
						sForm.ShowDialog();
					}	
				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else{MessageBox.Show("No record. Pls. select a new record",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}

		}
	}
}
