namespace StudentRegistration
{
    partial class StudentDetails
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
            this.saveData = new System.Windows.Forms.Button();
            this.NewRgistration = new System.Windows.Forms.Button();
            this.dataToSave = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataToSave)).BeginInit();
            this.SuspendLayout();
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(12, 8);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(75, 23);
            this.saveData.TabIndex = 0;
            this.saveData.Text = "Save";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // NewRgistration
            // 
            this.NewRgistration.Location = new System.Drawing.Point(94, 8);
            this.NewRgistration.Name = "NewRgistration";
            this.NewRgistration.Size = new System.Drawing.Size(75, 23);
            this.NewRgistration.TabIndex = 0;
            this.NewRgistration.Text = "Add New";
            this.NewRgistration.UseVisualStyleBackColor = true;
            this.NewRgistration.Click += new System.EventHandler(this.NewRgistration_Click);
            // 
            // dataToSave
            // 
            this.dataToSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataToSave.Location = new System.Drawing.Point(12, 37);
            this.dataToSave.Name = "dataToSave";
            this.dataToSave.Size = new System.Drawing.Size(526, 430);
            this.dataToSave.TabIndex = 1;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 472);
            this.Controls.Add(this.dataToSave);
            this.Controls.Add(this.NewRgistration);
            this.Controls.Add(this.saveData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataToSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.Button NewRgistration;
        private System.Windows.Forms.DataGridView dataToSave;
    }
}