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
	public class FORMCategory : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		string sAddedBy;
		string sDateAdd;

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMCategory publicCatList;
		
		OleDbDataAdapter daCategoryList = new OleDbDataAdapter();
		OleDbCommand cmdDelete;
		DataSet dsCategoryList = new DataSet();

		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Button bttnDelete;
		private System.Windows.Forms.Button bttnEdit;
		private System.Windows.Forms.Button bttnNew;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader chCategory;
		private System.Windows.Forms.ColumnHeader chDescription;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.ComponentModel.Container components = null;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Button bttnHistory;

		private static FORMCategory sForm = null;
		public static FORMCategory  Instance()
		{
			if(sForm==null){sForm = new FORMCategory();}

			return sForm;
		}

		public FORMCategory(){InitializeComponent();}

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
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMCategory));
			this.bttnReload = new System.Windows.Forms.Button();
			this.bttnDelete = new System.Windows.Forms.Button();
			this.bttnEdit = new System.Windows.Forms.Button();
			this.bttnNew = new System.Windows.Forms.Button();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.chCategory = new System.Windows.Forms.ColumnHeader();
			this.chDescription = new System.Windows.Forms.ColumnHeader();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.bttnHistory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bttnReload
			// 
			this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReload.ForeColor = System.Drawing.Color.Black;
			this.bttnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnReload.Location = new System.Drawing.Point(3, 139);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(24, 24);
			this.bttnReload.TabIndex = 43;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// bttnDelete
			// 
			this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnDelete.ForeColor = System.Drawing.Color.Black;
			this.bttnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnDelete.Location = new System.Drawing.Point(3, 114);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(24, 24);
			this.bttnDelete.TabIndex = 42;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// bttnEdit
			// 
			this.bttnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnEdit.ForeColor = System.Drawing.Color.Black;
			this.bttnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnEdit.Location = new System.Drawing.Point(3, 88);
			this.bttnEdit.Name = "bttnEdit";
			this.bttnEdit.Size = new System.Drawing.Size(24, 25);
			this.bttnEdit.TabIndex = 41;
			this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
			// 
			// bttnNew
			// 
			this.bttnNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnNew.ForeColor = System.Drawing.Color.Black;
			this.bttnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnNew.Location = new System.Drawing.Point(3, 63);
			this.bttnNew.Name = "bttnNew";
			this.bttnNew.Size = new System.Drawing.Size(24, 24);
			this.bttnNew.TabIndex = 40;
			this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.ForeColor = System.Drawing.Color.Black;
			this.bttnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnSearch.Location = new System.Drawing.Point(3, 37);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(24, 25);
			this.bttnSearch.TabIndex = 39;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chCategory,
																						this.chDescription});
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.ForeColor = System.Drawing.Color.Navy;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(29, 37);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(415, 267);
			this.listView1.TabIndex = 38;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			// 
			// chCategory
			// 
			this.chCategory.Text = "Category";
			this.chCategory.Width = 150;
			// 
			// chDescription
			// 
			this.chDescription.Text = "Description";
			this.chDescription.Width = 240;
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 1);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 37;
			this.picLOGO.TabStop = false;
			// 
			// lblHeader
			// 
			this.lblHeader.AutoSize = true;
			this.lblHeader.BackColor = System.Drawing.Color.Transparent;
			this.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblHeader.ForeColor = System.Drawing.Color.White;
			this.lblHeader.Location = new System.Drawing.Point(40, 5);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new System.Drawing.Size(77, 22);
			this.lblHeader.TabIndex = 36;
			this.lblHeader.Text = "Category";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(452, 30);
			this.picHeader.TabIndex = 35;
			this.picHeader.TabStop = false;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(5, 315);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(440, 2);
			this.ctrlSeparator1.TabIndex = 44;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(3, 192);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(24, 24);
			this.bttnCancel.TabIndex = 45;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// bttnHistory
			// 
			this.bttnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnHistory.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnHistory.ForeColor = System.Drawing.Color.Black;
			this.bttnHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnHistory.Location = new System.Drawing.Point(3, 166);
			this.bttnHistory.Name = "bttnHistory";
			this.bttnHistory.Size = new System.Drawing.Size(24, 24);
			this.bttnHistory.TabIndex = 51;
			this.bttnHistory.Click += new System.EventHandler(this.bttnHistory_Click);
			// 
			// FORMCategory
			// 
			this.AcceptButton = this.bttnNew;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(452, 326);
			this.Controls.Add(this.bttnHistory);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.bttnDelete);
			this.Controls.Add(this.bttnEdit);
			this.Controls.Add(this.bttnNew);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Category";
			this.Load += new System.EventHandler(this.FORMCategory_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMCategory_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daCategoryList= new OleDbDataAdapter("",clsConnections.CN);

			loadCategory("SELECT CategoryName, CATDescription  FROM tblCategory ORDER BY CategoryName ASC");
			setButtonTips();
			publicCatList=this;
		}

		public void loadCategory(string sSQL)
		{
			long totalRow =0;
			daCategoryList.SelectCommand.CommandText = sSQL;

			dsCategoryList.Clear();
			daCategoryList.Fill(dsCategoryList,"tblCategory");

			totalRow = dsCategoryList.Tables["tblCategory"].Rows.Count -1;
			
			listView1.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				listView1.Items.Add(new ListViewItem("" + dsCategoryList.Tables["tblCategory"].Rows[i].ItemArray.GetValue(0).ToString(),15));
				listView1.Items[i].SubItems.Add("" + dsCategoryList.Tables["tblCategory"].Rows[i].ItemArray.GetValue(1).ToString());
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

		public void LoadSearch(string sField, string sSearch)
		{
			loadCategory("SELECT CategoryName, CATDescription  FROM tblCategory WHERE " + sField + " LIKE '%" + sSearch + "%' ORDER BY CategoryName ASC");
		}

		public void setButtonTips()
		{
			MDIFORM.toolTip.SetToolTip(this.bttnSearch, "Find");
			MDIFORM.toolTip.SetToolTip(this.bttnNew,	"New");
			MDIFORM.toolTip.SetToolTip(this.bttnEdit,	"Edit");
			MDIFORM.toolTip.SetToolTip(this.bttnDelete, "Delete");
			MDIFORM.toolTip.SetToolTip(this.bttnReload, "Reload");
			MDIFORM.toolTip.SetToolTip(this.bttnHistory,"History");
			MDIFORM.toolTip.SetToolTip(this.bttnCancel, "Cancel");
		}

		protected void setImages()
		{
			listView1.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnSearch.Image=MDIFORM.i16x16.Images[7];
			bttnNew.Image=MDIFORM.i16x16.Images[8];
			bttnEdit.Image=MDIFORM.i16x16.Images[9];
			bttnDelete.Image=MDIFORM.i16x16.Images[10];
			bttnReload.Image=MDIFORM.i16x16.Images[11];
			bttnHistory.Image=MDIFORM.i16x16.Images[23];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e){bttnEdit.PerformClick();}

		private void bttnReload_Click(object sender, System.EventArgs e){loadCategory("SELECT CategoryName, CATDescription  FROM tblCategory ORDER BY CategoryName ASC");}

		private void bttnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(listView1.Items.Count > 0)
				{
					if(MessageBox.Show("This will permanently delete the selected record. Do you want to continue?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
					{
						try{sFunctions.setOleDbCommand(cmdDelete,"DELETE FROM tblCategory WHERE CategoryName = @getCategoryName","@getCategoryName", listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text);}
						catch(Exception ex){MessageBox.Show(ex.Message ,clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}

						int lvw_pos;
						lvw_pos=listView1.FocusedItem.Index;

						loadCategory("SELECT CategoryName, CATDescription  FROM tblCategory ORDER BY CategoryName ASC");
						
						if(listView1.Items.Count != 0 && listView1.Items.Count -1 >= lvw_pos)
						{
							listView1.Items[listView1.FocusedItem.Index].Selected =false;
							listView1.Items[listView1.FocusedItem.Index].Focused=false;

							listView1.Items[lvw_pos].Focused=true;
							listView1.Items[lvw_pos].Selected = true;
							listView1.Items[lvw_pos].EnsureVisible();
						}
						lvw_pos = 0;
					}
				}
				else
				{
					MessageBox.Show("No record to delete.","Unable to Delete",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}			
			}
			catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
			
			catch(NullReferenceException nreE){}
		}

		private void bttnNew_Click(object sender, System.EventArgs e)
		{
			FORMCategory_Modify.ADD_STATE = true;
			FORMCategory_Modify sForm = new FORMCategory_Modify();
			sForm.ShowDialog();
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnEdit_Click(object sender, System.EventArgs e)
		{
			if(listView1.Items.Count > 0)
			{
				try
				{
					FORMCategory_Modify.ADD_STATE = false;
					FORMCategory_Modify.sCategory=listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text;
					FORMCategory_Modify sForm = new FORMCategory_Modify();
					sForm.ShowDialog();

				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else
			{
				MessageBox.Show("No record to edit.","Unable to Edit",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sCategory= "Categories";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnHistory_Click(object sender, System.EventArgs e)
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblCategory.CategoryName, [tblLibrarian.LastName] & ', ' & [tblLibrarian.FirstName] & ' ' & [tblLibrarian.MiddleName] AS AddedBys, tblCategory.DateAdd FROM tblLibrarian RIGHT JOIN tblCategory ON tblLibrarian.LibrarianID = tblCategory.AddedBy WHERE tblCategory.CategoryName LIKE '" + listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text + "' ",clsConnections.CN);
			DataSet ds	= new DataSet();
			da.Fill(ds,"tblBooks");

			totalRow	= ds.Tables["tblBooks"].Rows.Count -1;

			sAddedBy	= ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(1).ToString();
			sDateAdd	= ds.Tables["tblBooks"].Rows[0].ItemArray.GetValue(2).ToString();

			MessageBox.Show("Date Added: " + sDateAdd + "\nAdded By: " + sAddedBy,"Midification History",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}

