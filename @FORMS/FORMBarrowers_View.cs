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
	public class FORMBarrowers_View : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//STRING VARIABLES
		public static string sSY;
		public static string sLevel;

		public static FORMBarrowers_View publicBarrwrList;
		
		OleDbDataAdapter daBarrwrList = new OleDbDataAdapter();
		DataSet dsBarrwrList = new DataSet();

		private System.Windows.Forms.Button bttnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader ChBarrowerID;
		private System.Windows.Forms.ColumnHeader chStudentName;
		private System.Windows.Forms.ColumnHeader chCourse;
		private System.Windows.Forms.ColumnHeader chLevel;
		private System.Windows.Forms.Button bttnSelect;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Button bttnSearch;
		public System.Windows.Forms.ListView lvBarrowers;
		private System.ComponentModel.Container components = null;

		public FORMBarrowers_View(){InitializeComponent();}

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
			this.bttnSelect = new System.Windows.Forms.Button();
			this.bttnReload = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvBarrowers = new System.Windows.Forms.ListView();
			this.ChBarrowerID = new System.Windows.Forms.ColumnHeader();
			this.chStudentName = new System.Windows.Forms.ColumnHeader();
			this.chCourse = new System.Windows.Forms.ColumnHeader();
			this.chLevel = new System.Windows.Forms.ColumnHeader();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bttnSelect
			// 
			this.bttnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSelect.Location = new System.Drawing.Point(296, 416);
			this.bttnSelect.Name = "bttnSelect";
			this.bttnSelect.Size = new System.Drawing.Size(80, 25);
			this.bttnSelect.TabIndex = 244;
			this.bttnSelect.Text = "&Select";
			this.bttnSelect.Click += new System.EventHandler(this.bttnSelect_Click);
			// 
			// bttnReload
			// 
			this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnReload.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReload.Location = new System.Drawing.Point(472, 415);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(80, 25);
			this.bttnReload.TabIndex = 243;
			this.bttnReload.Text = "&Reload";
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(560, 415);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 242;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(7, 401);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(632, 2);
			this.ctrlSeparator1.TabIndex = 241;
			// 
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(5, 35);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(635, 354);
			this.picFill.TabIndex = 239;
			this.picFill.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-1, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(648, 20);
			this.label1.TabIndex = 238;
			this.label1.Text = "  Barrowed History Viewer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lvBarrowers
			// 
			this.lvBarrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBarrowers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvBarrowers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.ChBarrowerID,
																						  this.chStudentName,
																						  this.chCourse,
																						  this.chLevel});
			this.lvBarrowers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBarrowers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBarrowers.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBarrowers.FullRowSelect = true;
			this.lvBarrowers.GridLines = true;
			this.lvBarrowers.HideSelection = false;
			this.lvBarrowers.HoverSelection = true;
			this.lvBarrowers.Location = new System.Drawing.Point(7, 37);
			this.lvBarrowers.MultiSelect = false;
			this.lvBarrowers.Name = "lvBarrowers";
			this.lvBarrowers.Size = new System.Drawing.Size(630, 350);
			this.lvBarrowers.TabIndex = 246;
			this.lvBarrowers.View = System.Windows.Forms.View.Details;
			this.lvBarrowers.DoubleClick += new System.EventHandler(this.lvBarrowers_DoubleClick);
			// 
			// ChBarrowerID
			// 
			this.ChBarrowerID.Text = "Barrower ID";
			this.ChBarrowerID.Width = 150;
			// 
			// chStudentName
			// 
			this.chStudentName.Text = "Barrower Name";
			this.chStudentName.Width = 300;
			// 
			// chCourse
			// 
			this.chCourse.Text = "Course";
			this.chCourse.Width = 150;
			// 
			// chLevel
			// 
			this.chLevel.Text = "Level";
			this.chLevel.Width = 150;
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.Location = new System.Drawing.Point(384, 416);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(80, 25);
			this.bttnSearch.TabIndex = 247;
			this.bttnSearch.Text = "&Search";
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// FORMBarrowers_View
			// 
			this.AcceptButton = this.bttnSelect;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(646, 448);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.lvBarrowers);
			this.Controls.Add(this.bttnSelect);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMBarrowers_View";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Barrowers";
			this.Load += new System.EventHandler(this.FORMBarrowers_View_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			loadBooks("SELECT tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse RIGHT JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + sSY + "' AND tblLevel.LevelName LIKE '" + sLevel + "' ORDER BY tblBarrowers.BarrowerID ASC");
		}

		private void FORMBarrowers_View_Load(object sender, System.EventArgs e)
		{
			lvBarrowers.SmallImageList = MDIFORM.i16x16;

			//Set the Data Adapter
			daBarrwrList= new OleDbDataAdapter("",clsConnections.CN);

			loadBooks("SELECT tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse RIGHT JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + sSY + "' AND tblLevel.LevelName LIKE '" + sLevel + "' ORDER BY tblBarrowers.BarrowerID ASC");
		
			publicBarrwrList=this;
			this.Refresh();
		}

		public void loadBooks(string sSQL)
		{
			long totalRow =0;

			daBarrwrList.SelectCommand.CommandText = sSQL;

			dsBarrwrList.Clear();
			daBarrwrList.Fill(dsBarrwrList,"tblBarrowers");

			totalRow = dsBarrwrList.Tables["tblBarrowers"].Rows.Count -1;
			
			lvBarrowers.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBarrowers.Items.Add(new ListViewItem("" + dsBarrwrList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(0).ToString(),20));
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrwrList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(1).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrwrList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrwrList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(3).ToString());
			}
			if (lvBarrowers.Items.Count > 0)
			{
				try
				{
					lvBarrowers.Items[0].Focused=true;
					lvBarrowers.Items[0].Selected = true;
					lvBarrowers.Items[0].EnsureVisible();
					lvBarrowers.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			loadBooks("SELECT tblBarrowers.BarrowerID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblCourse.CourseName, tblLevel.LevelName, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse RIGHT JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + sSY + "' AND tblLevel.LevelName LIKE '" + sLevel + "' AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBarrowers.BarrowerID ASC");
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sBooks= "Barrowers List";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnSelect_Click(object sender, System.EventArgs e)
		{
			FORMBarrowedBooks_New.publicBarrowedList.setBarrower(lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text, lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[1].Text);
			this.Close();
		}

		private void lvBarrowers_DoubleClick(object sender, System.EventArgs e){bttnSelect_Click(sender, e);}
	}
}
