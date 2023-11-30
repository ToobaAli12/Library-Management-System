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
	public class FORMBarrowers_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		string imgPath = "";
		string imgName = "";

		public static string sBarrowerID;

		//INTEGERS VARIABLES
		int iCourse;
		int iLevel;
		int iSY;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdAddBarrower;

		//OTHER VARIABLES
		public static FORMBarrowers_Modify publicBarrowerList;
		public static bool ADD_STATE;

		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button bttnEmailAdd;
		private System.Windows.Forms.TextBox txtEmailAdd;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtContactNo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button bttnPicture;
		private System.Windows.Forms.Button bttnZipCode;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtStreetAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.TextBox txtLevelName;
		private System.Windows.Forms.TextBox txtCourseName;
		private System.Windows.Forms.Button bttnCourse;
		private System.Windows.Forms.Button bttnLevel;
		private System.Windows.Forms.Button bttnSY;
		private System.Windows.Forms.TextBox txtSchoolYear;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtBarrowerID;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.Button bttnReset;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.PictureBox picBarrower;
		private System.ComponentModel.Container components = null;

		public FORMBarrowers_Modify(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBarrowers_Modify));
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.txtLevelName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCourseName = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.bttnEmailAdd = new System.Windows.Forms.Button();
			this.txtEmailAdd = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtContactNo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.bttnPicture = new System.Windows.Forms.Button();
			this.bttnZipCode = new System.Windows.Forms.Button();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStreetAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBarrowerID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.bttnCourse = new System.Windows.Forms.Button();
			this.bttnLevel = new System.Windows.Forms.Button();
			this.bttnSY = new System.Windows.Forms.Button();
			this.txtSchoolYear = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.bttnReset = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.picBarrower = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(8, 439);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(488, 2);
			this.ctrlSeparator2.TabIndex = 181;
			// 
			// txtLevelName
			// 
			this.txtLevelName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLevelName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtLevelName.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtLevelName.Location = new System.Drawing.Point(95, 379);
			this.txtLevelName.Name = "txtLevelName";
			this.txtLevelName.ReadOnly = true;
			this.txtLevelName.Size = new System.Drawing.Size(209, 20);
			this.txtLevelName.TabIndex = 179;
			this.txtLevelName.Text = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(7, 379);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(66, 17);
			this.label12.TabIndex = 178;
			this.label12.Text = "Level Name:";
			// 
			// txtCourseName
			// 
			this.txtCourseName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCourseName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCourseName.Location = new System.Drawing.Point(95, 352);
			this.txtCourseName.Name = "txtCourseName";
			this.txtCourseName.ReadOnly = true;
			this.txtCourseName.Size = new System.Drawing.Size(209, 20);
			this.txtCourseName.TabIndex = 177;
			this.txtCourseName.Text = "";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 352);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(75, 17);
			this.label13.TabIndex = 176;
			this.label13.Text = "&Course Name:";
			// 
			// bttnEmailAdd
			// 
			this.bttnEmailAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnEmailAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnEmailAdd.Image")));
			this.bttnEmailAdd.Location = new System.Drawing.Point(282, 311);
			this.bttnEmailAdd.Name = "bttnEmailAdd";
			this.bttnEmailAdd.Size = new System.Drawing.Size(21, 20);
			this.bttnEmailAdd.TabIndex = 175;
			this.bttnEmailAdd.Click += new System.EventHandler(this.bttnEmailAdd_Click);
			// 
			// txtEmailAdd
			// 
			this.txtEmailAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEmailAdd.ForeColor = System.Drawing.Color.Blue;
			this.txtEmailAdd.Location = new System.Drawing.Point(95, 311);
			this.txtEmailAdd.Name = "txtEmailAdd";
			this.txtEmailAdd.Size = new System.Drawing.Size(185, 20);
			this.txtEmailAdd.TabIndex = 174;
			this.txtEmailAdd.Text = "";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 312);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 17);
			this.label11.TabIndex = 173;
			this.label11.Text = "&Email Address:";
			// 
			// txtContactNo
			// 
			this.txtContactNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtContactNo.Location = new System.Drawing.Point(95, 283);
			this.txtContactNo.Name = "txtContactNo";
			this.txtContactNo.Size = new System.Drawing.Size(185, 20);
			this.txtContactNo.TabIndex = 172;
			this.txtContactNo.Text = "";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(5, 283);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 17);
			this.label10.TabIndex = 171;
			this.label10.Text = "&Contact Number:";
			// 
			// bttnPicture
			// 
			this.bttnPicture.BackColor = System.Drawing.SystemColors.Control;
			this.bttnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnPicture.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnPicture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPicture.Location = new System.Drawing.Point(408, 158);
			this.bttnPicture.Name = "bttnPicture";
			this.bttnPicture.Size = new System.Drawing.Size(88, 24);
			this.bttnPicture.TabIndex = 170;
			this.bttnPicture.Text = "Change Picture";
			this.bttnPicture.Click += new System.EventHandler(this.bttnPicture_Click);
			// 
			// bttnZipCode
			// 
			this.bttnZipCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnZipCode.Image = ((System.Drawing.Image)(resources.GetObject("bttnZipCode.Image")));
			this.bttnZipCode.Location = new System.Drawing.Point(250, 255);
			this.bttnZipCode.Name = "bttnZipCode";
			this.bttnZipCode.Size = new System.Drawing.Size(21, 20);
			this.bttnZipCode.TabIndex = 168;
			this.bttnZipCode.Click += new System.EventHandler(this.bttnZipCode_Click);
			// 
			// txtZipCode
			// 
			this.txtZipCode.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtZipCode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtZipCode.Location = new System.Drawing.Point(95, 255);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.ReadOnly = true;
			this.txtZipCode.Size = new System.Drawing.Size(153, 20);
			this.txtZipCode.TabIndex = 167;
			this.txtZipCode.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(7, 255);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 17);
			this.label9.TabIndex = 166;
			this.label9.Text = "&Zip Code:";
			// 
			// txtProvince
			// 
			this.txtProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtProvince.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtProvince.Location = new System.Drawing.Point(95, 225);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.ReadOnly = true;
			this.txtProvince.Size = new System.Drawing.Size(209, 20);
			this.txtProvince.TabIndex = 165;
			this.txtProvince.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 225);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 17);
			this.label8.TabIndex = 164;
			this.label8.Text = "&State/Province:";
			// 
			// txtCity
			// 
			this.txtCity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtCity.Location = new System.Drawing.Point(95, 197);
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(209, 20);
			this.txtCity.TabIndex = 163;
			this.txtCity.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 197);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 17);
			this.label7.TabIndex = 162;
			this.label7.Text = "&City/Town:";
			// 
			// txtStreetAddress
			// 
			this.txtStreetAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtStreetAddress.Location = new System.Drawing.Point(95, 167);
			this.txtStreetAddress.Name = "txtStreetAddress";
			this.txtStreetAddress.Size = new System.Drawing.Size(233, 20);
			this.txtStreetAddress.TabIndex = 161;
			this.txtStreetAddress.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 17);
			this.label6.TabIndex = 160;
			this.label6.Text = "&Street Address:";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(95, 141);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(200, 20);
			this.txtLastName.TabIndex = 159;
			this.txtLastName.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 17);
			this.label5.TabIndex = 158;
			this.label5.Text = "&Last Name:";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(95, 115);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(200, 20);
			this.txtMiddleName.TabIndex = 157;
			this.txtMiddleName.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 156;
			this.label4.Text = "&Middle Name:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(95, 89);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(200, 20);
			this.txtFirstName.TabIndex = 155;
			this.txtFirstName.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 154;
			this.label3.Text = "&First Name:";
			// 
			// txtBarrowerID
			// 
			this.txtBarrowerID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtBarrowerID.Location = new System.Drawing.Point(95, 63);
			this.txtBarrowerID.Name = "txtBarrowerID";
			this.txtBarrowerID.Size = new System.Drawing.Size(201, 20);
			this.txtBarrowerID.TabIndex = 153;
			this.txtBarrowerID.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 152;
			this.label2.Text = "&Barrower ID:";
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(4, 50);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(491, 2);
			this.ctrlSeparator1.TabIndex = 151;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 40);
			this.label1.TabIndex = 150;
			this.label1.Text = "Fill all the fields bellow and click \'Update\' or \'Save\' button to be able to Add " +
				"or Save changes in records.Click \'Cancel\' if you want to cancel and Click Change" +
				" Picture to change picture.";
			// 
			// picLOGO
			// 
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(35, 31);
			this.picLOGO.TabIndex = 149;
			this.picLOGO.TabStop = false;
			// 
			// bttnCourse
			// 
			this.bttnCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCourse.Image = ((System.Drawing.Image)(resources.GetObject("bttnCourse.Image")));
			this.bttnCourse.Location = new System.Drawing.Point(306, 352);
			this.bttnCourse.Name = "bttnCourse";
			this.bttnCourse.Size = new System.Drawing.Size(21, 20);
			this.bttnCourse.TabIndex = 184;
			this.bttnCourse.Click += new System.EventHandler(this.bttnCourse_Click);
			// 
			// bttnLevel
			// 
			this.bttnLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnLevel.Image = ((System.Drawing.Image)(resources.GetObject("bttnLevel.Image")));
			this.bttnLevel.Location = new System.Drawing.Point(306, 379);
			this.bttnLevel.Name = "bttnLevel";
			this.bttnLevel.Size = new System.Drawing.Size(21, 20);
			this.bttnLevel.TabIndex = 185;
			this.bttnLevel.Click += new System.EventHandler(this.bttnLevel_Click);
			// 
			// bttnSY
			// 
			this.bttnSY.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSY.Image = ((System.Drawing.Image)(resources.GetObject("bttnSY.Image")));
			this.bttnSY.Location = new System.Drawing.Point(308, 408);
			this.bttnSY.Name = "bttnSY";
			this.bttnSY.Size = new System.Drawing.Size(21, 20);
			this.bttnSY.TabIndex = 188;
			this.bttnSY.Click += new System.EventHandler(this.bttnSY_Click);
			// 
			// txtSchoolYear
			// 
			this.txtSchoolYear.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtSchoolYear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtSchoolYear.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtSchoolYear.Location = new System.Drawing.Point(96, 408);
			this.txtSchoolYear.Name = "txtSchoolYear";
			this.txtSchoolYear.ReadOnly = true;
			this.txtSchoolYear.Size = new System.Drawing.Size(209, 20);
			this.txtSchoolYear.TabIndex = 190;
			this.txtSchoolYear.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 408);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(67, 17);
			this.label14.TabIndex = 189;
			this.label14.Text = "School Year:";
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(224, 452);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(88, 26);
			this.bttnUpdate.TabIndex = 196;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// bttnReset
			// 
			this.bttnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReset.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReset.Location = new System.Drawing.Point(317, 452);
			this.bttnReset.Name = "bttnReset";
			this.bttnReset.Size = new System.Drawing.Size(88, 26);
			this.bttnReset.TabIndex = 195;
			this.bttnReset.Text = "&Reset";
			this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(411, 452);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(88, 26);
			this.bttnCancel.TabIndex = 194;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// picBarrower
			// 
			this.picBarrower.BackColor = System.Drawing.Color.White;
			this.picBarrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBarrower.Location = new System.Drawing.Point(408, 62);
			this.picBarrower.Name = "picBarrower";
			this.picBarrower.Size = new System.Drawing.Size(86, 88);
			this.picBarrower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBarrower.TabIndex = 198;
			this.picBarrower.TabStop = false;
			// 
			// FORMBarrowers_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(506, 488);
			this.Controls.Add(this.picBarrower);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnReset);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.txtSchoolYear);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtLevelName);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtCourseName);
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
			this.Controls.Add(this.txtBarrowerID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnSY);
			this.Controls.Add(this.bttnLevel);
			this.Controls.Add(this.bttnCourse);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.bttnEmailAdd);
			this.Controls.Add(this.bttnPicture);
			this.Controls.Add(this.bttnZipCode);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBarrowers_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMBarrowers_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowers_Modify_Load(object sender, System.EventArgs e)
		{
			if(ADD_STATE == true)
			{
				picLOGO.Image =MDIFORM.i32x32.Images[13];

				//Set Add OleDbCommand
				cmdAddBarrower = new OleDbCommand("INSERT INTO tblBarrowers(BarrowerID,FirstName,MiddleName,LastName,StreetAddress,ZipCode,ContactNO,EmailAddress,Course,LevelIndex,SchoolYear,AddedBy,DateAdd) VALUES(@getBarrowerID,@getFirstName,@getMiddleName,@getLastName,@getStreetAddress,@getZipCode,@getContactNO,@getEmailAddress,@getCourse,@getLevelIndex,@getSchoolYear,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				picLOGO.Image =MDIFORM.i32x32.Images[14];
				//Picture Details
				try
				{
					if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + sBarrowerID + ".lms") == true)
					{
						picBarrower.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + sBarrowerID + ".lms" ,true);
					}
				}
				catch(Exception ex){}
				txtBarrowerID.ReadOnly=true;

				//Set Edit OleDbCommand
				cmdAddBarrower = new OleDbCommand("UPDATE tblBarrowers SET BarrowerID =@getBarrowerID, FirstName =@getFirstName, MiddleName =@getMiddleName, LastName =@getLastName, StreetAddress =@getStreetAddress, ZipCode =@getZipCode, ContactNO =@getContactNO, EmailAddress =@getEmailAddress, Course =@getCourse, LevelIndex =@getLevelIndex, SchoolYear =@getSchoolYear, ModifyBy =@getModifyBy, DateModify =@getDateModify WHERE BarrowerID LIKE '" + sBarrowerID + "' " ,clsConnections.CN);
				FillFields();
				this.Text = "Edit Existing";
			}

			cmdAddBarrower.Parameters.Add("@getBarrowerID",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getFirstName",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getMiddleName",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getLastName",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getStreetAddress",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getZipCode",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getContactNO",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getEmailAddress",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getCourse",OleDbType.Double);
			cmdAddBarrower.Parameters.Add("@getLevelIndex",OleDbType.Double);
			cmdAddBarrower.Parameters.Add("@getSchoolYear",OleDbType.Double);
			cmdAddBarrower.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getDateAdd",OleDbType.Date);
			cmdAddBarrower.Parameters.Add("@getModifyBy",OleDbType.VarChar);
			cmdAddBarrower.Parameters.Add("@getDateModify",OleDbType.Date);

			publicBarrowerList = this;
		}

		private void FillFields()
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblBarrowers.BarrowerID, tblBarrowers.FirstName, tblBarrowers.MiddleName, tblBarrowers.LastName, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, tblCourse.CourseName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.IndexCourse, tblLevel.IndexLevel, tblSchoolYear.IndexSY FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE tblBarrowers.BarrowerID LIKE '" + sBarrowerID + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblBarrowers");

			totalRow = ds.Tables["tblBarrowers"].Rows.Count -1;

			txtBarrowerID.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(0).ToString();
			txtFirstName.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(1).ToString();
			txtMiddleName.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(2).ToString();
			txtLastName.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(3).ToString();
			txtStreetAddress.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(4).ToString();
			txtCity.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(5).ToString();
			txtProvince.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(6).ToString();
			txtZipCode.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(7).ToString();
			txtContactNo.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(8).ToString();
			txtEmailAdd.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(9).ToString();
			txtCourseName.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(10).ToString();
			txtLevelName.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(11).ToString();
			txtSchoolYear.Text=ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(12).ToString();
		
			iCourse = Convert.ToInt32(ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(13).ToString());
			iLevel  = Convert.ToInt32(ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(14).ToString());
			iSY		= Convert.ToInt32(ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(15).ToString());
		}

		private void bttnZipCode_Click(object sender, System.EventArgs e)
		{
			FORMZipCodes_View.sZipBarrowers = "Barrowers";
			FORMZipCodes_View sForm = new FORMZipCodes_View();
			sForm.ShowDialog();
		}

		private void bttnCourse_Click(object sender, System.EventArgs e)
		{
			FORMCourse_View.sCourseBarrower = "Barrowers";
			FORMCourse_View sForm = new FORMCourse_View();
			sForm.ShowDialog();
		}

		private void bttnLevel_Click(object sender, System.EventArgs e)
		{
			FORMLevel_View.sLevelBarrower = "Barrowers";
			FORMLevel_View sForm = new FORMLevel_View();
			sForm.ShowDialog();
		}

		private void bttnSY_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Barrowers";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}

		private void bttnReset_Click(object sender, System.EventArgs e)
		{
			txtFirstName.Clear();
			txtMiddleName.Clear();
			txtLastName.Clear();
			txtStreetAddress.Clear();
			txtCity.Clear();
			txtProvince.Clear();
			txtZipCode.Clear();
			txtContactNo.Clear();
			txtEmailAdd.Clear();
			txtCourseName.Clear();
			txtLevelName.Clear();
			txtSchoolYear.Clear();
		}

		private void bttnPicture_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openIMG = new OpenFileDialog();

			try
			{
				openIMG.Filter="Known graphics format (*.bmp,*.jpg,*.gif,*.png)|*.bmp;*.jpg;*.gif;*.jpeg;*.png";
				openIMG.ShowDialog();
				imgPath = openIMG.FileName;
				if(imgPath != ""){picBarrower.Image = Image.FromFile(imgPath);}
			}
			catch(Exception ex){}
		}

		public void setAreas(string sCity, string sProvince, string sZipCode)
		{
			txtCity.Text=sCity;
			txtProvince.Text=sProvince;
			txtZipCode.Text=sZipCode;
		}

		public void setCourse(string sCourseName, string sIndexCourse)
		{
			txtCourseName.Text = sCourseName;
			iCourse = Convert.ToInt32(sIndexCourse);
		}

		public void setLevelName(string sLevelName, string sIndexLevel)
		{
			txtLevelName.Text = sLevelName;
			iLevel = Convert.ToInt32(sIndexLevel);
		}

		public void setSchoolYear(string sSY, string sIndexSY)
		{
			txtSchoolYear.Text = sSY;
			iSY = Convert.ToInt32(sIndexSY);
		}

		private void bttnEmailAdd_Click(object sender, System.EventArgs e)
		{
			if( txtEmailAdd.Text  != "" )
			{
				System.Diagnostics.Process.Start("mailto:" + txtEmailAdd.Text + "?subject=Attn: "+ txtLastName.Text + ", " + txtFirstName.Text   +"&body=");
			}
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			if(txtBarrowerID.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Barrower ID");
				txtBarrowerID.Focus();
			}
			else if(txtFirstName.Text == "" || txtLastName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Name");
				txtLastName.Focus();
			}				
			else if(txtZipCode.Text == "" || txtProvince.Text == "" || txtCity.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Area");
				txtZipCode.Focus();
			}			
			else if(txtCourseName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Course Name");
				txtCourseName.Focus();
			}			
			else if(txtLevelName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Level Name");
				txtLevelName.Focus();
			}			
			else if(txtSchoolYear.Text == "")
			{
				clsFunctions.isTextEmptyMsg("School Year");
				txtSchoolYear.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT BarrowerID FROM tblBarrowers WHERE BarrowerID LIKE '" + txtBarrowerID.Text + "' ","tblBarrowers") == true)
			{
				MessageBox.Show("Barrower ID already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtBarrowerID.Focus();
			}
			else
			{
				cmdAddBarrower.Parameters["@getBarrowerID"].Value=txtBarrowerID.Text;
				cmdAddBarrower.Parameters["@getFirstName"].Value = txtFirstName.Text;
				cmdAddBarrower.Parameters["@getMiddleName"].Value=txtMiddleName.Text;
				cmdAddBarrower.Parameters["@getLastName"].Value = txtLastName.Text;
				cmdAddBarrower.Parameters["@getStreetAddress"].Value=txtStreetAddress.Text;
				cmdAddBarrower.Parameters["@getZipCode"].Value = txtZipCode.Text;
				cmdAddBarrower.Parameters["@getContactNO"].Value=txtContactNo.Text;
				cmdAddBarrower.Parameters["@getEmailAddress"].Value = txtEmailAdd.Text;
				cmdAddBarrower.Parameters["@getCourse"].Value=iCourse;
				cmdAddBarrower.Parameters["@getLevelIndex"].Value =iLevel;
				cmdAddBarrower.Parameters["@getSchoolYear"].Value =iSY;
				cmdAddBarrower.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddBarrower.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();
				cmdAddBarrower.Parameters["@getModifyBy"].Value = clsVariables.sLibrarianID;
				cmdAddBarrower.Parameters["@getDateModify"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddBarrower.ExecuteNonQuery();

				FORMBarrowers.publicBarrowersList.removePic();
				imgName = sBarrowerID + ".lms";

				if(ADD_STATE==false)
				{
					if(imgPath != "")
					{
						File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + imgName);
						File.Copy(imgPath,AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + imgName, true);
					}
					FORMBarrowers.publicBarrowersList.reload_current();
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					if(imgPath == ""){imgName = "";}
					else
					{
						File.Copy(imgPath,AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + txtBarrowerID.Text + ".lms", true);
					}
					FORMBarrowers.publicBarrowersList.tabCourse_SelectedIndexChanged(sender, e);
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

				this.Close();
			}
		}
	}
}
