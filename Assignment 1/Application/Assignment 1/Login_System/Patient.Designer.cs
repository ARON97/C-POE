namespace Login_System
{
    partial class Patient
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
            this.nametxtB = new System.Windows.Forms.TextBox();
            this.surnametxtB = new System.Windows.Forms.TextBox();
            this.cnumtxtB = new System.Windows.Forms.TextBox();
            this.savePbtn = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.reportBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveRbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(369, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO STAR HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contact Number";
            // 
            // nametxtB
            // 
            this.nametxtB.Location = new System.Drawing.Point(170, 89);
            this.nametxtB.Name = "nametxtB";
            this.nametxtB.Size = new System.Drawing.Size(160, 20);
            this.nametxtB.TabIndex = 7;
            // 
            // surnametxtB
            // 
            this.surnametxtB.Location = new System.Drawing.Point(170, 118);
            this.surnametxtB.Name = "surnametxtB";
            this.surnametxtB.Size = new System.Drawing.Size(160, 20);
            this.surnametxtB.TabIndex = 8;
            // 
            // cnumtxtB
            // 
            this.cnumtxtB.Location = new System.Drawing.Point(170, 148);
            this.cnumtxtB.Name = "cnumtxtB";
            this.cnumtxtB.Size = new System.Drawing.Size(160, 20);
            this.cnumtxtB.TabIndex = 9;
            // 
            // savePbtn
            // 
            this.savePbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savePbtn.Location = new System.Drawing.Point(104, 219);
            this.savePbtn.Name = "savePbtn";
            this.savePbtn.Size = new System.Drawing.Size(71, 28);
            this.savePbtn.TabIndex = 10;
            this.savePbtn.Text = "SAVE";
            this.savePbtn.UseVisualStyleBackColor = true;
            this.savePbtn.Click += new System.EventHandler(this.savePbtn_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.Location = new System.Drawing.Point(21, 179);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(93, 13);
            this.ChangePassword.TabIndex = 16;
            this.ChangePassword.TabStop = true;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePassword_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(24, 219);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(82, 28);
            this.reportBtn.TabIndex = 17;
            this.reportBtn.Text = "Open Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(172, 219);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(77, 28);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // saveRbtn
            // 
            this.saveRbtn.Location = new System.Drawing.Point(247, 219);
            this.saveRbtn.Name = "saveRbtn";
            this.saveRbtn.Size = new System.Drawing.Size(83, 28);
            this.saveRbtn.TabIndex = 19;
            this.saveRbtn.Text = "Save Report";
            this.saveRbtn.UseVisualStyleBackColor = true;
            this.saveRbtn.Click += new System.EventHandler(this.saveRbtn_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 273);
            this.Controls.Add(this.saveRbtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.cnumtxtB);
            this.Controls.Add(this.surnametxtB);
            this.Controls.Add(this.nametxtB);
            this.Controls.Add(this.savePbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametxtB;
        private System.Windows.Forms.TextBox surnametxtB;
        private System.Windows.Forms.TextBox cnumtxtB;
        private System.Windows.Forms.Button savePbtn;
        private System.Windows.Forms.LinkLabel ChangePassword;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveRbtn;
    }
}