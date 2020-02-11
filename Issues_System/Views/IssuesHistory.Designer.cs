namespace Issues_System.Views
{
    partial class IssuesHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.dgvIssuesHistory = new Guna.UI.WinForms.GunaDataGridView();
            this.testDBDataSet = new Issues_System.TestDBDataSet();
            this.issuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuesTableAdapter = new Issues_System.TestDBDataSetTableAdapters.IssuesTableAdapter();
            this.openAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(341, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 42);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Issues History";
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(688, 590);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(210, 55);
            this.btnDetails.TabIndex = 12;
            this.btnDetails.Text = "View";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // dgvIssuesHistory
            // 
            this.dgvIssuesHistory.AllowUserToAddRows = false;
            this.dgvIssuesHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIssuesHistory.AutoGenerateColumns = false;
            this.dgvIssuesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIssuesHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIssuesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIssuesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIssuesHistory.ColumnHeadersHeight = 34;
            this.dgvIssuesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.openByDataGridViewTextBoxColumn,
            this.assignedToDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.openAtDataGridViewTextBoxColumn});
            this.dgvIssuesHistory.DataSource = this.issuesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIssuesHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIssuesHistory.EnableHeadersVisualStyles = false;
            this.dgvIssuesHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIssuesHistory.Location = new System.Drawing.Point(14, 70);
            this.dgvIssuesHistory.MultiSelect = false;
            this.dgvIssuesHistory.Name = "dgvIssuesHistory";
            this.dgvIssuesHistory.ReadOnly = true;
            this.dgvIssuesHistory.RowHeadersVisible = false;
            this.dgvIssuesHistory.RowHeadersWidth = 51;
            this.dgvIssuesHistory.RowTemplate.Height = 24;
            this.dgvIssuesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuesHistory.Size = new System.Drawing.Size(884, 501);
            this.dgvIssuesHistory.TabIndex = 14;
            this.dgvIssuesHistory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvIssuesHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvIssuesHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvIssuesHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvIssuesHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvIssuesHistory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIssuesHistory.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvIssuesHistory.ThemeStyle.ReadOnly = true;
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.Height = 24;
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIssuesHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // testDBDataSet
            // 
            this.testDBDataSet.DataSetName = "TestDBDataSet";
            this.testDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuesBindingSource
            // 
            this.issuesBindingSource.DataMember = "Issues";
            this.issuesBindingSource.DataSource = this.testDBDataSet;
            // 
            // issuesTableAdapter
            // 
            this.issuesTableAdapter.ClearBeforeFill = true;
            // 
            // openAtDataGridViewTextBoxColumn
            // 
            this.openAtDataGridViewTextBoxColumn.DataPropertyName = "openAt";
            this.openAtDataGridViewTextBoxColumn.FillWeight = 100.7487F;
            this.openAtDataGridViewTextBoxColumn.HeaderText = "openAt";
            this.openAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openAtDataGridViewTextBoxColumn.Name = "openAtDataGridViewTextBoxColumn";
            this.openAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.FillWeight = 100.7487F;
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.FillWeight = 100.7487F;
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.lineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assignedToDataGridViewTextBoxColumn
            // 
            this.assignedToDataGridViewTextBoxColumn.DataPropertyName = "AssignedTo";
            this.assignedToDataGridViewTextBoxColumn.FillWeight = 100.7487F;
            this.assignedToDataGridViewTextBoxColumn.HeaderText = "AssignedTo";
            this.assignedToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignedToDataGridViewTextBoxColumn.Name = "assignedToDataGridViewTextBoxColumn";
            this.assignedToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openByDataGridViewTextBoxColumn
            // 
            this.openByDataGridViewTextBoxColumn.DataPropertyName = "OpenBy";
            this.openByDataGridViewTextBoxColumn.FillWeight = 100.7487F;
            this.openByDataGridViewTextBoxColumn.HeaderText = "OpenBy";
            this.openByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openByDataGridViewTextBoxColumn.Name = "openByDataGridViewTextBoxColumn";
            this.openByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IssuesHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvIssuesHistory);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IssuesHistory";
            this.Size = new System.Drawing.Size(912, 661);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDetails;
        public Guna.UI.WinForms.GunaDataGridView dgvIssuesHistory;
        private System.Windows.Forms.BindingSource issuesBindingSource;
        private TestDBDataSet testDBDataSet;
        private TestDBDataSetTableAdapters.IssuesTableAdapter issuesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openAtDataGridViewTextBoxColumn;
    }
}
