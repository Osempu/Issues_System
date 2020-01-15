namespace Issues_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.topLogo = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnIssueHistory = new System.Windows.Forms.Button();
            this.btnAttendIssue = new System.Windows.Forms.Button();
            this.btnOpenIssue = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnSelector = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.topPanel.Controls.Add(this.button5);
            this.topPanel.Controls.Add(this.button4);
            this.topPanel.Controls.Add(this.lblFormTitle);
            this.topPanel.Controls.Add(this.topLogo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1105, 35);
            this.topPanel.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1018, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 35);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1060, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(61, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(82, 20);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "TECHNIUS";
            // 
            // topLogo
            // 
            this.topLogo.Image = ((System.Drawing.Image)(resources.GetObject("topLogo.Image")));
            this.topLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("topLogo.InitialImage")));
            this.topLogo.Location = new System.Drawing.Point(12, 0);
            this.topLogo.Name = "topLogo";
            this.topLogo.Size = new System.Drawing.Size(34, 31);
            this.topLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.topLogo.TabIndex = 0;
            this.topLogo.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(152)))), ((int)(((byte)(142)))));
            this.leftPanel.Controls.Add(this.btnSelector);
            this.leftPanel.Controls.Add(this.btnIssueHistory);
            this.leftPanel.Controls.Add(this.btnAttendIssue);
            this.leftPanel.Controls.Add(this.btnOpenIssue);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 35);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(203, 661);
            this.leftPanel.TabIndex = 2;
            // 
            // btnIssueHistory
            // 
            this.btnIssueHistory.FlatAppearance.BorderSize = 0;
            this.btnIssueHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueHistory.ForeColor = System.Drawing.Color.White;
            this.btnIssueHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueHistory.Image")));
            this.btnIssueHistory.Location = new System.Drawing.Point(12, 172);
            this.btnIssueHistory.Name = "btnIssueHistory";
            this.btnIssueHistory.Size = new System.Drawing.Size(191, 52);
            this.btnIssueHistory.TabIndex = 11;
            this.btnIssueHistory.Text = "  Issue History";
            this.btnIssueHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueHistory.UseVisualStyleBackColor = true;
            this.btnIssueHistory.Click += new System.EventHandler(this.btnIssueHistory_Click);
            // 
            // btnAttendIssue
            // 
            this.btnAttendIssue.FlatAppearance.BorderSize = 0;
            this.btnAttendIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendIssue.ForeColor = System.Drawing.Color.White;
            this.btnAttendIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendIssue.Image")));
            this.btnAttendIssue.Location = new System.Drawing.Point(12, 96);
            this.btnAttendIssue.Name = "btnAttendIssue";
            this.btnAttendIssue.Size = new System.Drawing.Size(191, 52);
            this.btnAttendIssue.TabIndex = 10;
            this.btnAttendIssue.Text = "  Attend Issue";
            this.btnAttendIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendIssue.UseVisualStyleBackColor = true;
            this.btnAttendIssue.Click += new System.EventHandler(this.btnAttendIssue_Click);
            // 
            // btnOpenIssue
            // 
            this.btnOpenIssue.FlatAppearance.BorderSize = 0;
            this.btnOpenIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIssue.ForeColor = System.Drawing.Color.White;
            this.btnOpenIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenIssue.Image")));
            this.btnOpenIssue.Location = new System.Drawing.Point(12, 20);
            this.btnOpenIssue.Name = "btnOpenIssue";
            this.btnOpenIssue.Size = new System.Drawing.Size(191, 52);
            this.btnOpenIssue.TabIndex = 9;
            this.btnOpenIssue.Text = "  Open Issue";
            this.btnOpenIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenIssue.UseVisualStyleBackColor = true;
            this.btnOpenIssue.Click += new System.EventHandler(this.btnOpenIssue_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.lblBrand);
            this.mainPanel.Controls.Add(this.Logo);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(203, 35);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(902, 661);
            this.mainPanel.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.Black;
            this.lblBrand.Location = new System.Drawing.Point(327, 432);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(328, 81);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "TECHNIUS";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = null;
            this.Logo.Location = new System.Drawing.Point(274, 146);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(384, 272);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // btnSelector
            // 
            this.btnSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnSelector.Location = new System.Drawing.Point(0, 20);
            this.btnSelector.Name = "btnSelector";
            this.btnSelector.Size = new System.Drawing.Size(10, 52);
            this.btnSelector.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 696);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox topLogo;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnIssueHistory;
        private System.Windows.Forms.Button btnAttendIssue;
        private System.Windows.Forms.Button btnOpenIssue;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel btnSelector;
    }
}

