namespace CSD207_Project_System
{
    partial class Home
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
            this.DisplayNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.CreatePostBtn = new MaterialSkin.Controls.MaterialButton();
            this.CardPanel = new MaterialSkin.Controls.MaterialCard();
            this.UsernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PostsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TagPostFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard3.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.DisplayNameLabel.Size = new System.Drawing.Size(163, 30);
            this.DisplayNameLabel.TabIndex = 0;
            this.DisplayNameLabel.Text = "User";
            this.DisplayNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.flowLayoutPanel1);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(673, 0);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(191, 600);
            this.materialCard3.TabIndex = 2;
            // 
            // CreatePostBtn
            // 
            this.CreatePostBtn.AutoSize = false;
            this.CreatePostBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreatePostBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreatePostBtn.Depth = 0;
            this.CreatePostBtn.HighEmphasis = true;
            this.CreatePostBtn.Icon = null;
            this.CreatePostBtn.Location = new System.Drawing.Point(0, 70);
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
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CardPanel.Controls.Add(this.TagPostFilter);
            this.CardPanel.Controls.Add(this.PostsPanel);
            this.CardPanel.Depth = 0;
            this.CardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CardPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CardPanel.Location = new System.Drawing.Point(0, 0);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(14, 50, 14, 14);
            this.CardPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Padding = new System.Windows.Forms.Padding(14);
            this.CardPanel.Size = new System.Drawing.Size(430, 600);
            this.CardPanel.TabIndex = 3;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Depth = 0;
            this.UsernameLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.UsernameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UsernameLabel.Location = new System.Drawing.Point(0, 30);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.UsernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(163, 20);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "User";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DisplayNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.UsernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.CreatePostBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 14);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 131);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PostsPanel
            // 
            this.PostsPanel.AutoScroll = true;
            this.PostsPanel.ColumnCount = 1;
            this.PostsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PostsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PostsPanel.Location = new System.Drawing.Point(14, 14);
            this.PostsPanel.Name = "PostsPanel";
            this.PostsPanel.RowCount = 1;
            this.PostsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PostsPanel.Size = new System.Drawing.Size(402, 572);
            this.PostsPanel.TabIndex = 0;
            // 
            // TagPostFilter
            // 
            this.TagPostFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagPostFilter.Location = new System.Drawing.Point(14, 14);
            this.TagPostFilter.Name = "TagPostFilter";
            this.TagPostFilter.Size = new System.Drawing.Size(402, 39);
            this.TagPostFilter.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.materialCard3);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(864, 600);
            this.materialCard3.ResumeLayout(false);
            this.CardPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel DisplayNameLabel;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton CreatePostBtn;
        private MaterialSkin.Controls.MaterialCard CardPanel;
        private MaterialSkin.Controls.MaterialLabel UsernameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel PostsPanel;
        private System.Windows.Forms.FlowLayoutPanel TagPostFilter;
    }
}
