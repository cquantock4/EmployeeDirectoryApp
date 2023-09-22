namespace WinForms
{
    partial class EmployeeDirectory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            employeeList = new ListBox();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            formHeader.Location = new Point(150, 28);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(618, 112);
            formHeader.TabIndex = 0;
            formHeader.Text = "Employee List";
            // 
            // employeeList
            // 
            employeeList.FormattingEnabled = true;
            employeeList.ItemHeight = 57;
            employeeList.Location = new Point(33, 154);
            employeeList.Name = "employeeList";
            employeeList.Size = new Size(837, 574);
            employeeList.TabIndex = 1;
            // 
            // EmployeeDirectory
            // 
            AutoScaleDimensions = new SizeF(23F, 57F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 841);
            Controls.Add(employeeList);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "EmployeeDirectory";
            Text = "Employee Directory";
            Load += EmployeeDirectory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private ListBox employeeList;
    }
}