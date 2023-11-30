using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class SPLASHSCREEN : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		private System.Windows.Forms.PictureBox picSplashScreen;
		private System.Windows.Forms.Timer timer;
		private System.ComponentModel.IContainer components;

		public SPLASHSCREEN(){InitializeComponent();}

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
			this.components = new System.ComponentModel.Container();
			this.picSplashScreen = new System.Windows.Forms.PictureBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// picSplashScreen
			// 
			this.picSplashScreen.BackColor = System.Drawing.Color.White;
			this.picSplashScreen.Location = new System.Drawing.Point(1, 1);
			this.picSplashScreen.Name = "picSplashScreen";
			this.picSplashScreen.Size = new System.Drawing.Size(423, 219);
			this.picSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSplashScreen.TabIndex = 0;
			this.picSplashScreen.TabStop = false;
			this.picSplashScreen.DoubleClick += new System.EventHandler(this.picSplashScreen_DoubleClick);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 10000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// SPLASHSCREEN
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(425, 221);
			this.ControlBox = false;
			this.Controls.Add(this.picSplashScreen);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SPLASHSCREEN";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.SPLASHSCREEN_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void picSplashScreen_DoubleClick(object sender, System.EventArgs e){this.Close();}

		private void SPLASHSCREEN_Load(object sender, System.EventArgs e){picSplashScreen.Image = MDIFORM.picSPLASH.Image;}

		private void timer_Tick(object sender, System.EventArgs e){this.Close();}
	}
}
