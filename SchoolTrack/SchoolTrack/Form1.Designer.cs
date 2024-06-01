namespace SchoolTrack
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.AppName = new DevExpress.XtraBars.BarHeaderItem();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.StudentsAccordion = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ListStudentsButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.newSchoolDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSchoolDBDataSet = new SchoolTrack.NewSchoolDBDataSet();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.newSchoolDBDataSet1 = new SchoolTrack.NewSchoolDBDataSet();
            this.studentTableAdapter1 = new SchoolTrack.NewSchoolDBDataSetTableAdapters.STUDENTTableAdapter();
            this.newSchoolDBDataSet11 = new SchoolTrack.NewSchoolDBDataSet1();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new SchoolTrack.NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter();
            this.sTUDENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newSchoolDBDataSet2 = new SchoolTrack.NewSchoolDBDataSet();
            this.studentTableAdapter2 = new SchoolTrack.NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter();
            this.colstudent_firstname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sTUDENTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.newSchoolDBDataSet12 = new SchoolTrack.NewSchoolDBDataSet1();
            this.studentTableAdapter3 = new SchoolTrack.NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter();
            this.colstudent_firstname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_lastname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_birthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_adress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_schoolNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).BeginInit();
            this.gridSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.AppName});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // AppName
            // 
            this.AppName.Caption = "TrackSchool";
            this.AppName.Id = 0;
            this.AppName.Name = "AppName";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.StudentsAccordion});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 643);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // StudentsAccordion
            // 
            this.StudentsAccordion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ListStudentsButton,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement5});
            this.StudentsAccordion.Expanded = true;
            this.StudentsAccordion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("StudentsAccordion.ImageOptions.SvgImage")));
            this.StudentsAccordion.Name = "StudentsAccordion";
            this.StudentsAccordion.Text = "Students";
            // 
            // ListStudentsButton
            // 
            this.ListStudentsButton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ListStudentsButton.ImageOptions.SvgImage")));
            this.ListStudentsButton.Name = "ListStudentsButton";
            this.ListStudentsButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ListStudentsButton.Text = "List Students";
            this.ListStudentsButton.Click += new System.EventHandler(this.ListStudentsButton_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Add Students";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement3.ImageOptions.SvgImage")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Remove Students";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Update Students";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.AppName});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1404, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.AppName);
            // 
            // newSchoolDBDataSetBindingSource
            // 
            this.newSchoolDBDataSetBindingSource.DataSource = this.newSchoolDBDataSet;
            this.newSchoolDBDataSetBindingSource.Position = 0;
            // 
            // newSchoolDBDataSet
            // 
            this.newSchoolDBDataSet.DataSetName = "NewSchoolDBDataSet";
            this.newSchoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newSchoolDBDataSet1
            // 
            this.newSchoolDBDataSet1.DataSetName = "NewSchoolDBDataSet";
            this.newSchoolDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // newSchoolDBDataSet11
            // 
            this.newSchoolDBDataSet11.DataSetName = "NewSchoolDBDataSet1";
            this.newSchoolDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.newSchoolDBDataSet11;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource1
            // 
            this.sTUDENTBindingSource1.DataMember = "STUDENT";
            this.sTUDENTBindingSource1.DataSource = this.newSchoolDBDataSet2;
            this.sTUDENTBindingSource1.Sort = "";
            // 
            // newSchoolDBDataSet2
            // 
            this.newSchoolDBDataSet2.DataSetName = "NewSchoolDBDataSet";
            this.newSchoolDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter2
            // 
            this.studentTableAdapter2.ClearBeforeFill = true;
            // 
            // colstudent_firstname
            // 
            this.colstudent_firstname.FieldName = "student_firstname";
            this.colstudent_firstname.MinWidth = 25;
            this.colstudent_firstname.Name = "colstudent_firstname";
            this.colstudent_firstname.Visible = true;
            this.colstudent_firstname.VisibleIndex = 1;
            this.colstudent_firstname.Width = 94;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.gridSplitContainer1);
            this.popupControlContainer1.Location = new System.Drawing.Point(262, 40);
            this.popupControlContainer1.Manager = this.fluentFormDefaultManager1;
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(1141, 641);
            this.popupControlContainer1.TabIndex = 3;
            this.popupControlContainer1.Visible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sTUDENTBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.fluentFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1141, 641);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstudent_firstname1,
            this.colstudent_lastname,
            this.colstudent_birthdate,
            this.colstudent_gender,
            this.colstudent_image,
            this.colstudent_adress,
            this.colstudent_schoolNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sTUDENTBindingSource2
            // 
            this.sTUDENTBindingSource2.DataMember = "STUDENT";
            this.sTUDENTBindingSource2.DataSource = this.newSchoolDBDataSet12;
            this.sTUDENTBindingSource2.Sort = "student_schoolNo ASC";
            // 
            // newSchoolDBDataSet12
            // 
            this.newSchoolDBDataSet12.DataSetName = "NewSchoolDBDataSet1";
            this.newSchoolDBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter3
            // 
            this.studentTableAdapter3.ClearBeforeFill = true;
            // 
            // colstudent_firstname1
            // 
            this.colstudent_firstname1.FieldName = "student_firstname";
            this.colstudent_firstname1.MinWidth = 25;
            this.colstudent_firstname1.Name = "colstudent_firstname1";
            this.colstudent_firstname1.Visible = true;
            this.colstudent_firstname1.VisibleIndex = 0;
            this.colstudent_firstname1.Width = 94;
            // 
            // colstudent_lastname
            // 
            this.colstudent_lastname.FieldName = "student_lastname";
            this.colstudent_lastname.MinWidth = 25;
            this.colstudent_lastname.Name = "colstudent_lastname";
            this.colstudent_lastname.Visible = true;
            this.colstudent_lastname.VisibleIndex = 1;
            this.colstudent_lastname.Width = 94;
            // 
            // colstudent_birthdate
            // 
            this.colstudent_birthdate.FieldName = "student_birthdate";
            this.colstudent_birthdate.MinWidth = 25;
            this.colstudent_birthdate.Name = "colstudent_birthdate";
            this.colstudent_birthdate.Visible = true;
            this.colstudent_birthdate.VisibleIndex = 2;
            this.colstudent_birthdate.Width = 94;
            // 
            // colstudent_gender
            // 
            this.colstudent_gender.FieldName = "student_gender";
            this.colstudent_gender.MinWidth = 25;
            this.colstudent_gender.Name = "colstudent_gender";
            this.colstudent_gender.Visible = true;
            this.colstudent_gender.VisibleIndex = 3;
            this.colstudent_gender.Width = 94;
            // 
            // colstudent_image
            // 
            this.colstudent_image.FieldName = "student_image";
            this.colstudent_image.MinWidth = 25;
            this.colstudent_image.Name = "colstudent_image";
            this.colstudent_image.Visible = true;
            this.colstudent_image.VisibleIndex = 4;
            this.colstudent_image.Width = 94;
            // 
            // colstudent_adress
            // 
            this.colstudent_adress.FieldName = "student_adress";
            this.colstudent_adress.MinWidth = 25;
            this.colstudent_adress.Name = "colstudent_adress";
            this.colstudent_adress.Visible = true;
            this.colstudent_adress.VisibleIndex = 5;
            this.colstudent_adress.Width = 94;
            // 
            // colstudent_schoolNo
            // 
            this.colstudent_schoolNo.FieldName = "student_schoolNo";
            this.colstudent_schoolNo.MinWidth = 25;
            this.colstudent_schoolNo.Name = "colstudent_schoolNo";
            this.colstudent_schoolNo.Visible = true;
            this.colstudent_schoolNo.VisibleIndex = 6;
            this.colstudent_schoolNo.Width = 94;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            // 
            // gridSplitContainer1.Panel1
            // 
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1141, 641);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 682);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSchoolDBDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel1)).EndInit();
            this.gridSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement StudentsAccordion;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarHeaderItem AppName;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ListStudentsButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private System.Windows.Forms.BindingSource newSchoolDBDataSetBindingSource;
        private NewSchoolDBDataSet newSchoolDBDataSet;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private NewSchoolDBDataSet newSchoolDBDataSet1;
        private NewSchoolDBDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private NewSchoolDBDataSet1 newSchoolDBDataSet11;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource1;
        private NewSchoolDBDataSet newSchoolDBDataSet2;
        private NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter2;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_firstname;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource2;
        private NewSchoolDBDataSet1 newSchoolDBDataSet12;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_firstname1;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_lastname;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_birthdate;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_gender;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_image;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_adress;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_schoolNo;
        private NewSchoolDBDataSet1TableAdapters.STUDENTTableAdapter studentTableAdapter3;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}

