﻿namespace CSD207_Project_System
{
    partial class Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegCard = new MaterialSkin.Controls.MaterialCard();
            this.userMsg = new MaterialSkin.Controls.MaterialLabel();
            this.passMsg = new MaterialSkin.Controls.MaterialLabel();
            this.regGmail = new MaterialSkin.Controls.MaterialTextBox();
            this.regPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.sendBtn = new MaterialSkin.Controls.MaterialButton();
            this.regCode = new MaterialSkin.Controls.MaterialTextBox();
            this.loginBtn = new MaterialSkin.Controls.MaterialLabel();
            this.regBtn = new MaterialSkin.Controls.MaterialButton();
            this.regPassword2 = new MaterialSkin.Controls.MaterialTextBox();
            this.regUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.RegCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegCard
            // 
            this.RegCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegCard.Controls.Add(this.userMsg);
            this.RegCard.Controls.Add(this.passMsg);
            this.RegCard.Controls.Add(this.regGmail);
            this.RegCard.Controls.Add(this.regPassword);
            this.RegCard.Controls.Add(this.sendBtn);
            this.RegCard.Controls.Add(this.regCode);
            this.RegCard.Controls.Add(this.loginBtn);
            this.RegCard.Controls.Add(this.regBtn);
            this.RegCard.Controls.Add(this.regPassword2);
            this.RegCard.Controls.Add(this.regUsername);
            this.RegCard.Depth = 0;
            this.RegCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegCard.Location = new System.Drawing.Point(255, 78);
            this.RegCard.Margin = new System.Windows.Forms.Padding(14);
            this.RegCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegCard.Name = "RegCard";
            this.RegCard.Padding = new System.Windows.Forms.Padding(14);
            this.RegCard.Size = new System.Drawing.Size(350, 472);
            this.RegCard.TabIndex = 16;
            // 
            // userMsg
            // 
            this.userMsg.Depth = 0;
            this.userMsg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userMsg.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.userMsg.HighEmphasis = true;
            this.userMsg.Location = new System.Drawing.Point(14, 14);
            this.userMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.userMsg.Name = "userMsg";
            this.userMsg.Size = new System.Drawing.Size(166, 16);
            this.userMsg.TabIndex = 22;
            this.userMsg.UseAccent = true;
            // 
            // passMsg
            // 
            this.passMsg.Depth = 0;
            this.passMsg.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passMsg.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.passMsg.HighEmphasis = true;
            this.passMsg.Location = new System.Drawing.Point(18, 230);
            this.passMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.passMsg.Name = "passMsg";
            this.passMsg.Size = new System.Drawing.Size(315, 18);
            this.passMsg.TabIndex = 21;
            this.passMsg.UseAccent = true;
            // 
            // regGmail
            // 
            this.regGmail.AnimateReadOnly = false;
            this.regGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regGmail.Depth = 0;
            this.regGmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regGmail.Hint = "Gmail";
            this.regGmail.LeadingIcon = null;
            this.regGmail.LeaveOnEnterKey = true;
            this.regGmail.Location = new System.Drawing.Point(18, 105);
            this.regGmail.MaxLength = 50;
            this.regGmail.MouseState = MaterialSkin.MouseState.OUT;
            this.regGmail.Multiline = false;
            this.regGmail.Name = "regGmail";
            this.regGmail.Size = new System.Drawing.Size(315, 50);
            this.regGmail.TabIndex = 1;
            this.regGmail.Text = "";
            this.regGmail.TrailingIcon = global::CSD207_Project_System.Properties.Resources.mail_gray;
            this.regGmail.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // regPassword
            // 
            this.regPassword.AnimateReadOnly = false;
            this.regPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPassword.Depth = 0;
            this.regPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regPassword.Hint = "Password";
            this.regPassword.LeadingIcon = null;
            this.regPassword.LeaveOnEnterKey = true;
            this.regPassword.Location = new System.Drawing.Point(18, 173);
            this.regPassword.MaxLength = 50;
            this.regPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.regPassword.Multiline = false;
            this.regPassword.Name = "regPassword";
            this.regPassword.Password = true;
            this.regPassword.Size = new System.Drawing.Size(315, 50);
            this.regPassword.TabIndex = 2;
            this.regPassword.Text = "";
            this.regPassword.TrailingIcon = global::CSD207_Project_System.Properties.Resources.lock_gray;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendBtn.AutoSize = false;
            this.sendBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sendBtn.Depth = 0;
            this.sendBtn.Enabled = false;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.HighEmphasis = true;
            this.sendBtn.Icon = null;
            this.sendBtn.Location = new System.Drawing.Point(248, 307);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sendBtn.Size = new System.Drawing.Size(85, 50);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "Send";
            this.sendBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendBtn.UseAccentColor = true;
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // regCode
            // 
            this.regCode.AnimateReadOnly = false;
            this.regCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regCode.Depth = 0;
            this.regCode.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regCode.Hint = "Verification Code";
            this.regCode.LeadingIcon = null;
            this.regCode.LeaveOnEnterKey = true;
            this.regCode.Location = new System.Drawing.Point(18, 307);
            this.regCode.MaxLength = 50;
            this.regCode.MouseState = MaterialSkin.MouseState.OUT;
            this.regCode.Multiline = false;
            this.regCode.Name = "regCode";
            this.regCode.Size = new System.Drawing.Size(223, 50);
            this.regCode.TabIndex = 4;
            this.regCode.Text = "";
            this.regCode.TrailingIcon = global::CSD207_Project_System.Properties.Resources.key_gray;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Depth = 0;
            this.loginBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.loginBtn.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.loginBtn.Location = new System.Drawing.Point(266, 427);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(67, 16);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.UseAccent = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_LinkClicked);
            // 
            // regBtn
            // 
            this.regBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regBtn.AutoSize = false;
            this.regBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regBtn.Depth = 0;
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.HighEmphasis = true;
            this.regBtn.Icon = null;
            this.regBtn.Location = new System.Drawing.Point(18, 367);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.regBtn.Name = "regBtn";
            this.regBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regBtn.Size = new System.Drawing.Size(315, 54);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Register";
            this.regBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.regBtn.UseAccentColor = true;
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // regPassword2
            // 
            this.regPassword2.AnimateReadOnly = false;
            this.regPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPassword2.Depth = 0;
            this.regPassword2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regPassword2.Hint = "Repeat Password";
            this.regPassword2.LeadingIcon = null;
            this.regPassword2.LeaveOnEnterKey = true;
            this.regPassword2.Location = new System.Drawing.Point(18, 251);
            this.regPassword2.MaxLength = 50;
            this.regPassword2.MouseState = MaterialSkin.MouseState.OUT;
            this.regPassword2.Multiline = false;
            this.regPassword2.Name = "regPassword2";
            this.regPassword2.Password = true;
            this.regPassword2.Size = new System.Drawing.Size(315, 50);
            this.regPassword2.TabIndex = 3;
            this.regPassword2.Text = "";
            this.regPassword2.TrailingIcon = global::CSD207_Project_System.Properties.Resources.lock_gray;
            // 
            // regUsername
            // 
            this.regUsername.AnimateReadOnly = false;
            this.regUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regUsername.Depth = 0;
            this.regUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regUsername.Hint = "Username";
            this.regUsername.LeadingIcon = null;
            this.regUsername.LeaveOnEnterKey = true;
            this.regUsername.Location = new System.Drawing.Point(18, 33);
            this.regUsername.MaxLength = 50;
            this.regUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.regUsername.Multiline = false;
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(315, 50);
            this.regUsername.TabIndex = 0;
            this.regUsername.Text = "";
            this.regUsername.TrailingIcon = global::CSD207_Project_System.Properties.Resources.user_gray;
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.RegCard);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(864, 628);
            this.RegCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard RegCard;
        private MaterialSkin.Controls.MaterialLabel loginBtn;
        private MaterialSkin.Controls.MaterialButton regBtn;
        private MaterialSkin.Controls.MaterialTextBox regPassword2;
        private MaterialSkin.Controls.MaterialTextBox regUsername;
        private MaterialSkin.Controls.MaterialTextBox regGmail;
        private MaterialSkin.Controls.MaterialTextBox regPassword;
        private MaterialSkin.Controls.MaterialButton sendBtn;
        private MaterialSkin.Controls.MaterialTextBox regCode;
        private MaterialSkin.Controls.MaterialLabel passMsg;
        private MaterialSkin.Controls.MaterialLabel userMsg;
    }
}
