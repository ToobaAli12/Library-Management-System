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
	public class FORMBarrowedBooks_New : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sSY;
		public static string sLevel;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdAddBarrowed;
		OleDbCommand cmdUpdateBook;

		//OTHER VARIABLES
		public static FORMBarrowedBooks_New publicBarrowedList;

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtBookNO;
		private System.Windows.Forms.Button bttnBookNO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnStudentID;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtBarrowed;
		private System.Windows.Forms.Label label5;
		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.DateTimePicker dtDueDate;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.TextBox txtBarrowerName;
		private System.Windows.Forms.TextBox txtBarrowerID;
		private System.Windows.Forms.TextBox textBookTitle;

		private System.ComponentModel.Container components = null;

		public FORMBarrowedBooks_New(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBarrowedBooks_New));
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.txtBookNO = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.bttnBookNO = new System.Windows.Forms.Button();
			this.textBookTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBarrowerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBarrowerID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnStudentID = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.dtBarrowed = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtDueDate = new System.Windows.Forms.DateTimePicker();
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 64);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(328, 2);
			this.ctrlSeparator1.TabIndex = 159;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 40);
			this.label1.TabIndex = 158;
			this.label1.Text = "Fill all the fields bellow and click \'Update\' or \'Save\' button to be able to Add " +
				"or Save changes in records.Click \'Cancel\' if you want to cancel.";
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 157;
			this.picLOGO.TabStop = false;
			// 
			// txtBookNO
			// 
			this.txtBookNO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBookNO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBookNO.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtBookNO.Location = new System.Drawing.Point(98, 80);
			this.txtBookNO.Name = "txtBookNO";
			this.txtBookNO.ReadOnly = true;
			this.txtBookNO.Size = new System.Drawing.Size(211, 20);
			this.txtBookNO.TabIndex = 196;
			this.txtBookNO.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(10, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 17);
			this.label14.TabIndex = 195;
			this.label14.Text = "&Book Number:";
			// 
			// bttnBookNO
			// 
			this.bttnBookNO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnBookNO.Image = ((System.Drawing.Image)(resources.GetObject("bttnBookNO.Image")));
			this.bttnBookNO.Location = new System.Drawing.Point(312, 79);
			this.bttnBookNO.Name = "bttnBookNO";
			this.bttnBookNO.Size = new System.Drawing.Size(21, 20);
			this.bttnBookNO.TabIndex = 194;
			this.bttnBookNO.Click += new System.EventHandler(this.bttnBookNO_Click);
			// 
			// textBookTitle
			// 
			this.textBookTitle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBookTitle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBookTitle.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.textBookTitle.Location = new System.Drawing.Point(98, 109);
			this.textBookTitle.Name = "textBookTitle";
			this.textBookTitle.ReadOnly = true;
			this.textBookTitle.Size = new System.Drawing.Size(238, 20);
			this.textBookTitle.TabIndex = 198;
			this.textBookTitle.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 197;
			this.label2.Text = "&Book Title:";
			// 
			// txtBarrowerName
			// 
			this.txtBarrowerName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBarrowerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBarrowerName.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtBarrowerName.Location = new System.Drawing.Point(98, 169);
			this.txtBarrowerName.Name = "txtBarrowerName";
			this.txtBarrowerName.ReadOnly = true;
			this.txtBarrowerName.Size = new System.Drawing.Size(238, 20);
			this.txtBarrowerName.TabIndex = 203;
			this.txtBarrowerName.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 17);
			this.label3.TabIndex = 202;
			this.label3.Text = "&Barrower Name:";
			// 
			// txtBarrowerID
			// 
			this.txtBarrowerID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBarrowerID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBarrowerID.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtBarrowerID.Location = new System.Drawing.Point(98, 140);
			this.txtBarrowerID.Name = "txtBarrowerID";
			this.txtBarrowerID.ReadOnly = true;
			this.txtBarrowerID.Size = new System.Drawing.Size(211, 20);
			this.txtBarrowerID.TabIndex = 201;
			this.txtBarrowerID.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 200;
			this.label4.Text = "&Barrower ID:";
			// 
			// bttnStudentID
			// 
			this.bttnStudentID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnStudentID.Image = ((System.Drawing.Image)(resources.GetObject("bttnStudentID.Image")));
			this.bttnStudentID.Location = new System.Drawing.Point(312, 139);
			this.bttnStudentID.Name = "bttnStudentID";
			this.bttnStudentID.Size = new System.Drawing.Size(21, 20);
			this.bttnStudentID.TabIndex = 199;
			this.bttnStudentID.Click += new System.EventHandler(this.bttnStudentID_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 17);
			this.label7.TabIndex = 204;
			this.label7.Text = "&Date Barrowed:";
			// 
			// dtBarrowed
			// 
			this.dtBarrowed.CustomFormat = "MMMM/dd/yyyy";
			this.dtBarrowed.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtBarrowed.Location = new System.Drawing.Point(98, 199);
			this.dtBarrowed.Name = "dtBarrowed";
			this.dtBarrowed.Size = new System.Drawing.Size(213, 21);
			this.dtBarrowed.TabIndex = 205;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 17);
			this.label5.TabIndex = 206;
			this.label5.Text = "&Date Due:";
			// 
			// dtDueDate
			// 
			this.dtDueDate.CustomFormat = "MMMM/dd/yyyy";
			this.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtDueDate.Location = new System.Drawing.Point(98, 232);
			this.dtDueDate.Name = "dtDueDate";
			this.dtDueDate.Size = new System.Drawing.Size(213, 21);
			this.dtDueDate.TabIndex = 207;
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(8, 271);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(328, 2);
			this.ctrlSeparator2.TabIndex = 209;
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(171, 281);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(80, 25);
			this.bttnUpdate.TabIndex = 211;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(257, 281);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 210;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// FORMBarrowedBooks_New
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(344, 312);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBarrowerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBarrowerID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBookTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBookNO);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dtDueDate);
			this.Controls.Add(this.dtBarrowed);
			this.Controls.Add(this.bttnStudentID);
			this.Controls.Add(this.bttnBookNO);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBarrowedBooks_New";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Barrowed Book";
			this.Load += new System.EventHandler(this.FORMBarrowedBooks_New_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowedBooks_New_Load(object sender, System.EventArgs e)
		{
			picLOGO.Image =MDIFORM.i32x32.Images[13];

			//Set Add OleDbCommand
			cmdAddBarrowed = new OleDbCommand("INSERT INTO tblBarrowed(BookNo,BarrowerID,DateBarrowed,DateDue,AddedBy,DateAdd) VALUES(@getBookNo,@getBarrowerID,@getDateBarrowed,@getDateDue,@getAddedBy,@getDateAdd)",clsConnections.CN);

			cmdAddBarrowed.Parameters.Add("@getBookNo",OleDbType.VarChar);
			cmdAddBarrowed.Parameters.Add("@getBarrowerID",OleDbType.VarChar);
			cmdAddBarrowed.Parameters.Add("@getDateBarrowed",OleDbType.Date);
			cmdAddBarrowed.Parameters.Add("@getDateDue",OleDbType.Date);
			cmdAddBarrowed.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddBarrowed.Parameters.Add("@getDateAdd",OleDbType.Date);

			publicBarrowedList = this;
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnBookNO_Click(object sender, System.EventArgs e)
		{
			FORMBooks_View sForm = new FORMBooks_View();
			sForm.ShowDialog();
		}

		private void bttnStudentID_Click(object sender, System.EventArgs e)
		{
			FORMBarrowers_View.sSY		= sSY;
			FORMBarrowers_View.sLevel	= sLevel;
			FORMBarrowers_View sForm	= new FORMBarrowers_View();
			sForm.ShowDialog();
		}

		public void setBook(string sBookNumber, string sBookTitle)
		{
			txtBookNO.Text		= sBookNumber;
			textBookTitle.Text	= sBookTitle;
		}

		public void setBarrower(string sBarrowerID, string sBarrowerName)
		{
			txtBarrowerID.Text	 = sBarrowerID;
			txtBarrowerName.Text = sBarrowerName;
		}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			if(txtBarrowerID.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Barrower ID");
				txtBarrowerID.Focus();
			}
			else if(txtBookNO.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Book Number");
				txtBookNO.Focus();
			}
			else
			{
				long iBarrowed=0;
				long iTotal=0;

				cmdAddBarrowed.Parameters["@getBookNo"].Value		= txtBookNO.Text;
				cmdAddBarrowed.Parameters["@getBarrowerID"].Value	= txtBarrowerID.Text;
				cmdAddBarrowed.Parameters["@getDateBarrowed"].Value	= dtBarrowed.Text;
				cmdAddBarrowed.Parameters["@getDateDue"].Value		= dtDueDate.Text;
				cmdAddBarrowed.Parameters["@getAddedBy"].Value		= clsVariables.sLibrarianID;
				cmdAddBarrowed.Parameters["@getDateAdd"].Value		= DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				long totalRow =0;

				//Set the Data Adapter
				OleDbDataAdapter da = new OleDbDataAdapter("SELECT BookNo, Barrowed FROM tblBooks WHERE tblBooks.BookNo LIKE '" + txtBookNO.Text + "' ",clsConnections.CN);
				DataSet ds = new DataSet();
				da.Fill(ds,"tblBooks");

				totalRow = ds.Tables["tblBooks"].Rows.Count -1;

				iBarrowed = Convert.ToInt32(ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString());
				iTotal = iBarrowed + 1;

				cmdUpdateBook = new OleDbCommand("UPDATE tblBooks SET Barrowed = @getBarrowed WHERE BookNo LIKE '" + txtBookNO.Text + "' " ,clsConnections.CN);
				cmdUpdateBook.Parameters.Add("@getBarrowed",OleDbType.Double);
				cmdUpdateBook.Parameters["@getBarrowed"].Value		= iTotal;
				
				cmdUpdateBook.ExecuteNonQuery();
				cmdAddBarrowed.ExecuteNonQuery();

				FORMBarrowedBooks.publicBarrowedList.setLoading();
				MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);

				this.Close();
			}
		}
	}
}
