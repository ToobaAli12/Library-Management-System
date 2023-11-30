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
	public class FORMLibrarian : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		public static FORMLibrarian publcLibrarianList;
		
		OleDbDataAdapter daLibrarianList = new OleDbDataAdapter();
		OleDbCommand cmdDelete;
		DataSet dsLibrarianList = new DataSet();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.PictureBox picFill;
		private System.Windows.Forms.ColumnHeader chStudentID;
		private System.Windows.Forms.ColumnHeader chFullname;
		private System.Windows.Forms.ColumnHeader chStreet;
		private System.Windows.Forms.ColumnHeader chCity;
		private System.Windows.Forms.ColumnHeader chProvince;
		private System.Windows.Forms.ColumnHeader chZipCode;
		private System.Windows.Forms.ColumnHeader chContact;
		private System.Windows.Forms.ColumnHeader chEmail;
		private System.Windows.Forms.ColumnHeader chUsername;
		public System.Windows.Forms.ListView lvLibrarian;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button bttnPrint;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bttnAddNew;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button bttnModify;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bttnSearch;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bttnDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnReload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bttnCancel;
		private System.Windows.Forms.Panel panelBOTTOM;
		private System.Windows.Forms.Panel panelRIGHT;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.PictureBox picLibrarian;

		private static FORMLibrarian sForm = null;
		public static FORMLibrarian  Instance()
		{
			if(sForm==null){sForm = new FORMLibrarian();}

			return sForm;
		}

		public FORMLibrarian(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMLibrarian));
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.picFill = new System.Windows.Forms.PictureBox();
			this.lvLibrarian = new System.Windows.Forms.ListView();
			this.chStudentID = new System.Windows.Forms.ColumnHeader();
			this.chFullname = new System.Windows.Forms.ColumnHeader();
			this.chStreet = new System.Windows.Forms.ColumnHeader();
			this.chCity = new System.Windows.Forms.ColumnHeader();
			this.chProvince = new System.Windows.Forms.ColumnHeader();
			this.chZipCode = new System.Windows.Forms.ColumnHeader();
			this.chContact = new System.Windows.Forms.ColumnHeader();
			this.chEmail = new System.Windows.Forms.ColumnHeader();
			this.chUsername = new System.Windows.Forms.ColumnHeader();
			this.panelBOTTOM = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.bttnPrint = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lblContains = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.bttnModify = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.bttnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.bttnDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnReload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.bttnCancel = new System.Windows.Forms.Button();
			this.panelRIGHT = new System.Windows.Forms.Panel();
			this.picLibrarian = new System.Windows.Forms.PictureBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panelBOTTOM.SuspendLayout();
			this.panelRIGHT.SuspendLayout();
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
			this.lblHeader.Size = new System.Drawing.Size(76, 22);
			this.lblHeader.TabIndex = 12;
			this.lblHeader.Text = "Librarian";
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
			// picFill
			// 
			this.picFill.BackColor = System.Drawing.Color.White;
			this.picFill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picFill.Location = new System.Drawing.Point(8, 37);
			this.picFill.Name = "picFill";
			this.picFill.Size = new System.Drawing.Size(583, 416);
			this.picFill.TabIndex = 119;
			this.picFill.TabStop = false;
			// 
			// lvLibrarian
			// 
			this.lvLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvLibrarian.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvLibrarian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.chStudentID,
																						  this.chFullname,
																						  this.chStreet,
																						  this.chCity,
																						  this.chProvince,
																						  this.chZipCode,
																						  this.chContact,
																						  this.chEmail,
																						  this.chUsername});
			this.lvLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvLibrarian.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvLibrarian.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvLibrarian.FullRowSelect = true;
			this.lvLibrarian.GridLines = true;
			this.lvLibrarian.HideSelection = false;
			this.lvLibrarian.HoverSelection = true;
			this.lvLibrarian.Location = new System.Drawing.Point(11, 39);
			this.lvLibrarian.MultiSelect = false;
			this.lvLibrarian.Name = "lvLibrarian";
			this.lvLibrarian.Size = new System.Drawing.Size(578, 412);
			this.lvLibrarian.TabIndex = 120;
			this.lvLibrarian.View = System.Windows.Forms.View.Details;
			this.lvLibrarian.Click += new System.EventHandler(this.lvLibrarian_Click);
			this.lvLibrarian.SelectedIndexChanged += new System.EventHandler(this.lvLibrarian_SelectedIndexChanged);
			// 
			// chStudentID
			// 
			this.chStudentID.Text = "Librarian ID";
			this.chStudentID.Width = 150;
			// 
			// chFullname
			// 
			this.chFullname.Text = "Fullname";
			this.chFullname.Width = 250;
			// 
			// chStreet
			// 
			this.chStreet.Text = "Street Address";
			this.chStreet.Width = 250;
			// 
			// chCity
			// 
			this.chCity.Text = "City/Town";
			this.chCity.Width = 200;
			// 
			// chProvince
			// 
			this.chProvince.Text = "Province/State";
			this.chProvince.Width = 200;
			// 
			// chZipCode
			// 
			this.chZipCode.Text = "ZipCode";
			this.chZipCode.Width = 100;
			// 
			// chContact
			// 
			this.chContact.Text = "Contact Number";
			this.chContact.Width = 150;
			// 
			// chEmail
			// 
			this.chEmail.Text = "Email Address";
			this.chEmail.Width = 200;
			// 
			// chUsername
			// 
			this.chUsername.Text = "Username";
			this.chUsername.Width = 150;
			// 
			// panelBOTTOM
			// 
			this.panelBOTTOM.Controls.Add(this.label8);
			this.panelBOTTOM.Controls.Add(this.bttnPrint);
			this.panelBOTTOM.Controls.Add(this.label7);
			this.panelBOTTOM.Controls.Add(this.lblContains);
			this.panelBOTTOM.Controls.Add(this.label5);
			this.panelBOTTOM.Controls.Add(this.bttnAddNew);
			this.panelBOTTOM.Controls.Add(this.label6);
			this.panelBOTTOM.Controls.Add(this.bttnModify);
			this.panelBOTTOM.Controls.Add(this.label3);
			this.panelBOTTOM.Controls.Add(this.bttnSearch);
			this.panelBOTTOM.Controls.Add(this.label4);
			this.panelBOTTOM.Controls.Add(this.bttnDelete);
			this.panelBOTTOM.Controls.Add(this.label2);
			this.panelBOTTOM.Controls.Add(this.bttnReload);
			this.panelBOTTOM.Controls.Add(this.label1);
			this.panelBOTTOM.Controls.Add(this.bttnCancel);
			this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBOTTOM.Location = new System.Drawing.Point(0, 456);
			this.panelBOTTOM.Name = "panelBOTTOM";
			this.panelBOTTOM.Size = new System.Drawing.Size(682, 64);
			this.panelBOTTOM.TabIndex = 121;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(450, 49);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 48);
			this.label8.TabIndex = 134;
			this.label8.Text = "&Print";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnPrint
			// 
			this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPrint.ForeColor = System.Drawing.Color.Black;
			this.bttnPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnPrint.Location = new System.Drawing.Point(448, 8);
			this.bttnPrint.Name = "bttnPrint";
			this.bttnPrint.Size = new System.Drawing.Size(40, 40);
			this.bttnPrint.TabIndex = 133;
			this.bttnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(6, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 19);
			this.label7.TabIndex = 132;
			this.label7.Text = "Librarian Records:";
			// 
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(5, 30);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(279, 17);
			this.lblContains.TabIndex = 119;
			this.lblContains.Text = "This contains all information about the librarian.";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(356, 49);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 32);
			this.label5.TabIndex = 131;
			this.label5.Text = "&New";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnAddNew.ForeColor = System.Drawing.Color.Black;
			this.bttnAddNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnAddNew.Location = new System.Drawing.Point(352, 9);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(40, 40);
			this.bttnAddNew.TabIndex = 130;
			this.bttnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(404, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 129;
			this.label6.Text = "&Modify";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnModify
			// 
			this.bttnModify.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnModify.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnModify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnModify.ForeColor = System.Drawing.Color.Black;
			this.bttnModify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnModify.Location = new System.Drawing.Point(400, 9);
			this.bttnModify.Name = "bttnModify";
			this.bttnModify.Size = new System.Drawing.Size(40, 40);
			this.bttnModify.TabIndex = 128;
			this.bttnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnModify.Click += new System.EventHandler(this.bttnModify_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(496, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 48);
			this.label3.TabIndex = 127;
			this.label3.Text = "&Search";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnSearch
			// 
			this.bttnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnSearch.ForeColor = System.Drawing.Color.Black;
			this.bttnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnSearch.Location = new System.Drawing.Point(493, 7);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 126;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(544, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 48);
			this.label4.TabIndex = 125;
			this.label4.Text = "&Delete";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// bttnDelete
			// 
			this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnDelete.ForeColor = System.Drawing.Color.Black;
			this.bttnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnDelete.Location = new System.Drawing.Point(541, 7);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(40, 40);
			this.bttnDelete.TabIndex = 124;
			this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(592, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 123;
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
			this.bttnReload.Location = new System.Drawing.Point(589, 7);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 122;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(640, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 121;
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
			this.bttnCancel.Location = new System.Drawing.Point(637, 7);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 120;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// panelRIGHT
			// 
			this.panelRIGHT.Controls.Add(this.picLibrarian);
			this.panelRIGHT.Controls.Add(this.lblEmail);
			this.panelRIGHT.Controls.Add(this.label9);
			this.panelRIGHT.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRIGHT.Location = new System.Drawing.Point(594, 30);
			this.panelRIGHT.Name = "panelRIGHT";
			this.panelRIGHT.Size = new System.Drawing.Size(88, 426);
			this.panelRIGHT.TabIndex = 122;
			// 
			// picLibrarian
			// 
			this.picLibrarian.BackColor = System.Drawing.Color.White;
			this.picLibrarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picLibrarian.Location = new System.Drawing.Point(5, 6);
			this.picLibrarian.Name = "picLibrarian";
			this.picLibrarian.Size = new System.Drawing.Size(80, 88);
			this.picLibrarian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLibrarian.TabIndex = 27;
			this.picLibrarian.TabStop = false;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(198)), ((System.Byte)(81)));
			this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.Color.Brown;
			this.lblEmail.Location = new System.Drawing.Point(4, 120);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 16);
			this.lblEmail.TabIndex = 26;
			this.lblEmail.Text = "Click to Email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(198)), ((System.Byte)(81)));
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(5, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "Librarian";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FORMLibrarian
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.panelRIGHT);
			this.Controls.Add(this.panelBOTTOM);
			this.Controls.Add(this.lvLibrarian);
			this.Controls.Add(this.picFill);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMLibrarian";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "List of Librarian";
			this.Load += new System.EventHandler(this.FORMLibrarian_Load);
			this.panelBOTTOM.ResumeLayout(false);
			this.panelRIGHT.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void loadLibrarians(string sSQL)
		{
			try
			{
				long totalRow =0;

				daLibrarianList.SelectCommand.CommandText = sSQL;

				dsLibrarianList.Clear();
				daLibrarianList.Fill(dsLibrarianList,"tblLibrarian");

				totalRow = dsLibrarianList.Tables["tblLibrarian"].Rows.Count -1;
			
				lvLibrarian.Items.Clear();
				for(int i = 0; i <= totalRow; i++)
				{
					lvLibrarian.Items.Add(new ListViewItem("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(0).ToString(),22));
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(1).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(2).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(3).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(4).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(5).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(6).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(7).ToString());
					lvLibrarian.Items[i].SubItems.Add("" + dsLibrarianList.Tables["tblLibrarian"].Rows[i].ItemArray.GetValue(8).ToString());
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
			catch(Exception ex){}
		}

		public void reload_current()
		{
			try
			{
				int lvw_pos;
				
				lvw_pos=lvLibrarian.FocusedItem.Index;

				loadLibrarians("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode ORDER BY tblLibrarian.LibrarianID ASC");
			
				if(lvLibrarian.Items.Count != 0 && lvLibrarian.Items.Count-1 >= lvw_pos)
				{
					lvLibrarian.Items[lvLibrarian.FocusedItem.Index].Selected =false;
					lvLibrarian.Items[lvLibrarian.FocusedItem.Index].Focused=false;

					lvLibrarian.Items[lvw_pos].Focused=true;
					lvLibrarian.Items[lvw_pos].Selected = true;
					lvLibrarian.Items[lvw_pos].EnsureVisible();
					
				}
				lvw_pos = 0;
				
			}
			catch(ArgumentOutOfRangeException aooreE){}

			catch(NullReferenceException nreE){}

			catch(IOException ioeE){MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message,clsVariables.sMSGBOX,MessageBoxButtons.OK ,MessageBoxIcon.Error);}
		}

		public void removePic()
		{
			try
			{
				picLibrarian.Image.Dispose();
				picLibrarian.Image=null;
			}
			catch(NullReferenceException nre){}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			loadLibrarians("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode WHERE " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblLibrarian.LibrarianID ASC");
		}

		private void FORMLibrarian_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Create Directory
			sFunctions.CreateDirectory("\\@Pictures\\@Librarian");

			//Set the Data Adapter
			daLibrarianList= new OleDbDataAdapter("",clsConnections.CN);

			//Load List of Librarian
			loadLibrarians("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode ORDER BY tblLibrarian.LibrarianID ASC");
		
			publcLibrarianList=this;
		}

		protected void setImages()
		{
			panelRIGHT.BackgroundImage = MDIFORM.picBanners.Image;
			lvLibrarian.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;
			
			bttnAddNew.Image = MDIFORM.i32x32.Images[13];
			bttnModify.Image = MDIFORM.i32x32.Images[14];
			bttnPrint.Image	 = MDIFORM.i32x32.Images[11];
			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnDelete.Image = MDIFORM.i32x32.Images[16];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			FORMLibrarian_Modify.ADD_STATE = true;
			FORMLibrarian_Modify sForm = new FORMLibrarian_Modify();
			sForm.ShowDialog();
		}

		private void bttnModify_Click(object sender, System.EventArgs e)
		{
			if(lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text == clsVariables.sLibrarianID)
			{
				if(lvLibrarian.Items.Count > 0)
				{
					try
					{
						FORMLibrarian_Modify.ADD_STATE = false;
						FORMLibrarian_Modify.sLibrarianID = lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text;
						FORMLibrarian_Modify sForm = new FORMLibrarian_Modify();
						sForm.ShowDialog();

					}
					catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
					catch(NullReferenceException nreE){}
				}
				else{MessageBox.Show("No record to edit.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
			}
			else
			{
				MessageBox.Show("Cannot Edit the Profile of " + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[1].Text + ". Pls. try again later.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void bttnReload_Click(object sender, System.EventArgs e){loadLibrarians("SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName FROM tblZipCodeList RIGHT JOIN tblLibrarian ON tblZipCodeList.ZipCode = tblLibrarian.ZipCode ORDER BY tblLibrarian.LibrarianID ASC");}

		private void bttnDelete_Click(object sender, System.EventArgs e)
		{
			if(lvLibrarian.Items.Count > 0)
			{
				if(MessageBox.Show("This will permanently delete the selected record. Do you want to continue?",clsVariables.sMSGBOX,MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
				{
					try
					{
						removePic();
						try
						{
							sFunctions.setOleDbCommand(cmdDelete,"DELETE FROM tblLibrarian WHERE LibrarianID = @getLibrarianID","@getLibrarianID", lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text);
							if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
							{
								File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text + ".lms");
							}
						}
						catch(Exception ex){MessageBox.Show(ex.Message ,clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}
						reload_current();
					}
					catch(ArgumentOutOfRangeException aooreE){}
					catch(NullReferenceException nreE){}
					catch(IOException ioeE){MessageBox.Show("Error: " + ioeE.Source + ": " + ioeE.Message,clsVariables.sMSGBOX,MessageBoxButtons.OK ,MessageBoxIcon.Error);}
				}
			}
			else{MessageBox.Show("No record to delete.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void lvLibrarian_Click(object sender, System.EventArgs e)
		{
			if(lvLibrarian.Items.Count >0)
			{
				if(lvLibrarian.SelectedItems.Count < 1){MessageBox.Show("Pls. Select an Item.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Error);}
				
				else{lvLibrarian_SelectedIndexChanged(sender, e);}
			}
			else
			{
				MessageBox.Show("No more records found.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}

		private void lvLibrarian_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Picture Details
			removePic();
			if (lvLibrarian.Items.Count > 0)
			{
				try
				{
					if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
					{
						picLibrarian.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Librarian\\" + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[0].Text + ".lms" ,true);
					}
				}
				catch(Exception ex){}
			}
		}

		private void lblEmail_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lvLibrarian.Items.Count > 0)
				{System.Diagnostics.Process.Start("mailto:" + lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[7].Text + "?subject=Attn: "+ lvLibrarian.Items[lvLibrarian.FocusedItem.Index].SubItems[1].Text  +"&body=");}
			}
			catch(Exception ex){}
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{
			FORMSearch.sLibriran = "Librarian";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnPrint_Click(object sender, System.EventArgs e)
		{
			FORMViewer.sDeploy="Librarians";
			FORMViewer.sSQL = "SELECT tblLibrarian.LibrarianID, [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblLibrarian.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblLibrarian.ContactNo, tblLibrarian.EmailAddress, tblLibrarian.UserName " + 
			"FROM tblLibrarian LEFT JOIN tblZipCodeList ON tblLibrarian.ZipCode = tblZipCodeList.ZipCode ORDER BY tblLibrarian.LibrarianID ASC";
			FORMViewer.sTable = "tblLibrarian";
			FORMViewer sForm = new FORMViewer();
			sForm.ShowDialog();
		}

	}
}
