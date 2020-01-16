namespace Issues_System.Views
{
    partial class IssuesHistoryForm
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
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtEquipment = new System.Windows.Forms.TextBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.llbTime = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSolution
            // 
            this.txtSolution.Location = new System.Drawing.Point(150, 333);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.ReadOnly = true;
            this.txtSolution.Size = new System.Drawing.Size(460, 114);
            this.txtSolution.TabIndex = 11;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(33, 333);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(95, 28);
            this.lblSolution.TabIndex = 22;
            this.lblSolution.Text = "Solution :";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(150, 187);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(460, 112);
            this.txtDetails.TabIndex = 21;
            this.txtDetails.TabStop = false;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(48, 187);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(80, 28);
            this.lblDetails.TabIndex = 20;
            this.lblDetails.Text = "Details :";
            // 
            // txtEquipment
            // 
            this.txtEquipment.Location = new System.Drawing.Point(150, 130);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.ReadOnly = true;
            this.txtEquipment.Size = new System.Drawing.Size(158, 34);
            this.txtEquipment.TabIndex = 19;
            this.txtEquipment.TabStop = false;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(12, 133);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(116, 28);
            this.lblEquipment.TabIndex = 18;
            this.lblEquipment.Text = "Equipment :";
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(150, 75);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(158, 34);
            this.txtLine.TabIndex = 17;
            this.txtLine.TabStop = false;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(72, 78);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(56, 28);
            this.lblLine.TabIndex = 16;
            this.lblLine.Text = "Line :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(442, 466);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(168, 58);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Back";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(456, 19);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(114, 34);
            this.txtTime.TabIndex = 15;
            this.txtTime.TabStop = false;
            // 
            // llbTime
            // 
            this.llbTime.AutoSize = true;
            this.llbTime.Location = new System.Drawing.Point(352, 22);
            this.llbTime.Name = "llbTime";
            this.llbTime.Size = new System.Drawing.Size(91, 28);
            this.llbTime.TabIndex = 12;
            this.llbTime.Text = "Open at :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(109, 34);
            this.txtId.TabIndex = 23;
            this.txtId.TabStop = false;
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Location = new System.Drawing.Point(41, 22);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(87, 28);
            this.lblIssueID.TabIndex = 13;
            this.lblIssueID.Text = "Issue ID :";
            // 
            // IssuesHistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 543);
            this.Controls.Add(this.txtSolution);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtEquipment);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.llbTime);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIssueID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IssuesHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssuesHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtEquipment;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label llbTime;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIssueID;
    }
}