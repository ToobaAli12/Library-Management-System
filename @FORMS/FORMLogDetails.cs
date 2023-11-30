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
	public class FORMLogDetails : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMLogDetails publcLogList;
		
		OleDbDataAdapter daLogList = new OleDbDataAdapter();
		OleDbCommand cmdDelete;
		DataSet dsLogList = new DataSet();

		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.ComponentModel.Container components = null;
		public System.Windows.Forms.ListView lvLibrarian;
		private System.Windows.Forms.ColumnHeader chStudentID;
		private System.Windows.Forms.ColumnHeader chUsername;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.ColumnHeader chLogin;
		private System.Windows.Forms.ColumnHeader chLogout;

		private static FORMLogDetails sForm = null;
		public static FORMLogDetails  Instance()
		{
			if(sForm==null){sForm = new FORMLogDetails();}

			return sForm;
		}

		public FORMLogDetails(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMLogDetails));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.lvLibrarian = new System.Windows.Forms.ListView();
			this.chStudentID = new System.Windows.Forms.ColumnHeader();
			this.chUsername = new System.Windows.Forms.ColumnHeader();
			this.chLogin = new System.Windows.Forms.ColumnHeader();
			this.chLogout = new System.Windows.Forms.ColumnHeader();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.lblContains = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 13;
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
			this.lblHeader.Size = new System.Drawing.Size(95, 22);
			this.lblHeader.TabIndex = 12;
			this.lblHeader.Text = "Log Details";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 11;
			this.picHeader.TabStop = false;
			// 
			// lvLibrarian
			// 
			this.lvLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvLibrarian.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvLibrarian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.chStudentID,
																						  this.chUsername,
																						  this.chLogin,
																						  this.chLogout});
			this.lvLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvLibrarian.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvLibrarian.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvLibrarian.FullRowSelect = true;
			this.lvLibrarian.GridLines = true;
			this.lvLibrarian.HideSelection = false;
			this.lvLibrarian.HoverSelection = true;
			this.lvLibrarian.Location = new System.Drawing.Point(10, 40);
			this.lvLibrarian.MultiSelect = false;
			this.lvLibrarian.Name = "lvLibrarian";
			this.lvLibrarian.Size = new System.Drawing.Size(665, 412);
			this.lvLibrarian.TabIndex = 138;
			this.lvLibrarian.View = System.Windows.Forms.View.Details;
			// 
			// chStudentID
			// 
			this.chStudentID.Text = "Librarian ID";
			this.chStudentID.Width = 150;
			// 
			// chUsername
			// 
			this.chUsername.Text = "Username";
			this.chUsername.Width = 150;
			// 
			// chLogin
			// 
			this.chLogin.Text = "Time Log-in";
			this.chLogin.Width = 300;
			// 
			// chLogout
			// 
			this.chLogout.Text = "Time Log-out";
			this.chLogout.Width = 300;
			// 
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(8, 38);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(668, 416);
			this.picFill.TabIndex = 137;
			this.picFill.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(5, 470);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 19);
			this.label7.TabIndex = 134;
			this.label7.Text = "Users Log Details:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(592, 503);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 125;
			this.label2.Text = "&Reload";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnReload
			// 
			this.bttnReload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnReload.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnReload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnReload.ForeColor = System.Drawing.Color.Black;
			this.bttnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnReload.Location = new System.Drawing.Point(589, 461);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 124;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(640, 503);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 123;
			this.label1.Text = "&Cancel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(637, 461);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 122;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(5, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(290, 17);
			this.lblContains.TabIndex = 121;
			this.lblContains.Text = "This contains all information about the log details.";
			// 
			// FORMLogDetails
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.lvLibrarian);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMLogDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log Details";
			this.Load += new System.EventHandler(this.picLOGO_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void picLOGO_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set the Data Adapter
			daLogList= new OleDbDataAdapter("",clsConnections.CN);

			//Load List of Librarian
			loadLogDetails();
		}

		protected void setImages()
		{
			lvLibrarian.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void loadLogDetails()
		{
			long totalRow =0;
			string sTimeLogin;
			string sTimeLogout;

			daLogList.SelectCommand.CommandText = "SELECT tblLibrarian.LibrarianID, tblLibrarian.UserName, tblUsersLog.[Login], tblUsersLog.[Logout] FROM tblLibrarian RIGHT JOIN tblUsersLog ON tblLibrarian.LibrarianID = tblUsersLog.LibrarianID ORDER BY tblUsersLog.[Login] ASC";

			dsLogList.Clear();
			daLogList.Fill(dsLogList,"tblUsersLog");

			totalRow = dsLogList.Tables["tblUsersLog"].Rows.Count -1;
			
			lvLibrarian.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvLibrarian.Items.Add(new ListViewItem("" + dsLogList.Tables["tblUsersLog"].Rows[i].ItemArray.GetValue(0).ToString(),22));
				lvLibrarian.Items[i].SubItems.Add("" + dsLogList.Tables["tblUsersLog"].Rows[i].ItemArray.GetValue(1).ToString());

				try
				{
					sTimeLogin = dsLogList.Tables["tblUsersLog"].Rows[i].ItemArray.GetValue(2).ToString();
					sTimeLogin = Convert.ToDateTime(sTimeLogin).ToString("MMMM dd, yyyy [ hh:mm:ss ttttt ]");
					lvLibrarian.Items[i].SubItems.Add(sTimeLogin);

					sTimeLogout = dsLogList.Tables["tblUsersLog"].Rows[i].ItemArray.GetValue(3).ToString();
					sTimeLogout = Convert.ToDateTime(sTimeLogout).ToString("MMMM dd, yyyy [ hh:mm:ss ttttt ]");
					lvLibrarian.Items[i].SubItems.Add(sTimeLogout);
				}
				catch(Exception ex){}

			}
			if (lvLibrarian.Items.Count > 0)
			{
				try
				{
					lvLibrarian.Items[0].Focused=true;
					lvLibrarian.Items[0].Selected = true;
					lvLibrarian.Items[0].EnsureVisible();
					lvLibrarian.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnReload_Click(object sender, System.EventArgs e){loadLogDetails();}

	}
}
