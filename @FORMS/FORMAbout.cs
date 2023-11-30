using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class FORMAbout : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnOK;
		private System.Windows.Forms.Button bttnInfo;
		private System.Windows.Forms.PictureBox picSPLASH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;

		private static FORMAbout sForm = null;
		public static FORMAbout  Instance()
		{
			if(sForm==null){sForm = new FORMAbout();}
			return sForm;
		}

		public FORMAbout(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMAbout));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnOK = new System.Windows.Forms.Button();
			this.bttnInfo = new System.Windows.Forms.Button();
			this.picSPLASH = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 7;
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
			this.lblHeader.Size = new System.Drawing.Size(163, 22);
			this.lblHeader.TabIndex = 6;
			this.lblHeader.Text = "Product Information";
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(450, 30);
			this.picHeader.TabIndex = 5;
			this.picHeader.TabStop = false;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 249);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(432, 2);
			this.ctrlSeparator1.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Brown;
			this.label1.Location = new System.Drawing.Point(8, 261);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(336, 48);
			this.label1.TabIndex = 10;
			this.label1.Text = "Warning: This software is copyright 2006 by Jaslad Solutions. Any form of selling" +
				" or reproduction of this software without permission from the author is strictly" +
				" prohibited.";
			// 
			// bttnOK
			// 
			this.bttnOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnOK.Location = new System.Drawing.Point(344, 261);
			this.bttnOK.Name = "bttnOK";
			this.bttnOK.Size = new System.Drawing.Size(96, 25);
			this.bttnOK.TabIndex = 11;
			this.bttnOK.Text = "&OK";
			this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
			// 
			// bttnInfo
			// 
			this.bttnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnInfo.Location = new System.Drawing.Point(344, 293);
			this.bttnInfo.Name = "bttnInfo";
			this.bttnInfo.Size = new System.Drawing.Size(96, 23);
			this.bttnInfo.TabIndex = 0;
			this.bttnInfo.Text = "&System Info...";
			this.bttnInfo.Click += new System.EventHandler(this.bttnInfo_Click);
			// 
			// picSPLASH
			// 
			this.picSPLASH.BackColor = System.Drawing.Color.White;
			this.picSPLASH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picSPLASH.Location = new System.Drawing.Point(8, 40);
			this.picSPLASH.Name = "picSPLASH";
			this.picSPLASH.Size = new System.Drawing.Size(432, 200);
			this.picSPLASH.TabIndex = 14;
			this.picSPLASH.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(112, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(320, 80);
			this.label3.TabIndex = 16;
			this.label3.Text = @"This software was designed for library purpose only. This system can be able to speed-up the proccess of barrowing of books, searching of books, monitoring of due and barrowed books in the library per school year. The system also do all the reporting you needs for  your hard copy of data.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(120, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(312, 16);
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// FORMAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(450, 328);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picSPLASH);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.bttnInfo);
			this.Controls.Add(this.bttnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About the System";
			this.Load += new System.EventHandler(this.FORMAbout_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMAbout_Load(object sender, System.EventArgs e)
		{
			setImages();
		}

		protected void setImages()
		{
			picSPLASH.Image = MDIFORM.picSPLASH.Image;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;
		}

		private void bttnOK_Click(object sender, System.EventArgs e){this.Close();}

		private void bttnInfo_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("NOTE: This application was created by: JUNALD ASTRONOMO LAGOD\nFreelance Programmer/Web Developer/Designer/Technician.\n\n[ APPLICATION TOOLS USED: ]\nProgramming Language: C#.Net 2003\nBack End Database: MS Access 2003\nGraphics Designed: Adobe Photoshop CS2\n\n[ CONTACT INFORMATION: ]\nEmail Address: junaldlagod@yahoo.com\nWebsites:http://www.jasladsolutions.cjb.net\n\thttp://www.junaldlagod.cjb.net\nCellphone Number: +639287899820 (Philippines)\n\n[ JASLAD SOLUTIONS - makers of high quality softwares. ]\n","Short Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

	}
}
