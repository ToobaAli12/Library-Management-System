using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class Do_FIRST : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button bttnCLOSE;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.ComponentModel.Container components = null;

		public Do_FIRST(){InitializeComponent();}

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
			this.bttnCLOSE = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bttnCLOSE
			// 
			this.bttnCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCLOSE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCLOSE.Location = new System.Drawing.Point(192, 463);
			this.bttnCLOSE.Name = "bttnCLOSE";
			this.bttnCLOSE.Size = new System.Drawing.Size(144, 24);
			this.bttnCLOSE.TabIndex = 2;
			this.bttnCLOSE.Text = "&Close this Form!";
			this.bttnCLOSE.Click += new System.EventHandler(this.bttnCLOSE_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(528, 448);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(530, 450);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "\r\nLIBRARY MANAGEMENT SYSTEM ver. 2.0\r\n- APPLICATION AND DEVELOPER INFO -\r\n\r\nNOTE:" +
				" This is a back-up copy. I made some modifications for this program when i gave " +
				"it to my client. But this file will work also. Enjoy!!!!!\r\n\r\n===================" +
				"====================\r\n:: INFORMATION OF THE DEVELOPER ::\r\n======================" +
				"=================\r\nDeveloper: Junald Astronomo Lagod\r\nCurrent Address: Lumogdang" +
				" Subd., Kidapawan City, Philippines 09400\r\nContact Number: +639287899820 (Philip" +
				"pines)\r\nEmail Address: junaldlagod@yahoo.com\r\nWebsite Address: www.junaldlagod.c" +
				"jb.net\r\n\r\nLanguage Commondly Used: VBA, VB, VB.NET, C#.NET, JAVA, ASP, ASP.NET, " +
				"JSP\r\nReserved Language: C++, VC++, C++.NET, J#.NET, PHP\r\nArchitecture: N-Tier,2-" +
				"Tier,Multi-Tier,.NET Smart Client Architecture(Under Study)\r\nRDBMS: MS Access, m" +
				"ySQL and SQL Server (Oracle is under study)\r\n\r\n- JOB EXPERIENCE -\r\nCompany: Kida" +
				"pawan City Municipal Hall\r\nAgency: Government Agency\r\nDepartement: Engineer Depa" +
				"rtment\r\nJob: Programmer/Technician/Designer\r\n\r\nCompany: Support to Agrarian Refo" +
				"rm Communities in Central Mindanao (STARCM)\r\nAgency: Semi Government Agency\r\nFun" +
				"ded: European Governement (Foreign  Funded)\r\nDepartment: Management and Informat" +
				"ion Group (MIG)\r\nJob:  Programmer/Technician/Designer/Web Developer\r\n\r\n- EDUCATI" +
				"ONAL BACKGROUND -\r\nElementary: Kidapawan City Pilot Elementary School  \r\nSeconda" +
				"ry: Kidapawan City National High School\r\nCollege: Systems Technology Institute (" +
				"STI Kidapawan)\r\nEducation: Diploma in E-Commerce Programming\r\n\r\n================" +
				"=======================\r\n:: PROGRAM REQUIREMENTS ::\r\n===========================" +
				"============\r\n1. Comuter (desktor, laptop or any)\r\n2. Microsoft Operating System" +
				"s(2000, XP or Higher version)\r\n3. Common Language Runtime (CLR)\r\n4. thats all\r\n\r" +
				"\n\r\n=======================================\r\n:: DATABASE ::\r\n====================" +
				"===================\r\nDatabase Name: MasterFile.mdb\r\nDatabase Passowrd: lib2006\r\n" +
				"\r\n=======================================\r\n:: APPLICATION ::\r\n==================" +
				"=====================\r\nUser ID: junaldlagod\r\nUser Password: junaldlagod\r\n\r\nUser " +
				"ID: admin\r\nUser Password: admin\r\n\r\n\r\n*NOTE: I AM WILLING TO WORK IN ABROAD AS PR" +
				"OGRAMMER AND WEB DEVELOPER \r\n              OR ANY IT RELATED JOBS IN A RIGHT PRI" +
				"CE. THANKS!!!";
			// 
			// Do_FIRST
			// 
			this.AcceptButton = this.bttnCLOSE;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.bttnCLOSE;
			this.ClientSize = new System.Drawing.Size(530, 496);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bttnCLOSE);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Do_FIRST";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ":: MESSAGGE FROM THE AUTHOR ::";
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCLOSE_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://jasladsolutions.cjb.net");
			this.Close();
		}
	}
}
