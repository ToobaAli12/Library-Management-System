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
	public class FORMLevel_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static string sLevel;
		public static bool ADD_STATE;

		OleDbCommand cmdAddLevel;

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLevelName;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnAddNew;
		private System.ComponentModel.Container components = null;

		public FORMLevel_Modify(){InitializeComponent();}

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
			this.txtLevelName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 40);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(280, 2);
			this.ctrlSeparator1.TabIndex = 28;
			// 
			// txtLevelName
			// 
			this.txtLevelName.Location = new System.Drawing.Point(80, 8);
			this.txtLevelName.Name = "txtLevelName";
			this.txtLevelName.Size = new System.Drawing.Size(208, 21);
			this.txtLevelName.TabIndex = 31;
			this.txtLevelName.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Level Name:";
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.Location = new System.Drawing.Point(218, 48);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(70, 24);
			this.bttnCancel.TabIndex = 32;
			this.bttnCancel.Text = "   &Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnAddNew.Location = new System.Drawing.Point(152, 48);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(58, 24);
			this.bttnAddNew.TabIndex = 33;
			this.bttnAddNew.Text = "    &Save";
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// FORMLevel_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(294, 80);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.txtLevelName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMLevel_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMLevel_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMLevel_Modify_Load(object sender, System.EventArgs e)
		{
			setImages();
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddLevel = new OleDbCommand("INSERT INTO tblLevel(LevelName,AddedBy,DateAdd) VALUES(@getLevelName,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddLevel = new OleDbCommand("UPDATE tblLevel SET LevelName =@getLevelName WHERE LevelName = " + sLevel,clsConnections.CN);
				fillFields();
				txtLevelName.ReadOnly=true;
				bttnAddNew.Enabled=false;
				this.Text = "Edit Existing";
			}
			cmdAddLevel.Parameters.Add("@getLevelName",OleDbType.VarChar);
			cmdAddLevel.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddLevel.Parameters.Add("@getDateAdd",OleDbType.Date);
		}

		private void fillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT LevelName FROM tblLevel WHERE LevelName LIKE '" + sLevel + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblLevel");

			totalRow = ds.Tables["tblLevel"].Rows.Count -1;

			txtLevelName.Text=ds.Tables["tblLevel"].Rows[0].ItemArray.GetValue(0).ToString();
		}

		protected void setImages()
		{
			bttnAddNew.Image=MDIFORM.i16x16.Images[13];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			if(txtLevelName.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Level Name");
				txtLevelName.Focus();
			}			
			else
			{
				cmdAddLevel.Parameters["@getLevelName"].Value=txtLevelName.Text;
				cmdAddLevel.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddLevel.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddLevel.ExecuteNonQuery();
				FORMLevel.publicLevList.loadLevel("SELECT LevelName FROM tblLevel ORDER BY LevelName ASC");

				if(ADD_STATE==true)
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				this.Close();
			}
		}
	}
}
