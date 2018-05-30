namespace Login_System
{
    partial class Change_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userNametxtBox = new System.Windows.Forms.TextBox();
            this.OldPasswordtxtBox = new System.Windows.Forms.TextBox();
            this.NewPasswordtxtBox = new System.Windows.Forms.TextBox();
            this.RePasswordtxtBox = new System.Windows.Forms.TextBox();
            this.PasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(325, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO STAR HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // userNametxtBox
            // 
            this.userNametxtBox.Location = new System.Drawing.Point(176, 97);
            this.userNametxtBox.Name = "userNametxtBox";
            this.userNametxtBox.Size = new System.Drawing.Size(114, 20);
            this.userNametxtBox.TabIndex = 6;
            // 
            // OldPasswordtxtBox
            // 
            this.OldPasswordtxtBox.Location = new System.Drawing.Point(176, 130);
            this.OldPasswordtxtBox.Name = "OldPasswordtxtBox";
            this.OldPasswordtxtBox.Size = new System.Drawing.Size(114, 20);
            this.OldPasswordtxtBox.TabIndex = 7;
            this.OldPasswordtxtBox.TextChanged += new System.EventHandler(this.OldPasswordtxtBox_TextChanged);
            // 
            // NewPasswordtxtBox
            // 
            this.NewPasswordtxtBox.Location = new System.Drawing.Point(176, 164);
            this.NewPasswordtxtBox.Name = "NewPasswordtxtBox";
            this.NewPasswordtxtBox.Size = new System.Drawing.Size(114, 20);
            this.NewPasswordtxtBox.TabIndex = 8;
            this.NewPasswordtxtBox.TextChanged += new System.EventHandler(this.NewPasswordtxtBox_TextChanged);
            // 
            // RePasswordtxtBox
            // 
            this.RePasswordtxtBox.Location = new System.Drawing.Point(176, 200);
            this.RePasswordtxtBox.Name = "RePasswordtxtBox";
            this.RePasswordtxtBox.Size = new System.Drawing.Size(114, 20);
            this.RePasswordtxtBox.TabIndex = 9;
            this.RePasswordtxtBox.TextChanged += new System.EventHandler(this.RePasswordtxtBox_TextChanged);
            // 
            // PasswordBtn
            // 
            this.PasswordBtn.Location = new System.Drawing.Point(91, 250);
            this.PasswordBtn.Name = "PasswordBtn";
            this.PasswordBtn.Size = new System.Drawing.Size(151, 33);
            this.PasswordBtn.TabIndex = 10;
            this.PasswordBtn.Text = "CHANGE PASSWORD";
            this.PasswordBtn.UseVisualStyleBackColor = true;
            this.PasswordBtn.Click += new System.EventHandler(this.PasswordBtn_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 308);
            this.Controls.Add(this.PasswordBtn);
            this.Controls.Add(this.RePasswordtxtBox);
            this.Controls.Add(this.NewPasswordtxtBox);
            this.Controls.Add(this.OldPasswordtxtBox);
            this.Controls.Add(this.userNametxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userNametxtBox;
        private System.Windows.Forms.TextBox OldPasswordtxtBox;
        private System.Windows.Forms.TextBox NewPasswordtxtBox;
        private System.Windows.Forms.TextBox RePasswordtxtBox;
        private System.Windows.Forms.Button PasswordBtn;
    }
}