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
	public class FORMCategory_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static string sCategory;
		public static bool ADD_STATE;

		OleDbCommand cmdAddCategory;

		private System.Windows.Forms.Label label2;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnAddNew;
		private System.ComponentModel.Container components = null;

		public FORMCategory_Modify(){InitializeComponent();}

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
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(90, 16);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(216, 21);
			this.txtCategory.TabIndex = 37;
			this.txtCategory.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 43;
			this.label2.Text = "Category Name:";
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(10, 136);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(296, 2);
			this.ctrlSeparator1.TabIndex = 40;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(90, 48);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(216, 80);
			this.txtDescription.TabIndex = 39;
			this.txtDescription.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 38;
			this.label1.Text = "Description:";
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.Location = new System.Drawing.Point(236, 144);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(70, 24);
			this.bttnCancel.TabIndex = 44;
			this.bttnCancel.Text = "   &Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnAddNew.Location = new System.Drawing.Point(168, 144);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(58, 24);
			this.bttnAddNew.TabIndex = 45;
			this.bttnAddNew.Text = "    &Save";
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// FORMCategory_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(314, 176);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.txtCategory);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlSeparator1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMCategory_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMCategory_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMCategory_Modify_Load(object sender, System.EventArgs e)
		{
			setImages();
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddCategory = new OleDbCommand("INSERT INTO tblCategory(CategoryName,CATDescription,AddedBy,DateAdd) VALUES(@getCategoryName,@getCATDescription,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddCategory = new OleDbCommand("UPDATE tblCategory SET CategoryName =@getCategoryName, CATDescription =@getCATDescription WHERE CategoryName LIKE '" + sCategory + "' " ,clsConnections.CN);
				fillFields();
				txtCategory.ReadOnly=true;
				this.Text = "Edit Existing";
			}
			cmdAddCategory.Parameters.Add("@getCategoryName",OleDbType.VarChar);
			cmdAddCategory.Parameters.Add("@getCATDescription",OleDbType.VarChar);
			cmdAddCategory.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddCategory.Parameters.Add("@getDateAdd",OleDbType.Date);

			this.Refresh();
		}

		private void fillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT CategoryName,CATDescription FROM tblCategory WHERE CategoryName LIKE '" + sCategory + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblCategory");

			totalRow = ds.Tables["tblCategory"].Rows.Count -1;

			txtCategory.Text=ds.Tables["tblCategory"].Rows[0].ItemArray.GetValue(0).ToString();
			txtDescription.Text=ds.Tables["tblCategory"].Rows[0].ItemArray.GetValue(1).ToString();
		}

		protected void setImages()
		{
			bttnAddNew.Image=MDIFORM.i16x16.Images[13];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			if(txtCategory.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Category");
				txtCategory.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT CategoryName FROM tblCategory WHERE CategoryName LIKE '" + txtCategory.Text + "' ","tblCategory") == true)
			{
				MessageBox.Show("Category already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtCategory.Focus();
			}			
			else
			{
				cmdAddCategory.Parameters["@getCategoryName"].Value   = txtCategory.Text; 
				cmdAddCategory.Parameters["@getCATDescription"].Value = txtDescription.Text;
				cmdAddCategory.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddCategory.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddCategory.ExecuteNonQuery();
				FORMCategory.publicCatList.loadCategory("SELECT CategoryName, CATDescription  FROM tblCategory ORDER BY CategoryName ASC");

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
