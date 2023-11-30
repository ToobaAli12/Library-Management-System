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
	public class FORMBooks_View : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static FORMBooks_View publicBooksList;
		
		OleDbDataAdapter daBooksList = new OleDbDataAdapter();
		DataSet dsBooksList = new DataSet();

		private System.Windows.Forms.Button bttnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.ColumnHeader chBookTitle;
		public System.Windows.Forms.ListView lvBooks;
		private System.Windows.Forms.ColumnHeader ChBookNO;
		private System.Windows.Forms.ColumnHeader chCategoty;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader chISBN;
		private System.Windows.Forms.ColumnHeader chAvailable;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Button bttnSelect;
		private System.ComponentModel.Container components = null;

		public FORMBooks_View(){InitializeComponent();}

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
			this.bttnReload = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.chBookTitle = new System.Windows.Forms.ColumnHeader();
			this.lvBooks = new System.Windows.Forms.ListView();
			this.ChBookNO = new System.Windows.Forms.ColumnHeader();
			this.chISBN = new System.Windows.Forms.ColumnHeader();
			this.chCategoty = new System.Windows.Forms.ColumnHeader();
			this.chAvailable = new System.Windows.Forms.ColumnHeader();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.bttnSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bttnReload
			// 
			this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReload.Location = new System.Drawing.Point(472, 415);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(80, 25);
			this.bttnReload.TabIndex = 243;
			this.bttnReload.Text = "&Reload";
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(560, 415);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 242;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(7, 401);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(632, 2);
			this.ctrlSeparator1.TabIndex = 241;
			// 
			// chBookTitle
			// 
			this.chBookTitle.Text = "Book Title";
			this.chBookTitle.Width = 300;
			// 
			// lvBooks
			// 
			this.lvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.ChBookNO,
																					  this.chISBN,
																					  this.chBookTitle,
																					  this.chCategoty,
																					  this.chAvailable});
			this.lvBooks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBooks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBooks.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBooks.FullRowSelect = true;
			this.lvBooks.GridLines = true;
			this.lvBooks.HideSelection = false;
			this.lvBooks.HoverSelection = true;
			this.lvBooks.Location = new System.Drawing.Point(7, 37);
			this.lvBooks.MultiSelect = false;
			this.lvBooks.Name = "lvBooks";
			this.lvBooks.Size = new System.Drawing.Size(630, 350);
			this.lvBooks.TabIndex = 240;
			this.lvBooks.View = System.Windows.Forms.View.Details;
			this.lvBooks.DoubleClick += new System.EventHandler(this.lvBooks_DoubleClick);
			// 
			// ChBookNO
			// 
			this.ChBookNO.Text = "Book Number";
			this.ChBookNO.Width = 150;
			// 
			// chISBN
			// 
			this.chISBN.Text = "ISBN";
			this.chISBN.Width = 150;
			// 
			// chCategoty
			// 
			this.chCategoty.Text = "Categoty Name";
			this.chCategoty.Width = 150;
			// 
			// chAvailable
			// 
			this.chAvailable.Text = "Available";
			this.chAvailable.Width = 200;
			// 
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(5, 35);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(635, 354);
			this.picFill.TabIndex = 239;
			this.picFill.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-1, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 20);
			this.label1.TabIndex = 238;
			this.label1.Text = "  Book Records";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.Location = new System.Drawing.Point(384, 416);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(80, 25);
			this.bttnSearch.TabIndex = 245;
			this.bttnSearch.Text = "&Search";
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// bttnSelect
			// 
			this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSelect.Location = new System.Drawing.Point(296, 416);
			this.bttnSelect.Name = "bttnSelect";
			this.bttnSelect.Size = new System.Drawing.Size(80, 25);
			this.bttnSelect.TabIndex = 246;
			this.bttnSelect.Text = "&Select";
			this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
			// 
			// FORMBooks_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(646, 448);
			this.Controls.Add(this.bttnSelect);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.lvBooks);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBooks_View";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Books";
			this.Load += new System.EventHandler(this.FORMBooks_View_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMBooks_View_Load(object sender, System.EventArgs e)
		{
			lvBooks.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daBooksList= new OleDbDataAdapter("",clsConnections.CN);

			loadBooks("SELECT tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
		
			publicBooksList=this;
			this.Refresh();
		}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;
			string sAvailable;

			daBooksList.SelectCommand.CommandText = sSQL;

			dsBooksList.Clear();
			daBooksList.Fill(dsBooksList,"tblBooks");

			totalRow = dsBooksList.Tables["tblBooks"].Rows.Count -1;
			
			lvBooks.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBooks.Items.Add(new ListViewItem("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(0).ToString(),20));
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(1).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBooks.Items[i].SubItems.Add("" + dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(3).ToString());

				sAvailable = dsBooksList.Tables["tblBooks"].Rows[i].ItemArray.GetValue(4).ToString();
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
			loadBooks("SELECT tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE " + sField + " LIKE '*" + sSearch + "*' ORDER BY tblBooks.BookNo ASC");
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks= "Barrowed Books";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			loadBooks("SELECT tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblCategory.CategoryName, ([Qty])-([Barrowed]) AS Available FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex ORDER BY tblBooks.BookNo ASC");
		}

		private void lvBooks_DoubleClick(object sender, System.EventArgs e){bttnSelect_Click(sender, e);}

		private void bttnSelect_Click(object sender, System.EventArgs e)
		{
			if (lvBooks.Items.Count > 0)
			{
				int sAvailable;
				sAvailable = Convert.ToInt32(lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[4].Text);

				if( sAvailable >= 1)
				{
					FORMBarrowedBooks_New.publicBarrowedList.setBook(lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[0].Text, lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[2].Text);
					this.Close();
				}		
				else
				{
					MessageBox.Show("No Available Book " + lvBooks.Items[lvBooks.FocusedItem.Index].SubItems[2].Text + " in the Records.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}
		}
	}
}
