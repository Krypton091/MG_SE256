namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnAddPayCheck = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.txtReadWholeFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(115, 38);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(161, 20);
            this.txtFName.TabIndex = 1;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(115, 88);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(161, 20);
            this.txtMName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(115, 137);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(161, 20);
            this.txtLName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(115, 185);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(161, 20);
            this.txtRate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hourly Rate";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(115, 239);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(161, 20);
            this.txtHours.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hours Worked";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(333, 45);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 10;
            this.lblFeedback.Text = "Feedback";
            // 
            // btnAddPayCheck
            // 
            this.btnAddPayCheck.Location = new System.Drawing.Point(62, 309);
            this.btnAddPayCheck.Name = "btnAddPayCheck";
            this.btnAddPayCheck.Size = new System.Drawing.Size(132, 23);
            this.btnAddPayCheck.TabIndex = 11;
            this.btnAddPayCheck.Text = "Add PayCheck";
            this.btnAddPayCheck.UseVisualStyleBackColor = true;
            this.btnAddPayCheck.Click += new System.EventHandler(this.btnAddPayCheck_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(336, 88);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFeedback.Size = new System.Drawing.Size(470, 200);
            this.txtFeedback.TabIndex = 12;
            // 
            // txtReadWholeFile
            // 
            this.txtReadWholeFile.Location = new System.Drawing.Point(240, 309);
            this.txtReadWholeFile.Name = "txtReadWholeFile";
            this.txtReadWholeFile.Size = new System.Drawing.Size(132, 23);
            this.txtReadWholeFile.TabIndex = 13;
            this.txtReadWholeFile.Text = "Read Whole File";
            this.txtReadWholeFile.UseVisualStyleBackColor = true;
            this.txtReadWholeFile.Click += new System.EventHandler(this.txtReadWholeFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 379);
            this.Controls.Add(this.txtReadWholeFile);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.btnAddPayCheck);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnAddPayCheck;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button txtReadWholeFile;
    }
}

