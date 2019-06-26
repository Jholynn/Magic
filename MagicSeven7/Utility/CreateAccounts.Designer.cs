namespace MagicSeven7.Utility
{
    partial class CreateAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccounts));
            this.btnShutDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCardsHeader = new Bunifu.Framework.UI.BunifuCards();
            this.lblFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmailAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.checkBoxAdmin = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).BeginInit();
            this.bunifuCardsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.BackColor = System.Drawing.Color.Transparent;
            this.btnShutDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnShutDown.ImageActive")));
            this.btnShutDown.Location = new System.Drawing.Point(600, 3);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(35, 30);
            this.btnShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShutDown.TabIndex = 28;
            this.btnShutDown.TabStop = false;
            this.btnShutDown.Zoom = 40;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // bunifuCardsHeader
            // 
            this.bunifuCardsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.bunifuCardsHeader.BorderRadius = 5;
            this.bunifuCardsHeader.BottomSahddow = true;
            this.bunifuCardsHeader.color = System.Drawing.Color.Transparent;
            this.bunifuCardsHeader.Controls.Add(this.btnShutDown);
            this.bunifuCardsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCardsHeader.LeftSahddow = false;
            this.bunifuCardsHeader.Location = new System.Drawing.Point(0, 0);
            this.bunifuCardsHeader.Name = "bunifuCardsHeader";
            this.bunifuCardsHeader.RightSahddow = true;
            this.bunifuCardsHeader.ShadowDepth = 20;
            this.bunifuCardsHeader.Size = new System.Drawing.Size(638, 131);
            this.bunifuCardsHeader.TabIndex = 29;
            this.bunifuCardsHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseDown);
            this.bunifuCardsHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseMove);
            this.bunifuCardsHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuCardsHeader_MouseUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblFirstName.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblFirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblFirstName.BorderThickness = 1;
            this.lblFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFirstName.isPassword = false;
            this.lblFirstName.Location = new System.Drawing.Point(13, 167);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(285, 37);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.DimGray;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(12, 134);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 32;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(339, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Last Name";
            // 
            // lblLastName
            // 
            this.lblLastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblLastName.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblLastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblLastName.BorderThickness = 1;
            this.lblLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLastName.isPassword = false;
            this.lblLastName.Location = new System.Drawing.Point(329, 167);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(285, 37);
            this.lblLastName.TabIndex = 34;
            this.lblLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "User Name";
            // 
            // lblUserName
            // 
            this.lblUserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblUserName.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblUserName.BorderThickness = 1;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.isPassword = false;
            this.lblUserName.Location = new System.Drawing.Point(13, 216);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(285, 37);
            this.lblUserName.TabIndex = 36;
            this.lblUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(23, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Password";
            // 
            // lblPassword
            // 
            this.lblPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblPassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblPassword.BorderThickness = 1;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.isPassword = false;
            this.lblPassword.Location = new System.Drawing.Point(13, 265);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(285, 37);
            this.lblPassword.TabIndex = 38;
            this.lblPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(339, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Confirm Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblConfirmPassword.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblConfirmPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblConfirmPassword.BorderThickness = 1;
            this.lblConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblConfirmPassword.isPassword = false;
            this.lblConfirmPassword.Location = new System.Drawing.Point(329, 265);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(285, 37);
            this.lblConfirmPassword.TabIndex = 40;
            this.lblConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(339, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Email Address";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblEmailAddress.BorderColorIdle = System.Drawing.Color.DimGray;
            this.lblEmailAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.lblEmailAddress.BorderThickness = 1;
            this.lblEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblEmailAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmailAddress.isPassword = false;
            this.lblEmailAddress.Location = new System.Drawing.Point(329, 216);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(285, 37);
            this.lblEmailAddress.TabIndex = 42;
            this.lblEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(145)))));
            this.checkBoxAdmin.Depth = 0;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxAdmin.Location = new System.Drawing.Point(13, 317);
            this.checkBoxAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Ripple = true;
            this.checkBoxAdmin.Size = new System.Drawing.Size(70, 30);
            this.checkBoxAdmin.TabIndex = 49;
            this.checkBoxAdmin.Text = "Admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = false;
            this.checkBoxAdmin.Click += new System.EventHandler(this.checkBoxAdmin_Click);
            // 
            // CreateAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.bunifuCardsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccounts";
            ((System.ComponentModel.ISupportInitialize)(this.btnShutDown)).EndInit();
            this.bunifuCardsHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnShutDown;
        private Bunifu.Framework.UI.BunifuCards bunifuCardsHeader;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblFirstName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblLastName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblUserName;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblPassword;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblConfirmPassword;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox lblEmailAddress;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxAdmin;
    }
}