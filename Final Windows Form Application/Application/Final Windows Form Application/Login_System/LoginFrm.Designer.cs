﻿namespace Login_System
{
    partial class LoginFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkpwd = new System.Windows.Forms.CheckBox();
            this.PassWtxtb = new System.Windows.Forms.TextBox();
            this.UserNtxtbx = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(756, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO STAR HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkpwd);
            this.panel1.Controls.Add(this.PassWtxtb);
            this.panel1.Controls.Add(this.UserNtxtbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(53, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 249);
            this.panel1.TabIndex = 3;
            // 
            // chkpwd
            // 
            this.chkpwd.AutoSize = true;
            this.chkpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpwd.ForeColor = System.Drawing.Color.Green;
            this.chkpwd.Location = new System.Drawing.Point(19, 184);
            this.chkpwd.Name = "chkpwd";
            this.chkpwd.Size = new System.Drawing.Size(204, 33);
            this.chkpwd.TabIndex = 6;
            this.chkpwd.Text = "Show password";
            this.chkpwd.UseVisualStyleBackColor = true;
            this.chkpwd.CheckedChanged += new System.EventHandler(this.chkpwd_CheckedChanged);
            // 
            // PassWtxtb
            // 
            this.PassWtxtb.Location = new System.Drawing.Point(11, 143);
            this.PassWtxtb.Multiline = true;
            this.PassWtxtb.Name = "PassWtxtb";
            this.PassWtxtb.Size = new System.Drawing.Size(509, 35);
            this.PassWtxtb.TabIndex = 4;
            this.PassWtxtb.TextChanged += new System.EventHandler(this.PassWtxtb_TextChanged);
            // 
            // UserNtxtbx
            // 
            this.UserNtxtbx.Location = new System.Drawing.Point(11, 53);
            this.UserNtxtbx.Multiline = true;
            this.UserNtxtbx.Name = "UserNtxtbx";
            this.UserNtxtbx.Size = new System.Drawing.Size(509, 36);
            this.UserNtxtbx.TabIndex = 3;
            this.UserNtxtbx.TextChanged += new System.EventHandler(this.UserNtxtbx_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(438, 351);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(137, 55);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current date and time";
            // 
            // datelbl
            // 
            this.datelbl.Location = new System.Drawing.Point(131, 70);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(84, 13);
            this.datelbl.TabIndex = 6;
            this.datelbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // timelbl
            // 
            this.timelbl.Location = new System.Drawing.Point(221, 70);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(57, 13);
            this.timelbl.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(-1, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(756, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(758, 496);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "LoginFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassWtxtb;
        private System.Windows.Forms.TextBox UserNtxtbx;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.CheckBox chkpwd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

