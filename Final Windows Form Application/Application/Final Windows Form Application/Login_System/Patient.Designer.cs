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
            this.savePbtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cnumtxtB = new System.Windows.Forms.TextBox();
            this.surnametxtB = new System.Windows.Forms.TextBox();
            this.nametxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(757, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO STAR HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // savePbtn
            // 
            this.savePbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savePbtn.Location = new System.Drawing.Point(243, 413);
            this.savePbtn.Name = "savePbtn";
            this.savePbtn.Size = new System.Drawing.Size(174, 50);
            this.savePbtn.TabIndex = 10;
            this.savePbtn.Text = "SAVE";
            this.savePbtn.UseVisualStyleBackColor = true;
            this.savePbtn.Click += new System.EventHandler(this.savePbtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(423, 413);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(174, 50);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(63, 413);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(174, 50);
            this.menuBtn.TabIndex = 19;
            this.menuBtn.Text = "<<Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.cnumtxtB);
            this.panel1.Controls.Add(this.surnametxtB);
            this.panel1.Controls.Add(this.nametxtB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(63, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 324);
            this.panel1.TabIndex = 20;
            // 
            // cnumtxtB
            // 
            this.cnumtxtB.Location = new System.Drawing.Point(50, 262);
            this.cnumtxtB.Multiline = true;
            this.cnumtxtB.Name = "cnumtxtB";
            this.cnumtxtB.Size = new System.Drawing.Size(509, 36);
            this.cnumtxtB.TabIndex = 15;
            // 
            // surnametxtB
            // 
            this.surnametxtB.Location = new System.Drawing.Point(50, 161);
            this.surnametxtB.Multiline = true;
            this.surnametxtB.Name = "surnametxtB";
            this.surnametxtB.Size = new System.Drawing.Size(509, 36);
            this.surnametxtB.TabIndex = 14;
            // 
            // nametxtB
            // 
            this.nametxtB.Location = new System.Drawing.Point(50, 64);
            this.nametxtB.Multiline = true;
            this.nametxtB.Name = "nametxtB";
            this.nametxtB.Size = new System.Drawing.Size(509, 36);
            this.nametxtB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(47, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 45);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contact Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(47, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(47, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(758, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.savePbtn);
            this.Controls.Add(this.label1);
            this.Name = "Patient";
            this.Text = "Patient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePbtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cnumtxtB;
        private System.Windows.Forms.TextBox surnametxtB;
        private System.Windows.Forms.TextBox nametxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}