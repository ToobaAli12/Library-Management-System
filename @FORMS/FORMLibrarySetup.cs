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
	public class FORMLibrarySetup : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static FORMLibrarySetup publicProfile;

		public static string sProfile;
		public static bool ADD_STATE;

		OleDbCommand cmdAddProfile;

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtInstitutionName;
		private System.Windows.Forms.TextBox txtContactName;
		private System.Windows.Forms.TextBox txtStreetAddress;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox txtProvince;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFaxNumber;
		private System.Windows.Forms.TextBox txtEmailAdd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtWebsite;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnSave;
		private System.Windows.Forms.Button bttnZipCode;
		private System.Windows.Forms.Button bttnEmailAdd;
		private System.Windows.Forms.Button bttnWebsite;

		private static FORMLibrarySetup sForm = null;
		public static FORMLibrarySetup  Instance()
		{
			if(sForm==null){sForm = new FORMLibrarySetup();}

			return sForm;
		}

		public FORMLibrarySetup(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMLibrarySetup));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInstitutionName = new System.Windows.Forms.TextBox();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.txtStreetAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProvince = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.bttnZipCode = new System.Windows.Forms.Button();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFaxNumber = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEmailAdd = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.bttnEmailAdd = new System.Windows.Forms.Button();
			this.bttnWebsite = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 16;
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
			this.lblHeader.Size = new System.Drawing.Size(118, 22);
			this.lblHeader.TabIndex = 15;
			this.lblHeader.Text = "Library Profile";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(354, 30);
			this.picHeader.TabIndex = 14;
			this.picHeader.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "&Institution Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "&Contact Name:";
			// 
			// txtInstitutionName
			// 
			this.txtInstitutionName.Location = new System.Drawing.Point(98, 46);
			this.txtInstitutionName.Name = "txtInstitutionName";
			this.txtInstitutionName.Size = new System.Drawing.Size(211, 21);
			this.txtInstitutionName.TabIndex = 19;
			this.txtInstitutionName.Text = "";
			// 
			// txtContactName
			// 
			this.txtContactName.Location = new System.Drawing.Point(98, 80);
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Size = new System.Drawing.Size(211, 21);
			this.txtContactName.TabIndex = 20;
			this.txtContactName.Text = "";
			// 
			// txtStreetAddress
			// 
			this.txtStreetAddress.Location = new System.Drawing.Point(98, 112);
			this.txtStreetAddress.Name = "txtStreetAddress";
			this.txtStreetAddress.Size = new System.Drawing.Size(251, 21);
			this.txtStreetAddress.TabIndex = 22;
			this.txtStreetAddress.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 21;
			this.label3.Text = "&Street Address:";
			// 
			// txtCity
			// 
			this.txtCity.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtCity.Location = new System.Drawing.Point(98, 144);
			this.txtCity.Name = "txtCity";
			this.txtCity.ReadOnly = true;
			this.txtCity.Size = new System.Drawing.Size(211, 21);
			this.txtCity.TabIndex = 24;
			this.txtCity.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "&Town/City:";
			// 
			// txtProvince
			// 
			this.txtProvince.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtProvince.Location = new System.Drawing.Point(98, 176);
			this.txtProvince.Name = "txtProvince";
			this.txtProvince.ReadOnly = true;
			this.txtProvince.Size = new System.Drawing.Size(211, 21);
			this.txtProvince.TabIndex = 26;
			this.txtProvince.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 17);
			this.label5.TabIndex = 25;
			this.label5.Text = "&Province/State:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtZipCode.Location = new System.Drawing.Point(98, 207);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.ReadOnly = true;
			this.txtZipCode.Size = new System.Drawing.Size(98, 21);
			this.txtZipCode.TabIndex = 44;
			this.txtZipCode.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 17);
			this.label6.TabIndex = 27;
			this.label6.Text = "&Zip Code:";
			// 
			// bttnZipCode
			// 
			this.bttnZipCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnZipCode.Image = ((System.Drawing.Image)(resources.GetObject("bttnZipCode.Image")));
			this.bttnZipCode.Location = new System.Drawing.Point(197, 207);
			this.bttnZipCode.Name = "bttnZipCode";
			this.bttnZipCode.Size = new System.Drawing.Size(21, 22);
			this.bttnZipCode.TabIndex = 29;
			this.bttnZipCode.Click += new System.EventHandler(this.bttnZipCode_Click);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(98, 240);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(177, 21);
			this.txtPhoneNumber.TabIndex = 31;
			this.txtPhoneNumber.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 17);
			this.label7.TabIndex = 30;
			this.label7.Text = "&Phone Number:";
			// 
			// txtFaxNumber
			// 
			this.txtFaxNumber.Location = new System.Drawing.Point(98, 272);
			this.txtFaxNumber.Name = "txtFaxNumber";
			this.txtFaxNumber.Size = new System.Drawing.Size(177, 21);
			this.txtFaxNumber.TabIndex = 33;
			this.txtFaxNumber.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 272);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 17);
			this.label8.TabIndex = 32;
			this.label8.Text = "&Fax Number:";
			// 
			// txtEmailAdd
			// 
			this.txtEmailAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEmailAdd.ForeColor = System.Drawing.Color.Blue;
			this.txtEmailAdd.Location = new System.Drawing.Point(98, 304);
			this.txtEmailAdd.Name = "txtEmailAdd";
			this.txtEmailAdd.Size = new System.Drawing.Size(211, 21);
			this.txtEmailAdd.TabIndex = 35;
			this.txtEmailAdd.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 304);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 17);
			this.label9.TabIndex = 34;
			this.label9.Text = "&Email Address:";
			// 
			// txtWebsite
			// 
			this.txtWebsite.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtWebsite.ForeColor = System.Drawing.Color.Blue;
			this.txtWebsite.Location = new System.Drawing.Point(98, 336);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(211, 21);
			this.txtWebsite.TabIndex = 37;
			this.txtWebsite.Text = "";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 336);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 17);
			this.label10.TabIndex = 36;
			this.label10.Text = "&Website Address:";
			// 
			// bttnEmailAdd
			// 
			this.bttnEmailAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnEmailAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnEmailAdd.Image")));
			this.bttnEmailAdd.Location = new System.Drawing.Point(312, 303);
			this.bttnEmailAdd.Name = "bttnEmailAdd";
			this.bttnEmailAdd.Size = new System.Drawing.Size(21, 22);
			this.bttnEmailAdd.TabIndex = 38;
			this.bttnEmailAdd.Click += new System.EventHandler(this.bttnEmailAdd_Click);
			// 
			// bttnWebsite
			// 
			this.bttnWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnWebsite.Image = ((System.Drawing.Image)(resources.GetObject("bttnWebsite.Image")));
			this.bttnWebsite.Location = new System.Drawing.Point(312, 336);
			this.bttnWebsite.Name = "bttnWebsite";
			this.bttnWebsite.Size = new System.Drawing.Size(21, 22);
			this.bttnWebsite.TabIndex = 43;
			this.bttnWebsite.Click += new System.EventHandler(this.bttnWebsite_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 376);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(336, 2);
			this.ctrlSeparator1.TabIndex = 40;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(256, 388);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(88, 26);
			this.bttnCancel.TabIndex = 41;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnSave
			// 
			this.bttnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSave.ForeColor = System.Drawing.Color.Black;
			this.bttnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnSave.Location = new System.Drawing.Point(160, 388);
			this.bttnSave.Name = "bttnSave";
			this.bttnSave.Size = new System.Drawing.Size(88, 26);
			this.bttnSave.TabIndex = 42;
			this.bttnSave.Text = "&Save";
			this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
			// 
			// FORMLibrarySetup
			// 
			this.AcceptButton = this.bttnSave;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(354, 424);
			this.Controls.Add(this.bttnSave);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.bttnWebsite);
			this.Controls.Add(this.bttnEmailAdd);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtEmailAdd);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtFaxNumber);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.bttnZipCode);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtProvince);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtStreetAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtContactName);
			this.Controls.Add(this.txtInstitutionName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMLibrarySetup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Profile";
			this.Load += new System.EventHandler(this.FORMLibrarySetup_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMLibrarySetup_Load(object sender, System.EventArgs e)
		{
			setImages();

			
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddProfile = new OleDbCommand("INSERT INTO tblLibrarySetup(InstitutionName,ContactName,StreetAddr,ZipCode,PhoneNumber,FaxNumber,EmailAddr,Website) VALUES(@getInstitutionName,@getContactName,@getStreetAddr,@getZipCode,@getPhoneNumber,@getFaxNumber,@getEmailAddr,@getWebsite)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddProfile = new OleDbCommand("UPDATE tblLibrarySetup SET InstitutionName =@getInstitutionName, ContactName =@getContactName, StreetAddr =@getStreetAddr,  ZipCode =@getZipCode, PhoneNumber =@getPhoneNumber, FaxNumber =@getFaxNumber, EmailAddr =@getEmailAddr, Website =@getWebsite" ,clsConnections.CN);
				FillFields("","","",true);
				this.Text = "Edit Existing";
			}
			cmdAddProfile.Parameters.Add("@getInstitutionName",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getContactName",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getStreetAddr",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getZipCode",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getPhoneNumber",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getFaxNumber",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getEmailAddr",OleDbType.VarChar);
			cmdAddProfile.Parameters.Add("@getWebsite",OleDbType.VarChar);

			publicProfile = this;
		}

		protected void setImages()
		{
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;
		}

		public void FillFields(string sCity, string sProvince, string sZipCode, bool sState)
		{
			if(ADD_STATE == false)
			{
				long totalRow =0;
				//Set the Data Adapter
				OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblLibrarySetup.InstitutionName, tblLibrarySetup.ContactName, tblLibrarySetup.StreetAddr, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarySetup.PhoneNumber, tblLibrarySetup.FaxNumber, tblLibrarySetup.EmailAddr, tblLibrarySetup.Website FROM tblZipCodeList RIGHT JOIN tblLibrarySetup ON tblZipCodeList.ZipCode = tblLibrarySetup.ZipCode;",clsConnections.CN);
				DataSet ds = new DataSet();
				da.Fill(ds,"tblLibrarySetup");

				totalRow = ds.Tables["tblLibrarySetup"].Rows.Count -1;

				txtInstitutionName.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(0).ToString();
				txtContactName.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(1).ToString();
				txtStreetAddress.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(2).ToString();
				txtPhoneNumber.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(6).ToString();
				txtFaxNumber.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(7).ToString();
				txtEmailAdd.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(8).ToString();
				txtWebsite.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(9).ToString();
		
				if(sState == true)
				{
					txtCity.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(3).ToString();
					txtProvince.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(4).ToString();
					txtZipCode.Text=ds.Tables["tblLibrarySetup"].Rows[0].ItemArray.GetValue(5).ToString();
				}
				else
				{
					txtCity.Text=sCity;
					txtProvince.Text=sProvince;
					txtZipCode.Text=sZipCode;
				}
			}
			else
			{
				txtCity.Text=sCity;
				txtProvince.Text=sProvince;
				txtZipCode.Text=sZipCode;
			}
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnEmailAdd_Click(object sender, System.EventArgs e)
		{
			if( txtEmailAdd.Text  != "" )
			{
				System.Diagnostics.Process.Start("mailto:" + txtEmailAdd.Text + "?subject=Attn: "+ txtContactName.Text  +"&body=");
			}
		}

		private void bttnWebsite_Click(object sender, System.EventArgs e)
		{
			if( txtWebsite.Text  != "" ){System.Diagnostics.Process.Start(txtWebsite.Text);}
		}

		private void bttnZipCode_Click(object sender, System.EventArgs e)
		{
			FORMZipCodes_View.sZipLibrarySetup= "Library Setup";
			FORMZipCodes_View sForm = new FORMZipCodes_View();
			sForm.ShowDialog();
		}

		private void bttnSave_Click(object sender, System.EventArgs e)
		{
			if(txtInstitutionName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("InstitutionName");
				txtInstitutionName.Focus();
			}
			else if(txtContactName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("ContactName");
				txtContactName.Focus();
			}
			else if(txtStreetAddress.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Street Address");
				txtStreetAddress.Focus();
			}			
			else if(txtZipCode.Text == "" || txtProvince.Text == "" || txtCity.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Zip Code");
				txtZipCode.Focus();
			}			
			else
			{
				cmdAddProfile.Parameters["@getInstitutionName"].Value = txtInstitutionName.Text;
				cmdAddProfile.Parameters["@getContactName"].Value = txtContactName.Text;
				cmdAddProfile.Parameters["@getStreetAddr"].Value = txtStreetAddress.Text;
				cmdAddProfile.Parameters["@getZipCode"].Value = txtZipCode.Text;
				cmdAddProfile.Parameters["@getPhoneNumber"].Value = txtPhoneNumber.Text;
				cmdAddProfile.Parameters["@getFaxNumber"].Value = txtFaxNumber.Text;
				cmdAddProfile.Parameters["@getEmailAddr"].Value = txtEmailAdd.Text;
				cmdAddProfile.Parameters["@getWebsite"].Value = txtWebsite.Text;

				cmdAddProfile.ExecuteNonQuery();
			

				if(ADD_STATE==false)
				{
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}

				clsInstitutionSetup.setINSTITUTION();
			}
		}
	}
}
