namespace CSD207_Project_System
{
    partial class ErrorPage
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
            this.ReturnBtn = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.AutoSize = true;
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.ReturnBtn);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(864, 628);
            this.materialCard1.TabIndex = 0;
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBtn.Depth = 0;
            this.ReturnBtn.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ReturnBtn.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.ReturnBtn.Location = new System.Drawing.Point(31, 348);
            this.ReturnBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(802, 33);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Return to previous page.";
            this.ReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReturnBtn.UseAccent = true;
            this.ReturnBtn.UseCompatibleTextRendering = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.ForeColor = System.Drawing.Color.Red;
            this.materialLabel1.Location = new System.Drawing.Point(31, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(802, 61);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Something went wrong.";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.UseAccent = true;
            this.materialLabel1.UseCompatibleTextRendering = true;
            // 
            // ErrorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "ErrorPage";
            this.Size = new System.Drawing.Size(864, 628);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel ReturnBtn;
    }
}
