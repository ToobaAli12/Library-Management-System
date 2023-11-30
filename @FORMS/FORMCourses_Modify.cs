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
	public class FORMCourses_Modify : System.Windows.Forms.Form
	{
		//FORM VARIABLES
		MDI MDIFORM = new MDI();

		public static string sCourse;
		public static bool ADD_STATE;

		OleDbCommand cmdAddCourse;

		private System.Windows.Forms.Button bttnCancel;
		private LibrarySystem.ctrlSeparator ctrlSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtCourse;
		private System.Windows.Forms.Button bttnAddNew;
		private System.ComponentModel.Container components = null;

		public FORMCourses_Modify(){InitializeComponent();}

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
			this.bttnCancel = new System.Windows.Forms.Button();
			this.ctrlSeparator1 = new LibrarySystem.ctrlSeparator();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.bttnAddNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bttnCancel
			// 
			this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnCancel.ForeColor = System.Drawing.Color.Black;
			this.bttnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.bttnCancel.Location = new System.Drawing.Point(232, 144);
			this.bttnCancel.Name = "bttnCancel";
			this.bttnCancel.Size = new System.Drawing.Size(70, 24);
			this.bttnCancel.TabIndex = 35;
			this.bttnCancel.Text = "   &Cancel";
			this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
			// 
			// ctrlSeparator1
			// 
			this.ctrlSeparator1.Location = new System.Drawing.Point(8, 136);
			this.ctrlSeparator1.Name = "ctrlSeparator1";
			this.ctrlSeparator1.Size = new System.Drawing.Size(296, 2);
			this.ctrlSeparator1.TabIndex = 33;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(88, 48);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(216, 80);
			this.txtDescription.TabIndex = 32;
			this.txtDescription.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 31;
			this.label1.Text = "Description:";
			// 
			// txtCourse
			// 
			this.txtCourse.Location = new System.Drawing.Point(88, 16);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.Size = new System.Drawing.Size(216, 21);
			this.txtCourse.TabIndex = 0;
			this.txtCourse.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 36;
			this.label2.Text = "Course Name:";
			// 
			// bttnAddNew
			// 
			this.bttnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bttnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bttnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bttnAddNew.Location = new System.Drawing.Point(168, 144);
			this.bttnAddNew.Name = "bttnAddNew";
			this.bttnAddNew.Size = new System.Drawing.Size(58, 24);
			this.bttnAddNew.TabIndex = 37;
			this.bttnAddNew.Text = "    &Save";
			this.bttnAddNew.Click += new System.EventHandler(this.bttnAddNew_Click);
			// 
			// FORMCourses_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.bttnCancel;
			this.ClientSize = new System.Drawing.Size(312, 176);
			this.Controls.Add(this.bttnAddNew);
			this.Controls.Add(this.txtCourse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bttnCancel);
			this.Controls.Add(this.ctrlSeparator1);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FORMCourses_Modify";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add New";
			this.Load += new System.EventHandler(this.FORMCourses_Modify_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void bttnCancel_Click(object sender, System.EventArgs e){this.Close();}

		private void FORMCourses_Modify_Load(object sender, System.EventArgs e)
		{
			setImages();
			if(ADD_STATE==true)
			{
				//Set Add OleDbCommand
				cmdAddCourse = new OleDbCommand("INSERT INTO tblCourse(CourseName,CourseDescription,AddedBy,DateAdd) VALUES(@getCourseName,@getCourseDescription,@getAddedBy,@getDateAdd)",clsConnections.CN);
				this.Text = "Add New";
			}
			else
			{
				//Set Edit OleDbCommand
				cmdAddCourse = new OleDbCommand("UPDATE tblCourse SET CourseName =@getCourseName, CourseDescription =@getCourseDescription WHERE CourseName LIKE '" + sCourse + "' " ,clsConnections.CN);
				fillFields();
				txtCourse.ReadOnly=true;
				this.Text = "Edit Existing";
			}
			cmdAddCourse.Parameters.Add("@getCourseName",OleDbType.VarChar);
			cmdAddCourse.Parameters.Add("@getCourseDescription",OleDbType.VarChar);
			cmdAddCourse.Parameters.Add("@getAddedBy",OleDbType.VarChar);
			cmdAddCourse.Parameters.Add("@getDateAdd",OleDbType.Date);
		}

		private void fillFields()
		{
			long totalRow =0;
			//Set the Data Adapter
			OleDbDataAdapter da = new OleDbDataAdapter("SELECT CourseName,CourseDescription FROM tblCourse WHERE CourseName LIKE '" + sCourse + "' ",clsConnections.CN);
			DataSet ds = new DataSet();
			da.Fill(ds,"tblCourse");

			totalRow = ds.Tables["tblCourse"].Rows.Count -1;

			txtCourse.Text=ds.Tables["tblCourse"].Rows[0].ItemArray.GetValue(0).ToString();
			txtDescription.Text=ds.Tables["tblCourse"].Rows[0].ItemArray.GetValue(1).ToString();
		}

		protected void setImages()
		{
			bttnAddNew.Image=MDIFORM.i16x16.Images[13];
			bttnCancel.Image=MDIFORM.i16x16.Images[14];
		}

		private void bttnAddNew_Click(object sender, System.EventArgs e)
		{
			if(txtCourse.Text == "")
			{
				clsFunctions.isTextEmptyMsg("Course");
				txtCourse.Focus();
			}
			else if(ADD_STATE==true && clsFunctions.recordExist("SELECT CourseName FROM tblCourse WHERE CourseName LIKE '" + txtCourse.Text + "' ","tblCourse") == true)
			{
				MessageBox.Show("Course Name already exist.Please check it and change it!",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				txtCourse.Focus();
			}			
			else
			{
				cmdAddCourse.Parameters["@getCourseName"].Value=txtCourse.Text;
				cmdAddCourse.Parameters["@getCourseDescription"].Value = txtDescription.Text;
				cmdAddCourse.Parameters["@getAddedBy"].Value = clsVariables.sLibrarianID;
				cmdAddCourse.Parameters["@getDateAdd"].Value = DateTime.Now.ToLongDateString ()+ " " + DateTime.Now.ToLongTimeString();

				cmdAddCourse.ExecuteNonQuery();
				FORMCourses.publicCourseList.loadCourse("SELECT CourseName, CourseDescription FROM tblCourse ORDER BY CourseName ASC");

				if(ADD_STATE==false)
				{
					MessageBox.Show("Changes in record has been successfully saved.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Record has been successfully added.",clsVariables.sMSGBOX,MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				this.Close();
			}
		}
	}
}
