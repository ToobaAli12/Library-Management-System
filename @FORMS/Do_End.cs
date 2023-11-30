using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class Do_End : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button bttnCLOSE;
		private System.ComponentModel.Container components = null;

		public Do_End(){InitializeComponent();}

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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bttnCLOSE = new System.Windows.Forms.Button();
			this.SuspendLayout();
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
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = @"
LIBRARY MANAGEMENT SYSTEM ver. 2.0
- APPLICATION AND DEVELOPER INFO -

=======================================
:: MESSAGE FROM THE AUTHOR ::
=======================================
-The reason why I share this C#.Net program is not boast my skill. I shared this code to help 
 other develop to stand with their own knowledge. To developed customable programs. 
 optimized codes,organized database tables and etc. 
 I need your vote as acknowledgement of my work only.

NOTE: This is a back-up copy. I made some modifications for this program when i gave it to my client. But this file will work also. Enjoy!!!!!

 THAT'S ALL AND THANKS FOR READING!!!!!!!!!!!!
 IF YOU BARROWED SOME CODES GIVE A CREDIT TO THE AUTHOR!!!!!!
 PLEASE VOTE! COZ I CONSIDER YOUR VOTE AS ACKNOWLEDGEMENT TO THIS WORK

 HELLO TO ALL MY FRIENDS!!!!!!!!!!
 -> Mabuhay ang Pinoy !
 -> Mabuhay ang Philippines
 -> Mabuhay ang Mindanao
 -> Mabuhay ang North Cotabato
 -> Mabuhay ang Kidapawan City
 -> Mabuhay si Junald Astronomo Lagod

Developerr: Junald Astronomo Lagod (Programmer/Web Developer)
                     http://www.junaldlagod.cjb.net

*NOTE: I AM WILLING TO WORK IN ABROAD AS PROGRAMMER AND WEB DEVELOPER 
              OR ANY IT RELATED JOBS IN A RIGHT PRICE. THANKS!!!";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(528, 448);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// bttnCLOSE
			// 
			this.bttnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCLOSE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCLOSE.Location = new System.Drawing.Point(192, 462);
			this.bttnCLOSE.Name = "bttnCLOSE";
			this.bttnCLOSE.Size = new System.Drawing.Size(144, 24);
			this.bttnCLOSE.TabIndex = 5;
			this.bttnCLOSE.Text = "&Close this Form!";
			this.bttnCLOSE.Click += new System.EventHandler(this.bttnCLOSE_Click);
			// 
			// Do_End
			// 
			this.AcceptButton = this.bttnCLOSE;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.bttnCLOSE;
			this.ClientSize = new System.Drawing.Size(528, 494);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.bttnCLOSE);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Do_End";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ":: MESSAGGE FROM THE AUTHOR ::";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Do_End_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCLOSE_Click(object sender, System.EventArgs e){this.Close();}

		private void Do_End_Closing(object sender, System.ComponentModel.CancelEventArgs e){System.Diagnostics.Process.Start("http://www.votelms.cjb.net");}
	}
}
