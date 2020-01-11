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
            this.fechaApertura = new System.Windows.Forms.DateTimePicker();
            this.lblTIme = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtLine = new System.Windows.Forms.ComboBox();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(646, 566);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(243, 65);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit Issue";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // fechaApertura
            // 
            this.fechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechaApertura.Location = new System.Drawing.Point(217, 511);
            this.fechaApertura.Margin = new System.Windows.Forms.Padding(4);
            this.fechaApertura.Name = "fechaApertura";
            this.fechaApertura.Size = new System.Drawing.Size(182, 22);
            this.fechaApertura.TabIndex = 13;
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIme.Location = new System.Drawing.Point(54, 512);
            this.lblTIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(140, 32);
            this.lblTIme.TabIndex = 11;
            this.lblTIme.Text = "Issue Time :";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(37, 275);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(159, 32);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Issue Details :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(217, 153);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(266, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // txtLine
            // 
            this.txtLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLine.FormattingEnabled = true;
            this.txtLine.Location = new System.Drawing.Point(217, 52);
            this.txtLine.Margin = new System.Windows.Forms.Padding(4);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(266, 24);
            this.txtLine.TabIndex = 10;
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipment.Location = new System.Drawing.Point(48, 155);
            this.lblEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(143, 32);
            this.lblEquipment.TabIndex = 6;
            this.lblEquipment.Text = "Equipment :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 274);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(530, 171);
            this.textBox1.TabIndex = 8;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(108, 54);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(71, 32);
            this.lblLine.TabIndex = 7;
            this.lblLine.Text = "Line :";
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.fechaApertura);
            this.Controls.Add(this.lblTIme);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLine);
            this.Name = "IssueForm";
            this.Size = new System.Drawing.Size(912, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker fechaApertura;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox txtLine;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLine;
    }
}
