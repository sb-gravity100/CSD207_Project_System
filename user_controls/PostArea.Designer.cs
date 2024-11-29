namespace CSD207_Project_System
{
    partial class PostArea
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
            this.CommentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ControlBtnPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LikeBtn = new MaterialSkin.Controls.MaterialButton();
            this.CommentBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AuthorBox = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.PostContent = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DisplayNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UsernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CreatePostBtn = new MaterialSkin.Controls.MaterialButton();
            this.EditProfileBtn = new MaterialSkin.Controls.MaterialButton();
            this.LogoutBtn = new MaterialSkin.Controls.MaterialButton();
            this.DateBox = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.ControlBtnPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.CommentPanel);
            this.materialCard1.Controls.Add(this.ControlBtnPanel);
            this.materialCard1.Controls.Add(this.panel2);
            this.materialCard1.Controls.Add(this.materialCard2);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 10);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(437, 498);
            this.materialCard1.TabIndex = 0;
            // 
            // CommentPanel
            // 
            this.CommentPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CommentPanel.ColumnCount = 1;
            this.CommentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CommentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommentPanel.Location = new System.Drawing.Point(14, 261);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.RowCount = 1;
            this.CommentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CommentPanel.Size = new System.Drawing.Size(409, 184);
            this.CommentPanel.TabIndex = 6;
            // 
            // ControlBtnPanel
            // 
            this.ControlBtnPanel.Controls.Add(this.LikeBtn);
            this.ControlBtnPanel.Controls.Add(this.CommentBtn);
            this.ControlBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBtnPanel.Location = new System.Drawing.Point(14, 216);
            this.ControlBtnPanel.Name = "ControlBtnPanel";
            this.ControlBtnPanel.Size = new System.Drawing.Size(409, 45);
            this.ControlBtnPanel.TabIndex = 5;
            // 
            // LikeBtn
            // 
            this.LikeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LikeBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.LikeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LikeBtn.Depth = 0;
            this.LikeBtn.HighEmphasis = true;
            this.LikeBtn.Icon = null;
            this.LikeBtn.Location = new System.Drawing.Point(5, 5);
            this.LikeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LikeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LikeBtn.Name = "LikeBtn";
            this.LikeBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LikeBtn.Size = new System.Drawing.Size(64, 36);
            this.LikeBtn.TabIndex = 2;
            this.LikeBtn.Text = "Like";
            this.LikeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LikeBtn.UseAccentColor = false;
            this.LikeBtn.UseVisualStyleBackColor = true;
            this.LikeBtn.Click += new System.EventHandler(this.LikeBtn_Click);
            // 
            // CommentBtn
            // 
            this.CommentBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CommentBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.CommentBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CommentBtn.Depth = 0;
            this.CommentBtn.HighEmphasis = true;
            this.CommentBtn.Icon = null;
            this.CommentBtn.Location = new System.Drawing.Point(79, 5);
            this.CommentBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CommentBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CommentBtn.Name = "CommentBtn";
            this.CommentBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CommentBtn.Size = new System.Drawing.Size(95, 36);
            this.CommentBtn.TabIndex = 4;
            this.CommentBtn.Text = "Comment";
            this.CommentBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CommentBtn.UseAccentColor = false;
            this.CommentBtn.UseVisualStyleBackColor = true;
            this.CommentBtn.Click += new System.EventHandler(this.CommentBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DateBox);
            this.panel2.Controls.Add(this.AuthorBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(14, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 21);
            this.panel2.TabIndex = 8;
            // 
            // AuthorBox
            // 
            this.AuthorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorBox.Depth = 0;
            this.AuthorBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.AuthorBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AuthorBox.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.AuthorBox.Location = new System.Drawing.Point(209, 0);
            this.AuthorBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.AuthorBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Padding = new System.Windows.Forms.Padding(10);
            this.AuthorBox.Size = new System.Drawing.Size(200, 21);
            this.AuthorBox.TabIndex = 1;
            this.AuthorBox.Text = "Author";
            this.AuthorBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.PostContent);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(5);
            this.materialCard2.Size = new System.Drawing.Size(409, 181);
            this.materialCard2.TabIndex = 4;
            // 
            // PostContent
            // 
            this.PostContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PostContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostContent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PostContent.Depth = 0;
            this.PostContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PostContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PostContent.Location = new System.Drawing.Point(5, 5);
            this.PostContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.PostContent.Name = "PostContent";
            this.PostContent.ReadOnly = true;
            this.PostContent.Size = new System.Drawing.Size(399, 171);
            this.PostContent.TabIndex = 0;
            this.PostContent.Text = "";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(14, 453);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(409, 31);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Back";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.panel1);
            this.materialCard3.Controls.Add(this.flowLayoutPanel2);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(663, 10);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(191, 498);
            this.materialCard3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CSD207_Project_System.Properties.Resources.LOGO;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(14, 384);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 100);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.DisplayNameLabel);
            this.flowLayoutPanel2.Controls.Add(this.UsernameLabel);
            this.flowLayoutPanel2.Controls.Add(this.CreatePostBtn);
            this.flowLayoutPanel2.Controls.Add(this.EditProfileBtn);
            this.flowLayoutPanel2.Controls.Add(this.LogoutBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 191);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.Depth = 0;
            this.DisplayNameLabel.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DisplayNameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.DisplayNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.DisplayNameLabel.Location = new System.Drawing.Point(0, 0);
            this.DisplayNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DisplayNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(163, 19);
            this.DisplayNameLabel.TabIndex = 0;
            this.DisplayNameLabel.Text = "User";
            this.DisplayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Depth = 0;
            this.UsernameLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UsernameLabel.Location = new System.Drawing.Point(0, 19);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(163, 15);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "User";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatePostBtn
            // 
            this.CreatePostBtn.AutoSize = false;
            this.CreatePostBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreatePostBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.CreatePostBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreatePostBtn.Depth = 0;
            this.CreatePostBtn.HighEmphasis = true;
            this.CreatePostBtn.Icon = null;
            this.CreatePostBtn.Location = new System.Drawing.Point(0, 54);
            this.CreatePostBtn.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.CreatePostBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreatePostBtn.Name = "CreatePostBtn";
            this.CreatePostBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreatePostBtn.Size = new System.Drawing.Size(163, 31);
            this.CreatePostBtn.TabIndex = 2;
            this.CreatePostBtn.Text = "Post";
            this.CreatePostBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreatePostBtn.UseAccentColor = false;
            this.CreatePostBtn.UseVisualStyleBackColor = true;
            this.CreatePostBtn.Click += new System.EventHandler(this.CreatePostBtn_Click);
            // 
            // EditProfileBtn
            // 
            this.EditProfileBtn.AutoSize = false;
            this.EditProfileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditProfileBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.EditProfileBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditProfileBtn.Depth = 0;
            this.EditProfileBtn.HighEmphasis = true;
            this.EditProfileBtn.Icon = null;
            this.EditProfileBtn.Location = new System.Drawing.Point(0, 90);
            this.EditProfileBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.EditProfileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditProfileBtn.Name = "EditProfileBtn";
            this.EditProfileBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditProfileBtn.Size = new System.Drawing.Size(163, 31);
            this.EditProfileBtn.TabIndex = 4;
            this.EditProfileBtn.Text = "Edit Profile";
            this.EditProfileBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditProfileBtn.UseAccentColor = false;
            this.EditProfileBtn.UseVisualStyleBackColor = true;
            this.EditProfileBtn.Click += new System.EventHandler(this.EditProfileBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AutoSize = false;
            this.LogoutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogoutBtn.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.LogoutBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogoutBtn.Depth = 0;
            this.LogoutBtn.HighEmphasis = true;
            this.LogoutBtn.Icon = null;
            this.LogoutBtn.Location = new System.Drawing.Point(0, 126);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LogoutBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogoutBtn.Size = new System.Drawing.Size(163, 31);
            this.LogoutBtn.TabIndex = 7;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogoutBtn.UseAccentColor = false;
            this.LogoutBtn.UseVisualStyleBackColor = true;
            // 
            // DateBox
            // 
            this.DateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateBox.Depth = 0;
            this.DateBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DateBox.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.DateBox.Location = new System.Drawing.Point(0, 0);
            this.DateBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.DateBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DateBox.Name = "DateBox";
            this.DateBox.Padding = new System.Windows.Forms.Padding(10);
            this.DateBox.Size = new System.Drawing.Size(174, 21);
            this.DateBox.TabIndex = 2;
            this.DateBox.Text = "Author";
            this.DateBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PostArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.materialCard1);
            this.Name = "PostArea";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(864, 518);
            this.materialCard1.ResumeLayout(false);
            this.ControlBtnPanel.ResumeLayout(false);
            this.ControlBtnPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel DisplayNameLabel;
        private MaterialSkin.Controls.MaterialLabel UsernameLabel;
        private MaterialSkin.Controls.MaterialButton CreatePostBtn;
        private MaterialSkin.Controls.MaterialButton EditProfileBtn;
        private MaterialSkin.Controls.MaterialLabel AuthorBox;
        private System.Windows.Forms.FlowLayoutPanel ControlBtnPanel;
        private MaterialSkin.Controls.MaterialButton LikeBtn;
        private MaterialSkin.Controls.MaterialButton CommentBtn;
        private System.Windows.Forms.TableLayoutPanel CommentPanel;
        private MaterialSkin.Controls.MaterialButton LogoutBtn;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox PostContent;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel DateBox;
    }
}
