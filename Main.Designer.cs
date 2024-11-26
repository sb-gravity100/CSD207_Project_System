namespace CSD207_Project_System
{
    partial class Main
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.themeBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.AutoSize = true;
            this.loginPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Location = new System.Drawing.Point(7, 32);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(0, 0);
            this.loginPanel.TabIndex = 0;
            // 
            // themeBtn
            // 
            this.themeBtn.AnimateShowHideButton = true;
            this.themeBtn.Depth = 0;
            this.themeBtn.Icon = global::CSD207_Project_System.Properties.Resources.dark_mode_black;
            this.themeBtn.Location = new System.Drawing.Point(996, 32);
            this.themeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.themeBtn.Mini = true;
            this.themeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Size = new System.Drawing.Size(52, 53);
            this.themeBtn.TabIndex = 15;
            this.themeBtn.Text = "materialFloatingActionButton1";
            this.themeBtn.UseVisualStyleBackColor = true;
            this.themeBtn.Click += new System.EventHandler(this.themeBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1056, 756);
            this.Controls.Add(this.themeBtn);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 4, 4);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private MaterialSkin.Controls.MaterialFloatingActionButton themeBtn;
    }
}

