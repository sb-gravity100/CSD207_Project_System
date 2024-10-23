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
            this.userTable = new System.Windows.Forms.DataGridView();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToResizeColumns = false;
            this.userTable.AllowUserToResizeRows = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userTable.CausesValidation = false;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Location = new System.Drawing.Point(11, 8);
            this.userTable.Name = "userTable";
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userTable.RowHeadersVisible = false;
            this.userTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.userTable.ShowEditingIcon = false;
            this.userTable.Size = new System.Drawing.Size(459, 430);
            this.userTable.TabIndex = 0;
            this.userTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deletePress);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(476, 12);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(212, 31);
            this.firstNameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(476, 86);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(212, 31);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(476, 49);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(212, 31);
            this.lastNameBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(476, 232);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(212, 31);
            this.idBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "REFRESH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.userTable);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

