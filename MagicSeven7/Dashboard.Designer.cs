namespace MagicSeven7
{
	partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuDashBoard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTipShutDown = new System.Windows.Forms.ToolTip(this.components);
            this.btnShutDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelDashBoardBody = new System.Windows.Forms.Panel();
            this.bunifuCardsHeader = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButtonMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButtonMinimizer = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCardsLeft = new Bunifu.Framework.UI.BunifuCards();
            this.panelLeftActive = new System.Windows.Forms.Panel();
            this.btnUtility = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAccounting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOperation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).BeginInit();
            this.bunifuCardsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimizer)).BeginInit();
            this.bunifuCardsLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDashBoard
            // 
            this.bunifuDashBoard.ElipseRadius = 5;
            this.bunifuDashBoard.TargetControl = this;
            // 
            // toolTipShutDown
            // 
            this.toolTipShutDown.BackColor = System.Drawing.Color.Transparent;
            this.toolTipShutDown.ForeColor = System.Drawing.Color.White;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnShutDown.ImageActive")));
            this.btnShutDown.Location = new System.Drawing.Point(1288, 5);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(30, 30);
            this.btnShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShutDown.TabIndex = 27;
            this.btnShutDown.TabStop = false;
            this.toolTipShutDown.SetToolTip(this.btnShutDown, "Shutdown this application");
            this.btnShutDown.Zoom = 40;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // panelDashBoardBody
            // 
            this.panelDashBoardBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDashBoardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoardBody.Location = new System.Drawing.Point(181, 41);
            this.panelDashBoardBody.Name = "panelDashBoardBody";
            this.panelDashBoardBody.Size = new System.Drawing.Size(1140, 656);
            this.panelDashBoardBody.TabIndex = 29;
            // 
            // bunifuCardsHeader
            // 
            this.bunifuCardsHeader.BackColor = System.Drawing.Color.White;
            this.bunifuCardsHeader.BorderRadius = 5;
            this.bunifuCardsHeader.BottomSahddow = true;
            this.bunifuCardsHeader.color = System.Drawing.Color.White;
            this.bunifuCardsHeader.Controls.Add(this.pictureBox1);
            this.bunifuCardsHeader.Controls.Add(this.bunifuImageButtonMaximize);
            this.bunifuCardsHeader.Controls.Add(this.btnShutDown);
            this.bunifuCardsHeader.Controls.Add(this.btnMinimized);
            this.bunifuCardsHeader.Controls.Add(this.bunifuImageButtonMinimizer);
            this.bunifuCardsHeader.Controls.Add(this.lblTitle);
            this.bunifuCardsHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.bunifuCardsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCardsHeader.LeftSahddow = false;
            this.bunifuCardsHeader.Location = new System.Drawing.Point(0, 0);
            this.bunifuCardsHeader.Name = "bunifuCardsHeader";
            this.bunifuCardsHeader.RightSahddow = true;
            this.bunifuCardsHeader.ShadowDepth = 20;
            this.bunifuCardsHeader.Size = new System.Drawing.Size(1321, 41);
            this.bunifuCardsHeader.TabIndex = 29;
            this.bunifuCardsHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseDown);
            this.bunifuCardsHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseMove);
            this.bunifuCardsHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButtonMaximize
            // 
            this.bunifuImageButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMaximize.Image")));
            this.bunifuImageButtonMaximize.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMaximize.ImageActive")));
            this.bunifuImageButtonMaximize.Location = new System.Drawing.Point(1252, 5);
            this.bunifuImageButtonMaximize.Name = "bunifuImageButtonMaximize";
            this.bunifuImageButtonMaximize.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButtonMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButtonMaximize.TabIndex = 28;
            this.bunifuImageButtonMaximize.TabStop = false;
            this.bunifuImageButtonMaximize.Zoom = 10;
            this.bunifuImageButtonMaximize.Click += new System.EventHandler(this.bunifuImageButtonMaximize_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimized.ImageActive")));
            this.btnMinimized.Location = new System.Drawing.Point(1216, 5);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimized.TabIndex = 26;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Zoom = 10;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // bunifuImageButtonMinimizer
            // 
            this.bunifuImageButtonMinimizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonMinimizer.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonMinimizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButtonMinimizer.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimizer.Image")));
            this.bunifuImageButtonMinimizer.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonMinimizer.ImageActive")));
            this.bunifuImageButtonMinimizer.Location = new System.Drawing.Point(1252, 5);
            this.bunifuImageButtonMinimizer.Name = "bunifuImageButtonMinimizer";
            this.bunifuImageButtonMinimizer.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButtonMinimizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButtonMinimizer.TabIndex = 29;
            this.bunifuImageButtonMinimizer.TabStop = false;
            this.bunifuImageButtonMinimizer.Zoom = 10;
            this.bunifuImageButtonMinimizer.Click += new System.EventHandler(this.bunifuImageButtonMinimizer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(63)))), ((int)(((byte)(146)))));
            this.lblTitle.Location = new System.Drawing.Point(503, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 18);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "MAGIC SEVEN7 INTERNATIONAL. LOGISTICS INC.";
            // 
            // bunifuCardsLeft
            // 
            this.bunifuCardsLeft.BackColor = System.Drawing.Color.White;
            this.bunifuCardsLeft.BorderRadius = 5;
            this.bunifuCardsLeft.BottomSahddow = true;
            this.bunifuCardsLeft.color = System.Drawing.Color.White;
            this.bunifuCardsLeft.Controls.Add(this.panelLeftActive);
            this.bunifuCardsLeft.Controls.Add(this.btnUtility);
            this.bunifuCardsLeft.Controls.Add(this.btnAccounting);
            this.bunifuCardsLeft.Controls.Add(this.btnOperation);
            this.bunifuCardsLeft.Controls.Add(this.bunifuSeparator1);
            this.bunifuCardsLeft.Controls.Add(this.btnHome);
            this.bunifuCardsLeft.Controls.Add(this.pictureBox2);
            this.bunifuCardsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuCardsLeft.LeftSahddow = false;
            this.bunifuCardsLeft.Location = new System.Drawing.Point(0, 41);
            this.bunifuCardsLeft.Name = "bunifuCardsLeft";
            this.bunifuCardsLeft.RightSahddow = true;
            this.bunifuCardsLeft.ShadowDepth = 20;
            this.bunifuCardsLeft.Size = new System.Drawing.Size(181, 656);
            this.bunifuCardsLeft.TabIndex = 30;
            // 
            // panelLeftActive
            // 
            this.panelLeftActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.panelLeftActive.Location = new System.Drawing.Point(0, 156);
            this.panelLeftActive.Name = "panelLeftActive";
            this.panelLeftActive.Size = new System.Drawing.Size(4, 45);
            this.panelLeftActive.TabIndex = 36;
            // 
            // btnUtility
            // 
            this.btnUtility.Activecolor = System.Drawing.Color.Transparent;
            this.btnUtility.BackColor = System.Drawing.Color.Transparent;
            this.btnUtility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUtility.BorderRadius = 5;
            this.btnUtility.ButtonText = "    Utitlity";
            this.btnUtility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtility.DisabledColor = System.Drawing.Color.Transparent;
            this.btnUtility.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUtility.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUtility.Iconimage")));
            this.btnUtility.Iconimage_right = null;
            this.btnUtility.Iconimage_right_Selected = null;
            this.btnUtility.Iconimage_Selected = null;
            this.btnUtility.IconMarginLeft = 0;
            this.btnUtility.IconMarginRight = 0;
            this.btnUtility.IconRightVisible = true;
            this.btnUtility.IconRightZoom = 0D;
            this.btnUtility.IconVisible = true;
            this.btnUtility.IconZoom = 40D;
            this.btnUtility.IsTab = true;
            this.btnUtility.Location = new System.Drawing.Point(12, 309);
            this.btnUtility.Name = "btnUtility";
            this.btnUtility.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUtility.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnUtility.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnUtility.selected = false;
            this.btnUtility.Size = new System.Drawing.Size(155, 45);
            this.btnUtility.TabIndex = 35;
            this.btnUtility.Text = "    Utitlity";
            this.btnUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtility.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnUtility.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtility.Click += new System.EventHandler(this.btnUtility_Click);
            // 
            // btnAccounting
            // 
            this.btnAccounting.Activecolor = System.Drawing.Color.Transparent;
            this.btnAccounting.BackColor = System.Drawing.Color.Transparent;
            this.btnAccounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccounting.BorderRadius = 5;
            this.btnAccounting.ButtonText = "   Accounting";
            this.btnAccounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccounting.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAccounting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAccounting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAccounting.Iconimage")));
            this.btnAccounting.Iconimage_right = null;
            this.btnAccounting.Iconimage_right_Selected = null;
            this.btnAccounting.Iconimage_Selected = null;
            this.btnAccounting.IconMarginLeft = 0;
            this.btnAccounting.IconMarginRight = 0;
            this.btnAccounting.IconRightVisible = true;
            this.btnAccounting.IconRightZoom = 0D;
            this.btnAccounting.IconVisible = true;
            this.btnAccounting.IconZoom = 40D;
            this.btnAccounting.IsTab = true;
            this.btnAccounting.Location = new System.Drawing.Point(13, 258);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAccounting.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAccounting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnAccounting.selected = false;
            this.btnAccounting.Size = new System.Drawing.Size(155, 45);
            this.btnAccounting.TabIndex = 34;
            this.btnAccounting.Text = "   Accounting";
            this.btnAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounting.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnAccounting.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.Activecolor = System.Drawing.Color.Transparent;
            this.btnOperation.BackColor = System.Drawing.Color.Transparent;
            this.btnOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOperation.BorderRadius = 5;
            this.btnOperation.ButtonText = "    Operation";
            this.btnOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperation.DisabledColor = System.Drawing.Color.Transparent;
            this.btnOperation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOperation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOperation.Iconimage")));
            this.btnOperation.Iconimage_right = null;
            this.btnOperation.Iconimage_right_Selected = null;
            this.btnOperation.Iconimage_Selected = null;
            this.btnOperation.IconMarginLeft = 0;
            this.btnOperation.IconMarginRight = 0;
            this.btnOperation.IconRightVisible = true;
            this.btnOperation.IconRightZoom = 0D;
            this.btnOperation.IconVisible = true;
            this.btnOperation.IconZoom = 40D;
            this.btnOperation.IsTab = true;
            this.btnOperation.Location = new System.Drawing.Point(12, 207);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOperation.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnOperation.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnOperation.selected = false;
            this.btnOperation.Size = new System.Drawing.Size(155, 45);
            this.btnOperation.TabIndex = 33;
            this.btnOperation.Text = "    Operation";
            this.btnOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperation.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnOperation.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(25, 94);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(131, 17);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.Transparent;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 5;
            this.btnHome.ButtonText = "    Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 40D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(12, 156);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(155, 45);
            this.btnHome.TabIndex = 31;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1321, 697);
            this.Controls.Add(this.panelDashBoardBody);
            this.Controls.Add(this.bunifuCardsLeft);
            this.Controls.Add(this.bunifuCardsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).EndInit();
            this.bunifuCardsHeader.ResumeLayout(false);
            this.bunifuCardsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonMinimizer)).EndInit();
            this.bunifuCardsLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuDashBoard;
        private System.Windows.Forms.ToolTip toolTipShutDown;
        private Bunifu.Framework.UI.BunifuCards bunifuCardsLeft;
        private System.Windows.Forms.Panel panelLeftActive;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelDashBoardBody;
        private Bunifu.Framework.UI.BunifuCards bunifuCardsHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnShutDown;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonMinimizer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        public Bunifu.Framework.UI.BunifuFlatButton btnOperation;
        public Bunifu.Framework.UI.BunifuFlatButton btnUtility;
        public Bunifu.Framework.UI.BunifuFlatButton btnAccounting;
    }
}