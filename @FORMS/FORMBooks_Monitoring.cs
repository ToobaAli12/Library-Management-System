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
	public class FORMBooks_Monitoring : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static string sBookNumber;
		public static FORMBooks_Monitoring publicHistory;
		
		OleDbDataAdapter daHistory = new OleDbDataAdapter();
		DataSet dsHistory = new DataSet();
		private System.Windows.Forms.Button bttReload;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Label label1;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		public System.Windows.Forms.ListView lvBooks;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		private System.Windows.Forms.ColumnHeader chCategoty;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.ColumnHeader ChISBN;
		private System.Windows.Forms.ColumnHeader chAdjustBy;
		private System.Windows.Forms.ColumnHeader chDateAdjust;
		private System.Windows.Forms.ColumnHeader chLibrarianID;
		private System.ComponentModel.Container components = null;

		public FORMBooks_Monitoring(){InitializeComponent();}

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
			this.bttnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.lvBooks = new System.Windows.Forms.ListView();
			this.ChISBN = new System.Windows.Forms.ColumnHeader();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.chCategoty = new System.Windows.Forms.ColumnHeader();
			this.chLibrarianID = new System.Windows.Forms.ColumnHeader();
			this.chAdjustBy = new System.Windows.Forms.ColumnHeader();
			this.chDateAdjust = new System.Windows.Forms.ColumnHeader();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// bttReload
			// 
			this.bttReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttReload.Location = new System.Drawing.Point(465, 414);
			this.bttReload.Name = "bttReload";
			this.bttReload.Size = new System.Drawing.Size(80, 25);
			this.bttReload.TabIndex = 242;
			this.bttReload.Text = "&Reload";
			this.bttReload.Click += new System.EventHandler(this.bttReload_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(557, 414);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 241;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 20);
			this.label1.TabIndex = 237;
			this.label1.Text = "  Adjustment History Viewer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 400);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(632, 2);
			this.ctrlSeparator1.TabIndex = 246;
			// 
			// lvBooks
			// 
			this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.ChISBN,
																					  this.chBookTitle,
																					  this.chCategoty,
																					  this.chLibrarianID,
																					  this.chAdjustBy,
																					  this.chDateAdjust});
			this.lvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBooks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBooks.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBooks.FullRowSelect = true;
			this.lvBooks.GridLines = true;
			this.lvBooks.HideSelection = false;
			this.lvBooks.HoverSelection = true;
			this.lvBooks.Location = new System.Drawing.Point(8, 36);
			this.lvBooks.MultiSelect = false;
			this.lvBooks.Name = "lvBooks";
			this.lvBooks.Size = new System.Drawing.Size(630, 350);
			this.lvBooks.TabIndex = 245;
			this.lvBooks.View = System.Windows.Forms.View.Details;
			// 
			// ChISBN
			// 
			this.ChISBN.Text = "ISBN";
			this.ChISBN.Width = 150;
			// 
			// chBookTitle
			// 
			this.chBookTitle.Text = "Book Title";
			this.chBookTitle.Width = 300;
			// 
			// chCategoty
			// 
			this.chCategoty.Text = "Categoty Name";
			this.chCategoty.Width = 150;
			// 
			// chLibrarianID
			// 
			this.chLibrarianID.Text = "LibrarianID";
			this.chLibrarianID.Width = 150;
			// 
			// chAdjustBy
			// 
			this.chAdjustBy.Text = "Adjust By";
			this.chAdjustBy.Width = 300;
			// 
			// chDateAdjust
			// 
			this.chDateAdjust.Text = "Date Adjust";
			this.chDateAdjust.Width = 300;
			// 
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(6, 34);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(635, 354);
			this.picFill.TabIndex = 244;
			this.picFill.TabStop = false;
			// 
			// FORMBooks_Monitoring
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(646, 448);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.lvBooks);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.bttReload);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBooks_Monitoring";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adjustment Records";
			this.Load += new System.EventHandler(this.FORMBooks_Monitoring_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMBooks_Monitoring_Load(object sender, System.EventArgs e)
		{
			//Set the Icon on Listview.
			lvBooks.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daHistory= new OleDbDataAdapter("",clsConnections.CN);

			//Set to Load Books History
			loadBooks("SELECT tblAdjustments.BookNumber, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblAdjustments.DateAdjust FROM tblCategory RIGHT JOIN (tblLibrarian INNER JOIN (tblBooks RIGHT JOIN tblAdjustments ON tblBooks.BookNo = tblAdjustments.BookNumber) ON tblLibrarian.LibrarianID = tblAdjustments.AdjustBy) ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblAdjustments.BookNumber LIKE '" + sBookNumber + "' ORDER BY tblAdjustments.DateAdjust DESC");

			publicHistory =this;

		}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;
			string sDateAdjust;

			daHistory.SelectCommand.CommandText = sSQL;

			dsHistory.Clear();
			daHistory.Fill(dsHistory,"tblAdjustments");

			totalRow = dsHistory.Tables["tblAdjustments"].Rows.Count -1;
			
			lvBooks.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBooks.Items.Add(new ListViewItem("" + dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(1).ToString(),20));
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(3).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(4).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(5).ToString());

				sDateAdjust = dsHistory.Tables["tblAdjustments"].Rows[i].ItemArray.GetValue(6).ToString();
				sDateAdjust = Convert.ToDateTime(sDateAdjust).ToString("MMMM dd, yyyy [ hh:mm:ss ttttt ]");
				lvBooks.Items[i].SubItems.Add(sDateAdjust);
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
			loadBooks("SELECT tblAdjustments.BookNumber, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblAdjustments.DateAdjust FROM tblCategory RIGHT JOIN (tblLibrarian INNER JOIN (tblBooks RIGHT JOIN tblAdjustments ON tblBooks.BookNo = tblAdjustments.BookNumber) ON tblLibrarian.LibrarianID = tblAdjustments.AdjustBy) ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblAdjustments.BookNumber LIKE '" + sBookNumber + "'  AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblAdjustments.DateAdjust DESC");
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBokHstry = "Monitoring";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttReload_Click(object sender, System.EventArgs e)
		{
			loadBooks("SELECT tblAdjustments.BookNumber, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblAdjustments.DateAdjust FROM tblCategory RIGHT JOIN (tblLibrarian INNER JOIN (tblBooks RIGHT JOIN tblAdjustments ON tblBooks.BookNo = tblAdjustments.BookNumber) ON tblLibrarian.LibrarianID = tblAdjustments.AdjustBy) ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblAdjustments.BookNumber LIKE '" + sBookNumber + "' ORDER BY tblAdjustments.DateAdjust DESC");
		}

	}
}
