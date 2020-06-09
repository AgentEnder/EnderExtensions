namespace EnderExtensionsVSTO
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnderExtensions = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.copyAsSql = this.Factory.CreateRibbonButton();
            this.copyAsNumericSql = this.Factory.CreateRibbonButton();
            this.copyAsCSharp = this.Factory.CreateRibbonButton();
            this.copyAsCSharpNumeric = this.Factory.CreateRibbonButton();
            this.EnderExtensions.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnderExtensions
            // 
            this.EnderExtensions.Groups.Add(this.group1);
            this.EnderExtensions.Label = "EnderExtensions";
            this.EnderExtensions.Name = "EnderExtensions";
            // 
            // group1
            // 
            this.group1.Items.Add(this.copyAsSql);
            this.group1.Items.Add(this.copyAsNumericSql);
            this.group1.Items.Add(this.copyAsCSharp);
            this.group1.Items.Add(this.copyAsCSharpNumeric);
            this.group1.Label = "Copy as Code";
            this.group1.Name = "group1";
            // 
            // copyAsSql
            // 
            this.copyAsSql.Label = "Copy as SQL";
            this.copyAsSql.Name = "copyAsSql";
            this.copyAsSql.OfficeImageId = "AdpViewSqlPane";
            this.copyAsSql.ShowImage = true;
            this.copyAsSql.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.copyAsSql_Click);
            // 
            // copyAsNumericSql
            // 
            this.copyAsNumericSql.Label = "Copy as SQL (numeric)";
            this.copyAsNumericSql.Name = "copyAsNumericSql";
            this.copyAsNumericSql.OfficeImageId = "AdpViewSqlPane";
            this.copyAsNumericSql.ShowImage = true;
            this.copyAsNumericSql.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.copyAsNumericSql_Click);
            // 
            // copyAsCSharp
            // 
            this.copyAsCSharp.Label = "Copy as C#";
            this.copyAsCSharp.Name = "copyAsCSharp";
            this.copyAsCSharp.OfficeImageId = "AdpViewSqlPane";
            this.copyAsCSharp.ShowImage = true;
            this.copyAsCSharp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.copyAsCSharp_Click);
            // 
            // copyAsCSharpNumeric
            // 
            this.copyAsCSharpNumeric.Label = "Copy as C# (numeric)";
            this.copyAsCSharpNumeric.Name = "copyAsCSharpNumeric";
            this.copyAsCSharpNumeric.OfficeImageId = "AdpViewSqlPane";
            this.copyAsCSharpNumeric.ShowImage = true;
            this.copyAsCSharpNumeric.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.copyAsCSharpNumeric_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.EnderExtensions);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.EnderExtensions.ResumeLayout(false);
            this.EnderExtensions.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab EnderExtensions;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton copyAsSql;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton copyAsNumericSql;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton copyAsCSharp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton copyAsCSharpNumeric;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
