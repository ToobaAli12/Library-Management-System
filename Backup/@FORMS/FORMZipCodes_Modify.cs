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
	public class FORMZipCodes_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sZipCode;
		
		//BOOLEAN VARIABLES
		public static bool ADD_STATE;

		OleDbCommand cmdAddZip;

		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label lblProvice;
		private System.Windows.Forms.Label label1;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.TextBox txtProvice;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnAddNew;
		private System.ComponentModel.Container components = null;

		public FORMZipCodes_Modify(){InitializeComponent();}

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
			this.lblCity = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtProvice = new System.Windows.Forms.TextBox();
			this.lblProvice = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(26, 16);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(59, 17);
			this.lblCity.TabIndex = 0;
			this.lblCity.Text = "City/Town:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(91, 14);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(173, 21);
			this.txtCity.TabIndex = 1;
			this.txtCity.Text = "";
			// 
			// txtProvice
			// 
			this.txtProvice.Location = new System.Drawing.Point(91, 40);
			this.txtProvice.Name = "txtProvice";
			this.txtProvice.Size = new System.Drawing.Size(173, 21);
			this.txtProvice.TabIndex = 3;
			this.txtProvice.Text = "";
			// 
			// lblProvice
			// 
			this.lblProvice.AutoSize = true;
			this.lblProvice.Location = new System.Drawing.Point(11, 40);
			this.lblProvice.Name = "lblProvice";
			this.lblProvice.Size = new System.Drawing.Size(74, 17);
			this.lblProvice.TabIndex = 2;
			this.lblProvice.Text = "Provice/State:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(92, 67);
			this.txtZipCode.MaxLength = 5;
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.TabIndex = 5;
			this.txtZipCode.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zip Codes:";
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 104);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(256, 2);
			this.ctrlSeparator1.TabIndex = 6;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.Location = new System.Drawing.Point(194, 120);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(72, 25);
			this.bttnCancel.TabIndex = 25;
			this.bttnCancel.Text = "   &Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnAddNew.Location = new System.Drawing.Point(120, 120);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(64, 25);
			this.bttnAddNew.TabIndex = 26;
			this.bttnAddNew.Text = "    &Save";
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click_1);
			// 
			// FORMZipCodes_Modify
			// 
			this.AcceptButton = this.bttnAddNew;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(274, 152);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtProvice);
			this.Controls.Add(this.lblProvice);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.lblCity);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMZipCodes_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMZipCodes_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMZipCodes_Modify_Load(object sender, System.EventArgs e)
		{
			setImages();
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddZip = new OleDbCommand("INSERT INTO tblZipCodeList(CityTown,Province,ZipCode,AddedBy,DateAdd) VALUES(@getCityTown,@getProvince,@getZipCode,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddZip = new OleDbCommand("UPDATE tblZipCodeList SET CityTown =@getCityTown, Province =@getProvince, ZipCode =@getZipCode WHERE ZipCode LIKE '" + sZipCode + "' " ,clsConnections.CN);
				fillFields();
				txtZipCode.ReadOnly=true;
				this.Text = "Edit Existing";
			}
			cmdAddZip.Parameters.Add("@getCityTown",OleDbType.VarChar);
			cmdAddZip.Parameters.Add("@getProvince",OleDbType.VarChar);
			cmdAddZip.Parameters.Add("@getZipCode",OleDbType.VarChar);
			cmdAddZip.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddZip.Parameters.Add("@getDateAdd",OleDbType.Date);

			this.Refresh();
		}

		protected void setImages()
		{
			bttnAddNew.Image=MDIFORM.i16x16.Images[13];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void fillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT CityTown,Province,ZipCode FROM tblZipCodeList WHERE ZipCode LIKE '" + sZipCode + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblZipCodeList");

			totalRow = ds.Tables["tblZipCodeList"].Rows.Count -1;

			txtCity.Text=ds.Tables["tblZipCodeList"].Rows[0].ItemArray.GetValue(0).ToString();
			txtProvice.Text=ds.Tables["tblZipCodeList"].Rows[0].ItemArray.GetValue(1).ToString();
			txtZipCode.Text=ds.Tables["tblZipCodeList"].Rows[0].ItemArray.GetValue(2).ToString();
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnAddNew_Click_1(object sender, System.EventArgs e)
		{
			if(txtCity.Text == "")
			{
				clsFunctions.isTextEmptyMsg("City/Town");
				txtCity.Focus();
			}
			else if(txtProvice.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Provice/State");
				txtProvice.Focus();
			}			
			else if(txtZipCode.Text == "")
			{
				clsFunctions.isTextEmptyMsg("ZipCode");
				txtZipCode.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT * FROM tblZipCodeList WHERE ZipCode LIKE '" + txtZipCode.Text + "' ","tblZipCodeList") == true)
			{
				MessageBox.Show("Zip Code already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtZipCode.Focus();
			}			
			else
			{
				cmdAddZip.Parameters["@getCityTown"].Value = txtCity.Text;
				cmdAddZip.Parameters["@getProvince"].Value = txtProvice.Text;
				cmdAddZip.Parameters["@getZipCode"].Value  = txtZipCode.Text;
				cmdAddZip.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddZip.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddZip.ExecuteNonQuery();
				FORMZipCodes.publicZipList.loadZipCodes("SELECT CityTown, Province, ZipCode FROM tblZipCodeList ORDER BY CityTown ASC");

				if(ADD_STATE==false)
				{
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				this.Close();
			}
		}
	}
}
