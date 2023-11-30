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
	public class FORMCategory_View : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sCATBooks;

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMCategory_View publicCatList;
		
		OleDbDataAdapter daCategoryList = new OleDbDataAdapter();
		DataSet dsCategoryList = new DataSet();

		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Button bttnSelect;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader chCategory;
		private System.Windows.Forms.ColumnHeader chDescription;
		private System.Windows.Forms.ColumnHeader chIndex;

		private System.ComponentModel.Container components = null;

		public FORMCategory_View()
		{InitializeComponent();}

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
			this.bttnSelect = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.chCategory = new System.Windows.Forms.ColumnHeader();
			this.chDescription = new System.Windows.Forms.ColumnHeader();
			this.chIndex = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(4, 280);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(416, 2);
			this.ctrlSeparator1.TabIndex = 45;
			// 
			// bttnSelect
			// 
			this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSelect.Location = new System.Drawing.Point(214, 288);
			this.bttnSelect.Name = "bttnSelect";
			this.bttnSelect.Size = new System.Drawing.Size(100, 25);
			this.bttnSelect.TabIndex = 213;
			this.bttnSelect.Text = "&Select";
			this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(321, 288);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(100, 25);
			this.bttnCancel.TabIndex = 212;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(6, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(416, 264);
			this.pictureBox1.TabIndex = 214;
			this.pictureBox1.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.chCategory,
																						this.chDescription,
																						this.chIndex});
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.ForeColor = System.Drawing.Color.Navy;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 10);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(412, 261);
			this.listView1.TabIndex = 215;
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
			// chIndex
			// 
			this.chIndex.Text = "Index";
			this.chIndex.Width = 0;
			// 
			// FORMCategory_View
			// 
			this.AcceptButton = this.bttnSelect;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(426, 320);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bttnSelect);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMCategory_View";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Category";
			this.Load += new System.EventHandler(this.FORMCategory_View_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMCategory_View_Load(object sender, System.EventArgs e)
		{
			//Set Images
			listView1.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daCategoryList= new OleDbDataAdapter("",clsConnections.CN);

			loadCategory();
			publicCatList=this;
		}

		public void loadCategory()
		{
			long totalRow =0;
			daCategoryList.SelectCommand.CommandText = "SELECT CategoryName, CATDescription, IndexCategory FROM tblCategory ORDER BY CategoryName ASC";

			dsCategoryList.Clear();
			daCategoryList.Fill(dsCategoryList,"tblCategory");

			totalRow = dsCategoryList.Tables["tblCategory"].Rows.Count -1;
			
			listView1.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				listView1.Items.Add(new ListViewItem("" + dsCategoryList.Tables["tblCategory"].Rows[i].ItemArray.GetValue(0).ToString(),15));
				listView1.Items[i].SubItems.Add("" + dsCategoryList.Tables["tblCategory"].Rows[i].ItemArray.GetValue(1).ToString());
				listView1.Items[i].SubItems.Add("" + dsCategoryList.Tables["tblCategory"].Rows[i].ItemArray.GetValue(2).ToString());
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

		private void bttnSelect_Click(object sender, System.EventArgs e)
		{
			if(sCATBooks == "Categories")
			{
				FORMBooks_Modify.publicBooksList.setCategory(listView1.Items[listView1.FocusedItem.Index].SubItems[0].Text, listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text);
			}
			this.Close();
		}

		private void listView1_DoubleClick(object sender, System.EventArgs e){bttnSelect_Click(sender, e);}

	}
}
