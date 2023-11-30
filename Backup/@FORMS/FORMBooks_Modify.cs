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
	public class FORMBooks_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		string sAddedBy;
		string sDateAdd;
		string sModifyBy;
		string sDateModify;

		public static string sBookID;

		//INTEGERS VARIABLES
		int iCategory;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdAddBook;

		//OTHER VARIABLES
		public static FORMBooks_Modify publicBooksList;
		public static bool ADD_STATE;

		private System.Windows.Forms.Label label2;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.TextBox txtBookNO;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBookTitle;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button bttnCategory;
		private System.Windows.Forms.TextBox txtPublished;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtArrived;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label label9;
		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.Button bttnBarrowed;
		private System.Windows.Forms.Button bttnModification;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.Button bttnCancel;
		private System.ComponentModel.Container components = null;

		public FORMBooks_Modify(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBooks_Modify));
			this.txtBookNO = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.bttnCategory = new System.Windows.Forms.Button();
			this.txtPublished = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtArrived = new System.Windows.Forms.DateTimePicker();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.bttnBarrowed = new System.Windows.Forms.Button();
			this.bttnModification = new System.Windows.Forms.Button();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBookNO
			// 
			this.txtBookNO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBookNO.Location = new System.Drawing.Point(96, 72);
			this.txtBookNO.Name = "txtBookNO";
			this.txtBookNO.Size = new System.Drawing.Size(208, 20);
			this.txtBookNO.TabIndex = 158;
			this.txtBookNO.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 157;
			this.label2.Text = "&Book Number:";
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 60);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(408, 2);
			this.ctrlSeparator1.TabIndex = 156;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(384, 40);
			this.label1.TabIndex = 155;
			this.label1.Text = "Fill all the fields bellow and click \'Update\' or \'Save\' button to be able to Add " +
				"or Save changes in records.Click \'Cancel\' if you want to cancel.";
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 154;
			this.picLOGO.TabStop = false;
			// 
			// txtISBN
			// 
			this.txtISBN.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtISBN.Location = new System.Drawing.Point(96, 99);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(208, 20);
			this.txtISBN.TabIndex = 160;
			this.txtISBN.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 159;
			this.label3.Text = "&ISBN:";
			// 
			// txtBookTitle
			// 
			this.txtBookTitle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBookTitle.Location = new System.Drawing.Point(96, 157);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.Size = new System.Drawing.Size(264, 20);
			this.txtBookTitle.TabIndex = 164;
			this.txtBookTitle.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 17);
			this.label4.TabIndex = 163;
			this.label4.Text = "&Book Title:";
			// 
			// txtAuthor
			// 
			this.txtAuthor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtAuthor.Location = new System.Drawing.Point(96, 128);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(235, 20);
			this.txtAuthor.TabIndex = 162;
			this.txtAuthor.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 161;
			this.label5.Text = "&Author Name:";
			// 
			// txtCategory
			// 
			this.txtCategory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCategory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCategory.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtCategory.Location = new System.Drawing.Point(96, 188);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.ReadOnly = true;
			this.txtCategory.Size = new System.Drawing.Size(211, 20);
			this.txtCategory.TabIndex = 193;
			this.txtCategory.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 188);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 17);
			this.label14.TabIndex = 192;
			this.label14.Text = "&Category:";
			// 
			// bttnCategory
			// 
			this.bttnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCategory.Image = ((System.Drawing.Image)(resources.GetObject("bttnCategory.Image")));
			this.bttnCategory.Location = new System.Drawing.Point(310, 188);
			this.bttnCategory.Name = "bttnCategory";
			this.bttnCategory.Size = new System.Drawing.Size(21, 20);
			this.bttnCategory.TabIndex = 191;
			this.bttnCategory.Click += new System.EventHandler(this.bttnCategory_Click);
			// 
			// txtPublished
			// 
			this.txtPublished.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPublished.Location = new System.Drawing.Point(96, 217);
			this.txtPublished.MaxLength = 4;
			this.txtPublished.Name = "txtPublished";
			this.txtPublished.Size = new System.Drawing.Size(120, 20);
			this.txtPublished.TabIndex = 195;
			this.txtPublished.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 17);
			this.label6.TabIndex = 194;
			this.label6.Text = "&Year Published:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 248);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 17);
			this.label7.TabIndex = 196;
			this.label7.Text = "&Date Arrived:";
			// 
			// dtArrived
			// 
			this.dtArrived.Location = new System.Drawing.Point(96, 248);
			this.dtArrived.Name = "dtArrived";
			this.dtArrived.Size = new System.Drawing.Size(213, 21);
			this.dtArrived.TabIndex = 197;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(96, 279);
			this.txtPrice.MaxLength = 1000;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(120, 20);
			this.txtPrice.TabIndex = 199;
			this.txtPrice.Text = "0.00";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 280);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 17);
			this.label8.TabIndex = 198;
			this.label8.Text = "&Price:";
			// 
			// txtQuantity
			// 
			this.txtQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtQuantity.Location = new System.Drawing.Point(96, 309);
			this.txtQuantity.MaxLength = 1000;
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(120, 20);
			this.txtQuantity.TabIndex = 201;
			this.txtQuantity.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 311);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 17);
			this.label9.TabIndex = 200;
			this.label9.Text = "&Quantity:";
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(8, 344);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(408, 2);
			this.ctrlSeparator2.TabIndex = 203;
			// 
			// bttnBarrowed
			// 
			this.bttnBarrowed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnBarrowed.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnBarrowed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnBarrowed.Location = new System.Drawing.Point(115, 356);
			this.bttnBarrowed.Name = "bttnBarrowed";
			this.bttnBarrowed.Size = new System.Drawing.Size(104, 25);
			this.bttnBarrowed.TabIndex = 207;
			this.bttnBarrowed.Text = "&Barrowed History";
			this.bttnBarrowed.Click += new System.EventHandler(this.bttnBarrowed_Click);
			// 
			// bttnModification
			// 
			this.bttnModification.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnModification.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnModification.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnModification.Location = new System.Drawing.Point(8, 356);
			this.bttnModification.Name = "bttnModification";
			this.bttnModification.Size = new System.Drawing.Size(104, 25);
			this.bttnModification.TabIndex = 206;
			this.bttnModification.Text = "&Modification History";
			this.bttnModification.Click += new System.EventHandler(this.bttnModification_Click);
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(248, 356);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(80, 25);
			this.bttnUpdate.TabIndex = 205;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(336, 356);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 204;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// FORMBooks_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(426, 392);
			this.Controls.Add(this.bttnBarrowed);
			this.Controls.Add(this.bttnModification);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.txtQuantity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPublished);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCategory);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtBookTitle);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtISBN);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBookNO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtArrived);
			this.Controls.Add(this.bttnCategory);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBooks_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMBooks_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBooks_Modify_Load(object sender, System.EventArgs e)
		{
			if(ADD_STATE == true)
			{
				picLOGO.Image =MDIFORM.i32x32.Images[13];
				bttnModification.Enabled=false;
				bttnBarrowed.Enabled=false;

				//Set Add OleDbCommand
				cmdAddBook = new OleDbCommand("INSERT INTO tblBooks(BookNo,ISBN,Author,BookTitle,CategoryIndex,YearPublished,DateArrived,Price,Qty,AddedBy,DateAdd) VALUES(@getBookNo,@getISBN,@getAuthor,@getBookTitle,@getCategoryIndex,@getYearPublished,@getDateArrived,@getPrice,@getQty,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";

			}
			else
			{
				picLOGO.Image =MDIFORM.i32x32.Images[14];

				//Set Edit OleDbCommand
				cmdAddBook = new OleDbCommand("UPDATE tblBooks SET BookNo =@getBookNo, ISBN =@getISBN, Author =@getAuthor, BookTitle =@getBookTitle, CategoryIndex =@getCategoryIndex, YearPublished =@getYearPublished, DateArrived =@getDateArrived, Price =@getPrice, Qty =@getQty, ModifyBy =@getModifyBy, DateModify =@getDateModify WHERE BookNo LIKE '" + sBookID + "' " ,clsConnections.CN);
				FillFields();
				txtBookNO.ReadOnly=true;
				this.Text = "Edit Existing";
			}

			cmdAddBook.Parameters.Add("@getBookNo",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getISBN",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getAuthor",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getBookTitle",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getCategoryIndex",OleDbType.Double);
			cmdAddBook.Parameters.Add("@getYearPublished",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getDateArrived",OleDbType.Date);
			cmdAddBook.Parameters.Add("@getPrice",OleDbType.Currency);
			cmdAddBook.Parameters.Add("@getQty",OleDbType.Double);
			cmdAddBook.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getDateAdd",OleDbType.Date);
			cmdAddBook.Parameters.Add("@getModifyBy",OleDbType.VarChar);
			cmdAddBook.Parameters.Add("@getDateModify",OleDbType.Date);

			publicBooksList = this;
		}

		private void FillFields()
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblBooks.BookNo, tblBooks.ISBN, tblBooks.Author, tblBooks.BookTitle, tblCategory.CategoryName, tblBooks.YearPublished, tblBooks.DateArrived, tblBooks.Price, tblBooks.Qty, tblBooks.Barrowed, tblBooks.AddedBy, tblBooks.DateAdd, tblBooks.ModifyBy, tblBooks.DateModify, tblCategory.IndexCategory FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex WHERE tblBooks.BookNo LIKE '" + sBookID + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblBooks");

			totalRow = ds.Tables["tblBooks"].Rows.Count -1;

			txtBookNO.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(0).ToString();
			txtISBN.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString();
			txtAuthor.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(2).ToString();
			txtBookTitle.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(3).ToString();
			txtCategory.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(4).ToString();			
			txtPublished.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(5).ToString();
			dtArrived.Text =ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(6).ToString();
			txtPrice.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(7).ToString();
			txtQuantity.Text=ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(8).ToString();
		
			iCategory = Convert.ToInt32(ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(14).ToString());
		}

		public void setCategory(string sCategoryName, string sIndexCategory)
		{
			txtCategory.Text = sCategoryName;
			iCategory = Convert.ToInt32(sIndexCategory);
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnModification_Click(object sender, System.EventArgs e)
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblBooks.BookNo, [tblLibrarian.LastName] & ', ' & [tblLibrarian.FirstName] & ' ' & [tblLibrarian.MiddleName] AS AddedBys, tblBooks.DateAdd, tblBooks.DateModify, [tblLibrarian_1.LastName] & ', ' & [tblLibrarian_1.FirstName] & ' ' & [tblLibrarian_1.MiddleName] AS ModifyBys FROM tblLibrarian RIGHT JOIN (tblLibrarian AS tblLibrarian_1 RIGHT JOIN tblBooks ON tblLibrarian_1.LibrarianID = tblBooks.ModifyBy) ON tblLibrarian.LibrarianID = tblBooks.AddedBy WHERE tblBooks.BookNo LIKE '" + txtBookNO.Text + "' ",clsConnections.CN);
			DataSet ds	= new DataSet();
			da.Fill(ds,"tblBooks");

			totalRow	= ds.Tables["tblBooks"].Rows.Count -1;

			sAddedBy	= ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString();
			sDateAdd	= ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(2).ToString();
			sModifyBy	= ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(3).ToString();
			sDateModify = ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(4).ToString();

			MessageBox.Show("Date Added: " + sDateAdd + "\nAdded By: " + sAddedBy + "\n\nLast Modified: " + sModifyBy + "\nModified By:" + sDateModify ,"Midification History",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void bttnBarrowed_Click(object sender, System.EventArgs e)
		{
			FORMBarrowedBooks_Barrowers.sBookNumber = txtBookNO.Text;
			FORMBarrowedBooks_Barrowers sForm = new FORMBarrowedBooks_Barrowers();
			sForm.ShowDialog();
		}

		private void bttnCategory_Click(object sender, System.EventArgs e)
		{
			FORMCategory_View.sCATBooks = "Categories";
			FORMCategory_View sForm = new FORMCategory_View();
			sForm.ShowDialog();
		}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			if(txtBookNO.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Book Number");
				txtBookNO.Focus();
			}
			else if(txtISBN.Text  == "")
			{
				clsFunctions.isTextEmptyMsg("ISBN");
				txtISBN.Focus();
			}				
			else if(txtAuthor.Text  == "")
			{
				clsFunctions.isTextEmptyMsg("Author");
				txtAuthor.Focus();
			}					
			else if(txtBookTitle.Text  == "")
			{
				clsFunctions.isTextEmptyMsg("Book Title");
				txtBookTitle.Focus();
			}			
			else if(txtCategory.Text  == "")
			{
				clsFunctions.isTextEmptyMsg("Category");
				txtCategory.Focus();
			}		
			else if(txtPublished.Text.Length < 4)
			{
				MessageBox.Show("Pls. enter the correct year that Book was Published",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}	
			else if(txtQuantity.Text  == "")
			{
				clsFunctions.isTextEmptyMsg("Quantity");
				txtQuantity.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT BookNo FROM tblBooks WHERE BookNo LIKE '" + txtBookNO.Text + "' ","tblBooks") == true)
			{
				MessageBox.Show("Book Number already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtBookNO.Focus();
			}
			else
			{
				cmdAddBook.Parameters["@getBookNo"].Value=txtBookNO.Text;
				cmdAddBook.Parameters["@getISBN"].Value=txtISBN.Text;
				cmdAddBook.Parameters["@getAuthor"].Value=txtAuthor.Text;
				cmdAddBook.Parameters["@getBookTitle"].Value=txtBookTitle.Text;
				cmdAddBook.Parameters["@getCategoryIndex"].Value=iCategory;
				cmdAddBook.Parameters["@getYearPublished"].Value=txtPublished.Text;
				cmdAddBook.Parameters["@getDateArrived"].Value=dtArrived.Text;
				cmdAddBook.Parameters["@getPrice"].Value=(double.Parse(txtPrice.Text));
				cmdAddBook.Parameters["@getQty"].Value=(double.Parse(txtQuantity.Text));
				cmdAddBook.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddBook.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();
				cmdAddBook.Parameters["@getModifyBy"].Value = clsVariables.sLibrarianID;
				cmdAddBook.Parameters["@getDateModify"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddBook.ExecuteNonQuery();

				if(ADD_STATE==false)
				{
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				FORMBooks.publicBooksList.tabCategory_SelectedIndexChanged(sender, e);
				this.Close();
			}
		}

	}
}
