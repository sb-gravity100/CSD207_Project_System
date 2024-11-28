namespace CSD207_Project_System
{
    partial class Login
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.userLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passLabel = new MaterialSkin.Controls.MaterialLabel();
            this.regBtn = new MaterialSkin.Controls.MaterialLabel();
            this.loginBtn = new MaterialSkin.Controls.MaterialButton();
            this.password = new MaterialSkin.Controls.MaterialTextBox();
            this.username = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.userLabel);
            this.materialCard1.Controls.Add(this.passLabel);
            this.materialCard1.Controls.Add(this.regBtn);
            this.materialCard1.Controls.Add(this.loginBtn);
            this.materialCard1.Controls.Add(this.password);
            this.materialCard1.Controls.Add(this.username);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(255, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(350, 472);
            this.materialCard1.TabIndex = 6;
            // 
            // userLabel
            // 
            this.userLabel.Depth = 0;
            this.userLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.userLabel.HighEmphasis = true;
            this.userLabel.Location = new System.Drawing.Point(14, 114);
            this.userLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(166, 16);
            this.userLabel.TabIndex = 24;
            this.userLabel.UseAccent = true;
            // 
            // passLabel
            // 
            this.passLabel.Depth = 0;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.passLabel.HighEmphasis = true;
            this.passLabel.Location = new System.Drawing.Point(14, 189);
            this.passLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(166, 16);
            this.passLabel.TabIndex = 23;
            this.passLabel.UseAccent = true;
            // 
            // regBtn
            // 
            this.regBtn.Depth = 0;
            this.regBtn.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.regBtn.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.regBtn.Location = new System.Drawing.Point(266, 320);
            this.regBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(67, 16);
            this.regBtn.TabIndex = 13;
            this.regBtn.Text = "Register";
            this.regBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.regBtn.UseAccent = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.AutoSize = false;
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginBtn.Depth = 0;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.HighEmphasis = true;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(17, 267);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.loginBtn.Size = new System.Drawing.Size(316, 47);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginBtn.UseAccentColor = true;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_ClickAsync);
            // 
            // password
            // 
            this.password.AnimateReadOnly = false;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Depth = 0;
            this.password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password.Hint = "Password";
            this.password.LeadingIcon = null;
            this.password.LeaveOnEnterKey = true;
            this.password.Location = new System.Drawing.Point(17, 208);
            this.password.MaxLength = 50;
            this.password.MouseState = MaterialSkin.MouseState.OUT;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Password = true;
            this.password.Size = new System.Drawing.Size(316, 50);
            this.password.TabIndex = 9;
            this.password.Text = "";
            this.password.TrailingIcon = global::CSD207_Project_System.Properties.Resources.lock_gray;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress);
            // 
            // username
            // 
            this.username.AnimateReadOnly = false;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Depth = 0;
            this.username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username.Hint = "Username";
            this.username.LeadingIcon = null;
            this.username.LeaveOnEnterKey = true;
            this.username.Location = new System.Drawing.Point(17, 133);
            this.username.MaxLength = 50;
            this.username.MouseState = MaterialSkin.MouseState.OUT;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(316, 50);
            this.username.TabIndex = 8;
            this.username.Text = "";
            this.username.TrailingIcon = global::CSD207_Project_System.Properties.Resources.user_gray;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPress);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialCard1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(864, 628);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox password;
        private MaterialSkin.Controls.MaterialTextBox username;
        private MaterialSkin.Controls.MaterialButton loginBtn;
        private MaterialSkin.Controls.MaterialLabel regBtn;
        private MaterialSkin.Controls.MaterialLabel userLabel;
        private MaterialSkin.Controls.MaterialLabel passLabel;
    }
}
