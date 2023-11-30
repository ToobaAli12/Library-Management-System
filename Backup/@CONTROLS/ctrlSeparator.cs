using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace LibrarySystem
{
	public class ctrlSeparator : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.Container components = null;

		public ctrlSeparator(){InitializeComponent();}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null){components.Dispose();}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		private void InitializeComponent()
		{
			// 
			// ctrlSeparator
			// 
			this.Name = "ctrlSeparator";
			this.Size = new System.Drawing.Size(264, 8);
			this.Resize += new System.EventHandler(this.ctrlSeparator_Resize);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ctrlSeparator_Paint);

		}
		#endregion

		private void ctrlSeparator_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			e.Graphics.DrawLine(new Pen(Color.FromName("ControlDark")),this.Width,0,0,0);
			e.Graphics.DrawLine(new Pen(Color.FromName("ControlLightLight")),this.Width,1,0,1);
		}

		private void ctrlSeparator_Resize(object sender, System.EventArgs e){this.Height=2;}

	}
}
