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
	public class FORMAdjustments_Modify : System.Windows.Forms.Form
	{
		//STRING VARIABLES
		public static string sBookID;
		public static string sISBN;
		public static string sBookTitle;
		public static string sQuantity;
		public static string sBarrowed;
		public static string sAvailable;

		//OLEDB COMMAND VARIABLES
		OleDbCommand cmdAdjustBook;
		OleDbCommand cmdUpdateBook;

		public static FORMAdjustments_Modify publicBooksList;

		private System.Windows.Forms.Label lblProvice;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.TextBox txtBookNO;
		private System.Windows.Forms.TextBox txtBookTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtQTY;
		private System.Windows.Forms.TextBox txtBarrowed;
		private System.Windows.Forms.TextBox txtAvailable;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnUpdate;
		private System.Windows.Forms.Button bttnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;

		private System.ComponentModel.Container components = null;

		public FORMAdjustments_Modify(){InitializeComponent();}

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
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.lblProvice = new System.Windows.Forms.Label();
			this.txtBookNO = new System.Windows.Forms.TextBox();
			this.lblCity = new System.Windows.Forms.Label();
			this.txtBookTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQTY = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBarrowed = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAvailable = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnUpdate = new System.Windows.Forms.Button();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.SuspendLayout();
			// 
			// txtISBN
			// 
			this.txtISBN.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtISBN.Location = new System.Drawing.Point(91, 43);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.ReadOnly = true;
			this.txtISBN.Size = new System.Drawing.Size(184, 21);
			this.txtISBN.TabIndex = 7;
			this.txtISBN.Text = "";
			// 
			// lblProvice
			// 
			this.lblProvice.AutoSize = true;
			this.lblProvice.Location = new System.Drawing.Point(8, 43);
			this.lblProvice.Name = "lblProvice";
			this.lblProvice.Size = new System.Drawing.Size(33, 17);
			this.lblProvice.TabIndex = 6;
			this.lblProvice.Text = "ISBN:";
			// 
			// txtBookNO
			// 
			this.txtBookNO.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBookNO.Location = new System.Drawing.Point(91, 16);
			this.txtBookNO.Name = "txtBookNO";
			this.txtBookNO.ReadOnly = true;
			this.txtBookNO.Size = new System.Drawing.Size(184, 21);
			this.txtBookNO.TabIndex = 5;
			this.txtBookNO.Text = "";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(8, 16);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(76, 17);
			this.lblCity.TabIndex = 4;
			this.lblCity.Text = "Book Number:";
			// 
			// txtBookTitle
			// 
			this.txtBookTitle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtBookTitle.Location = new System.Drawing.Point(91, 72);
			this.txtBookTitle.Name = "txtBookTitle";
			this.txtBookTitle.ReadOnly = true;
			this.txtBookTitle.Size = new System.Drawing.Size(216, 21);
			this.txtBookTitle.TabIndex = 9;
			this.txtBookTitle.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Book Title:";
			// 
			// txtQTY
			// 
			this.txtQTY.BackColor = System.Drawing.Color.White;
			this.txtQTY.Location = new System.Drawing.Point(91, 104);
			this.txtQTY.Name = "txtQTY";
			this.txtQTY.Size = new System.Drawing.Size(112, 21);
			this.txtQTY.TabIndex = 11;
			this.txtQTY.Text = "0";
			this.txtQTY.TextChanged += new System.EventHandler(this.txtQTY_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Total Quantity:";
			// 
			// txtBarrowed
			// 
			this.txtBarrowed.BackColor = System.Drawing.Color.White;
			this.txtBarrowed.Location = new System.Drawing.Point(91, 136);
			this.txtBarrowed.Name = "txtBarrowed";
			this.txtBarrowed.Size = new System.Drawing.Size(112, 21);
			this.txtBarrowed.TabIndex = 13;
			this.txtBarrowed.Text = "0";
			this.txtBarrowed.TextChanged += new System.EventHandler(this.txtBarrowed_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Total Barrowed:";
			// 
			// txtAvailable
			// 
			this.txtAvailable.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(241)), ((System.Byte)(211)));
			this.txtAvailable.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.txtAvailable.Location = new System.Drawing.Point(91, 166);
			this.txtAvailable.Name = "txtAvailable";
			this.txtAvailable.ReadOnly = true;
			this.txtAvailable.Size = new System.Drawing.Size(133, 21);
			this.txtAvailable.TabIndex = 15;
			this.txtAvailable.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Total Available:";
			// 
			// bttnUpdate
			// 
			this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnUpdate.Location = new System.Drawing.Point(141, 217);
			this.bttnUpdate.Name = "bttnUpdate";
			this.bttnUpdate.Size = new System.Drawing.Size(80, 25);
			this.bttnUpdate.TabIndex = 237;
			this.bttnUpdate.Text = "&Update";
			this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.Location = new System.Drawing.Point(229, 217);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(80, 25);
			this.bttnCancel.TabIndex = 236;
			this.bttnCancel.Text = "&Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(10, 206);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(296, 2);
			this.ctrlSeparator1.TabIndex = 239;
			// 
			// FORMAdjustments_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(314, 248);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.bttnUpdate);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.txtAvailable);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBarrowed);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtQTY);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBookTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtISBN);
			this.Controls.Add(this.lblProvice);
			this.Controls.Add(this.txtBookNO);
			this.Controls.Add(this.lblCity);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMAdjustments_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book Adjustment";
			this.Load += new System.EventHandler(this.FORMAdjustments_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void txtQTY_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				int sAvailable =  0;
				sAvailable = Convert.ToInt32(txtQTY.Text) - Convert.ToInt32(txtBarrowed.Text);
				txtAvailable.Text = sAvailable.ToString();
			}
			catch(Exception ex){MessageBox.Show(ex.Message,"Unable to Compute",MessageBoxButtons.OK,MessageBoxIcon.Error);}
		}

		private void txtBarrowed_TextChanged(object sender, System.EventArgs e){txtQTY_TextChanged(sender, e);}

		private void FORMAdjustments_Modify_Load(object sender, System.EventArgs e)
		{
			//Set Edit OleDbCommand
			cmdAdjustBook = new OleDbCommand("UPDATE tblBooks SET Qty =@getQty, Barrowed =@getBarrowed WHERE BookNo LIKE '" + sBookID + "' " ,clsConnections.CN);

			FillFields();

			cmdAdjustBook.Parameters.Add("@getQty",OleDbType.Double);
			cmdAdjustBook.Parameters.Add("@getBarrowed",OleDbType.Double);

			publicBooksList = this;
		}

		private void FillFields()
		{
			txtBookNO.Text=sBookID;
			txtISBN.Text=sISBN;
			txtBookTitle.Text=sBookTitle;
			txtQTY.Text=sQuantity;
			txtBarrowed.Text=sBarrowed;
			txtAvailable.Text=sAvailable;
		}

		private void bttnUpdate_Click(object sender, System.EventArgs e)
		{
			cmdAdjustBook.Parameters["@getQty"].Value=txtQTY.Text;
			cmdAdjustBook.Parameters["@getBarrowed"].Value=txtBarrowed.Text;

			cmdUpdateBook = new OleDbCommand("INSERT INTO tblAdjustments(BookNumber,AdjustBy,DateAdjust) VALUES(@getBookNumber,@getAdjustBy,@getDateAdjust)",clsConnections.CN);
			cmdUpdateBook.Parameters.Add("@getBookNumber",OleDbType.VarChar);
			cmdUpdateBook.Parameters.Add("@getAdjustBy",OleDbType.VarChar);
			cmdUpdateBook.Parameters.Add("@getDateAdjust",OleDbType.Date);
			cmdUpdateBook.Parameters["@getBookNumber"].Value = sBookID;
			cmdUpdateBook.Parameters["@getAdjustBy"].Value = clsVariables.sLibrarianID;
			cmdUpdateBook.Parameters["@getDateAdjust"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

			cmdUpdateBook.ExecuteNonQuery();
			cmdAdjustBook.ExecuteNonQuery();

			FORMAdjustments.publicAdjustList.tabCategory_SelectedIndexChanged(sender, e);
			MessageBox.Show("Record has been successfully adjust.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			this.Close();
		}

	}
}
