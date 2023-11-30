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
	public class FORMZipCodes_View : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sZipLibriran;
		public static string sZipLibrarySetup;
		public static string sZipBarrowers;

		OleDbDataAdapter daZipCodeList = new OleDbDataAdapter();
		DataSet dsZipCodeList = new DataSet();

		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader chCity;
		private System.Windows.Forms.ColumnHeader chProvince;
		private System.Windows.Forms.ColumnHeader chZip;
		private System.Windows.Forms.Button bttnSelect;

		private System.ComponentModel.Container components = null;

		public FORMZipCodes_View(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMZipCodes_View));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.chCity = new System.Windows.Forms.ColumnHeader();
			this.chProvince = new System.Windows.Forms.ColumnHeader();
			this.chZip = new System.Windows.Forms.ColumnHeader();
			this.bttnSelect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 10;
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
			this.lblHeader.Size = new System.Drawing.Size(85, 22);
			this.lblHeader.TabIndex = 9;
			this.lblHeader.Text = "Zip Codes";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(434, 30);
			this.picHeader.TabIndex = 8;
			this.picHeader.TabStop = false;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(7, 299);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(420, 2);
			this.ctrlSeparator1.TabIndex = 12;
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
			this.bttnCancel.Location = new System.Drawing.Point(340, 312);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(88, 26);
			this.bttnCancel.TabIndex = 43;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(7, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(420, 256);
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chCity,
																						this.chProvince,
																						this.chZip});
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.ForeColor = System.Drawing.Color.Navy;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(10, 38);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(415, 249);
			this.listView1.TabIndex = 46;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// chCity
			// 
			this.chCity.Text = "City/Town";
			this.chCity.Width = 150;
			// 
			// chProvince
			// 
			this.chProvince.Text = "State/Province";
			this.chProvince.Width = 150;
			// 
			// chZip
			// 
			this.chZip.Text = "Zip Code";
			this.chZip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chZip.Width = 95;
			// 
			// bttnSelect
			// 
			this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSelect.Location = new System.Drawing.Point(240, 312);
			this.bttnSelect.Name = "bttnSelect";
			this.bttnSelect.Size = new System.Drawing.Size(92, 26);
			this.bttnSelect.TabIndex = 47;
			this.bttnSelect.Text = "&Select";
			this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
			// 
			// FORMZipCodes_View
			// 
			this.AcceptButton = this.bttnSelect;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(434, 344);
			this.Controls.Add(this.bttnSelect);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMZipCodes_View";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zip Codes";
			this.Load += new System.EventHandler(this.FORMZipCodes_View_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public void loadZipCodes()
		{
			long totalRow =0;
			daZipCodeList.SelectCommand.CommandText = "SELECT CityTown, Province, ZipCode FROM tblZipCodeList ORDER BY CityTown ASC";

			dsZipCodeList.Clear();
			daZipCodeList.Fill(dsZipCodeList,"tblZipCodeList");

			totalRow = dsZipCodeList.Tables["tblZipCodeList"].Rows.Count -1;
			
			listView1.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				listView1.Items.Add(new ListViewItem("" + dsZipCodeList.Tables["tblZipCodeList"].Rows[i].ItemArray.GetValue(0).ToString(),6));
				listView1.Items[i].SubItems.Add("" + dsZipCodeList.Tables["tblZipCodeList"].Rows[i].ItemArray.GetValue(1).ToString());
				listView1.Items[i].SubItems.Add("" + dsZipCodeList.Tables["tblZipCodeList"].Rows[i].ItemArray.GetValue(2).ToString());
			}
			if (listView1.Items.Count > 0)
			{
				try
				{
					listView1.Items[0].Focused=true;
					listView1.Items[0].Selected = true;
					listView1.Items[0].EnsureVisible();
					listView1.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		protected void setImages()
		{
			listView1.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMZipCodes_View_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daZipCodeList= new OleDbDataAdapter("",clsConnections.CN);
			
			//Load List of ZipCodes
			loadZipCodes();
		}

		private void bttnSelect_Click(object sender, System.EventArgs e)
		{
			if(sZipLibrarySetup == "Library Setup")
			{
				FORMLibrarySetup.publicProfile.FillFields(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text, false);
			}
			else if(sZipLibriran == "Librarian")
			{
				FORMLibrarian_Modify.publcLibrarianList.setAreas(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);
			}
			else if(sZipBarrowers == "Barrowers")
			{
				FORMBarrowers_Modify.publicBarrowerList.setAreas(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);
			}
			this.Close();
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e){bttnSelect_Click(sender, e);}
	}
}
