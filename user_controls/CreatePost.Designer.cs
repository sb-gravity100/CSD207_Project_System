namespace CSD207_Project_System
{
    partial class CreatePost
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
            this.TagBox = new MaterialSkin.Controls.MaterialTextBox();
            this.MsgLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TagPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ContentBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.CreatePostBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.TagBox);
            this.materialCard1.Controls.Add(this.MsgLabel);
            this.materialCard1.Controls.Add(this.TagPanel);
            this.materialCard1.Controls.Add(this.flowLayoutPanel1);
            this.materialCard1.Controls.Add(this.ContentBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(836, 600);
            this.materialCard1.TabIndex = 17;
            // 
            // TagBox
            // 
            this.TagBox.AnimateReadOnly = false;
            this.TagBox.AutoWordSelection = true;
            this.TagBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagBox.Depth = 0;
            this.TagBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TagBox.Hint = "Add Tags...";
            this.TagBox.LeadingIcon = null;
            this.TagBox.Location = new System.Drawing.Point(14, 270);
            this.TagBox.MaxLength = 50;
            this.TagBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TagBox.Multiline = false;
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(808, 50);
            this.TagBox.TabIndex = 3;
            this.TagBox.Text = "";
            this.TagBox.TrailingIcon = null;
            // 
            // MsgLabel
            // 
            this.MsgLabel.Depth = 0;
            this.MsgLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MsgLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MsgLabel.Location = new System.Drawing.Point(14, 236);
            this.MsgLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(808, 34);
            this.MsgLabel.TabIndex = 2;
            // 
            // TagPanel
            // 
            this.TagPanel.Location = new System.Drawing.Point(14, 326);
            this.TagPanel.Name = "TagPanel";
            this.TagPanel.Size = new System.Drawing.Size(808, 83);
            this.TagPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CreatePostBtn);
            this.flowLayoutPanel1.Controls.Add(this.materialButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 541);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(808, 45);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(467, 5);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(163, 31);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Discard";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.AnimateReadOnly = false;
            this.ContentBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContentBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ContentBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContentBox.Depth = 0;
            this.ContentBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContentBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentBox.HideSelection = true;
            this.ContentBox.Hint = "Write anything...";
            this.ContentBox.Location = new System.Drawing.Point(14, 14);
            this.ContentBox.MaxLength = 32767;
            this.ContentBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.PasswordChar = '\0';
            this.ContentBox.ReadOnly = false;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ContentBox.SelectedText = "";
            this.ContentBox.SelectionLength = 0;
            this.ContentBox.SelectionStart = 0;
            this.ContentBox.ShortcutsEnabled = true;
            this.ContentBox.Size = new System.Drawing.Size(808, 222);
            this.ContentBox.TabIndex = 0;
            this.ContentBox.TabStop = false;
            this.ContentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ContentBox.UseAccent = false;
            this.ContentBox.UseSystemPasswordChar = false;
            // 
            // CreatePostBtn
            // 
            this.CreatePostBtn.AutoSize = false;
            this.CreatePostBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreatePostBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreatePostBtn.Depth = 0;
            this.CreatePostBtn.HighEmphasis = true;
            this.CreatePostBtn.Icon = global::CSD207_Project_System.Properties.Resources.send_16dp_999999_FILL0_wght400_GRAD0_opsz20__1_;
            this.CreatePostBtn.Location = new System.Drawing.Point(640, 5);
            this.CreatePostBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CreatePostBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreatePostBtn.Name = "CreatePostBtn";
            this.CreatePostBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreatePostBtn.Size = new System.Drawing.Size(163, 31);
            this.CreatePostBtn.TabIndex = 5;
            this.CreatePostBtn.Text = "Post";
            this.CreatePostBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreatePostBtn.UseAccentColor = false;
            this.CreatePostBtn.UseVisualStyleBackColor = true;
            this.CreatePostBtn.Click += new System.EventHandler(this.CreatePostBtn_Click);
            // 
            // CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(14);
            this.Name = "CreatePost";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.Size = new System.Drawing.Size(864, 628);
            this.materialCard1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ContentBox;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel MsgLabel;
        private MaterialSkin.Controls.MaterialTextBox TagBox;
        private System.Windows.Forms.FlowLayoutPanel TagPanel;
        private MaterialSkin.Controls.MaterialButton CreatePostBtn;
    }
}
