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
	public class FORMLibrarian_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		string imgPath = "";
		string imgName = "";

		public static string sLibrarianID;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdAddLibrarian;

		//OTHER VARIABLES
		public static FORMLibrarian_Modify publcLibrarianList;
		public static bool ADD_STATE;

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLibraryID;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStreetAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button bttnZipCode;
		private System.Windows.Forms.Button bttnPicture;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Button bttnEmailAdd;
		private System.Windows.Forms.TextBox txtEmailAdd;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserID;
		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnReset;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.PictureBox picLibrarian;

		private System.ComponentModel.Container components = null;

		public FORMLibrarian_Modify(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMLibrarian_Modify));
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.txtLibraryID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStreetAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.bttnZipCode = new System.Windows.Forms.Button();
			this.bttnPicture = new System.Windows.Forms.Button();
			this.picLibrarian = new System.Windows.Forms.PictureBox();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.bttnEmailAdd = new System.Windows.Forms.Button();
			this.txtEmailAdd = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtUserID = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnReset = new System.Windows.Forms.Button();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 50);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(453, 2);
			this.ctrlSeparator1.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 40);
			this.label1.TabIndex = 32;
			this.label1.Text = "Fill all the fields bellow and click \'Update\' or \'Save\' button to be able to Add " +
				"or Save changes in records.Click \'Reset\'  to clear all fields and \'Cancel\'  if y" +
				"ou want to cancel.";
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 31;
			this.picLOGO.TabStop = false;
			// 
			// txtLibraryID
			// 
			this.txtLibraryID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtLibraryID.Location = new System.Drawing.Point(95, 63);
			this.txtLibraryID.Name = "txtLibraryID";
			this.txtLibraryID.Size = new System.Drawing.Size(209, 20);
			this.txtLibraryID.TabIndex = 35;
			this.txtLibraryID.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 34;
			this.label2.Text = "&Library ID:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(95, 89);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(209, 20);
			this.txtFirstName.TabIndex = 37;
			this.txtFirstName.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 36;
			this.label3.Text = "&First Name:";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(95, 115);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(209, 20);
			this.txtMiddleName.TabIndex = 39;
			this.txtMiddleName.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 38;
			this.label4.Text = "&Middle Name:";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(95, 141);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(209, 20);
			this.txtLastName.TabIndex = 41;
			this.txtLastName.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 17);
			this.label5.TabIndex = 40;
			this.label5.Text = "&Last Name:";
			// 
			// txtStreetAddress
			// 
			this.txtStreetAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtStreetAddress.Location = new System.Drawing.Point(95, 167);
			this.txtStreetAddress.Name = "txtStreetAddress";
			this.txtStreetAddress.Size = new System.Drawing.Size(233, 20);
			this.txtStreetAddress.TabIndex = 43;
			this.txtStreetAddress.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 17);
			this.label6.TabIndex = 42;
			this.label6.Text = "&Street Address:";
			// 
			// txtCity
			// 
			this.txtCity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCity.Location = new System.Drawing.Point(95, 197);
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(209, 20);
			this.txtCity.TabIndex = 45;
			this.txtCity.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 197);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 17);
			this.label7.TabIndex = 44;
			this.label7.Text = "&City/Town:";
			// 
			// txtProvince
			// 
			this.txtProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtProvince.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtProvince.Location = new System.Drawing.Point(95, 225);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.ReadOnly = true;
			this.txtProvince.Size = new System.Drawing.Size(209, 20);
			this.txtProvince.TabIndex = 47;
			this.txtProvince.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 225);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 17);
			this.label8.TabIndex = 46;
			this.label8.Text = "&State/Province:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtZipCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtZipCode.Location = new System.Drawing.Point(95, 255);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.ReadOnly = true;
			this.txtZipCode.Size = new System.Drawing.Size(161, 20);
			this.txtZipCode.TabIndex = 49;
			this.txtZipCode.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(7, 255);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 17);
			this.label9.TabIndex = 48;
			this.label9.Text = "&Zip Code:";
			// 
			// bttnZipCode
			// 
			this.bttnZipCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnZipCode.Image = ((System.Drawing.Image)(resources.GetObject("bttnZipCode.Image")));
			this.bttnZipCode.Location = new System.Drawing.Point(258, 255);
			this.bttnZipCode.Name = "bttnZipCode";
			this.bttnZipCode.Size = new System.Drawing.Size(21, 20);
			this.bttnZipCode.TabIndex = 50;
			this.bttnZipCode.Click += new System.EventHandler(this.bttnZipCode_Click);
			// 
			// bttnPicture
			// 
			this.bttnPicture.BackColor = System.Drawing.SystemColors.Control;
			this.bttnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnPicture.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnPicture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPicture.Location = new System.Drawing.Point(368, 166);
			this.bttnPicture.Name = "bttnPicture";
			this.bttnPicture.Size = new System.Drawing.Size(88, 24);
			this.bttnPicture.TabIndex = 131;
			this.bttnPicture.Text = "Change Picture";
			this.bttnPicture.Click += new System.EventHandler(this.bttnPicture_Click);
			// 
			// picLibrarian
			// 
			this.picLibrarian.BackColor = System.Drawing.Color.White;
			this.picLibrarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLibrarian.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.picLibrarian.Location = new System.Drawing.Point(368, 62);
			this.picLibrarian.Name = "picLibrarian";
			this.picLibrarian.Size = new System.Drawing.Size(88, 96);
			this.picLibrarian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLibrarian.TabIndex = 130;
			this.picLibrarian.TabStop = false;
			// 
			// txtContactNo
			// 
			this.txtContactNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtContactNo.Location = new System.Drawing.Point(95, 283);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(185, 20);
			this.txtContactNo.TabIndex = 133;
			this.txtContactNo.Text = "";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(5, 283);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 17);
			this.label10.TabIndex = 132;
			this.label10.Text = "&Contact Number:";
			// 
			// bttnEmailAdd
			// 
			this.bttnEmailAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnEmailAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnEmailAdd.Image")));
			this.bttnEmailAdd.Location = new System.Drawing.Point(282, 311);
			this.bttnEmailAdd.Name = "bttnEmailAdd";
			this.bttnEmailAdd.Size = new System.Drawing.Size(21, 20);
			this.bttnEmailAdd.TabIndex = 136;
			this.bttnEmailAdd.Click += new System.EventHandler(this.bttnEmailAdd_Click);
			// 
			// txtEmailAdd
			// 
			this.txtEmailAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEmailAdd.ForeColor = System.Drawing.Color.Blue;
			this.txtEmailAdd.Location = new System.Drawing.Point(95, 311);
			this.txtEmailAdd.Name = "txtEmailAdd";
			this.txtEmailAdd.Size = new System.Drawing.Size(185, 20);
			this.txtEmailAdd.TabIndex = 135;
			this.txtEmailAdd.Text = "";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 312);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 17);
			this.label11.TabIndex = 134;
			this.label11.Text = "&Email Address:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(96, 379);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(211, 20);
			this.txtPassword.TabIndex = 140;
			this.txtPassword.Text = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 379);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 17);
			this.label12.TabIndex = 139;
			this.label12.Text = "User &Password:";
			// 
			// txtUserID
			// 
			this.txtUserID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUserID.Location = new System.Drawing.Point(96, 352);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.Size = new System.Drawing.Size(211, 20);
			this.txtUserID.TabIndex = 138;
			this.txtUserID.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 352);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 17);
			this.label13.TabIndex = 137;
			this.label13.Text = "&User Name:";
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(8, 413);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(450, 2);
			this.ctrlSeparator2.TabIndex = 142;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(371, 427);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(88, 26);
			this.bttnCancel.TabIndex = 0;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnReset
			// 
			this.bttnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReset.Location = new System.Drawing.Point(277, 427);
			this.bttnReset.Name = "bttnReset";
			this.bttnReset.Size = new System.Drawing.Size(88, 26);
			this.bttnReset.TabIndex = 146;
			this.bttnReset.Text = "&Reset";
			this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(182, 427);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(88, 26);
			this.bttnUpdate.TabIndex = 147;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// FORMLibrarian_Modify
			// 
			this.AcceptButton = this.bttnUpdate;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(466, 464);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnReset);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtUserID);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtEmailAdd);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtContactNo);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtProvince);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtStreetAddress);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLibraryID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnEmailAdd);
			this.Controls.Add(this.bttnPicture);
			this.Controls.Add(this.picLibrarian);
			this.Controls.Add(this.bttnZipCode);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMLibrarian_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMLibrarian_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMLibrarian_Modify_Load(object sender, System.EventArgs e)
		{
			if(ADD_STATE == true)
			{
				picLOGO.Image =MDIFORM.i32x32.Images[13];

				//Set Add OleDbCommand
				cmdAddLibrarian = new OleDbCommand("INSERT INTO tblLibrarian(LibrarianID,FirstName,MiddleName,LastName,StreetAddress,ZipCode,ContactNo,EmailAddress,UserName,UPassword) VALUES(@getLibrarianID,@getFirstName,@getMiddleName,@getLastName,@getStreetAddress,@getZipCode,@getContactNo,@getEmailAddress,@getUserName,@getUPassword)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				picLOGO.Image =MDIFORM.i32x32.Images[14];

				//Picture Details
				try
				{
					if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + sLibrarianID + ".lms") == true)
					{picLibrarian.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + sLibrarianID + ".lms" ,true);}
				}
				catch(Exception ex){}

				txtLibraryID.ReadOnly=true;

				//Set Edit OleDbCommand
				cmdAddLibrarian = new OleDbCommand("UPDATE tblLibrarian SET LibrarianID =@getLibrarianID, FirstName =@getFirstName, MiddleName =@getMiddleName, LastName =@getLastName, StreetAddress =@getStreetAddress, ZipCode =@getZipCode, ContactNo =@getContactNo, EmailAddress =@getEmailAddress, UserName =@getUserName, UPassword =@getUPassword WHERE LibrarianID LIKE '" + sLibrarianID + "' " ,clsConnections.CN);
				FillFields();
				this.Text = "Edit Existing";
			}

			cmdAddLibrarian.Parameters.Add("@getLibrarianID",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getFirstName",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getMiddleName",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getLastName",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getStreetAddress",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getZipCode",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getContactNo",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getEmailAddress",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getUserName",OleDbType.VarChar);
			cmdAddLibrarian.Parameters.Add("@getUPassword",OleDbType.VarChar);

			publcLibrarianList = this;
		}

		private void FillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblLibrarian.LibrarianID,  tblLibrarian.FirstName,  tblLibrarian.MiddleName,  tblLibrarian.LastName, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName,  tblLibrarian.UPassword FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode WHERE tblLibrarian.LibrarianID LIKE '" + sLibrarianID + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblLibrarian");

			totalRow = ds.Tables["tblLibrarian"].Rows.Count -1;

			txtLibraryID.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(0).ToString();
			txtFirstName.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(1).ToString();
			txtMiddleName.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(2).ToString();
			txtLastName.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(3).ToString();
			txtStreetAddress.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(4).ToString();
			txtCity.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(5).ToString();
			txtProvince.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(6).ToString();
			txtZipCode.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(7).ToString();
			txtContactNo.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(8).ToString();
			txtEmailAdd.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(9).ToString();
			txtUserID.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(10).ToString();
			txtPassword.Text=ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(11).ToString();
		}

		private void bttnPicture_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openIMG = new OpenFileDialog();

			try
			{
				openIMG.Filter="Known graphics format (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png";
				openIMG.ShowDialog();
				imgPath = openIMG.FileName;
				if(imgPath != ""){picLibrarian.Image = Image.FromFile(imgPath);}
			}
			catch(Exception ex){}
		}

		private void bttnReset_Click(object sender, System.EventArgs e)
		{
			//Clear All TextFields
			txtFirstName.Clear();
			txtMiddleName.Clear();
			txtLastName.Clear();
			txtStreetAddress.Clear();
			txtCity.Clear();
			txtProvince.Clear();
			txtZipCode.Clear();
			txtContactNo.Clear();
			txtEmailAdd.Clear();
			txtUserID.Clear();
			txtPassword.Clear();
		}

		private void bttnZipCode_Click(object sender, System.EventArgs e)
		{
			FORMZipCodes_View.sZipLibriran = "Librarian";
			FORMZipCodes_View sForm = new FORMZipCodes_View();
			sForm.ShowDialog();
		}

		public void setAreas(string sCity, string sProvince, string sZipCode)
		{
			txtCity.Text=sCity;
			txtProvince.Text=sProvince;
			txtZipCode.Text=sZipCode;
		}

		private void bttnEmailAdd_Click(object sender, System.EventArgs e)
		{
			if( txtEmailAdd.Text  != "" )
			{
				System.Diagnostics.Process.Start("mailto:" + txtEmailAdd.Text + "?subject=Attn: "+ txtFirstName.Text + " " + txtLastName.Text  +"&body=");
			}
		}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			if(txtLibraryID.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Library ID");
				txtLibraryID.Focus();
			}
			else if(txtFirstName.Text == "" || txtLastName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Complete Name");
				txtLastName.Focus();
			}
			else if(txtZipCode.Text == "" || txtProvince.Text == "" || txtCity.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Area");
				txtZipCode.Focus();
			}
			else if(txtContactNo.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Contact Number");
				txtContactNo.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT LibrarianID FROM tblLibrarian WHERE LibrarianID LIKE '" + txtLibraryID.Text + "' ","tblLibrarian") == true)
			{
				MessageBox.Show("Librarian already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtLibraryID.Focus();
			}
			else if(clsFunctions.recordExist("SELECT UserName FROM tblLibrarian WHERE UserName LIKE '" + txtUserID.Text + "' ","tblLibrarian") == true)
			{
				MessageBox.Show("UserName already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtUserID.Focus();
			}
			else
			{
				cmdAddLibrarian.Parameters["@getLibrarianID"].Value=txtLibraryID.Text;
				cmdAddLibrarian.Parameters["@getFirstName"].Value = txtFirstName.Text;
				cmdAddLibrarian.Parameters["@getMiddleName"].Value=txtMiddleName.Text;
				cmdAddLibrarian.Parameters["@getLastName"].Value = txtLastName.Text;
				cmdAddLibrarian.Parameters["@getStreetAddress"].Value=txtStreetAddress.Text;
				cmdAddLibrarian.Parameters["@getZipCode"].Value = txtZipCode.Text;
				cmdAddLibrarian.Parameters["@getContactNo"].Value=txtContactNo.Text;
				cmdAddLibrarian.Parameters["@getEmailAddress"].Value = txtEmailAdd.Text;
				cmdAddLibrarian.Parameters["@getUserName"].Value=txtUserID.Text;
				cmdAddLibrarian.Parameters["@getUPassword"].Value = txtPassword.Text;
								
				cmdAddLibrarian.ExecuteNonQuery();

				FORMLibrarian.publcLibrarianList.removePic();
				imgName = sLibrarianID + ".lms";
				
				if(ADD_STATE==false)
				{
					if(imgPath != "")
					{
						File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + imgName);
						File.Copy(imgPath,AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + imgName, true);
					}
					FORMLibrarian.publcLibrarianList.reload_current();
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					if(imgPath == ""){imgName = "";}
					else
					{
						File.Copy(imgPath,AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + txtLibraryID.Text + ".lms", true);
					}
					FORMLibrarian.publcLibrarianList.loadLibrarians("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode ORDER BY tblLibrarian.LibrarianID ASC");
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

				
				this.Close();
			}
		}
	}
}
