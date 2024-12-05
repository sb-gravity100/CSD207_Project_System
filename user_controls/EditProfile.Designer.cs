namespace CSD207_Project_System
{
    partial class EditProfile
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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.PassBox = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.RepeatPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.NewPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.InfoBox = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Gmail = new MaterialSkin.Controls.MaterialTextBox();
            this.UserName = new MaterialSkin.Controls.MaterialTextBox();
            this.DisplayName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard3);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(20, 20);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(824, 430);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.PassBox);
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.materialButton2);
            this.materialCard3.Controls.Add(this.RepeatPassword);
            this.materialCard3.Controls.Add(this.Password);
            this.materialCard3.Controls.Add(this.NewPassword);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(504, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(306, 402);
            this.materialCard3.TabIndex = 6;
            // 
            // PassBox
            // 
            this.PassBox.Depth = 0;
            this.PassBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PassBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PassBox.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.PassBox.Location = new System.Drawing.Point(14, 369);
            this.PassBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(278, 19);
            this.PassBox.TabIndex = 6;
            this.PassBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PassBox.UseAccent = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(14, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(278, 46);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Password";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(21, 303);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 15, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(274, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Change Password";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RepeatPassword.AnimateReadOnly = false;
            this.RepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepeatPassword.Depth = 0;
            this.RepeatPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RepeatPassword.Hint = "Repeat Password";
            this.RepeatPassword.LeadingIcon = null;
            this.RepeatPassword.Location = new System.Drawing.Point(16, 211);
            this.RepeatPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.RepeatPassword.MaxLength = 50;
            this.RepeatPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.RepeatPassword.Multiline = false;
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Password = true;
            this.RepeatPassword.Size = new System.Drawing.Size(273, 50);
            this.RepeatPassword.TabIndex = 5;
            this.RepeatPassword.Text = "";
            this.RepeatPassword.TrailingIcon = global::CSD207_Project_System.Properties.Resources.lock_gray;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Password";
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(16, 84);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(273, 50);
            this.Password.TabIndex = 3;
            this.Password.Text = "";
            this.Password.TrailingIcon = global::CSD207_Project_System.Properties.Resources.key_gray;
            // 
            // NewPassword
            // 
            this.NewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPassword.AnimateReadOnly = false;
            this.NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPassword.Depth = 0;
            this.NewPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewPassword.Hint = "New Password";
            this.NewPassword.LeadingIcon = null;
            this.NewPassword.Location = new System.Drawing.Point(16, 147);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.NewPassword.MaxLength = 50;
            this.NewPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.NewPassword.Multiline = false;
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Password = true;
            this.NewPassword.Size = new System.Drawing.Size(273, 50);
            this.NewPassword.TabIndex = 4;
            this.NewPassword.Text = "";
            this.NewPassword.TrailingIcon = global::CSD207_Project_System.Properties.Resources.lock_gray;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.InfoBox);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.Gmail);
            this.materialCard2.Controls.Add(this.UserName);
            this.materialCard2.Controls.Add(this.DisplayName);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(292, 402);
            this.materialCard2.TabIndex = 1;
            // 
            // InfoBox
            // 
            this.InfoBox.Depth = 0;
            this.InfoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.InfoBox.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.InfoBox.Location = new System.Drawing.Point(14, 369);
            this.InfoBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(264, 19);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoBox.UseAccent = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(14, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(264, 50);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Info";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(16, 303);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 15, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(258, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Update";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Gmail
            // 
            this.Gmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gmail.AnimateReadOnly = false;
            this.Gmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gmail.Depth = 0;
            this.Gmail.Enabled = false;
            this.Gmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Gmail.Hint = "Gmail";
            this.Gmail.LeadingIcon = null;
            this.Gmail.Location = new System.Drawing.Point(17, 211);
            this.Gmail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Gmail.MaxLength = 50;
            this.Gmail.MouseState = MaterialSkin.MouseState.OUT;
            this.Gmail.Multiline = false;
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(258, 50);
            this.Gmail.TabIndex = 2;
            this.Gmail.Text = "";
            this.Gmail.TrailingIcon = global::CSD207_Project_System.Properties.Resources.mail_gray;
            this.Gmail.TextChanged += new System.EventHandler(this.Gmail_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.AnimateReadOnly = false;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Depth = 0;
            this.UserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.Hint = "Username";
            this.UserName.LeadingIcon = null;
            this.UserName.Location = new System.Drawing.Point(17, 147);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.UserName.MaxLength = 50;
            this.UserName.MouseState = MaterialSkin.MouseState.OUT;
            this.UserName.Multiline = false;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(258, 50);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "";
            this.UserName.TrailingIcon = global::CSD207_Project_System.Properties.Resources.user_gray;
            // 
            // DisplayName
            // 
            this.DisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayName.AnimateReadOnly = false;
            this.DisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayName.Depth = 0;
            this.DisplayName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DisplayName.Hint = "Display Name";
            this.DisplayName.LeadingIcon = null;
            this.DisplayName.Location = new System.Drawing.Point(17, 84);
            this.DisplayName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.DisplayName.MaxLength = 50;
            this.DisplayName.MouseState = MaterialSkin.MouseState.OUT;
            this.DisplayName.Multiline = false;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(258, 50);
            this.DisplayName.TabIndex = 0;
            this.DisplayName.Text = "";
            this.DisplayName.TrailingIcon = global::CSD207_Project_System.Properties.Resources.grid_view_16dp_999999_FILL0_wght400_GRAD0_opsz20;
            this.DisplayName.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(20, 455);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 15, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(824, 43);
            this.materialButton3.TabIndex = 7;
            this.materialButton3.Text = "Go Back";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialCard1);
            this.Name = "EditProfile";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(864, 518);
            this.materialCard1.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox DisplayName;
        private MaterialSkin.Controls.MaterialTextBox Gmail;
        private MaterialSkin.Controls.MaterialTextBox UserName;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox RepeatPassword;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private MaterialSkin.Controls.MaterialTextBox NewPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel InfoBox;
        private MaterialSkin.Controls.MaterialLabel PassBox;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}
