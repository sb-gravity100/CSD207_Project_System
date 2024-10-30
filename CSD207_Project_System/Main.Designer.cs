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
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.FullNameUpdateBox = new System.Windows.Forms.TextBox();
            this.GmailUpdateBox = new System.Windows.Forms.TextBox();
            this.idUpdateBox = new System.Windows.Forms.TextBox();
            this.PasswordUpdateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BirthDateBox = new System.Windows.Forms.DateTimePicker();
            this.GmailBox = new System.Windows.Forms.TextBox();
            this.MobileBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MobileUpdateBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BirthDateUpdateBox = new System.Windows.Forms.DateTimePicker();
            this.UserNameUpdateBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userTable.RowHeadersVisible = false;
            this.userTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.userTable.ShowEditingIcon = false;
            this.userTable.Size = new System.Drawing.Size(688, 430);
            this.userTable.TabIndex = 0;
            this.userTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.handleErrpr);
            this.userTable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deletePress);
            // 
            // FullNameBox
            // 
            this.FullNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameBox.Location = new System.Drawing.Point(705, 12);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(212, 31);
            this.FullNameBox.TabIndex = 1;
            this.FullNameBox.TextChanged += new System.EventHandler(this.TextAddChange);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(705, 160);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(212, 31);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.TextChanged += new System.EventHandler(this.TextAddChange);
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameBox.Location = new System.Drawing.Point(705, 49);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(212, 31);
            this.UserNameBox.TabIndex = 2;
            this.UserNameBox.TextChanged += new System.EventHandler(this.TextAddChange);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(705, 237);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(212, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(781, 404);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(136, 34);
            this.DeleteBtn.TabIndex = 17;
            this.DeleteBtn.Text = "DELETE SELECTED";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(705, 404);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(70, 34);
            this.RefreshBtn.TabIndex = 16;
            this.RefreshBtn.Text = "REFRESH";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(1010, 274);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(212, 40);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // FullNameUpdateBox
            // 
            this.FullNameUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameUpdateBox.Location = new System.Drawing.Point(1011, 49);
            this.FullNameUpdateBox.Name = "FullNameUpdateBox";
            this.FullNameUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.FullNameUpdateBox.TabIndex = 9;
            // 
            // GmailUpdateBox
            // 
            this.GmailUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailUpdateBox.Location = new System.Drawing.Point(1011, 123);
            this.GmailUpdateBox.Name = "GmailUpdateBox";
            this.GmailUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.GmailUpdateBox.TabIndex = 11;
            // 
            // idUpdateBox
            // 
            this.idUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUpdateBox.Location = new System.Drawing.Point(1011, 12);
            this.idUpdateBox.Name = "idUpdateBox";
            this.idUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.idUpdateBox.TabIndex = 8;
            this.idUpdateBox.TextChanged += new System.EventHandler(this.idUpdateBox_TextChanged);
            // 
            // PasswordUpdateBox
            // 
            this.PasswordUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordUpdateBox.Location = new System.Drawing.Point(1011, 197);
            this.PasswordUpdateBox.Name = "PasswordUpdateBox";
            this.PasswordUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.PasswordUpdateBox.TabIndex = 13;
            this.PasswordUpdateBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(926, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "FullName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(926, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gmail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1229, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1229, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1229, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "FullName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1229, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID";
            // 
            // BirthDateBox
            // 
            this.BirthDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BirthDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateBox.Location = new System.Drawing.Point(706, 197);
            this.BirthDateBox.Name = "BirthDateBox";
            this.BirthDateBox.Size = new System.Drawing.Size(211, 31);
            this.BirthDateBox.TabIndex = 6;
            // 
            // GmailBox
            // 
            this.GmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailBox.Location = new System.Drawing.Point(705, 86);
            this.GmailBox.Name = "GmailBox";
            this.GmailBox.Size = new System.Drawing.Size(212, 31);
            this.GmailBox.TabIndex = 3;
            this.GmailBox.TextChanged += new System.EventHandler(this.TextAddChange);
            // 
            // MobileBox
            // 
            this.MobileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileBox.Location = new System.Drawing.Point(705, 123);
            this.MobileBox.Name = "MobileBox";
            this.MobileBox.Size = new System.Drawing.Size(212, 31);
            this.MobileBox.TabIndex = 4;
            this.MobileBox.TextChanged += new System.EventHandler(this.TextAddChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(926, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mobile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(926, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(926, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Birthdate";
            // 
            // MobileUpdateBox
            // 
            this.MobileUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileUpdateBox.Location = new System.Drawing.Point(1011, 160);
            this.MobileUpdateBox.Name = "MobileUpdateBox";
            this.MobileUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.MobileUpdateBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1229, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mobile";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1229, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Birthdate";
            // 
            // BirthDateUpdateBox
            // 
            this.BirthDateUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BirthDateUpdateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDateUpdateBox.Location = new System.Drawing.Point(1011, 234);
            this.BirthDateUpdateBox.Name = "BirthDateUpdateBox";
            this.BirthDateUpdateBox.Size = new System.Drawing.Size(211, 31);
            this.BirthDateUpdateBox.TabIndex = 14;
            // 
            // UserNameUpdateBox
            // 
            this.UserNameUpdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameUpdateBox.Location = new System.Drawing.Point(1011, 86);
            this.UserNameUpdateBox.Name = "UserNameUpdateBox";
            this.UserNameUpdateBox.Size = new System.Drawing.Size(212, 31);
            this.UserNameUpdateBox.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1229, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "UserName";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.UserNameUpdateBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BirthDateUpdateBox);
            this.Controls.Add(this.MobileUpdateBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MobileBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GmailBox);
            this.Controls.Add(this.BirthDateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordUpdateBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.FullNameUpdateBox);
            this.Controls.Add(this.GmailUpdateBox);
            this.Controls.Add(this.idUpdateBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.FullNameBox);
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
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox FullNameUpdateBox;
        private System.Windows.Forms.TextBox GmailUpdateBox;
        private System.Windows.Forms.TextBox idUpdateBox;
        private System.Windows.Forms.TextBox PasswordUpdateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker BirthDateBox;
        private System.Windows.Forms.TextBox GmailBox;
        private System.Windows.Forms.TextBox MobileBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MobileUpdateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker BirthDateUpdateBox;
        private System.Windows.Forms.TextBox UserNameUpdateBox;
        private System.Windows.Forms.Label label13;
    }
}

