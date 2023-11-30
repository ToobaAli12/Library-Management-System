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
	public class LOGSCREEN : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button btnConnect;
		internal System.Windows.Forms.Button btnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLOGO;
		internal System.Windows.Forms.CheckBox chkUnmask;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtPwd;
		internal System.Windows.Forms.Label label4;
		internal System.Windows.Forms.TextBox txtUsername;
		private LibrarySystem.ctrlSeparator ctrlSeparator2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAttempt;
		private System.ComponentModel.Container components = null;

		public LOGSCREEN(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LOGSCREEN));
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.chkUnmask = new System.Windows.Forms.CheckBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.ctrlSeparator2 = new LibrarySystem.ctrlSeparator();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAttempt = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.SystemColors.Control;
			this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConnect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
			this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConnect.Location = new System.Drawing.Point(203, 168);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(72, 22);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "&Connect";
			this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(147, 168);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(48, 22);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Exit";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(5, 48);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(272, 2);
			this.ctrlSeparator1.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 40);
			this.label1.TabIndex = 32;
			this.label1.Text = "Please enter your correct username and password in the space provided bellow to l" +
				"ogin.";
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(8, 8);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(32, 32);
			this.picLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picLOGO.TabIndex = 31;
			this.picLOGO.TabStop = false;
			// 
			// chkUnmask
			// 
			this.chkUnmask.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkUnmask.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkUnmask.Location = new System.Drawing.Point(80, 128);
			this.chkUnmask.Name = "chkUnmask";
			this.chkUnmask.Size = new System.Drawing.Size(136, 16);
			this.chkUnmask.TabIndex = 3;
			this.chkUnmask.Text = "Unmask Password";
			this.chkUnmask.CheckedChanged += new System.EventHandler(this.chkUnmask_CheckedChanged);
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(8, 98);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 16);
			this.Label3.TabIndex = 38;
			this.Label3.Text = "Password:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtPwd
			// 
			this.txtPwd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtPwd.Location = new System.Drawing.Point(80, 96);
			this.txtPwd.MaxLength = 9000;
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '•';
			this.txtPwd.Size = new System.Drawing.Size(184, 21);
			this.txtPwd.TabIndex = 2;
			this.txtPwd.Tag = "Password";
			this.txtPwd.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "User Name:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(80, 64);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(184, 21);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.Text = "";
			// 
			// ctrlSeparator2
			// 
			this.ctrlSeparator2.Location = new System.Drawing.Point(5, 160);
			this.ctrlSeparator2.Name = "ctrlSeparator2";
			this.ctrlSeparator2.Size = new System.Drawing.Size(272, 2);
			this.ctrlSeparator2.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 41;
			this.label2.Text = "Attempt:";
			// 
			// lblAttempt
			// 
			this.lblAttempt.AutoSize = true;
			this.lblAttempt.Location = new System.Drawing.Point(64, 168);
			this.lblAttempt.Name = "lblAttempt";
			this.lblAttempt.Size = new System.Drawing.Size(10, 17);
			this.lblAttempt.TabIndex = 42;
			this.lblAttempt.Text = "3";
			// 
			// LOGSCREEN
			// 
			this.AcceptButton = this.btnConnect;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(282, 200);
			this.Controls.Add(this.lblAttempt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.ctrlSeparator2);
			this.Controls.Add(this.chkUnmask);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnCancel);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LOGSCREEN";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN SCREEN";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.LOGSCREEN_Closing);
			this.Load += new System.EventHandler(this.LOGSCREEN_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void LOGSCREEN_Load(object sender, System.EventArgs e)
		{
			//Set the OLEDBConnection
			clsConnections conn = new clsConnections();
			conn.setConnection(AppDomain.CurrentDomain.BaseDirectory + "\\@Database\\", "MasterFile.mdb", "lib2006");
		}

		private void chkUnmask_CheckedChanged(object sender, System.EventArgs e)
		{
			if(chkUnmask.Checked==true){this.txtPwd.PasswordChar=Convert.ToChar(0);}
			else{this.txtPwd.PasswordChar='•';}
		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			if(clsFunctions.recordExist("SELECT LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname FROM tblLibrarian WHERE UserName LIKE '" + txtUsername.Text + "' AND UPassword LIKE '" + txtPwd.Text + "' ","tblLibrarian") == true)
			{
				clsVariables.sTimeLogin = DateTime.Now.ToLongTimeString();

				long totalRow =0;

				//Set the Data Adapter
				OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.UserName FROM tblLibrarian WHERE tblLibrarian.UserName LIKE '" + txtUsername.Text + "' ",clsConnections.CN);
				DataSet ds = new DataSet();
				da.Fill(ds,"tblLibrarian");

				totalRow = ds.Tables["tblLibrarian"].Rows.Count -1;

				clsVariables.sLibrarianID = ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(0).ToString();
				clsVariables.sLibrarianName = ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(1).ToString();
				clsVariables.sUserID = ds.Tables["tblLibrarian"].Rows[0].ItemArray.GetValue(2).ToString();

				clsUserLogs.record_login(clsVariables.sTimeLogin,clsVariables.sLibrarianID);
				clsApp.APP_CONNECTED=true;
				this.Close();
			}
			else
			{
				if(lblAttempt.Text == "1")
				{
					MessageBox.Show("You already used all the attempts.\nThis will terminate the application.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);
					this.Close();
				}
				else
				{
					int iAttempt;

					iAttempt = Convert.ToInt32(lblAttempt.Text) - 1;
					lblAttempt.Text = iAttempt.ToString();
					MessageBox.Show("Invalid Username/Password. Please try again.\n\nWarning: You only have " + lblAttempt.Text  + " attempt.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
		}

		private void LOGSCREEN_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			clsConnections.CN.Close();
		}
	}
}
