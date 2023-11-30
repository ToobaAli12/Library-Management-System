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
	public class FORMSchoolYear_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static int iSchoolYear = 0;
		public static bool ADD_STATE;

		OleDbCommand cmdAddSY;

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtYearStart;
		private System.Windows.Forms.TextBox txtYearEnd;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnAddNew;
		private System.ComponentModel.Container components = null;

		public FORMSchoolYear_Modify(){InitializeComponent();}

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
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.txtYearStart = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtYearEnd = new System.Windows.Forms.TextBox();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(13, 44);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(192, 2);
			this.ctrlSeparator1.TabIndex = 32;
			// 
			// txtYearStart
			// 
			this.txtYearStart.Location = new System.Drawing.Point(72, 12);
			this.txtYearStart.MaxLength = 4;
			this.txtYearStart.Name = "txtYearStart";
			this.txtYearStart.Size = new System.Drawing.Size(56, 21);
			this.txtYearStart.TabIndex = 27;
			this.txtYearStart.Text = "";
			this.txtYearStart.TextChanged += new System.EventHandler(this.txtYearStart_TextChanged);
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(8, 12);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(67, 17);
			this.lblCity.TabIndex = 26;
			this.lblCity.Text = "School Year:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(130, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 16);
			this.label1.TabIndex = 35;
			this.label1.Text = "____";
			// 
			// txtYearEnd
			// 
			this.txtYearEnd.BackColor = System.Drawing.Color.White;
			this.txtYearEnd.Location = new System.Drawing.Point(149, 13);
			this.txtYearEnd.MaxLength = 4;
			this.txtYearEnd.Name = "txtYearEnd";
			this.txtYearEnd.ReadOnly = true;
			this.txtYearEnd.Size = new System.Drawing.Size(56, 21);
			this.txtYearEnd.TabIndex = 36;
			this.txtYearEnd.Text = "";
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.Location = new System.Drawing.Point(136, 51);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(72, 25);
			this.bttnCancel.TabIndex = 38;
			this.bttnCancel.Text = "   &Cancel";
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnAddNew.Location = new System.Drawing.Point(66, 51);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(64, 25);
			this.bttnAddNew.TabIndex = 39;
			this.bttnAddNew.Text = "    &Save";
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// FORMSchoolYear_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(210, 80);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.txtYearEnd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.txtYearStart);
			this.Controls.Add(this.lblCity);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMSchoolYear_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMSchoolYear_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMSchoolYear_Modify_Load(object sender, System.EventArgs e)
		{
			setImages();
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddSY = new OleDbCommand("INSERT INTO tblSchoolYear(YearStart,YearEnd) VALUES(@getYearStart,@getYearEnd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddSY = new OleDbCommand("UPDATE tblSchoolYear SET YearStart =@getYearStart, YearEnd =@getYearEnd WHERE IndexSY = " + iSchoolYear,clsConnections.CN);
				fillFields();
				txtYearStart.ReadOnly=true;
				txtYearEnd.ReadOnly=true;
				this.Text = "Edit Existing";
			}
			cmdAddSY.Parameters.Add("@getYearStart",OleDbType.VarChar);
			cmdAddSY.Parameters.Add("@getYearEnd",OleDbType.VarChar);
		}

		private void fillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT YearStart,YearEnd FROM tblSchoolYear WHERE IndexSY = " + iSchoolYear,clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblSchoolYear");

			totalRow = ds.Tables["tblSchoolYear"].Rows.Count -1;

			txtYearStart.Text=ds.Tables["tblSchoolYear"].Rows[0].ItemArray.GetValue(0).ToString();
			txtYearEnd.Text=ds.Tables["tblSchoolYear"].Rows[0].ItemArray.GetValue(1).ToString();
		}

		protected void setImages()
		{
			bttnAddNew.Image=MDIFORM.i16x16.Images[13];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			if(txtYearStart.Text == "" || txtYearEnd.Text == "")
			{
				clsFunctions.isTextEmptyMsg("School Year");
				txtYearStart.Focus();
			}			
			else
			{
				cmdAddSY.Parameters["@getYearStart"].Value=txtYearStart.Text;
				cmdAddSY.Parameters["@getYearEnd"].Value = txtYearEnd.Text;

				cmdAddSY.ExecuteNonQuery();
				FORMSchoolYear.publicSYList.loadSchoolYear("SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC");

				if(ADD_STATE==true)
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				this.Close();
			}
		}

		private void txtYearStart_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				int sEnd =  0;
				sEnd = Convert.ToInt32(txtYearStart.Text) + 1;
				txtYearEnd.Text = sEnd.ToString();
			}
			catch(Exception ex){MessageBox.Show(ex.Message,clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}
		}
	}
}
