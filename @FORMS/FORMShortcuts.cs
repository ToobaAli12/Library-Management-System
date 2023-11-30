using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class FORMShortcuts : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		private System.ComponentModel.Container components = null;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtKeys;

		private static FORMShortcuts sForm = null;
		public static FORMShortcuts  Instance()
		{
			if(sForm==null){sForm = new FORMShortcuts();}

			return sForm;
		}

		public FORMShortcuts(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMShortcuts));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtKeys = new System.Windows.Forms.TextBox();
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
			this.lblHeader.Size = new System.Drawing.Size(118, 22);
			this.lblHeader.TabIndex = 9;
			this.lblHeader.Text = "Shortcut Keys";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(319, 30);
			this.picHeader.TabIndex = 8;
			this.picHeader.TabStop = false;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(6, 440);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(306, 2);
			this.ctrlSeparator1.TabIndex = 11;
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
			this.bttnCancel.Location = new System.Drawing.Point(213, 450);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(100, 30);
			this.bttnCancel.TabIndex = 35;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(5, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(307, 392);
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			// 
			// txtKeys
			// 
			this.txtKeys.BackColor = System.Drawing.Color.White;
			this.txtKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtKeys.Location = new System.Drawing.Point(93, 52);
			this.txtKeys.Multiline = true;
			this.txtKeys.Name = "txtKeys";
			this.txtKeys.ReadOnly = true;
			this.txtKeys.Size = new System.Drawing.Size(210, 368);
			this.txtKeys.TabIndex = 37;
			this.txtKeys.Text = @"Librarian Records		Shift + F1
Libarary Setup		Shift + F2
Log Details		Shift + F3
Log-Off			Shift + F4
Exit Appliction		Shift + F5

Barrowers Records		Ctrl   + B 
Books Records		Ctrl   + O 
Barrowed Books		Ctrl   + A 
Due Books		Ctrl   + D 
Returned Books		Ctrl   + R 
Book Monitoring		Ctrl   + M 

Quick Inventory Report	F1	
Barrowers Report		F2	
Barrowers w/ Fines		F3	
Book Report		F4	
Barrowed Books Reports	F5	
Due Books Reports		F6	
Returned Books Reports	F7	

Calculator		Alt    + F1
Wordpad			Alt    + F2
Notepad			Alt    + F3
MS Paint			Alt    + F4
Normal Window		Alt    + F5
Minimized Window		Alt    + F6
Maximized Window		Alt    + F7";
			// 
			// FORMShortcuts
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(319, 488);
			this.Controls.Add(this.txtKeys);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMShortcuts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Key Shortcuts";
			this.Load += new System.EventHandler(this.FORMShortcuts_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMShortcuts_Load(object sender, System.EventArgs e){setImages();}

		protected void setImages()
		{
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}
	}
}
