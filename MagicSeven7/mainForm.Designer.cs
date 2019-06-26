namespace MagicSeven7
{
	partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.elipseMainForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBodyBackGround = new System.Windows.Forms.Panel();
            this.picBoxShowPassword = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnShutDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnForgetPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtBoxUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTipShutDown = new System.Windows.Forms.ToolTip(this.components);
            this.panelBodyBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseMainForm
            // 
            this.elipseMainForm.ElipseRadius = 5;
            this.elipseMainForm.TargetControl = this;
            // 
            // panelBodyBackGround
            // 
            this.panelBodyBackGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBodyBackGround.BackgroundImage")));
            this.panelBodyBackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBodyBackGround.Controls.Add(this.picBoxShowPassword);
            this.panelBodyBackGround.Controls.Add(this.pictureBoxPassword);
            this.panelBodyBackGround.Controls.Add(this.pictureBoxUser);
            this.panelBodyBackGround.Controls.Add(this.pictureBoxLogo);
            this.panelBodyBackGround.Controls.Add(this.btnShutDown);
            this.panelBodyBackGround.Controls.Add(this.btnMinimized);
            this.panelBodyBackGround.Controls.Add(this.btnForgetPassword);
            this.panelBodyBackGround.Controls.Add(this.btnLogin);
            this.panelBodyBackGround.Controls.Add(this.txtBoxPassword);
            this.panelBodyBackGround.Controls.Add(this.txtBoxUserName);
            this.panelBodyBackGround.Controls.Add(this.panelHeader);
            this.panelBodyBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBodyBackGround.Location = new System.Drawing.Point(0, 0);
            this.panelBodyBackGround.Name = "panelBodyBackGround";
            this.panelBodyBackGround.Size = new System.Drawing.Size(869, 512);
            this.panelBodyBackGround.TabIndex = 1;
            // 
            // picBoxShowPassword
            // 
            this.picBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.picBoxShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxShowPassword.Image")));
            this.picBoxShowPassword.ImageActive = ((System.Drawing.Image)(resources.GetObject("picBoxShowPassword.ImageActive")));
            this.picBoxShowPassword.Location = new System.Drawing.Point(269, 207);
            this.picBoxShowPassword.Name = "picBoxShowPassword";
            this.picBoxShowPassword.Size = new System.Drawing.Size(30, 30);
            this.picBoxShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxShowPassword.TabIndex = 25;
            this.picBoxShowPassword.TabStop = false;
            this.picBoxShowPassword.Zoom = 40;
            this.picBoxShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxShowPassword_MouseDown);
            this.picBoxShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxShowPassword_MouseUp);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(35, 207);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPassword.TabIndex = 24;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(35, 163);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(33, 34);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUser.TabIndex = 23;
            this.pictureBoxUser.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(98, 62);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 72);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 20;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnShutDown
            // 
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnShutDown.ImageActive")));
            this.btnShutDown.Location = new System.Drawing.Point(836, 1);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(30, 30);
            this.btnShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShutDown.TabIndex = 21;
            this.btnShutDown.TabStop = false;
            this.toolTipShutDown.SetToolTip(this.btnShutDown, "Shutdown this application");
            this.btnShutDown.Zoom = 40;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(802, 1);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimized.TabIndex = 19;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Activecolor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForgetPassword.BorderRadius = 0;
            this.btnForgetPassword.ButtonText = "Forgot Password?";
            this.btnForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgetPassword.DisabledColor = System.Drawing.Color.Gray;
            this.btnForgetPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.Iconimage = null;
            this.btnForgetPassword.Iconimage_right = null;
            this.btnForgetPassword.Iconimage_right_Selected = null;
            this.btnForgetPassword.Iconimage_Selected = null;
            this.btnForgetPassword.IconMarginLeft = 0;
            this.btnForgetPassword.IconMarginRight = 0;
            this.btnForgetPassword.IconRightVisible = true;
            this.btnForgetPassword.IconRightZoom = 0D;
            this.btnForgetPassword.IconVisible = true;
            this.btnForgetPassword.IconZoom = 90D;
            this.btnForgetPassword.IsTab = false;
            this.btnForgetPassword.Location = new System.Drawing.Point(148, 249);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Normalcolor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnForgetPassword.OnHoverTextColor = System.Drawing.Color.Red;
            this.btnForgetPassword.selected = false;
            this.btnForgetPassword.Size = new System.Drawing.Size(123, 20);
            this.btnForgetPassword.TabIndex = 3;
            this.btnForgetPassword.Text = "Forgot Password?";
            this.btnForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnForgetPassword.Textcolor = System.Drawing.Color.Silver;
            this.btnForgetPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnLogin.Location = new System.Drawing.Point(35, 277);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(229, 48);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPassword.HintForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPassword.HintText = "";
            this.txtBoxPassword.isPassword = false;
            this.txtBoxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.txtBoxPassword.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBoxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.txtBoxPassword.LineThickness = 4;
            this.txtBoxPassword.Location = new System.Drawing.Point(70, 207);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(194, 34);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.Text = "Password";
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.OnValueChanged += new System.EventHandler(this.txtBoxPassword_OnValueChanged);
            this.txtBoxPassword.MouseEnter += new System.EventHandler(this.txtBoxPassword_MouseEnter);
            this.txtBoxPassword.MouseLeave += new System.EventHandler(this.txtBoxPassword_MouseLeave);
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxUserName.HintForeColor = System.Drawing.Color.DimGray;
            this.txtBoxUserName.HintText = "User Name";
            this.txtBoxUserName.isPassword = false;
            this.txtBoxUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.txtBoxUserName.LineIdleColor = System.Drawing.Color.Silver;
            this.txtBoxUserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.txtBoxUserName.LineThickness = 4;
            this.txtBoxUserName.Location = new System.Drawing.Point(70, 163);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(194, 34);
            this.txtBoxUserName.TabIndex = 1;
            this.txtBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.pictureBoxIcon);
            this.panelHeader.Controls.Add(this.lblTitle2);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelHeader.Location = new System.Drawing.Point(0, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(869, 32);
            this.panelHeader.TabIndex = 22;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 7;
            this.pictureBoxIcon.TabStop = false;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(420, 6);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(156, 20);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "NAL, LOGISTICS INC.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(63)))), ((int)(((byte)(146)))));
            this.lblTitle.Location = new System.Drawing.Point(217, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 18);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "MAGIC SEVEN7 INTERNATIO";
            // 
            // toolTipShutDown
            // 
            this.toolTipShutDown.BackColor = System.Drawing.Color.Transparent;
            this.toolTipShutDown.ForeColor = System.Drawing.Color.White;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 512);
            this.Controls.Add(this.panelBodyBackGround);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelBodyBackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse elipseMainForm;
		private System.Windows.Forms.Panel panelBodyBackGround;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxPassword;
		private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
		private Bunifu.Framework.UI.BunifuMaterialTextbox txtBoxUserName;
		private Bunifu.Framework.UI.BunifuFlatButton btnForgetPassword;
		private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
		private Bunifu.Framework.UI.BunifuImageButton btnShutDown;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.PictureBox pictureBoxIcon;
		private Bunifu.Framework.UI.BunifuCustomLabel lblTitle2;
		private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
		private System.Windows.Forms.PictureBox pictureBoxLogo;
		private System.Windows.Forms.PictureBox pictureBoxPassword;
		private System.Windows.Forms.PictureBox pictureBoxUser;
		private Bunifu.Framework.UI.BunifuImageButton picBoxShowPassword;
        private System.Windows.Forms.ToolTip toolTipShutDown;
    }
}

