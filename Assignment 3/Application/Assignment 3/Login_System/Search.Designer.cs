namespace Login_System
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.patienttblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patienttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.capture_DetailsDataSet = new Login_System.Capture_DetailsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patienttblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Menubtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByContactToolStrip = new System.Windows.Forms.ToolStrip();
            this.surnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.surnameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.contactToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.contactToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByContactToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.patienttblTableAdapter = new Login_System.Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter();
            this.tableAdapterManager = new Login_System.Capture_DetailsDataSetTableAdapters.TableAdapterManager();
            this.patienttblTableAdapter1 = new Login_System.Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingNavigator)).BeginInit();
            this.patienttblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capture_DetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByContactToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // patienttblBindingNavigator
            // 
            this.patienttblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patienttblBindingNavigator.BindingSource = this.patienttblBindingSource;
            this.patienttblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patienttblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patienttblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patienttblBindingNavigatorSaveItem});
            this.patienttblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patienttblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patienttblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patienttblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patienttblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patienttblBindingNavigator.Name = "patienttblBindingNavigator";
            this.patienttblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patienttblBindingNavigator.Size = new System.Drawing.Size(345, 25);
            this.patienttblBindingNavigator.TabIndex = 16;
            this.patienttblBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // patienttblBindingSource
            // 
            this.patienttblBindingSource.DataMember = "Patienttbl";
            this.patienttblBindingSource.DataSource = this.capture_DetailsDataSet;
            // 
            // capture_DetailsDataSet
            // 
            this.capture_DetailsDataSet.DataSetName = "Capture_DetailsDataSet";
            this.capture_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patienttblBindingNavigatorSaveItem
            // 
            this.patienttblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patienttblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patienttblBindingNavigatorSaveItem.Image")));
            this.patienttblBindingNavigatorSaveItem.Name = "patienttblBindingNavigatorSaveItem";
            this.patienttblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patienttblBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // Menubtn
            // 
            this.Menubtn.Location = new System.Drawing.Point(12, 280);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(108, 37);
            this.Menubtn.TabIndex = 17;
            this.Menubtn.Text = "<<Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patienttblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 203);
            this.dataGridView1.TabIndex = 18;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // fillByContactToolStrip
            // 
            this.fillByContactToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surnameToolStripLabel,
            this.surnameToolStripTextBox,
            this.contactToolStripLabel,
            this.contactToolStripTextBox,
            this.fillByContactToolStripButton});
            this.fillByContactToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByContactToolStrip.Name = "fillByContactToolStrip";
            this.fillByContactToolStrip.Size = new System.Drawing.Size(345, 25);
            this.fillByContactToolStrip.TabIndex = 19;
            this.fillByContactToolStrip.Text = "fillByContactToolStrip";
            // 
            // surnameToolStripLabel
            // 
            this.surnameToolStripLabel.Name = "surnameToolStripLabel";
            this.surnameToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.surnameToolStripLabel.Text = "Surname:";
            // 
            // surnameToolStripTextBox
            // 
            this.surnameToolStripTextBox.Name = "surnameToolStripTextBox";
            this.surnameToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // contactToolStripLabel
            // 
            this.contactToolStripLabel.Name = "contactToolStripLabel";
            this.contactToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.contactToolStripLabel.Text = "Contact:";
            // 
            // contactToolStripTextBox
            // 
            this.contactToolStripTextBox.Name = "contactToolStripTextBox";
            this.contactToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByContactToolStripButton
            // 
            this.fillByContactToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByContactToolStripButton.Name = "fillByContactToolStripButton";
            this.fillByContactToolStripButton.Size = new System.Drawing.Size(81, 19);
            this.fillByContactToolStripButton.Text = "FillByContact";
            this.fillByContactToolStripButton.Click += new System.EventHandler(this.fillByContactToolStripButton_Click);
            // 
            // patienttblTableAdapter
            // 
            this.patienttblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PatienttblTableAdapter = this.patienttblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Login_System.Capture_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patienttblTableAdapter1
            // 
            this.patienttblTableAdapter1.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 337);
            this.Controls.Add(this.fillByContactToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.patienttblBindingNavigator);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingNavigator)).EndInit();
            this.patienttblBindingNavigator.ResumeLayout(false);
            this.patienttblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patienttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capture_DetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByContactToolStrip.ResumeLayout(false);
            this.fillByContactToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Capture_DetailsDataSet capture_DetailsDataSet;
        private System.Windows.Forms.BindingSource patienttblBindingSource;
        private Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter patienttblTableAdapter;
        private Capture_DetailsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patienttblBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patienttblBindingNavigatorSaveItem;
        private System.Windows.Forms.Button Menubtn;
        private Capture_DetailsDataSetTableAdapters.PatienttblTableAdapter patienttblTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByContactToolStrip;
        private System.Windows.Forms.ToolStripLabel surnameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox surnameToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel contactToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox contactToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByContactToolStripButton;
    }
}