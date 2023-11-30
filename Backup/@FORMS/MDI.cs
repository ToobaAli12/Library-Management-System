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
	public class MDI : System.Windows.Forms.Form
	{
		public static MDI publicMainForm;

		//CLASS VARIABLES
		clsFunctions sFunctions = new clsFunctions();

		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem itmExit;
		private System.Windows.Forms.MenuItem mnuRecords;
		private System.Windows.Forms.MenuItem itmBarrowers_Records;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem mnuSep1_Records;
		private System.Windows.Forms.MenuItem mnuSep2_Records;
		private System.Windows.Forms.MenuItem itmZipCode_Records;
		private System.Windows.Forms.MenuItem itmCategory_Records;
		private System.Windows.Forms.MenuItem itmLevel_Records;
		private System.Windows.Forms.MenuItem itmCourse_Records;
		private System.Windows.Forms.MenuItem mnuReports;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem mnuSep1_Reports;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem mnuTools;
		private System.Windows.Forms.MenuItem itmCalculator;
		private System.Windows.Forms.MenuItem itmSep1_Tools;
		private System.Windows.Forms.MenuItem itmNotepad;
		private System.Windows.Forms.MenuItem itmPaint;
		private System.Windows.Forms.MenuItem mnuWindows;
		private System.Windows.Forms.MenuItem itmNormal;
		private System.Windows.Forms.MenuItem itmMinimized;
		private System.Windows.Forms.MenuItem itmMaximized;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem itmAbout;
		public System.Windows.Forms.ImageList i32x32;
		private System.Windows.Forms.ToolBar tbTOP;
		private System.Windows.Forms.ToolBarButton tbBarrowers;
		private System.Windows.Forms.ToolBarButton tbsep1;
		private System.Windows.Forms.ToolBarButton tbBooks;
		private System.Windows.Forms.ToolBarButton tbsep2;
		private System.Windows.Forms.ToolBarButton tbZips;
		private System.Windows.Forms.ToolBarButton tbCategory;
		private System.Windows.Forms.ToolBarButton tbLevel;
		private System.Windows.Forms.ToolBarButton tbCourse;
		private System.Windows.Forms.ToolBarButton tbsep3;
		private System.Windows.Forms.ToolBarButton tbReports;
		private System.Windows.Forms.ToolBarButton tbsep4;
		private System.Windows.Forms.ToolBarButton tbShortcuts;
		private System.Windows.Forms.ToolBarButton tbAbout;
		private System.Windows.Forms.ContextMenu cmBooks;
		private System.Windows.Forms.MenuItem itmBooksRec;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem itmBarrowed;
		private System.Windows.Forms.MenuItem itmDue;
		private System.Windows.Forms.MenuItem itmReturned;
		private System.Windows.Forms.ContextMenu cmReports;
		private System.Windows.Forms.MenuItem itmInventory_cmR;
		private System.Windows.Forms.MenuItem itmsep1;
		private System.Windows.Forms.MenuItem itmBarrowers_cmR;
		private System.Windows.Forms.MenuItem itmBWF_cmR;
		private System.Windows.Forms.MenuItem itmSep2;
		private System.Windows.Forms.MenuItem itmBooks_cmR;
		private System.Windows.Forms.MenuItem itmBarrowed_cmR;
		private System.Windows.Forms.MenuItem itmDues_cmR;
		private System.Windows.Forms.MenuItem itmReturned_cmR;
		public System.Windows.Forms.ImageList i16x16;
		public System.Windows.Forms.ToolTip toolTip;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolBar tbBOTTOM;
		private System.Windows.Forms.ToolBarButton tbLibrarian;
		private System.Windows.Forms.ToolBarButton tbLogDetails;
		private System.Windows.Forms.ToolBarButton tbSep1_tbBOTTOM;
		private System.Windows.Forms.ToolBarButton tbCalculator;
		private System.Windows.Forms.ToolBarButton tbNotepad;
		private System.Windows.Forms.ToolBarButton tbWordpad;
		private System.Windows.Forms.ToolBarButton tbPaint;
		private System.Windows.Forms.ToolBarButton tbSep2_tbBOTTOM;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.MenuItem itmWordpad;
		private System.Windows.Forms.MenuItem itmShortcuts;
		private System.Windows.Forms.MenuItem itmBooks_Records;
		private System.Windows.Forms.MenuItem itmBarrowed_Records;
		private System.Windows.Forms.MenuItem itmDueBooks_Records;
		private System.Windows.Forms.MenuItem itmReturned_Records;
		private System.Windows.Forms.ToolBarButton tbSchoolYear;
		private System.Windows.Forms.MenuItem itmSY_Records;
		public System.Windows.Forms.PictureBox picBackground;
		private System.Windows.Forms.MenuItem itmDetails_File;
		private System.Windows.Forms.ToolBarButton tbSetup;
		private System.Windows.Forms.MenuItem itmSetup_File;
		private System.Windows.Forms.MenuItem itmLibrarin_File;
		public System.Windows.Forms.PictureBox picSPLASH;
		private System.Windows.Forms.MenuItem mnuManager;
		private System.Windows.Forms.MenuItem itmSep1_Manager;
		private System.Windows.Forms.MenuItem itmSignout;
		private System.Windows.Forms.MenuItem itmSep1_File;
		private System.Windows.Forms.MenuItem mnuSep2_Record;
		private System.Windows.Forms.MenuItem itmAdjust_Records;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem itmAdjustment;
		public System.Windows.Forms.PictureBox picBanners;
		private System.ComponentModel.IContainer components;

		public MDI(){InitializeComponent();}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MDI));
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.itmSignout = new System.Windows.Forms.MenuItem();
			this.itmSep1_File = new System.Windows.Forms.MenuItem();
			this.itmExit = new System.Windows.Forms.MenuItem();
			this.mnuRecords = new System.Windows.Forms.MenuItem();
			this.itmBarrowers_Records = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.itmBooks_Records = new System.Windows.Forms.MenuItem();
			this.mnuSep1_Records = new System.Windows.Forms.MenuItem();
			this.itmBarrowed_Records = new System.Windows.Forms.MenuItem();
			this.itmDueBooks_Records = new System.Windows.Forms.MenuItem();
			this.itmReturned_Records = new System.Windows.Forms.MenuItem();
			this.mnuSep2_Record = new System.Windows.Forms.MenuItem();
			this.itmAdjust_Records = new System.Windows.Forms.MenuItem();
			this.mnuSep2_Records = new System.Windows.Forms.MenuItem();
			this.itmZipCode_Records = new System.Windows.Forms.MenuItem();
			this.itmSY_Records = new System.Windows.Forms.MenuItem();
			this.itmCategory_Records = new System.Windows.Forms.MenuItem();
			this.itmLevel_Records = new System.Windows.Forms.MenuItem();
			this.itmCourse_Records = new System.Windows.Forms.MenuItem();
			this.mnuReports = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.mnuSep1_Reports = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.mnuManager = new System.Windows.Forms.MenuItem();
			this.itmLibrarin_File = new System.Windows.Forms.MenuItem();
			this.itmSetup_File = new System.Windows.Forms.MenuItem();
			this.itmSep1_Manager = new System.Windows.Forms.MenuItem();
			this.itmDetails_File = new System.Windows.Forms.MenuItem();
			this.mnuTools = new System.Windows.Forms.MenuItem();
			this.itmCalculator = new System.Windows.Forms.MenuItem();
			this.itmSep1_Tools = new System.Windows.Forms.MenuItem();
			this.itmWordpad = new System.Windows.Forms.MenuItem();
			this.itmNotepad = new System.Windows.Forms.MenuItem();
			this.itmPaint = new System.Windows.Forms.MenuItem();
			this.mnuWindows = new System.Windows.Forms.MenuItem();
			this.itmNormal = new System.Windows.Forms.MenuItem();
			this.itmMinimized = new System.Windows.Forms.MenuItem();
			this.itmMaximized = new System.Windows.Forms.MenuItem();
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.itmShortcuts = new System.Windows.Forms.MenuItem();
			this.itmAbout = new System.Windows.Forms.MenuItem();
			this.i32x32 = new System.Windows.Forms.ImageList(this.components);
			this.tbTOP = new System.Windows.Forms.ToolBar();
			this.tbBarrowers = new System.Windows.Forms.ToolBarButton();
			this.tbsep1 = new System.Windows.Forms.ToolBarButton();
			this.tbBooks = new System.Windows.Forms.ToolBarButton();
			this.cmBooks = new System.Windows.Forms.ContextMenu();
			this.itmBooksRec = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.itmBarrowed = new System.Windows.Forms.MenuItem();
			this.itmDue = new System.Windows.Forms.MenuItem();
			this.itmReturned = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.itmAdjustment = new System.Windows.Forms.MenuItem();
			this.tbsep2 = new System.Windows.Forms.ToolBarButton();
			this.tbZips = new System.Windows.Forms.ToolBarButton();
			this.tbSchoolYear = new System.Windows.Forms.ToolBarButton();
			this.tbCategory = new System.Windows.Forms.ToolBarButton();
			this.tbLevel = new System.Windows.Forms.ToolBarButton();
			this.tbCourse = new System.Windows.Forms.ToolBarButton();
			this.tbsep3 = new System.Windows.Forms.ToolBarButton();
			this.tbReports = new System.Windows.Forms.ToolBarButton();
			this.cmReports = new System.Windows.Forms.ContextMenu();
			this.itmInventory_cmR = new System.Windows.Forms.MenuItem();
			this.itmsep1 = new System.Windows.Forms.MenuItem();
			this.itmBarrowers_cmR = new System.Windows.Forms.MenuItem();
			this.itmBWF_cmR = new System.Windows.Forms.MenuItem();
			this.itmSep2 = new System.Windows.Forms.MenuItem();
			this.itmBooks_cmR = new System.Windows.Forms.MenuItem();
			this.itmBarrowed_cmR = new System.Windows.Forms.MenuItem();
			this.itmDues_cmR = new System.Windows.Forms.MenuItem();
			this.itmReturned_cmR = new System.Windows.Forms.MenuItem();
			this.tbsep4 = new System.Windows.Forms.ToolBarButton();
			this.tbShortcuts = new System.Windows.Forms.ToolBarButton();
			this.tbAbout = new System.Windows.Forms.ToolBarButton();
			this.i16x16 = new System.Windows.Forms.ImageList(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.tbBOTTOM = new System.Windows.Forms.ToolBar();
			this.tbLibrarian = new System.Windows.Forms.ToolBarButton();
			this.tbSetup = new System.Windows.Forms.ToolBarButton();
			this.tbLogDetails = new System.Windows.Forms.ToolBarButton();
			this.tbSep1_tbBOTTOM = new System.Windows.Forms.ToolBarButton();
			this.tbCalculator = new System.Windows.Forms.ToolBarButton();
			this.tbNotepad = new System.Windows.Forms.ToolBarButton();
			this.tbWordpad = new System.Windows.Forms.ToolBarButton();
			this.tbPaint = new System.Windows.Forms.ToolBarButton();
			this.tbSep2_tbBOTTOM = new System.Windows.Forms.ToolBarButton();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.picBackground = new System.Windows.Forms.PictureBox();
			this.picSPLASH = new System.Windows.Forms.PictureBox();
			this.picBanners = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.mnuFile,
																					 this.mnuRecords,
																					 this.mnuReports,
																					 this.mnuManager,
																					 this.mnuTools,
																					 this.mnuWindows,
																					 this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MdiList = true;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.itmSignout,
																					this.itmSep1_File,
																					this.itmExit});
			this.mnuFile.Text = "&File";
			// 
			// itmSignout
			// 
			this.itmSignout.Index = 0;
			this.itmSignout.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.itmSignout.Text = "&Sign-out User";
			// 
			// itmSep1_File
			// 
			this.itmSep1_File.Index = 1;
			this.itmSep1_File.Text = "-";
			// 
			// itmExit
			// 
			this.itmExit.Index = 2;
			this.itmExit.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
			this.itmExit.Text = "&Exit";
			this.itmExit.Click += new System.EventHandler(this.itmExit_Click);
			// 
			// mnuRecords
			// 
			this.mnuRecords.Index = 1;
			this.mnuRecords.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.itmBarrowers_Records,
																					   this.menuItem13,
																					   this.mnuSep2_Records,
																					   this.itmZipCode_Records,
																					   this.itmSY_Records,
																					   this.itmCategory_Records,
																					   this.itmLevel_Records,
																					   this.itmCourse_Records});
			this.mnuRecords.Text = "&Records";
			// 
			// itmBarrowers_Records
			// 
			this.itmBarrowers_Records.Index = 0;
			this.itmBarrowers_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
			this.itmBarrowers_Records.Text = "&Barrowers";
			this.itmBarrowers_Records.Click += new System.EventHandler(this.itmBarrowers_Records_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.itmBooks_Records,
																					   this.mnuSep1_Records,
																					   this.itmBarrowed_Records,
																					   this.itmDueBooks_Records,
																					   this.itmReturned_Records,
																					   this.mnuSep2_Record,
																					   this.itmAdjust_Records});
			this.menuItem13.Text = "&Books";
			// 
			// itmBooks_Records
			// 
			this.itmBooks_Records.Index = 0;
			this.itmBooks_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.itmBooks_Records.Text = "B&ooks Records";
			this.itmBooks_Records.Click += new System.EventHandler(this.itmBooks_Records_Click);
			// 
			// mnuSep1_Records
			// 
			this.mnuSep1_Records.Index = 1;
			this.mnuSep1_Records.Text = "-";
			// 
			// itmBarrowed_Records
			// 
			this.itmBarrowed_Records.Index = 2;
			this.itmBarrowed_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.itmBarrowed_Records.Text = "B&arrowed Books";
			this.itmBarrowed_Records.Click += new System.EventHandler(this.itmBarrowed_Records_Click);
			// 
			// itmDueBooks_Records
			// 
			this.itmDueBooks_Records.Index = 3;
			this.itmDueBooks_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
			this.itmDueBooks_Records.Text = "&Due Books";
			this.itmDueBooks_Records.Click += new System.EventHandler(this.itmDueBooks_Records_Click);
			// 
			// itmReturned_Records
			// 
			this.itmReturned_Records.Index = 4;
			this.itmReturned_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.itmReturned_Records.Text = "&Returned Books";
			this.itmReturned_Records.Click += new System.EventHandler(this.itmReturned_Records_Click);
			// 
			// mnuSep2_Record
			// 
			this.mnuSep2_Record.Index = 5;
			this.mnuSep2_Record.Text = "-";
			// 
			// itmAdjust_Records
			// 
			this.itmAdjust_Records.Index = 6;
			this.itmAdjust_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.itmAdjust_Records.Text = "Book &Monitoring";
			this.itmAdjust_Records.Click += new System.EventHandler(this.itmAdjust_Records_Click);
			// 
			// mnuSep2_Records
			// 
			this.mnuSep2_Records.Index = 2;
			this.mnuSep2_Records.Text = "-";
			// 
			// itmZipCode_Records
			// 
			this.itmZipCode_Records.Index = 3;
			this.itmZipCode_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.itmZipCode_Records.Text = "&Manage Zip Code";
			this.itmZipCode_Records.Click += new System.EventHandler(this.itmZipCode_Records_Click);
			// 
			// itmSY_Records
			// 
			this.itmSY_Records.Index = 4;
			this.itmSY_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.itmSY_Records.Text = "&SchoolYear";
			this.itmSY_Records.Click += new System.EventHandler(this.itmSY_Records_Click);
			// 
			// itmCategory_Records
			// 
			this.itmCategory_Records.Index = 5;
			this.itmCategory_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.itmCategory_Records.Text = "&Manage Category";
			this.itmCategory_Records.Click += new System.EventHandler(this.itmCategory_Records_Click);
			// 
			// itmLevel_Records
			// 
			this.itmLevel_Records.Index = 6;
			this.itmLevel_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.itmLevel_Records.Text = "&Level Records";
			this.itmLevel_Records.Click += new System.EventHandler(this.itmLevel_Records_Click);
			// 
			// itmCourse_Records
			// 
			this.itmCourse_Records.Index = 7;
			this.itmCourse_Records.Shortcut = System.Windows.Forms.Shortcut.CtrlU;
			this.itmCourse_Records.Text = "&Course Records";
			this.itmCourse_Records.Click += new System.EventHandler(this.itmCourse_Records_Click);
			// 
			// mnuReports
			// 
			this.mnuReports.Index = 2;
			this.mnuReports.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem3,
																					   this.mnuSep1_Reports,
																					   this.menuItem4,
																					   this.menuItem6,
																					   this.menuItem7,
																					   this.menuItem8,
																					   this.menuItem9,
																					   this.menuItem10,
																					   this.menuItem11});
			this.mnuReports.Text = "&Reports";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem3.Text = "&Quick Inventory Report";
			// 
			// mnuSep1_Reports
			// 
			this.mnuSep1_Reports.Index = 1;
			this.mnuSep1_Reports.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.menuItem4.Text = "Barrowers Records";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.menuItem6.Text = "Barrowers w/ Fines";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 4;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 5;
			this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.F4;
			this.menuItem8.Text = "&Book Records";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 6;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.menuItem9.Text = "&Barrowed Books";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 7;
			this.menuItem10.Shortcut = System.Windows.Forms.Shortcut.F6;
			this.menuItem10.Text = "&Due Books";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 8;
			this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.F7;
			this.menuItem11.Text = "&Returned Books";
			// 
			// mnuManager
			// 
			this.mnuManager.Index = 3;
			this.mnuManager.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.itmLibrarin_File,
																					   this.itmSetup_File,
																					   this.itmSep1_Manager,
																					   this.itmDetails_File});
			this.mnuManager.Text = "&System Manager";
			// 
			// itmLibrarin_File
			// 
			this.itmLibrarin_File.Index = 0;
			this.itmLibrarin_File.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.itmLibrarin_File.Text = "&Librarian Records";
			this.itmLibrarin_File.Click += new System.EventHandler(this.itmLibrarin_File_Click);
			// 
			// itmSetup_File
			// 
			this.itmSetup_File.Index = 1;
			this.itmSetup_File.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.itmSetup_File.Text = "&Manage Profile";
			this.itmSetup_File.Click += new System.EventHandler(this.itmSetup_File_Click);
			// 
			// itmSep1_Manager
			// 
			this.itmSep1_Manager.Index = 2;
			this.itmSep1_Manager.Text = "-";
			// 
			// itmDetails_File
			// 
			this.itmDetails_File.Index = 3;
			this.itmDetails_File.Shortcut = System.Windows.Forms.Shortcut.ShiftF3;
			this.itmDetails_File.Text = "Log &Details";
			this.itmDetails_File.Click += new System.EventHandler(this.itmDetails_File_Click);
			// 
			// mnuTools
			// 
			this.mnuTools.Index = 4;
			this.mnuTools.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.itmCalculator,
																					 this.itmSep1_Tools,
																					 this.itmWordpad,
																					 this.itmNotepad,
																					 this.itmPaint});
			this.mnuTools.Text = "&Tools";
			// 
			// itmCalculator
			// 
			this.itmCalculator.Index = 0;
			this.itmCalculator.Shortcut = System.Windows.Forms.Shortcut.AltF1;
			this.itmCalculator.Text = "&Calculator";
			this.itmCalculator.Click += new System.EventHandler(this.itmCalculator_Click);
			// 
			// itmSep1_Tools
			// 
			this.itmSep1_Tools.Index = 1;
			this.itmSep1_Tools.Text = "-";
			// 
			// itmWordpad
			// 
			this.itmWordpad.Index = 2;
			this.itmWordpad.Shortcut = System.Windows.Forms.Shortcut.AltF2;
			this.itmWordpad.Text = "&Wordpad";
			this.itmWordpad.Click += new System.EventHandler(this.itmWordpad_Click);
			// 
			// itmNotepad
			// 
			this.itmNotepad.Index = 3;
			this.itmNotepad.Shortcut = System.Windows.Forms.Shortcut.AltF3;
			this.itmNotepad.Text = "&Notepad";
			this.itmNotepad.Click += new System.EventHandler(this.itmNotepad_Click);
			// 
			// itmPaint
			// 
			this.itmPaint.Index = 4;
			this.itmPaint.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.itmPaint.Text = "&MS Paint";
			this.itmPaint.Click += new System.EventHandler(this.itmPaint_Click);
			// 
			// mnuWindows
			// 
			this.mnuWindows.Index = 5;
			this.mnuWindows.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.itmNormal,
																					   this.itmMinimized,
																					   this.itmMaximized});
			this.mnuWindows.Text = "&Windows";
			// 
			// itmNormal
			// 
			this.itmNormal.Index = 0;
			this.itmNormal.Shortcut = System.Windows.Forms.Shortcut.AltF5;
			this.itmNormal.Text = "&Normal";
			this.itmNormal.Click += new System.EventHandler(this.itmNormal_Click);
			// 
			// itmMinimized
			// 
			this.itmMinimized.Index = 1;
			this.itmMinimized.Shortcut = System.Windows.Forms.Shortcut.AltF6;
			this.itmMinimized.Text = "&Minimized";
			this.itmMinimized.Click += new System.EventHandler(this.itmMinimized_Click);
			// 
			// itmMaximized
			// 
			this.itmMaximized.Index = 2;
			this.itmMaximized.Shortcut = System.Windows.Forms.Shortcut.AltF7;
			this.itmMaximized.Text = "&Maximized";
			this.itmMaximized.Click += new System.EventHandler(this.itmMaximized_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Index = 6;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.itmShortcuts,
																					this.itmAbout});
			this.mnuHelp.Text = "&Help";
			// 
			// itmShortcuts
			// 
			this.itmShortcuts.Index = 0;
			this.itmShortcuts.Shortcut = System.Windows.Forms.Shortcut.CtrlK;
			this.itmShortcuts.Text = "&Key Shortcuts";
			this.itmShortcuts.Click += new System.EventHandler(this.itmShortcuts_Click);
			// 
			// itmAbout
			// 
			this.itmAbout.Index = 1;
			this.itmAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.itmAbout.Text = "&About";
			this.itmAbout.Click += new System.EventHandler(this.itmAbout_Click);
			// 
			// i32x32
			// 
			this.i32x32.ImageSize = new System.Drawing.Size(32, 32);
			this.i32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i32x32.ImageStream")));
			this.i32x32.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tbTOP
			// 
			this.tbTOP.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbTOP.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					 this.tbBarrowers,
																					 this.tbsep1,
																					 this.tbBooks,
																					 this.tbsep2,
																					 this.tbZips,
																					 this.tbSchoolYear,
																					 this.tbCategory,
																					 this.tbLevel,
																					 this.tbCourse,
																					 this.tbsep3,
																					 this.tbReports,
																					 this.tbsep4,
																					 this.tbShortcuts,
																					 this.tbAbout});
			this.tbTOP.ButtonSize = new System.Drawing.Size(30, 30);
			this.tbTOP.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tbTOP.DropDownArrows = true;
			this.tbTOP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbTOP.ImageList = this.i32x32;
			this.tbTOP.Location = new System.Drawing.Point(0, 0);
			this.tbTOP.Name = "tbTOP";
			this.tbTOP.ShowToolTips = true;
			this.tbTOP.Size = new System.Drawing.Size(728, 44);
			this.tbTOP.TabIndex = 5;
			this.tbTOP.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbTOP_ButtonClick);
			// 
			// tbBarrowers
			// 
			this.tbBarrowers.ToolTipText = "Barrowers Records";
			// 
			// tbsep1
			// 
			this.tbsep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbBooks
			// 
			this.tbBooks.DropDownMenu = this.cmBooks;
			this.tbBooks.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			// 
			// cmBooks
			// 
			this.cmBooks.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.itmBooksRec,
																					this.menuItem5,
																					this.itmBarrowed,
																					this.itmDue,
																					this.itmReturned,
																					this.menuItem1,
																					this.itmAdjustment});
			// 
			// itmBooksRec
			// 
			this.itmBooksRec.Index = 0;
			this.itmBooksRec.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.itmBooksRec.Text = "&Books Records";
			this.itmBooksRec.Click += new System.EventHandler(this.itmBooksRec_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "-";
			// 
			// itmBarrowed
			// 
			this.itmBarrowed.Index = 2;
			this.itmBarrowed.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.itmBarrowed.Text = "&Barrowed Books";
			this.itmBarrowed.Click += new System.EventHandler(this.itmBarrowed_Click);
			// 
			// itmDue
			// 
			this.itmDue.Index = 3;
			this.itmDue.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
			this.itmDue.Text = "Due Books";
			this.itmDue.Click += new System.EventHandler(this.itmDue_Click);
			// 
			// itmReturned
			// 
			this.itmReturned.Index = 4;
			this.itmReturned.Shortcut = System.Windows.Forms.Shortcut.CtrlR;
			this.itmReturned.Text = "Returned Books";
			this.itmReturned.Click += new System.EventHandler(this.itmReturned_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 5;
			this.menuItem1.Text = "-";
			// 
			// itmAdjustment
			// 
			this.itmAdjustment.Index = 6;
			this.itmAdjustment.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.itmAdjustment.Text = "Book &Monitoring";
			this.itmAdjustment.Click += new System.EventHandler(this.itmAdjustment_Click);
			// 
			// tbsep2
			// 
			this.tbsep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbZips
			// 
			this.tbZips.ToolTipText = "Manage Zip Code";
			// 
			// tbSchoolYear
			// 
			this.tbSchoolYear.ToolTipText = "School Year";
			// 
			// tbCategory
			// 
			this.tbCategory.ToolTipText = "Manage Category";
			// 
			// tbLevel
			// 
			this.tbLevel.ToolTipText = "Level List";
			// 
			// tbCourse
			// 
			this.tbCourse.ToolTipText = "Course Records";
			// 
			// tbsep3
			// 
			this.tbsep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbReports
			// 
			this.tbReports.DropDownMenu = this.cmReports;
			this.tbReports.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.tbReports.ToolTipText = "Reports";
			// 
			// cmReports
			// 
			this.cmReports.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.itmInventory_cmR,
																					  this.itmsep1,
																					  this.itmBarrowers_cmR,
																					  this.itmBWF_cmR,
																					  this.itmSep2,
																					  this.itmBooks_cmR,
																					  this.itmBarrowed_cmR,
																					  this.itmDues_cmR,
																					  this.itmReturned_cmR});
			// 
			// itmInventory_cmR
			// 
			this.itmInventory_cmR.Index = 0;
			this.itmInventory_cmR.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.itmInventory_cmR.Text = "&Quick Inventory Report";
			this.itmInventory_cmR.Click += new System.EventHandler(this.itmInventory_cmR_Click);
			// 
			// itmsep1
			// 
			this.itmsep1.Index = 1;
			this.itmsep1.Text = "-";
			// 
			// itmBarrowers_cmR
			// 
			this.itmBarrowers_cmR.Index = 2;
			this.itmBarrowers_cmR.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.itmBarrowers_cmR.Text = "Barrowers Records";
			this.itmBarrowers_cmR.Click += new System.EventHandler(this.itmBarrowers_cmR_Click);
			// 
			// itmBWF_cmR
			// 
			this.itmBWF_cmR.Index = 3;
			this.itmBWF_cmR.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.itmBWF_cmR.Text = "Barrowers w/ Fines";
			this.itmBWF_cmR.Click += new System.EventHandler(this.itmBWF_cmR_Click);
			// 
			// itmSep2
			// 
			this.itmSep2.Index = 4;
			this.itmSep2.Text = "-";
			// 
			// itmBooks_cmR
			// 
			this.itmBooks_cmR.Index = 5;
			this.itmBooks_cmR.Shortcut = System.Windows.Forms.Shortcut.F4;
			this.itmBooks_cmR.Text = "Books Records";
			this.itmBooks_cmR.Click += new System.EventHandler(this.itmBooks_cmR_Click);
			// 
			// itmBarrowed_cmR
			// 
			this.itmBarrowed_cmR.Index = 6;
			this.itmBarrowed_cmR.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.itmBarrowed_cmR.Text = "Barrowed Books";
			this.itmBarrowed_cmR.Click += new System.EventHandler(this.itmBarrowed_cmR_Click);
			// 
			// itmDues_cmR
			// 
			this.itmDues_cmR.Index = 7;
			this.itmDues_cmR.Shortcut = System.Windows.Forms.Shortcut.F6;
			this.itmDues_cmR.Text = "Due Books";
			this.itmDues_cmR.Click += new System.EventHandler(this.itmDues_cmR_Click);
			// 
			// itmReturned_cmR
			// 
			this.itmReturned_cmR.Index = 8;
			this.itmReturned_cmR.Shortcut = System.Windows.Forms.Shortcut.F7;
			this.itmReturned_cmR.Text = "Returned Books";
			this.itmReturned_cmR.Click += new System.EventHandler(this.itmReturned_cmR_Click);
			// 
			// tbsep4
			// 
			this.tbsep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbShortcuts
			// 
			this.tbShortcuts.ToolTipText = "Key Shortcuts";
			// 
			// tbAbout
			// 
			this.tbAbout.ToolTipText = "About Library";
			// 
			// i16x16
			// 
			this.i16x16.ImageSize = new System.Drawing.Size(16, 16);
			this.i16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i16x16.ImageStream")));
			this.i16x16.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ctrlSeparator1.Location = new System.Drawing.Point(0, 44);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(728, 2);
			this.ctrlSeparator1.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblTime);
			this.panel1.Controls.Add(this.lblWelcome);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 46);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(728, 18);
			this.panel1.TabIndex = 7;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(661, 0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(67, 18);
			this.lblTime.TabIndex = 2;
			this.lblTime.Text = "Today is:  ";
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(32, 2);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(69, 18);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "Welcome! ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 28);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblCopyright);
			this.panel2.Controls.Add(this.tbBOTTOM);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 435);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(728, 30);
			this.panel2.TabIndex = 9;
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCopyright.Location = new System.Drawing.Point(384, 8);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(306, 18);
			this.lblCopyright.TabIndex = 1;
			this.lblCopyright.Text = "Copyright ©2006. Jaslad Solutions. All Rights Reserved";
			// 
			// tbBOTTOM
			// 
			this.tbBOTTOM.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.tbBOTTOM.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tbLibrarian,
																						this.tbSetup,
																						this.tbLogDetails,
																						this.tbSep1_tbBOTTOM,
																						this.tbCalculator,
																						this.tbNotepad,
																						this.tbWordpad,
																						this.tbPaint,
																						this.tbSep2_tbBOTTOM});
			this.tbBOTTOM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tbBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbBOTTOM.DropDownArrows = true;
			this.tbBOTTOM.ImageList = this.i16x16;
			this.tbBOTTOM.Location = new System.Drawing.Point(0, 2);
			this.tbBOTTOM.Name = "tbBOTTOM";
			this.tbBOTTOM.ShowToolTips = true;
			this.tbBOTTOM.Size = new System.Drawing.Size(728, 28);
			this.tbBOTTOM.TabIndex = 0;
			this.tbBOTTOM.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.tbBOTTOM.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbBOTTOM_ButtonClick);
			// 
			// tbLibrarian
			// 
			this.tbLibrarian.Text = " Librarian";
			// 
			// tbSetup
			// 
			this.tbSetup.Text = "Manage Profile";
			// 
			// tbLogDetails
			// 
			this.tbLogDetails.Text = " Log Details";
			// 
			// tbSep1_tbBOTTOM
			// 
			this.tbSep1_tbBOTTOM.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbCalculator
			// 
			this.tbCalculator.ToolTipText = "Calculator";
			// 
			// tbNotepad
			// 
			this.tbNotepad.ToolTipText = "Notepad";
			// 
			// tbWordpad
			// 
			this.tbWordpad.ToolTipText = "Wordpad";
			// 
			// tbPaint
			// 
			this.tbPaint.ToolTipText = "MS Paint";
			// 
			// tbSep2_tbBOTTOM
			// 
			this.tbSep2_tbBOTTOM.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// picBackground
			// 
			this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
			this.picBackground.Location = new System.Drawing.Point(496, 8);
			this.picBackground.Name = "picBackground";
			this.picBackground.Size = new System.Drawing.Size(0, 0);
			this.picBackground.TabIndex = 11;
			this.picBackground.TabStop = false;
			// 
			// picSPLASH
			// 
			this.picSPLASH.Image = ((System.Drawing.Image)(resources.GetObject("picSPLASH.Image")));
			this.picSPLASH.Location = new System.Drawing.Point(528, 16);
			this.picSPLASH.Name = "picSPLASH";
			this.picSPLASH.Size = new System.Drawing.Size(0, 0);
			this.picSPLASH.TabIndex = 13;
			this.picSPLASH.TabStop = false;
			// 
			// picBanners
			// 
			this.picBanners.Image = ((System.Drawing.Image)(resources.GetObject("picBanners.Image")));
			this.picBanners.Location = new System.Drawing.Point(568, 8);
			this.picBanners.Name = "picBanners";
			this.picBanners.Size = new System.Drawing.Size(0, 0);
			this.picBanners.TabIndex = 3;
			this.picBanners.TabStop = false;
			// 
			// MDI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(728, 465);
			this.Controls.Add(this.picSPLASH);
			this.Controls.Add(this.picBackground);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.tbTOP);
			this.Controls.Add(this.picBanners);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu;
			this.Name = "MDI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LIBRARY MANAGEMENT SYSTEM  [ version 2.0 ]";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MDI_Closing);
			this.Load += new System.EventHandler(this.MDI_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void itmBarrowers_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMBarrowers.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmZipCode_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMZipCodes.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmCategory_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMCategory.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmLevel_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMLevel.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void MDI_Load(object sender, System.EventArgs e)
		{
			//Set Images
			setImages();

			//Set Username
			lblWelcome.Text = "Welcome! " + clsVariables.sLibrarianName;

			//Create Directory
			sFunctions.CreateDirectory("@Pictures");

			//Set Splash Screen
			SPLASHSCREEN SCREEEN = new SPLASHSCREEN();
			SCREEEN.ShowDialog();

			//Set the OLEDBConnection
			clsConnections conn = new clsConnections();
			conn.setConnection(AppDomain.CurrentDomain.BaseDirectory + "\\@Database\\", "MasterFile.mdb", "lib2006");
			
			//Set Institution
			clsInstitutionSetup.setINSTITUTION();

			publicMainForm=this;
		}

		protected void setImages()
		{
			//Set Top Toolbar
			tbBarrowers.ImageIndex=0;
			tbBooks.ImageIndex=1;
			tbZips.ImageIndex=2;
			tbSchoolYear.ImageIndex=12;
			tbCategory.ImageIndex=7;
			tbLevel.ImageIndex=3;
			tbCourse.ImageIndex=4;
			tbReports.ImageIndex=11;
			tbShortcuts.ImageIndex=6;
			tbAbout.ImageIndex=10;

			//Set Bottom Toolbar
			tbLibrarian.ImageIndex =0;
			tbLogDetails.ImageIndex = 1;
			tbSetup.ImageIndex = 19;
			tbCalculator.ImageIndex = 2;
			tbNotepad.ImageIndex =3;
			tbWordpad.ImageIndex =4;
			tbPaint.ImageIndex =5;
		}

		private void MDI_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(MessageBox.Show("This will close the application. Do you want to continue?",clsVariables.sMSGBOX,MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
			{e.Cancel=true;}
			else
			{
				clsUserLogs.record_logout(DateTime.Now.ToString(), clsVariables.sLibrarianID);
				clsConnections.CN.Close();

				MessageBox.Show(clsVariables.sLibrarianName + " has been successfully log-out.","Log-out Time: " + DateTime.Now.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);

				Do_End sForm = new Do_End();
				sForm.ShowDialog();
			}		
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			lblTime.Text = "Today is:  " + DateTime.Now.ToLongDateString () + " [ " + DateTime.Now.ToLongTimeString() + " ] ";
		}

		private void itmCalculator_Click(object sender, System.EventArgs e){clsApp.shell("Calc.exe","Calculator");}

		private void itmNotepad_Click(object sender, System.EventArgs e){clsApp.shell("Notepad.exe","Notepad");}

		private void itmPaint_Click(object sender, System.EventArgs e){clsApp.shell("MSPaint.exe","MS Paint");}

		private void itmWordpad_Click(object sender, System.EventArgs e){clsApp.shell("Write.exe","Wordpad");}

		private void tbBOTTOM_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button == tbLibrarian){itmLibrarin_File.PerformClick();}
			else if(e.Button == tbSetup){itmSetup_File.PerformClick();}
			else if(e.Button == tbLogDetails){itmDetails_File.PerformClick();}
			else if(e.Button == tbCalculator){itmCalculator.PerformClick();}
			else if(e.Button == tbNotepad){itmNotepad.PerformClick();}
			else if(e.Button == tbWordpad){itmWordpad.PerformClick();}
			else if(e.Button == tbPaint){itmPaint.PerformClick();}
		}

		private void itmExit_Click(object sender, System.EventArgs e){this.Close();}

		private void tbTOP_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button == tbBarrowers){itmBarrowers_Records.PerformClick();}
			else if(e.Button == tbZips){itmZipCode_Records.PerformClick();}
			else if(e.Button == tbSchoolYear){itmSY_Records.PerformClick();}
			else if(e.Button == tbCategory){itmCategory_Records.PerformClick();}
			else if(e.Button == tbCourse){itmCourse_Records.PerformClick();}
			else if(e.Button == tbLevel){itmLevel_Records.PerformClick();}
			else if(e.Button == tbShortcuts){itmShortcuts.PerformClick();}
			else if(e.Button == tbAbout){itmAbout.PerformClick();}
		}

		private void itmCourse_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMCourses.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmAbout_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMAbout.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmShortcuts_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMShortcuts.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmBooks_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMBooks.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmBarrowed_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMBarrowedBooks.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmDueBooks_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMDueBooks.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmReturned_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMReturnBooks.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmBooksRec_Click(object sender, System.EventArgs e){itmBooks_Records.PerformClick();}

		private void itmBarrowed_Click(object sender, System.EventArgs e){itmBarrowed_Records.PerformClick();}

		private void itmDue_Click(object sender, System.EventArgs e){itmDueBooks_Records.PerformClick();}

		private void itmReturned_Click(object sender, System.EventArgs e){itmReturned_Records.PerformClick();}

		private void itmNormal_Click(object sender, System.EventArgs e){this.WindowState = FormWindowState.Normal;}

		private void itmMinimized_Click(object sender, System.EventArgs e){this.WindowState = FormWindowState.Minimized;}

		private void itmMaximized_Click(object sender, System.EventArgs e){this.WindowState = FormWindowState.Maximized;}

		private void itmSY_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMSchoolYear.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmDetails_File_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMLogDetails.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmSetup_File_Click(object sender, System.EventArgs e)
		{
			string sVerify="";
			string mySelectQuery = "SELECT InstitutionName FROM tblLibrarySetup";
			
			OleDbCommand myCommand = new OleDbCommand(mySelectQuery,clsConnections.CN);
			OleDbDataReader myReader;
			myReader = myCommand.ExecuteReader();

			while (myReader.Read()){sVerify =  "TRUE";}
			myReader.Close();

			if(sVerify == "TRUE"){FORMLibrarySetup.ADD_STATE = false;}
			else{FORMLibrarySetup.ADD_STATE = true;}

			Form sForm = FORMLibrarySetup.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmLibrarin_File_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMLibrarian.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmInventory_cmR_Click(object sender, System.EventArgs e)
		{
			FORMViewer.sDeploy = "Inventory";
			FORMViewer.sSQL = "SELECT Sum(tblBooks.Qty) AS TotalBooks, Sum(tblBooks.Price) AS TotalPrice, Sum(tblBooks.Barrowed) AS TotalBarrowed, Sum([Qty]-[Barrowed]) AS TotalAvailable FROM tblBooks";
			FORMViewer.sTable = "tblBooks";
			FORMViewer sForm = new FORMViewer();
			sForm.ShowDialog();
		}

		private void itmAdjust_Records_Click(object sender, System.EventArgs e)
		{
			Form sForm = FORMAdjustments.Instance();
			sForm.MdiParent = this;
			sForm.Show();
			sForm.Activate();
		}

		private void itmAdjustment_Click(object sender, System.EventArgs e){itmAdjust_Records_Click(sender, e);}

		private void itmBarrowers_cmR_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Report List";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}

		private void itmBWF_cmR_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Report Fines";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}

		private void itmBooks_cmR_Click(object sender, System.EventArgs e)
		{
			FORMViewer.sDeploy = "Books All";
			FORMViewer.sSQL = "SELECT tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] AS Available " +
				"FROM tblCategory RIGHT JOIN tblBooks ON tblCategory.IndexCategory = tblBooks.CategoryIndex " +
				"GROUP BY tblCategory.CategoryName, tblBooks.BookNo, tblBooks.ISBN, tblBooks.BookTitle, tblBooks.Qty, tblBooks.Barrowed, [tblBooks.Qty]-[tblBooks.Barrowed] " +
				"ORDER BY tblBooks.BookNo ASC";
			FORMViewer.sTable = "tblBooks";
			FORMViewer sForm = new FORMViewer();
			sForm.ShowDialog();
		}

		private void itmBarrowed_cmR_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Report Barrowed Books";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}

		private void itmDues_cmR_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Report Due Books";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}

		private void itmReturned_cmR_Click(object sender, System.EventArgs e)
		{
			FORMSchoolYear_View.sSYSelect = "Report Returned Books";
			FORMSchoolYear_View sForm = new FORMSchoolYear_View();
			sForm.ShowDialog();
		}
	}
}
