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
	public class FORMBarrowedBooks_Returned : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		string sAddedBy;
		string sDateAdd;
		string sModifyBy;
		string sDateModify;

		public static string sBookID;
		public static string sBookTitle;
		public static string sBarrowerID;
		public static string sBarrowerName;
		public static string sDTBrrwd;
		public static string sDTDue;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdUpdateReturn;
		OleDbCommand cmdUpdateBook;

		//OTHER VARIABLES
		public static FORMBarrowedBooks_Returned publicReturnList;

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBookNO;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtDateDue;
		private System.Windows.Forms.TextBox txtDateBarrowed;
		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDelayed;
		private System.Windows.Forms.TextBox txtFined;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnCalculator;
		private System.Windows.Forms.Button bttnModification;
		private System.Windows.Forms.TextBox txtBarrowerName;
		private System.Windows.Forms.TextBox txtBarrowerID;
		private System.Windows.Forms.DateTimePicker dtReturn;
		private System.Windows.Forms.TextBox txtBookTitle;
		private System.Windows.Forms.TextBox txtNote;

		private System.ComponentModel.Container components = null;

		public FORMBarrowedBooks_Returned(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBarrowedBooks_Returned));
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBarrowerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBarrowerID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBookNO = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtDateDue = new System.Windows.Forms.TextBox();
			this.txtDateBarrowed = new System.Windows.Forms.TextBox();
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.label6 = new System.Windows.Forms.Label();
			this.dtReturn = new System.Windows.Forms.DateTimePicker();
			this.txtDelayed = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFined = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnCalculator = new System.Windows.Forms.Button();
			this.bttnModification = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 48);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(616, 2);
			this.ctrlSeparator1.TabIndex = 159;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(576, 40);
			this.label1.TabIndex = 158;
			this.label1.Text = "Fill all the fields bellow and click \'Update\' or \'Save\' button to be able to Add " +
				"or Save changes in records. Click Cancel\'  if you want to cancel.";
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 157;
			this.picLOGO.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 17);
			this.label5.TabIndex = 220;
			this.label5.Text = "&Date Due:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 17);
			this.label7.TabIndex = 218;
			this.label7.Text = "&Date Barrowed:";
			// 
			// txtBarrowerName
			// 
			this.txtBarrowerName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBarrowerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBarrowerName.ForeColor = System.Drawing.Color.Black;
			this.txtBarrowerName.Location = new System.Drawing.Point(96, 147);
			this.txtBarrowerName.Name = "txtBarrowerName";
			this.txtBarrowerName.ReadOnly = true;
			this.txtBarrowerName.Size = new System.Drawing.Size(192, 20);
			this.txtBarrowerName.TabIndex = 217;
			this.txtBarrowerName.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 17);
			this.label3.TabIndex = 216;
			this.label3.Text = "&Barrower Name:";
			// 
			// txtBarrowerID
			// 
			this.txtBarrowerID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBarrowerID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBarrowerID.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(192)));
			this.txtBarrowerID.Location = new System.Drawing.Point(96, 118);
			this.txtBarrowerID.Name = "txtBarrowerID";
			this.txtBarrowerID.ReadOnly = true;
			this.txtBarrowerID.Size = new System.Drawing.Size(168, 20);
			this.txtBarrowerID.TabIndex = 215;
			this.txtBarrowerID.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 214;
			this.label4.Text = "&Barrower ID:";
			// 
			// txtBookTitle
			// 
			this.txtBookTitle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBookTitle.Location = new System.Drawing.Point(96, 88);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.ReadOnly = true;
			this.txtBookTitle.Size = new System.Drawing.Size(168, 21);
			this.txtBookTitle.TabIndex = 236;
			this.txtBookTitle.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 211;
			this.label2.Text = "&Book Title:";
			// 
			// txtBookNO
			// 
			this.txtBookNO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBookNO.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBookNO.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtBookNO.Location = new System.Drawing.Point(96, 64);
			this.txtBookNO.Name = "txtBookNO";
			this.txtBookNO.ReadOnly = true;
			this.txtBookNO.Size = new System.Drawing.Size(168, 20);
			this.txtBookNO.TabIndex = 210;
			this.txtBookNO.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(76, 17);
			this.label14.TabIndex = 209;
			this.label14.Text = "&Book Number:";
			// 
			// txtDateDue
			// 
			this.txtDateDue.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtDateDue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDateDue.ForeColor = System.Drawing.Color.Black;
			this.txtDateDue.Location = new System.Drawing.Point(96, 203);
			this.txtDateDue.Name = "txtDateDue";
			this.txtDateDue.ReadOnly = true;
			this.txtDateDue.Size = new System.Drawing.Size(152, 20);
			this.txtDateDue.TabIndex = 222;
			this.txtDateDue.Text = "";
			// 
			// txtDateBarrowed
			// 
			this.txtDateBarrowed.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtDateBarrowed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDateBarrowed.ForeColor = System.Drawing.Color.Black;
			this.txtDateBarrowed.Location = new System.Drawing.Point(96, 176);
			this.txtDateBarrowed.Name = "txtDateBarrowed";
			this.txtDateBarrowed.ReadOnly = true;
			this.txtDateBarrowed.Size = new System.Drawing.Size(152, 20);
			this.txtDateBarrowed.TabIndex = 221;
			this.txtDateBarrowed.Text = "";
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(8, 240);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(616, 2);
			this.ctrlSeparator2.TabIndex = 223;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(336, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 17);
			this.label6.TabIndex = 224;
			this.label6.Text = "&Date Return:";
			// 
			// dtReturn
			// 
			this.dtReturn.CustomFormat = "MMMM/dd/yyyy";
			this.dtReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtReturn.Location = new System.Drawing.Point(472, 64);
			this.dtReturn.Name = "dtReturn";
			this.dtReturn.Size = new System.Drawing.Size(152, 21);
			this.dtReturn.TabIndex = 225;
			// 
			// txtDelayed
			// 
			this.txtDelayed.BackColor = System.Drawing.Color.White;
			this.txtDelayed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDelayed.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtDelayed.Location = new System.Drawing.Point(472, 91);
			this.txtDelayed.Name = "txtDelayed";
			this.txtDelayed.Size = new System.Drawing.Size(115, 20);
			this.txtDelayed.TabIndex = 227;
			this.txtDelayed.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(336, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 17);
			this.label8.TabIndex = 226;
			this.label8.Text = "&Days Delayed:";
			// 
			// txtFined
			// 
			this.txtFined.BackColor = System.Drawing.Color.White;
			this.txtFined.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFined.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtFined.Location = new System.Drawing.Point(472, 118);
			this.txtFined.Name = "txtFined";
			this.txtFined.Size = new System.Drawing.Size(115, 20);
			this.txtFined.TabIndex = 229;
			this.txtFined.Text = "0.00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(336, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 17);
			this.label9.TabIndex = 228;
			this.label9.Text = "&Fines:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(337, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 17);
			this.label10.TabIndex = 230;
			this.label10.Text = "&Notes:";
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(338, 162);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNote.Size = new System.Drawing.Size(288, 64);
			this.txtNote.TabIndex = 231;
			this.txtNote.Text = "";
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(458, 250);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(80, 25);
			this.bttnUpdate.TabIndex = 233;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(546, 250);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 232;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnCalculator
			// 
			this.bttnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("bttnCalculator.Image")));
			this.bttnCalculator.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCalculator.Location = new System.Drawing.Point(590, 119);
			this.bttnCalculator.Name = "bttnCalculator";
			this.bttnCalculator.Size = new System.Drawing.Size(19, 20);
			this.bttnCalculator.TabIndex = 234;
			this.bttnCalculator.Click += new System.EventHandler(this.bttnCalculator_Click);
			// 
			// bttnModification
			// 
			this.bttnModification.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnModification.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnModification.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnModification.Location = new System.Drawing.Point(8, 250);
			this.bttnModification.Name = "bttnModification";
			this.bttnModification.Size = new System.Drawing.Size(112, 25);
			this.bttnModification.TabIndex = 235;
			this.bttnModification.Text = "&Modification History";
			this.bttnModification.Click += new System.EventHandler(this.bttnModification_Click);
			// 
			// FORMBarrowedBooks_Returned
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(634, 288);
			this.Controls.Add(this.bttnModification);
			this.Controls.Add(this.bttnCalculator);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtFined);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtDelayed);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDateDue);
			this.Controls.Add(this.txtDateBarrowed);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBarrowerName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBarrowerID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBookTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBookNO);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dtReturn);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBarrowedBooks_Returned";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Return";
			this.Load += new System.EventHandler(this.FORMBarrowedBooks_Returned_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowedBooks_Returned_Load(object sender, System.EventArgs e)
		{
			picLOGO.Image= MDIFORM.i32x32.Images[19];

			cmdUpdateReturn = new OleDbCommand("UPDATE tblBarrowed SET DateRetured =@getDateRetured, DelayedDays =@getDelayedDays, Fines =@getFines, Notes =@getNotes, Returned =@getReturned, ModifyBy =@getModifyBy, DateModify =@getDateModify WHERE BookNo LIKE '" + sBookID + "' AND BarrowerID LIKE '" + sBarrowerID + "' AND DateBarrowed =#" + sDTBrrwd + "# AND DateDue =#" + sDTDue + "#" ,clsConnections.CN);

			FillFields();

			cmdUpdateReturn.Parameters.Add("@getDateRetured",OleDbType.Date);
			cmdUpdateReturn.Parameters.Add("@getDelayedDays",OleDbType.Double);
			cmdUpdateReturn.Parameters.Add("@getFines",OleDbType.Double);
			cmdUpdateReturn.Parameters.Add("@getNotes",OleDbType.VarChar);
			cmdUpdateReturn.Parameters.Add("@getReturned",OleDbType.Boolean);
			cmdUpdateReturn.Parameters.Add("@getModifyBy",OleDbType.VarChar);
			cmdUpdateReturn.Parameters.Add("@getDateModify",OleDbType.Date);
			
			publicReturnList = this;
		}

		private void FillFields()
		{
			txtBookNO.Text=sBookID;
			txtBookTitle.Text=sBookTitle;
			txtBarrowerName.Text=sBarrowerName;
			txtBarrowerID.Text=sBarrowerID;
			txtDateBarrowed.Text=sDTBrrwd;
			txtDateDue.Text=sDTDue;
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnModification_Click(object sender, System.EventArgs e)
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblBarrowed.BookNo, tblBarrowed.BarrowerID, [tblLibrarian.LastName] & ', ' & [tblLibrarian.FirstName] & ' ' & [tblLibrarian.MiddleName] AS AddedBys, tblBarrowed.DateAdd FROM tblLibrarian RIGHT JOIN tblBarrowed ON tblLibrarian.LibrarianID = tblBarrowed.AddedBy WHERE tblBarrowed.BookNo LIKE '" + sBookID + "' AND tblBarrowed.BarrowerID LIKE '" + sBarrowerID + "' ",clsConnections.CN);
			DataSet ds	= new DataSet();
			da.Fill(ds,"tblBarrowed");

			totalRow	= ds.Tables["tblBarrowed"].Rows.Count -1;

			sAddedBy	= ds.Tables["tblBarrowed"].Rows[0].ItemArray.GetValue(2).ToString();
			sDateAdd	= ds.Tables["tblBarrowed"].Rows[0].ItemArray.GetValue(3).ToString();

			MessageBox.Show("Date Added: " + sDateAdd + "\nAdded By: " + sAddedBy,"Midification History",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void bttnCalculator_Click(object sender, System.EventArgs e){clsApp.shell("Calc.exe","Calculator");}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			long iBarrowed=0;
			long iTotal=0;

			cmdUpdateReturn.Parameters["@getDateRetured"].Value=dtReturn.Text;
			cmdUpdateReturn.Parameters["@getDelayedDays"].Value=txtDelayed.Text;
			cmdUpdateReturn.Parameters["@getFines"].Value=txtFined.Text;
			cmdUpdateReturn.Parameters["@getNotes"].Value=txtNote.Text;
			cmdUpdateReturn.Parameters["@getReturned"].Value=true;
			cmdUpdateReturn.Parameters["@getModifyBy"].Value = clsVariables.sLibrarianID;
			cmdUpdateReturn.Parameters["@getDateModify"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT BookNo, Barrowed FROM tblBooks WHERE tblBooks.BookNo LIKE '" + sBookID + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblBooks");

			totalRow = ds.Tables["tblBooks"].Rows.Count -1;

			iBarrowed = Convert.ToInt32(ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString());
			iTotal = iBarrowed - 1;

			cmdUpdateBook = new OleDbCommand("UPDATE tblBooks SET Barrowed = @getBarrowed WHERE BookNo LIKE '" + sBookID + "' " ,clsConnections.CN);
			cmdUpdateBook.Parameters.Add("@getBarrowed",OleDbType.Double);
			cmdUpdateBook.Parameters["@getBarrowed"].Value		= iTotal;
				
			cmdUpdateBook.ExecuteNonQuery();
			cmdUpdateReturn.ExecuteNonQuery();

			FORMBarrowedBooks.publicBarrowedList.reload_current();
			MessageBox.Show("Record has been successfully updated.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
		
			this.Close();
		}
	}
}
