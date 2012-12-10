namespace StudentRegistration
{
    partial class NewStudentData
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
            this.stdNameValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stdGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stbDOB = new System.Windows.Forms.DateTimePicker();
            this.stdStatus = new System.Windows.Forms.CheckBox();
            this.saveDetails = new System.Windows.Forms.Button();
            this.newDetails = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stdID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name  ";
            // 
            // stdNameValue
            // 
            this.stdNameValue.Location = new System.Drawing.Point(163, 54);
            this.stdNameValue.Name = "stdNameValue";
            this.stdNameValue.Size = new System.Drawing.Size(271, 20);
            this.stdNameValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "GPA";
            // 
            // stdGPA
            // 
            this.stdGPA.Location = new System.Drawing.Point(163, 120);
            this.stdGPA.Name = "stdGPA";
            this.stdGPA.Size = new System.Drawing.Size(271, 20);
            this.stdGPA.TabIndex = 3;
            this.stdGPA.Validated += new System.EventHandler(this.stdGPA_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Record Status";
            // 
            // stbDOB
            // 
            this.stbDOB.Location = new System.Drawing.Point(163, 84);
            this.stbDOB.Name = "stbDOB";
            this.stbDOB.Size = new System.Drawing.Size(271, 20);
            this.stbDOB.TabIndex = 2;
            // 
            // stdStatus
            // 
            this.stdStatus.AutoSize = true;
            this.stdStatus.Location = new System.Drawing.Point(163, 156);
            this.stdStatus.Name = "stdStatus";
            this.stdStatus.Size = new System.Drawing.Size(15, 14);
            this.stdStatus.TabIndex = 4;
            this.stdStatus.UseVisualStyleBackColor = true;
            // 
            // saveDetails
            // 
            this.saveDetails.Location = new System.Drawing.Point(278, 195);
            this.saveDetails.Name = "saveDetails";
            this.saveDetails.Size = new System.Drawing.Size(75, 23);
            this.saveDetails.TabIndex = 5;
            this.saveDetails.Text = "OK";
            this.saveDetails.UseVisualStyleBackColor = true;
            this.saveDetails.Click += new System.EventHandler(this.saveDetails_Click);
            // 
            // newDetails
            // 
            this.newDetails.Location = new System.Drawing.Point(359, 195);
            this.newDetails.Name = "newDetails";
            this.newDetails.Size = new System.Drawing.Size(75, 23);
            this.newDetails.TabIndex = 6;
            this.newDetails.Text = "Cancel";
            this.newDetails.UseVisualStyleBackColor = true;
            this.newDetails.Click += new System.EventHandler(this.newDetails_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student ID";
            // 
            // stdID
            // 
            this.stdID.AutoSize = true;
            this.stdID.Location = new System.Drawing.Point(165, 24);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(13, 13);
            this.stdID.TabIndex = 7;
            this.stdID.Text = "0";
            // 
            // NewStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 240);
            this.Controls.Add(this.stdID);
            this.Controls.Add(this.newDetails);
            this.Controls.Add(this.saveDetails);
            this.Controls.Add(this.stdStatus);
            this.Controls.Add(this.stbDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stdGPA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stdNameValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewStudentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Registration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NewStudentData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdNameValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stdGPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker stbDOB;
        private System.Windows.Forms.CheckBox stdStatus;
        private System.Windows.Forms.Button saveDetails;
        private System.Windows.Forms.Button newDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stdID;
    }
}