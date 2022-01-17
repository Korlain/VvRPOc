
namespace BD_cyrs
{
    partial class CompanyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete_Company = new System.Windows.Forms.Button();
            this.Update_Company = new System.Windows.Forms.Button();
            this.CompanyBox = new System.Windows.Forms.ListBox();
            this.Create_Company = new System.Windows.Forms.Button();
            this.Name_Company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Delete_Department = new System.Windows.Forms.Button();
            this.Update_Department = new System.Windows.Forms.Button();
            this.Create_Department = new System.Windows.Forms.Button();
            this.Name_department = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DepartmentBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Delete_Department);
            this.panel1.Controls.Add(this.Update_Department);
            this.panel1.Controls.Add(this.Create_Department);
            this.panel1.Controls.Add(this.Name_department);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Delete_Company);
            this.panel1.Controls.Add(this.Update_Company);
            this.panel1.Controls.Add(this.CompanyBox);
            this.panel1.Controls.Add(this.Create_Company);
            this.panel1.Controls.Add(this.Name_Company);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 680);
            this.panel1.TabIndex = 0;
            // 
            // Delete_Company
            // 
            this.Delete_Company.Location = new System.Drawing.Point(905, 57);
            this.Delete_Company.Name = "Delete_Company";
            this.Delete_Company.Size = new System.Drawing.Size(112, 29);
            this.Delete_Company.TabIndex = 9;
            this.Delete_Company.Text = "Удалить";
            this.Delete_Company.UseVisualStyleBackColor = true;
            this.Delete_Company.Click += new System.EventHandler(this.Delete_Company_Click);
            // 
            // Update_Company
            // 
            this.Update_Company.Location = new System.Drawing.Point(787, 57);
            this.Update_Company.Name = "Update_Company";
            this.Update_Company.Size = new System.Drawing.Size(112, 29);
            this.Update_Company.TabIndex = 8;
            this.Update_Company.Text = "Обновить";
            this.Update_Company.UseVisualStyleBackColor = true;
            this.Update_Company.Click += new System.EventHandler(this.Update_Company_Click);
            // 
            // CompanyBox
            // 
            this.CompanyBox.Enabled = false;
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.ItemHeight = 16;
            this.CompanyBox.Location = new System.Drawing.Point(0, 25);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(647, 164);
            this.CompanyBox.TabIndex = 7;
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.CompanyBox_SelectedIndexChanged);
            // 
            // Create_Company
            // 
            this.Create_Company.Location = new System.Drawing.Point(669, 57);
            this.Create_Company.Name = "Create_Company";
            this.Create_Company.Size = new System.Drawing.Size(112, 29);
            this.Create_Company.TabIndex = 5;
            this.Create_Company.Text = "Создать";
            this.Create_Company.UseVisualStyleBackColor = true;
            this.Create_Company.Click += new System.EventHandler(this.Create_Company_Click);
            // 
            // Name_Company
            // 
            this.Name_Company.Location = new System.Drawing.Point(669, 27);
            this.Name_Company.Multiline = true;
            this.Name_Company.Name = "Name_Company";
            this.Name_Company.Size = new System.Drawing.Size(348, 30);
            this.Name_Company.TabIndex = 6;
            this.Name_Company.TextChanged += new System.EventHandler(this.Name_Company_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Отделения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Отделы";
            // 
            // Delete_Department
            // 
            this.Delete_Department.Location = new System.Drawing.Point(905, 247);
            this.Delete_Department.Name = "Delete_Department";
            this.Delete_Department.Size = new System.Drawing.Size(112, 23);
            this.Delete_Department.TabIndex = 14;
            this.Delete_Department.Text = "Удалить";
            this.Delete_Department.UseVisualStyleBackColor = true;
            this.Delete_Department.Click += new System.EventHandler(this.Delete_Department_Click);
            // 
            // Update_Department
            // 
            this.Update_Department.Location = new System.Drawing.Point(787, 247);
            this.Update_Department.Name = "Update_Department";
            this.Update_Department.Size = new System.Drawing.Size(112, 23);
            this.Update_Department.TabIndex = 13;
            this.Update_Department.Text = "Обновить";
            this.Update_Department.UseVisualStyleBackColor = true;
            this.Update_Department.Click += new System.EventHandler(this.Update_Department_Click);
            // 
            // Create_Department
            // 
            this.Create_Department.Location = new System.Drawing.Point(669, 247);
            this.Create_Department.Name = "Create_Department";
            this.Create_Department.Size = new System.Drawing.Size(112, 23);
            this.Create_Department.TabIndex = 11;
            this.Create_Department.Text = "Создать";
            this.Create_Department.UseVisualStyleBackColor = true;
            this.Create_Department.Click += new System.EventHandler(this.Create_Department_Click);
            // 
            // Name_department
            // 
            this.Name_department.Location = new System.Drawing.Point(669, 217);
            this.Name_department.Multiline = true;
            this.Name_department.Name = "Name_department";
            this.Name_department.Size = new System.Drawing.Size(348, 24);
            this.Name_department.TabIndex = 12;
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Enabled = false;
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.ItemHeight = 16;
            this.DepartmentBox.Location = new System.Drawing.Point(0, 217);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(647, 180);
            this.DepartmentBox.TabIndex = 16;
            this.DepartmentBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentBox_SelectedIndexChanged);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 680);
            this.Controls.Add(this.panel1);
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete_Company;
        private System.Windows.Forms.Button Update_Company;
        private System.Windows.Forms.ListBox CompanyBox;
        private System.Windows.Forms.Button Create_Company;
        private System.Windows.Forms.TextBox Name_Company;
        private System.Windows.Forms.ListBox DepartmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Delete_Department;
        private System.Windows.Forms.Button Update_Department;
        private System.Windows.Forms.Button Create_Department;
        private System.Windows.Forms.TextBox Name_department;
        private System.Windows.Forms.Label label1;
    }
}