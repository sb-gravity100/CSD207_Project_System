﻿namespace CSD207_Project_System
{
    partial class UserWelcome
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
            this.TitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UserTxt = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.UserTxt);
            this.materialCard1.Controls.Add(this.TitleLabel);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(836, 600);
            this.materialCard1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Depth = 0;
            this.TitleLabel.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.TitleLabel.Location = new System.Drawing.Point(17, 67);
            this.TitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(802, 78);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome to Gestalt";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserTxt
            // 
            this.UserTxt.Depth = 0;
            this.UserTxt.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UserTxt.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.UserTxt.Location = new System.Drawing.Point(17, 145);
            this.UserTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(802, 63);
            this.UserTxt.TabIndex = 1;
            this.UserTxt.Text = "Welcome to Gestalt";
            this.UserTxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserWelcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.materialCard1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 24);
            this.Name = "UserWelcome";
            this.Size = new System.Drawing.Size(864, 628);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel TitleLabel;
        private MaterialSkin.Controls.MaterialLabel UserTxt;
    }
}