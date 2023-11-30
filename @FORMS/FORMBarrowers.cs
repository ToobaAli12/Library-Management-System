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
	public class FORMBarrowers : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		//STRING VARIABLES
		string sAddedBy;
		string sDateAdd;
		string sModifyBy;
		string sDateModify;

		public static FORMBarrowers publicBarrowersList;
		
		OleDbDataAdapter daBarrowersList = new OleDbDataAdapter();
		OleDbCommand cmdDelete;
		DataSet dsBarrowersList = new DataSet();

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox picHeader;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.PictureBox picLOGO;
		private System.Windows.Forms.Label label7;
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
		private System.Windows.Forms.Label lblContains;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabCourse;
		private System.Windows.Forms.ColumnHeader chFullname;
		private System.Windows.Forms.ColumnHeader chStreet;
		private System.Windows.Forms.ColumnHeader chCity;
		private System.Windows.Forms.ColumnHeader chProvince;
		private System.Windows.Forms.ColumnHeader chZipCode;
		private System.Windows.Forms.ComboBox cbYear;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ColumnHeader chContact;
		private System.Windows.Forms.ColumnHeader chEmail;
		public System.Windows.Forms.ListView lvBarrowers;
		private System.Windows.Forms.ColumnHeader chBarrowerID;
		private System.Windows.Forms.Panel panelRIGHT;
		private System.Windows.Forms.PictureBox picBarrower;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button bttnModification;
		private System.Windows.Forms.Button bttnBarrowed;

		private static FORMBarrowers sForm = null;
		public static FORMBarrowers  Instance()
		{
			if(sForm==null){sForm = new FORMBarrowers();}

			return sForm;
		}

		public FORMBarrowers(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FORMBarrowers));
			this.picHeader = new System.Windows.Forms.PictureBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.picLOGO = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
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
			this.lvBarrowers = new System.Windows.Forms.ListView();
			this.chBarrowerID = new System.Windows.Forms.ColumnHeader();
			this.chFullname = new System.Windows.Forms.ColumnHeader();
			this.chStreet = new System.Windows.Forms.ColumnHeader();
			this.chCity = new System.Windows.Forms.ColumnHeader();
			this.chProvince = new System.Windows.Forms.ColumnHeader();
			this.chZipCode = new System.Windows.Forms.ColumnHeader();
			this.chContact = new System.Windows.Forms.ColumnHeader();
			this.chEmail = new System.Windows.Forms.ColumnHeader();
			this.lblContains = new System.Windows.Forms.Label();
			this.tabCourse = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cbLevel = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panelRIGHT = new System.Windows.Forms.Panel();
			this.bttnBarrowed = new System.Windows.Forms.Button();
			this.bttnModification = new System.Windows.Forms.Button();
			this.picBarrower = new System.Windows.Forms.PictureBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tabCourse.SuspendLayout();
			this.panelRIGHT.SuspendLayout();
			this.SuspendLayout();
			// 
			// picHeader
			// 
			this.picHeader.BackColor = System.Drawing.Color.Transparent;
			this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.picHeader.Location = new System.Drawing.Point(0, 0);
			this.picHeader.Name = "picHeader";
			this.picHeader.Size = new System.Drawing.Size(682, 30);
			this.picHeader.TabIndex = 1;
			this.picHeader.TabStop = false;
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
			this.lblHeader.Size = new System.Drawing.Size(87, 22);
			this.lblHeader.TabIndex = 2;
			this.lblHeader.Text = "Barrowers";
			// 
			// picLOGO
			// 
			this.picLOGO.Image = ((System.Drawing.Image)(resources.GetObject("picLOGO.Image")));
			this.picLOGO.Location = new System.Drawing.Point(16, 0);
			this.picLOGO.Name = "picLOGO";
			this.picLOGO.Size = new System.Drawing.Size(24, 24);
			this.picLOGO.TabIndex = 4;
			this.picLOGO.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Firebrick;
			this.label7.Location = new System.Drawing.Point(4, 470);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 19);
			this.label7.TabIndex = 98;
			this.label7.Text = "Barrowers Records:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(398, 504);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 32);
			this.label5.TabIndex = 97;
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
			this.bttnAddNew.Location = new System.Drawing.Point(395, 462);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(40, 40);
			this.bttnAddNew.TabIndex = 96;
			this.bttnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(446, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 95;
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
			this.bttnModify.Location = new System.Drawing.Point(443, 462);
			this.bttnModify.Name = "bttnModify";
			this.bttnModify.Size = new System.Drawing.Size(40, 40);
			this.bttnModify.TabIndex = 94;
			this.bttnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnModify.Click += new System.EventHandler(this.bttnModify_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(494, 504);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 48);
			this.label3.TabIndex = 93;
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
			this.bttnSearch.Location = new System.Drawing.Point(491, 462);
			this.bttnSearch.Name = "bttnSearch";
			this.bttnSearch.Size = new System.Drawing.Size(40, 40);
			this.bttnSearch.TabIndex = 92;
			this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(542, 504);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 48);
			this.label4.TabIndex = 91;
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
			this.bttnDelete.Location = new System.Drawing.Point(539, 462);
			this.bttnDelete.Name = "bttnDelete";
			this.bttnDelete.Size = new System.Drawing.Size(40, 40);
			this.bttnDelete.TabIndex = 90;
			this.bttnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(590, 504);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 64);
			this.label2.TabIndex = 89;
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
			this.bttnReload.Location = new System.Drawing.Point(587, 462);
			this.bttnReload.Name = "bttnReload";
			this.bttnReload.Size = new System.Drawing.Size(40, 40);
			this.bttnReload.TabIndex = 88;
			this.bttnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnReload.Click += new System.EventHandler(this.bttnReload_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(638, 504);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 72);
			this.label1.TabIndex = 87;
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
			this.bttnCancel.Location = new System.Drawing.Point(635, 462);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(40, 40);
			this.bttnCancel.TabIndex = 86;
			this.bttnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// lvBarrowers
			// 
			this.lvBarrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvBarrowers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						  this.chBarrowerID,
																						  this.chFullname,
																						  this.chStreet,
																						  this.chCity,
																						  this.chProvince,
																						  this.chZipCode,
																						  this.chContact,
																						  this.chEmail});
			this.lvBarrowers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lvBarrowers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lvBarrowers.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lvBarrowers.FullRowSelect = true;
			this.lvBarrowers.GridLines = true;
			this.lvBarrowers.HideSelection = false;
			this.lvBarrowers.HoverSelection = true;
			this.lvBarrowers.Location = new System.Drawing.Point(9, 96);
			this.lvBarrowers.MultiSelect = false;
			this.lvBarrowers.Name = "lvBarrowers";
			this.lvBarrowers.Size = new System.Drawing.Size(575, 352);
			this.lvBarrowers.TabIndex = 85;
			this.lvBarrowers.View = System.Windows.Forms.View.Details;
			this.lvBarrowers.SelectedIndexChanged += new System.EventHandler(this.lvBarrowers_SelectedIndexChanged);
			// 
			// chBarrowerID
			// 
			this.chBarrowerID.Text = "Barrower ID";
			this.chBarrowerID.Width = 150;
			// 
			// chFullname
			// 
			this.chFullname.Text = "Barrower Name";
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
			this.chEmail.Width = 150;
			// 
			// lblContains
			// 
			this.lblContains.AutoSize = true;
			this.lblContains.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblContains.ForeColor = System.Drawing.Color.Black;
			this.lblContains.Location = new System.Drawing.Point(4, 490);
			this.lblContains.Name = "lblContains";
			this.lblContains.Size = new System.Drawing.Size(290, 17);
			this.lblContains.TabIndex = 84;
			this.lblContains.Text = "This contains all information about the barrowers.";
			// 
			// tabCourse
			// 
			this.tabCourse.Controls.Add(this.tabPage1);
			this.tabCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabCourse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabCourse.ItemSize = new System.Drawing.Size(121, 21);
			this.tabCourse.Location = new System.Drawing.Point(4, 35);
			this.tabCourse.Name = "tabCourse";
			this.tabCourse.SelectedIndex = 0;
			this.tabCourse.Size = new System.Drawing.Size(676, 421);
			this.tabCourse.TabIndex = 83;
			this.tabCourse.SelectedIndexChanged += new System.EventHandler(this.tabCourse_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(668, 392);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "All Courses";
			// 
			// cbYear
			// 
			this.cbYear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbYear.Location = new System.Drawing.Point(93, 64);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(219, 23);
			this.cbYear.TabIndex = 100;
			this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(14, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 17);
			this.label8.TabIndex = 99;
			this.label8.Text = "School Year:";
			// 
			// comboBox1
			// 
			this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox1.Location = new System.Drawing.Point(88, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(163, 23);
			this.comboBox1.TabIndex = 100;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 17);
			this.label9.TabIndex = 99;
			this.label9.Text = "School Year:";
			// 
			// cbLevel
			// 
			this.cbLevel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbLevel.Location = new System.Drawing.Point(480, 65);
			this.cbLevel.Name = "cbLevel";
			this.cbLevel.Size = new System.Drawing.Size(192, 23);
			this.cbLevel.TabIndex = 102;
			this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(405, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 17);
			this.label10.TabIndex = 101;
			this.label10.Text = "Select Level:";
			// 
			// panelRIGHT
			// 
			this.panelRIGHT.Controls.Add(this.bttnBarrowed);
			this.panelRIGHT.Controls.Add(this.bttnModification);
			this.panelRIGHT.Controls.Add(this.picBarrower);
			this.panelRIGHT.Controls.Add(this.lblEmail);
			this.panelRIGHT.Controls.Add(this.label11);
			this.panelRIGHT.Location = new System.Drawing.Point(586, 96);
			this.panelRIGHT.Name = "panelRIGHT";
			this.panelRIGHT.Size = new System.Drawing.Size(88, 351);
			this.panelRIGHT.TabIndex = 103;
			// 
			// bttnBarrowed
			// 
			this.bttnBarrowed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnBarrowed.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnBarrowed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnBarrowed.Location = new System.Drawing.Point(4, 313);
			this.bttnBarrowed.Name = "bttnBarrowed";
			this.bttnBarrowed.Size = new System.Drawing.Size(80, 35);
			this.bttnBarrowed.TabIndex = 193;
			this.bttnBarrowed.Text = "&Barrowed History";
			this.bttnBarrowed.Click += new System.EventHandler(this.bttnBarrowed_Click);
			// 
			// bttnModification
			// 
			this.bttnModification.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnModification.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.bttnModification.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnModification.Location = new System.Drawing.Point(4, 274);
			this.bttnModification.Name = "bttnModification";
			this.bttnModification.Size = new System.Drawing.Size(80, 35);
			this.bttnModification.TabIndex = 192;
			this.bttnModification.Text = "&Modification History";
			this.bttnModification.Click += new System.EventHandler(this.bttnModification_Click);
			// 
			// picBarrower
			// 
			this.picBarrower.BackColor = System.Drawing.Color.White;
			this.picBarrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picBarrower.Location = new System.Drawing.Point(4, 5);
			this.picBarrower.Name = "picBarrower";
			this.picBarrower.Size = new System.Drawing.Size(80, 88);
			this.picBarrower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBarrower.TabIndex = 30;
			this.picBarrower.TabStop = false;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(198)), ((System.Byte)(81)));
			this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.Color.Brown;
			this.lblEmail.Location = new System.Drawing.Point(5, 120);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 16);
			this.lblEmail.TabIndex = 29;
			this.lblEmail.Text = "Click to Email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(198)), ((System.Byte)(81)));
			this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 98);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 16);
			this.label11.TabIndex = 28;
			this.label11.Text = "Barrower";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FORMBarrowers
			// 
			this.AcceptButton = this.bttnAddNew;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(682, 520);
			this.Controls.Add(this.panelRIGHT);
			this.Controls.Add(this.cbLevel);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblContains);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.bttnModify);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bttnSearch);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.bttnDelete);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnReload);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.lvBarrowers);
			this.Controls.Add(this.tabCourse);
			this.Controls.Add(this.picLOGO);
			this.Controls.Add(this.picHeader);
			this.Controls.Add(this.comboBox1);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FORMBarrowers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Barrowers Records";
			this.Load += new System.EventHandler(this.FORMBarrowers_Load);
			this.tabCourse.ResumeLayout(false);
			this.panelRIGHT.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FORMBarrowers_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Create Directory
			sFunctions.CreateDirectory("\\@Pictures\\@Barrowers");

			//Set the Data Adapter
			daBarrowersList= new OleDbDataAdapter("",clsConnections.CN);

			//Set the Combo Box
			sFunctions.FillCombo(cbYear,"SELECT tblSchoolYear.IndexSY, [YearStart] & ' - ' & [YearEnd] AS SY FROM tblSchoolYear ORDER BY [YearStart] & ' - ' & [YearEnd] ASC","tblSchoolYear",1);
			sFunctions.FillCombo(cbLevel,"SELECT * FROM tblLevel ORDER BY LevelName ASC","tblLevel",1);
			
			//Set the Tab Control
			setTabControl();

			//Load List of Barrowers
			loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' ORDER BY tblBarrowers.BarrowerID ASC");
			
			//Set Buttons History
			setBTTNHistory();

			publicBarrowersList=this;
			this.Refresh();
		}

		protected void setBTTNHistory()
		{
			if(lvBarrowers.Items.Count > 0)
			{
				bttnModification.Enabled = true;
				bttnBarrowed.Enabled=true;
			}
			else
			{
				bttnModification.Enabled = false;
				bttnBarrowed.Enabled=false;
			}
		}

		protected void setImages()
		{
			panelRIGHT.BackgroundImage =MDIFORM.picBanners.Image;
			lvBarrowers.SmallImageList = MDIFORM.i16x16;
			lblHeader.Image = MDIFORM.picBackground.Image;
			picHeader.Image = MDIFORM.picBackground.Image;
			picLOGO.BackgroundImage = MDIFORM.picBackground.Image;

			bttnAddNew.Image = MDIFORM.i32x32.Images[13];
			bttnModify.Image = MDIFORM.i32x32.Images[14];
			bttnSearch.Image = MDIFORM.i32x32.Images[15];
			bttnDelete.Image = MDIFORM.i32x32.Images[16];
			bttnReload.Image = MDIFORM.i32x32.Images[17];
			bttnCancel.Image = MDIFORM.i32x32.Images[18];
		}

		public void loadBarrowers(string sSQL)
		{
			long totalRow =0;

			daBarrowersList.SelectCommand.CommandText = sSQL;

			dsBarrowersList.Clear();
			daBarrowersList.Fill(dsBarrowersList,"tblBarrowers");

			totalRow = dsBarrowersList.Tables["tblBarrowers"].Rows.Count -1;
			
			lvBarrowers.Items.Clear();
			for(int i = 0; i <= totalRow; i++)
			{
				lvBarrowers.Items.Add(new ListViewItem("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(0).ToString(),21));
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(1).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(2).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(3).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(4).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(5).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(6).ToString());
				lvBarrowers.Items[i].SubItems.Add("" + dsBarrowersList.Tables["tblBarrowers"].Rows[i].ItemArray.GetValue(7).ToString());
			}
			if (lvBarrowers.Items.Count > 0)
			{
				try
				{
					lvBarrowers.Items[0].Focused=true;
					lvBarrowers.Items[0].Selected = true;
					lvBarrowers.Items[0].EnsureVisible();
					lvBarrowers.Focus();
				}
				catch(ArgumentOutOfRangeException aooreE){}
				catch(NullReferenceException nreE){}
			}
		}


		public void reload_current()
		{
			try
			{
				int lvw_pos;
				
				lvw_pos=lvBarrowers.FocusedItem.Index;

				if(tabCourse.SelectedTab.Text.Equals("All Courses"))
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' ORDER BY tblBarrowers.BarrowerID ASC");
				}
				else
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblCourse.CourseName LIKE '" + tabCourse.SelectedTab.Text + "' ORDER BY tblBarrowers.BarrowerID ASC");
				}	
			
				if(lvBarrowers.Items.Count != 0 && lvBarrowers.Items.Count-1 >= lvw_pos)
				{
					lvBarrowers.Items[lvBarrowers.FocusedItem.Index].Selected =false;
					lvBarrowers.Items[lvBarrowers.FocusedItem.Index].Focused=false;

					lvBarrowers.Items[lvw_pos].Focused=true;
					lvBarrowers.Items[lvw_pos].Selected = true;
					lvBarrowers.Items[lvw_pos].EnsureVisible();
					
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
				picBarrower.Image.Dispose();
				picBarrower.Image=null;
			}
			catch(NullReferenceException nre){}
		}

		public void LoadSearch(string sField, string sSearch)
		{
			if(tabCourse.TabPages.Count > 0)
			{
				removePic();
				if(tabCourse.SelectedTab.Text.Equals("All Courses"))
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBarrowers.BarrowerID ASC");
				}
				else
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblCourse.CourseName LIKE '" + tabCourse.SelectedTab.Text + "' AND " + sField + " LIKE '%" + sSearch + "%' ORDER BY tblBarrowers.BarrowerID ASC");
				}	
				setBTTNHistory();
			}		
		}

		public void setTabControl(){sFunctions.FillTabControls(tabCourse,"SELECT CourseName FROM tblCourse ORDER BY CourseName ASC","tblCourse","All Courses");}

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void cbLevel_SelectedIndexChanged(object sender, System.EventArgs e){tabCourse_SelectedIndexChanged(sender, e);}

		private void cbYear_SelectedIndexChanged(object sender, System.EventArgs e){tabCourse_SelectedIndexChanged(sender, e);}

		public void tabCourse_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(tabCourse.TabPages.Count > 0)
			{
				if(tabCourse.SelectedTab.Text.Equals("All Courses"))
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' ORDER BY tblBarrowers.BarrowerID ASC");
				}
				else
				{
					loadBarrowers("SELECT tblBarrowers.BarrowerID, [LastName] & ',  ' & [FirstName] & ' ' & [MiddleName] AS Fullname, tblBarrowers.StreetAddress, tblZipCodeList.CityTown, tblZipCodeList.Province, tblZipCodeList.ZipCode, tblBarrowers.ContactNO, tblBarrowers.EmailAddress, [YearStart] & ' - ' & [YearEnd] AS SY, tblCourse.CourseName, tblLevel.LevelName FROM tblZipCodeList RIGHT JOIN (tblSchoolYear INNER JOIN (tblLevel INNER JOIN (tblCourse INNER JOIN tblBarrowers ON tblCourse.IndexCourse = tblBarrowers.Course) ON tblLevel.IndexLevel = tblBarrowers.LevelIndex) ON tblSchoolYear.IndexSY = tblBarrowers.SchoolYear) ON tblZipCodeList.ZipCode = tblBarrowers.ZipCode WHERE [YearStart] & ' - ' & [YearEnd] LIKE '" + cbYear.Text + "' AND tblLevel.LevelName LIKE '" + cbLevel.Text + "' AND tblCourse.CourseName LIKE '" + tabCourse.SelectedTab.Text + "' ORDER BY tblBarrowers.BarrowerID ASC");
				}	
				lvBarrowers_SelectedIndexChanged(sender, e);
			}
		}

		private void bttnSearch_Click(object sender, System.EventArgs e)
		{	
			FORMSearch.sBarrower = "Barrowers";
			FORMSearch sForm = new FORMSearch();
			sForm.ShowDialog();
		}

		private void bttnReload_Click(object sender, System.EventArgs e)
		{
			setTabControl();
			tabCourse_SelectedIndexChanged(sender, e);
		}

		private void bttnDelete_Click(object sender, System.EventArgs e)
		{
			if(lvBarrowers.Items.Count > 0)
			{
				if(MessageBox.Show("This will permanently delete the selected record. Do you want to continue?",clsVariables.sMSGBOX,MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
				{
					try
					{
						removePic();
						try
						{
							sFunctions.setOleDbCommand(cmdDelete,"DELETE FROM tblBarrowers WHERE BarrowerID = @getStudentID","@getStudentID", lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text);
							if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
							{
								File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text + ".lms");
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

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			FORMBarrowers_Modify.ADD_STATE =true;
			FORMBarrowers_Modify sForm = new FORMBarrowers_Modify();
			sForm.ShowDialog();
		}

		private void bttnModify_Click(object sender, System.EventArgs e)
		{
			if(lvBarrowers.Items.Count > 0)
			{
				try
				{
					FORMBarrowers_Modify.ADD_STATE = false;
					FORMBarrowers_Modify.sBarrowerID = lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text;
					FORMBarrowers_Modify sForm = new FORMBarrowers_Modify();
					sForm.ShowDialog();

				}
				catch(ArgumentOutOfRangeException aooreE){MessageBox.Show("" + aooreE.Message);}
				catch(NullReferenceException nreE){}
			}
			else{MessageBox.Show("No record to edit.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);}
		}

		private void lvBarrowers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Picture Details
			removePic();
			if (lvBarrowers.Items.Count > 0)
			{
				try
				{
					setBTTNHistory();
					if(lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text.Equals(""))
					{
						picBarrower.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + "default.lms" ,true);
					}
					else
					{
						if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text + ".lms") == true)
						{
							picBarrower.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\@Pictures\\@Barrowers\\" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text + ".lms" ,true);
						}
					}
					
				}
				catch(Exception ex){}
			}
		}

		private void bttnModification_Click(object sender, System.EventArgs e)
		{
			long totalRow =0;

			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT tblBarrowers.BarrowerID, [tblLibrarian.LastName] & ', ' & [tblLibrarian.FirstName] & ' ' & [tblLibrarian.MiddleName] AS AddedBy, tblBarrowers.DateAdd, [tblLibrarian_1.LastName] & ', ' & [tblLibrarian_1.FirstName] & ' ' & [tblLibrarian_1.MiddleName] AS ModifyBy, tblBarrowers.DateModify FROM tblLibrarian AS tblLibrarian_1 RIGHT JOIN (tblLibrarian LEFT JOIN tblBarrowers ON tblLibrarian.LibrarianID = tblBarrowers.AddedBy) ON tblLibrarian_1.LibrarianID = tblBarrowers.ModifyBy WHERE tblBarrowers.BarrowerID LIKE '" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text + "' ",clsConnections.CN);
			DataSet ds	= new DataSet();
			da.Fill(ds,"tblBarrowers");

			totalRow	= ds.Tables["tblBarrowers"].Rows.Count -1;

			sAddedBy	= ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(1).ToString();
			sDateAdd	= ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(2).ToString();
			sModifyBy	= ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(3).ToString();
			sDateModify = ds.Tables["tblBarrowers"].Rows[0].ItemArray.GetValue(4).ToString();

			MessageBox.Show("Date Added: " + sDateAdd + "\nAdded By: " + sAddedBy + "\n\nLast Modified: " + sModifyBy + "\nModified By:" + sDateModify ,"Midification History",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void bttnBarrowed_Click(object sender, System.EventArgs e)
		{
			FORMBarrowedBooks_History.sBarrowerID = lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[0].Text;
			FORMBarrowedBooks_History sForm = new FORMBarrowedBooks_History();
			sForm.ShowDialog();
		}

		private void lblEmail_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lvBarrowers.Items.Count > 0)
				{System.Diagnostics.Process.Start("mailto:" + lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[7].Text + "?subject=Attn: "+ lvBarrowers.Items[lvBarrowers.FocusedItem.Index].SubItems[1].Text  +"&body=");}
			}
			catch(Exception ex){}
		}

	}
}
