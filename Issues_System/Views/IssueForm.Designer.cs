namespace Issues_System.Views
{
    partial class IssueForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cbEquipment = new System.Windows.Forms.ComboBox();
            this.cbLine = new System.Windows.Forms.ComboBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.cbAssignedTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(646, 573);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(243, 65);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Issue";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(39, 362);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(185, 38);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Issue Details :";
            // 
            // cbEquipment
            // 
            this.cbEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipment.FormattingEnabled = true;
            this.cbEquipment.Items.AddRange(new object[] {
            "Hot Drop",
            "Embobinadora",
            "Cortadoras"});
            this.cbEquipment.Location = new System.Drawing.Point(239, 149);
            this.cbEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.cbEquipment.Name = "cbEquipment";
            this.cbEquipment.Size = new System.Drawing.Size(266, 45);
            this.cbEquipment.TabIndex = 1;
            // 
            // cbLine
            // 
            this.cbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLine.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLine.FormattingEnabled = true;
            this.cbLine.Items.AddRange(new object[] {
            "52",
            "33",
            "12"});
            this.cbLine.Location = new System.Drawing.Point(239, 53);
            this.cbLine.Margin = new System.Windows.Forms.Padding(4);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(266, 45);
            this.cbLine.TabIndex = 0;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.Location = new System.Drawing.Point(60, 152);
            this.lblEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(164, 38);
            this.lblEquipment.TabIndex = 6;
            this.lblEquipment.Text = "Equipment :";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(239, 362);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(530, 171);
            this.txtDetails.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(142, 56);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(82, 38);
            this.lblLine.TabIndex = 7;
            this.lblLine.Text = "Line :";
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedTo.Location = new System.Drawing.Point(79, 246);
            this.lblAssignedTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(145, 38);
            this.lblAssignedTo.TabIndex = 6;
            this.lblAssignedTo.Text = "Assign to :";
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignedTo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.Items.AddRange(new object[] {
            "Hot Drop",
            "Embobinadora",
            "Cortadoras"});
            this.cbAssignedTo.Location = new System.Drawing.Point(239, 243);
            this.cbAssignedTo.Margin = new System.Windows.Forms.Padding(4);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(266, 45);
            this.cbAssignedTo.TabIndex = 1;
            // 
            // IssueForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cbAssignedTo);
            this.Controls.Add(this.cbEquipment);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.cbLine);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblLine);
            this.Name = "IssueForm";
            this.Size = new System.Drawing.Size(912, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cbEquipment;
        private System.Windows.Forms.ComboBox cbLine;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblAssignedTo;
        public System.Windows.Forms.ComboBox cbAssignedTo;
    }
}
