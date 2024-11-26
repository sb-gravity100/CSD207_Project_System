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
            this.themeBtn = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.SuspendLayout();
            // 
            // themeBtn
            // 
            this.themeBtn.AnimateShowHideButton = true;
            this.themeBtn.Depth = 0;
            this.themeBtn.Icon = global::CSD207_Project_System.Properties.Resources.dark_mode_black;
            this.themeBtn.Location = new System.Drawing.Point(816, 38);
            this.themeBtn.Mini = true;
            this.themeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Size = new System.Drawing.Size(42, 42);
            this.themeBtn.TabIndex = 15;
            this.themeBtn.Text = "materialFloatingActionButton1";
            this.themeBtn.UseVisualStyleBackColor = true;
            this.themeBtn.Click += new System.EventHandler(this.themeBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(864, 652);
            this.Controls.Add(this.themeBtn);
            this.DoubleBuffered = false;
            this.DrawerAutoHide = false;
            this.DrawerUseColors = true;
            this.DrawerWidth = 0;
            this.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(864, 652);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tethys";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialFloatingActionButton themeBtn;
    }
}

