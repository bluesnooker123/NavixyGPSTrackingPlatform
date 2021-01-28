namespace Navixy
{
    partial class frmMain
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
            this.btn_start = new MetroFramework.Controls.MetroButton();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.header_IMEI = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Phone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Jan = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Feb = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Mar = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Apr = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_May = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Jun = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Jul = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Aug = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Sep = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Oct = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Nov = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Dec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_Blocked = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.header_SIM_Block = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_start.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_start.Location = new System.Drawing.Point(65, 63);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 25);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Read";
            this.btn_start.UseSelectable = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.header_IMEI);
            this.objectListView1.AllColumns.Add(this.header_Phone);
            this.objectListView1.AllColumns.Add(this.header_Jan);
            this.objectListView1.AllColumns.Add(this.header_Feb);
            this.objectListView1.AllColumns.Add(this.header_Mar);
            this.objectListView1.AllColumns.Add(this.header_Apr);
            this.objectListView1.AllColumns.Add(this.header_May);
            this.objectListView1.AllColumns.Add(this.header_Jun);
            this.objectListView1.AllColumns.Add(this.header_Jul);
            this.objectListView1.AllColumns.Add(this.header_Aug);
            this.objectListView1.AllColumns.Add(this.header_Sep);
            this.objectListView1.AllColumns.Add(this.header_Oct);
            this.objectListView1.AllColumns.Add(this.header_Nov);
            this.objectListView1.AllColumns.Add(this.header_Dec);
            this.objectListView1.AllColumns.Add(this.header_Blocked);
            this.objectListView1.AllColumns.Add(this.header_SIM_Block);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header_IMEI,
            this.header_Phone,
            this.header_Jan,
            this.header_Feb,
            this.header_Mar,
            this.header_Apr,
            this.header_May,
            this.header_Jun,
            this.header_Jul,
            this.header_Aug,
            this.header_Sep,
            this.header_Oct,
            this.header_Nov,
            this.header_Dec,
            this.header_Blocked,
            this.header_SIM_Block});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListView1.GridLines = true;
            this.objectListView1.HasCollapsibleGroups = false;
            this.objectListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.objectListView1.Location = new System.Drawing.Point(20, 106);
            this.objectListView1.MenuLabelGroupBy = "Group by \'\'";
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(1060, 680);
            this.objectListView1.SortGroupItemsByPrimaryColumn = false;
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // header_IMEI
            // 
            this.header_IMEI.AspectName = "aspect_IMEI";
            this.header_IMEI.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_IMEI.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_IMEI.Text = "IMEI";
            this.header_IMEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_IMEI.Width = 150;
            // 
            // header_Phone
            // 
            this.header_Phone.AspectName = "aspect_Phone";
            this.header_Phone.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Phone.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Phone.Text = "Phone";
            this.header_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Phone.Width = 150;
            // 
            // header_Jan
            // 
            this.header_Jan.AspectName = "aspect_Jan";
            this.header_Jan.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Jan.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Jan.Text = "J";
            this.header_Jan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Jan.Width = 40;
            // 
            // header_Feb
            // 
            this.header_Feb.AspectName = "aspect_Feb";
            this.header_Feb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Feb.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Feb.Text = "F";
            this.header_Feb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Feb.Width = 40;
            // 
            // header_Mar
            // 
            this.header_Mar.AspectName = "aspect_Mar";
            this.header_Mar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Mar.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Mar.Text = "M";
            this.header_Mar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Mar.Width = 40;
            // 
            // header_Apr
            // 
            this.header_Apr.AspectName = "aspect_Apr";
            this.header_Apr.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Apr.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Apr.Text = "A";
            this.header_Apr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Apr.Width = 40;
            // 
            // header_May
            // 
            this.header_May.AspectName = "aspect_May";
            this.header_May.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_May.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_May.Text = "M";
            this.header_May.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_May.Width = 40;
            // 
            // header_Jun
            // 
            this.header_Jun.AspectName = "aspect_Jun";
            this.header_Jun.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Jun.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Jun.Text = "J";
            this.header_Jun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Jun.Width = 40;
            // 
            // header_Jul
            // 
            this.header_Jul.AspectName = "aspect_Jul";
            this.header_Jul.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Jul.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Jul.Text = "J";
            this.header_Jul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Jul.Width = 40;
            // 
            // header_Aug
            // 
            this.header_Aug.AspectName = "aspect_Aug";
            this.header_Aug.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Aug.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Aug.Text = "A";
            this.header_Aug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Aug.Width = 40;
            // 
            // header_Sep
            // 
            this.header_Sep.AspectName = "aspect_Sep";
            this.header_Sep.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Sep.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Sep.Text = "S";
            this.header_Sep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Sep.Width = 40;
            // 
            // header_Oct
            // 
            this.header_Oct.AspectName = "aspect_Oct";
            this.header_Oct.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Oct.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Oct.Text = "O";
            this.header_Oct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Oct.Width = 40;
            // 
            // header_Nov
            // 
            this.header_Nov.AspectName = "aspect_Nov";
            this.header_Nov.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Nov.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Nov.Text = "N";
            this.header_Nov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Nov.Width = 40;
            // 
            // header_Dec
            // 
            this.header_Dec.AspectName = "aspect_Dec";
            this.header_Dec.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Dec.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Dec.Text = "D";
            this.header_Dec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Dec.Width = 40;
            // 
            // header_Blocked
            // 
            this.header_Blocked.AspectName = "aspect_Blocked";
            this.header_Blocked.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Blocked.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_Blocked.Text = "BLOCKED";
            this.header_Blocked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_Blocked.Width = 110;
            // 
            // header_SIM_Block
            // 
            this.header_SIM_Block.AspectName = "aspect_SIM_Block";
            this.header_SIM_Block.CheckBoxes = true;
            this.header_SIM_Block.HeaderCheckBox = true;
            this.header_SIM_Block.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_SIM_Block.HeaderForeColor = System.Drawing.Color.Navy;
            this.header_SIM_Block.Text = "SIM BLOCK";
            this.header_SIM_Block.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.header_SIM_Block.Width = 140;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.btn_start);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "GPS Tracking Platform";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_start;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        public BrightIdeasSoftware.OLVColumn header_IMEI;
        public BrightIdeasSoftware.OLVColumn header_Phone;
        private BrightIdeasSoftware.OLVColumn header_Jan;
        private BrightIdeasSoftware.OLVColumn header_Feb;
        private BrightIdeasSoftware.OLVColumn header_Mar;
        private BrightIdeasSoftware.OLVColumn header_Apr;
        private BrightIdeasSoftware.OLVColumn header_May;
        private BrightIdeasSoftware.OLVColumn header_Jun;
        private BrightIdeasSoftware.OLVColumn header_Jul;
        private BrightIdeasSoftware.OLVColumn header_Aug;
        private BrightIdeasSoftware.OLVColumn header_Sep;
        private BrightIdeasSoftware.OLVColumn header_Oct;
        private BrightIdeasSoftware.OLVColumn header_Nov;
        private BrightIdeasSoftware.OLVColumn header_Dec;
        private BrightIdeasSoftware.OLVColumn header_Blocked;
        private BrightIdeasSoftware.OLVColumn header_SIM_Block;
    }
}