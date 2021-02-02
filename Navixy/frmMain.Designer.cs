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
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder1 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer1 = new XPTable.Renderers.DragDropRenderer();
            this.btn_start = new MetroFramework.Controls.MetroButton();
            this.table = new XPTable.Models.Table();
            this.columnModel = new XPTable.Models.ColumnModel();
            this.tableModel = new XPTable.Models.TableModel();
            this.btn_save_SIM = new MetroFramework.Controls.MetroButton();
            this.btn_hide_show_SIM = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
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
            // table
            // 
            this.table.BorderColor = System.Drawing.Color.Black;
            this.table.ColumnModel = this.columnModel;
            this.table.DataMember = null;
            this.table.DataSourceColumnBinder = dataSourceColumnBinder1;
            dragDropRenderer1.ForeColor = System.Drawing.Color.Red;
            this.table.DragDropRenderer = dragDropRenderer1;
            this.table.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.FullRowSelect = true;
            this.table.GridLines = XPTable.Models.GridLines.Rows;
            this.table.GridLinesContrainedToData = false;
            this.table.HeaderAlignWithColumn = true;
            this.table.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.Location = new System.Drawing.Point(15, 106);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(930, 600);
            this.table.TabIndex = 3;
            this.table.TableModel = this.tableModel;
            this.table.Text = "table1";
            this.table.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // columnModel
            // 
            this.columnModel.HeaderHeight = 30;
            // 
            // tableModel
            // 
            this.tableModel.RowHeight = 20;
            // 
            // btn_save_SIM
            // 
            this.btn_save_SIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_save_SIM.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_save_SIM.Location = new System.Drawing.Point(429, 63);
            this.btn_save_SIM.Name = "btn_save_SIM";
            this.btn_save_SIM.Size = new System.Drawing.Size(90, 25);
            this.btn_save_SIM.TabIndex = 1;
            this.btn_save_SIM.Text = "Save";
            this.btn_save_SIM.UseSelectable = true;
            this.btn_save_SIM.Click += new System.EventHandler(this.btn_save_SIM_Click);
            // 
            // btn_hide_show_SIM
            // 
            this.btn_hide_show_SIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_hide_show_SIM.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_hide_show_SIM.Location = new System.Drawing.Point(793, 63);
            this.btn_hide_show_SIM.Name = "btn_hide_show_SIM";
            this.btn_hide_show_SIM.Size = new System.Drawing.Size(90, 25);
            this.btn_hide_show_SIM.TabIndex = 2;
            this.btn_hide_show_SIM.Text = "Hide";
            this.btn_hide_show_SIM.UseSelectable = true;
            this.btn_hide_show_SIM.Click += new System.EventHandler(this.btn_hide_show_SIM_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.btn_hide_show_SIM);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btn_save_SIM);
            this.Controls.Add(this.btn_start);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "GPS Tracking Platform";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_start;
        private XPTable.Models.Table table;
        private XPTable.Models.ColumnModel columnModel;
        private XPTable.Models.TableModel tableModel;
        private MetroFramework.Controls.MetroButton btn_save_SIM;
        private MetroFramework.Controls.MetroButton btn_hide_show_SIM;
    }
}