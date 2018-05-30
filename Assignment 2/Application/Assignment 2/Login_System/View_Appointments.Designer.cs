namespace Login_System
{
    partial class View_Appointments
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Login_System.Capture_DetailsDataSetTableAdapters.TableAdapterManager();
            this.capture_DetailsDataSet = new Login_System.Capture_DetailsDataSet();
            this.patienttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patienttblTableAdapter = new Login_System.Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter();
            this.patienttblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByTToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByTToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.capture_DetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblDataGridView)).BeginInit();
            this.fillByTToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(-14, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(404, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME TO STAR HOSPITAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "<<Appointments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(126, 298);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 37);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(197, 298);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 37);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(269, 298);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 36);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PatienttblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Login_System.Capture_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // capture_DetailsDataSet
            // 
            this.capture_DetailsDataSet.DataSetName = "Capture_DetailsDataSet";
            this.capture_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patienttblBindingSource
            // 
            this.patienttblBindingSource.DataMember = "Patienttbl";
            this.patienttblBindingSource.DataSource = this.capture_DetailsDataSet;
            // 
            // patienttblTableAdapter
            // 
            this.patienttblTableAdapter.ClearBeforeFill = true;
            // 
            // patienttblDataGridView
            // 
            this.patienttblDataGridView.AutoGenerateColumns = false;
            this.patienttblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patienttblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.patienttblDataGridView.DataSource = this.patienttblBindingSource;
            this.patienttblDataGridView.Location = new System.Drawing.Point(21, 61);
            this.patienttblDataGridView.Name = "patienttblDataGridView";
            this.patienttblDataGridView.Size = new System.Drawing.Size(323, 220);
            this.patienttblDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn3.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fillByTToolStrip
            // 
            this.fillByTToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByTToolStripButton});
            this.fillByTToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByTToolStrip.Name = "fillByTToolStrip";
            this.fillByTToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByTToolStrip.TabIndex = 11;
            this.fillByTToolStrip.Text = "fillByTToolStrip";
            // 
            // fillByTToolStripButton
            // 
            this.fillByTToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByTToolStripButton.Name = "fillByTToolStripButton";
            this.fillByTToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByTToolStripButton.Text = "FillByT";
            this.fillByTToolStripButton.Click += new System.EventHandler(this.fillByTToolStripButton_Click_1);
            // 
            // View_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 356);
            this.Controls.Add(this.fillByTToolStrip);
            this.Controls.Add(this.patienttblDataGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "View_Appointments";
            this.Text = "View_Appointments";
            this.Load += new System.EventHandler(this.View_Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capture_DetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblDataGridView)).EndInit();
            this.fillByTToolStrip.ResumeLayout(false);
            this.fillByTToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Capture_DetailsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Capture_DetailsDataSet capture_DetailsDataSet;
        private System.Windows.Forms.BindingSource patienttblBindingSource;
        private Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter patienttblTableAdapter;
        private System.Windows.Forms.DataGridView patienttblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStrip fillByTToolStrip;
        private System.Windows.Forms.ToolStripButton fillByTToolStripButton;
    }
}