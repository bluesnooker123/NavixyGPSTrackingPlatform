namespace Navixy
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.login_password = new MetroFramework.Controls.MetroTextBox();
            this.login_user = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_password
            // 
            // 
            // 
            // 
            this.login_password.CustomButton.Image = null;
            this.login_password.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.login_password.CustomButton.Name = "";
            this.login_password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.login_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_password.CustomButton.TabIndex = 1;
            this.login_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_password.CustomButton.UseSelectable = true;
            this.login_password.CustomButton.Visible = false;
            this.login_password.DisplayIcon = true;
            this.login_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.login_password.Icon = ((System.Drawing.Image)(resources.GetObject("login_password.Icon")));
            this.login_password.Lines = new string[0];
            this.login_password.Location = new System.Drawing.Point(148, 107);
            this.login_password.MaxLength = 32767;
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.PromptText = "Enter your password";
            this.login_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_password.SelectedText = "";
            this.login_password.SelectionLength = 0;
            this.login_password.SelectionStart = 0;
            this.login_password.ShortcutsEnabled = true;
            this.login_password.Size = new System.Drawing.Size(238, 30);
            this.login_password.TabIndex = 1;
            this.login_password.UseSelectable = true;
            this.login_password.WaterMark = "Enter your password";
            this.login_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // login_user
            // 
            // 
            // 
            // 
            this.login_user.CustomButton.Image = null;
            this.login_user.CustomButton.Location = new System.Drawing.Point(210, 2);
            this.login_user.CustomButton.Name = "";
            this.login_user.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.login_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login_user.CustomButton.TabIndex = 1;
            this.login_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login_user.CustomButton.UseSelectable = true;
            this.login_user.CustomButton.Visible = false;
            this.login_user.DisplayIcon = true;
            this.login_user.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.login_user.Icon = ((System.Drawing.Image)(resources.GetObject("login_user.Icon")));
            this.login_user.Lines = new string[0];
            this.login_user.Location = new System.Drawing.Point(148, 56);
            this.login_user.MaxLength = 32767;
            this.login_user.Name = "login_user";
            this.login_user.PasswordChar = '\0';
            this.login_user.PromptText = "Enter your user name";
            this.login_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login_user.SelectedText = "";
            this.login_user.SelectionLength = 0;
            this.login_user.SelectionStart = 0;
            this.login_user.ShortcutsEnabled = true;
            this.login_user.Size = new System.Drawing.Size(238, 30);
            this.login_user.TabIndex = 0;
            this.login_user.UseSelectable = true;
            this.login_user.WaterMark = "Enter your user name";
            this.login_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Navixy.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_login.Location = new System.Drawing.Point(281, 154);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(81, 24);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 195);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox login_user;
        private MetroFramework.Controls.MetroTextBox login_password;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

