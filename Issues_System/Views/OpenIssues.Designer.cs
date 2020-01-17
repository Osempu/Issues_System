namespace Issues_System.Views
{
    partial class OpenIssues
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOpenIssues = new Guna.UI.WinForms.GunaDataGridView();
            this.testDBDataSet1 = new Issues_System.TestDBDataSet1();
            this.testDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuesTableAdapter = new Issues_System.TestDBDataSet1TableAdapters.IssuesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(688, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(210, 55);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close Issue";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(353, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 42);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Open Issues";
            // 
            // dgvOpenIssues
            // 
            this.dgvOpenIssues.AllowUserToAddRows = false;
            this.dgvOpenIssues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOpenIssues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOpenIssues.AutoGenerateColumns = false;
            this.dgvOpenIssues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOpenIssues.BackgroundColor = System.Drawing.Color.White;
            this.dgvOpenIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOpenIssues.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOpenIssues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOpenIssues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOpenIssues.ColumnHeadersHeight = 34;
            this.dgvOpenIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.lineDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.openAtDataGridViewTextBoxColumn});
            this.dgvOpenIssues.DataSource = this.issuesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOpenIssues.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOpenIssues.EnableHeadersVisualStyles = false;
            this.dgvOpenIssues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpenIssues.Location = new System.Drawing.Point(14, 70);
            this.dgvOpenIssues.MultiSelect = false;
            this.dgvOpenIssues.Name = "dgvOpenIssues";
            this.dgvOpenIssues.ReadOnly = true;
            this.dgvOpenIssues.RowHeadersVisible = false;
            this.dgvOpenIssues.RowHeadersWidth = 51;
            this.dgvOpenIssues.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOpenIssues.RowTemplate.Height = 24;
            this.dgvOpenIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpenIssues.Size = new System.Drawing.Size(884, 501);
            this.dgvOpenIssues.TabIndex = 15;
            this.dgvOpenIssues.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvOpenIssues.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpenIssues.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOpenIssues.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOpenIssues.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOpenIssues.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOpenIssues.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpenIssues.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOpenIssues.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvOpenIssues.ThemeStyle.ReadOnly = true;
            this.dgvOpenIssues.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOpenIssues.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOpenIssues.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOpenIssues.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvOpenIssues.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOpenIssues.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvOpenIssues.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // testDBDataSet1
            // 
            this.testDBDataSet1.DataSetName = "TestDBDataSet1";
            this.testDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDBDataSet1BindingSource
            // 
            this.testDBDataSet1BindingSource.DataSource = this.testDBDataSet1;
            this.testDBDataSet1BindingSource.Position = 0;
            // 
            // issuesBindingSource
            // 
            this.issuesBindingSource.DataMember = "Issues";
            this.issuesBindingSource.DataSource = this.testDBDataSet1BindingSource;
            // 
            // issuesTableAdapter
            // 
            this.issuesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineDataGridViewTextBoxColumn
            // 
            this.lineDataGridViewTextBoxColumn.DataPropertyName = "Line";
            this.lineDataGridViewTextBoxColumn.HeaderText = "Line";
            this.lineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineDataGridViewTextBoxColumn.Name = "lineDataGridViewTextBoxColumn";
            this.lineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // openAtDataGridViewTextBoxColumn
            // 
            this.openAtDataGridViewTextBoxColumn.DataPropertyName = "OpenAt";
            this.openAtDataGridViewTextBoxColumn.HeaderText = "OpenAt";
            this.openAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.openAtDataGridViewTextBoxColumn.Name = "openAtDataGridViewTextBoxColumn";
            this.openAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OpenIssues
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvOpenIssues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OpenIssues";
            this.Size = new System.Drawing.Size(912, 661);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpenIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        public Guna.UI.WinForms.GunaDataGridView dgvOpenIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource issuesBindingSource;
        private System.Windows.Forms.BindingSource testDBDataSet1BindingSource;
        private TestDBDataSet1 testDBDataSet1;
        private TestDBDataSet1TableAdapters.IssuesTableAdapter issuesTableAdapter;
    }
}
