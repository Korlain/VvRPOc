
namespace BD_cyrs
{
    partial class PersonalForm
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
            this.Delete_Personal = new System.Windows.Forms.Button();
            this.Update_Personal = new System.Windows.Forms.Button();
            this.Create_Personal = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.TextBox();
            this.Data_birth = new System.Windows.Forms.DateTimePicker();
            this.SNILS = new System.Windows.Forms.MaskedTextBox();
            this.Departament = new System.Windows.Forms.ComboBox();
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.PersonalGrid = new System.Windows.Forms.DataGridView();
            this.personalBox = new System.Windows.Forms.ComboBox();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.Dismissal = new System.Windows.Forms.CheckBox();
            this.Wage_rate = new System.Windows.Forms.MaskedTextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Personal
            // 
            this.Delete_Personal.Location = new System.Drawing.Point(251, 178);
            this.Delete_Personal.Name = "Delete_Personal";
            this.Delete_Personal.Size = new System.Drawing.Size(112, 29);
            this.Delete_Personal.TabIndex = 13;
            this.Delete_Personal.Text = "Удалить";
            this.Delete_Personal.UseVisualStyleBackColor = true;
            this.Delete_Personal.Click += new System.EventHandler(this.Delete_Personal_Click);
            // 
            // Update_Personal
            // 
            this.Update_Personal.Location = new System.Drawing.Point(133, 178);
            this.Update_Personal.Name = "Update_Personal";
            this.Update_Personal.Size = new System.Drawing.Size(112, 29);
            this.Update_Personal.TabIndex = 12;
            this.Update_Personal.Text = "Обновить";
            this.Update_Personal.UseVisualStyleBackColor = true;
            this.Update_Personal.Click += new System.EventHandler(this.Update_Personal_Click);
            // 
            // Create_Personal
            // 
            this.Create_Personal.Location = new System.Drawing.Point(15, 178);
            this.Create_Personal.Name = "Create_Personal";
            this.Create_Personal.Size = new System.Drawing.Size(112, 29);
            this.Create_Personal.TabIndex = 10;
            this.Create_Personal.Text = "Создать";
            this.Create_Personal.UseVisualStyleBackColor = true;
            this.Create_Personal.Click += new System.EventHandler(this.Create_Personal_Click);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(14, 7);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(348, 22);
            this.FIO.TabIndex = 11;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // Data_birth
            // 
            this.Data_birth.Location = new System.Drawing.Point(162, 60);
            this.Data_birth.Name = "Data_birth";
            this.Data_birth.Size = new System.Drawing.Size(200, 22);
            this.Data_birth.TabIndex = 14;
            this.Data_birth.ValueChanged += new System.EventHandler(this.Data_birth_ValueChanged);
            // 
            // SNILS
            // 
            this.SNILS.Location = new System.Drawing.Point(14, 60);
            this.SNILS.Mask = "000-000-000 00";
            this.SNILS.Name = "SNILS";
            this.SNILS.Size = new System.Drawing.Size(142, 22);
            this.SNILS.TabIndex = 15;
            this.SNILS.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SNILS_MaskInputRejected);
            // 
            // Departament
            // 
            this.Departament.FormattingEnabled = true;
            this.Departament.Location = new System.Drawing.Point(15, 118);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(347, 24);
            this.Departament.TabIndex = 16;
            this.Departament.SelectedIndexChanged += new System.EventHandler(this.Departament_SelectedIndexChanged);
            // 
            // CompanyBox
            // 
            this.CompanyBox.Enabled = false;
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(13, 87);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(349, 24);
            this.CompanyBox.TabIndex = 17;
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.CompanyBox_SelectedIndexChanged);
            // 
            // PersonalGrid
            // 
            this.PersonalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalGrid.Location = new System.Drawing.Point(15, 213);
            this.PersonalGrid.Name = "PersonalGrid";
            this.PersonalGrid.ReadOnly = true;
            this.PersonalGrid.RowHeadersWidth = 51;
            this.PersonalGrid.RowTemplate.Height = 24;
            this.PersonalGrid.Size = new System.Drawing.Size(776, 224);
            this.PersonalGrid.TabIndex = 18;
            this.PersonalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalGrid_CellContentClick);
            // 
            // personalBox
            // 
            this.personalBox.FormattingEnabled = true;
            this.personalBox.Location = new System.Drawing.Point(15, 148);
            this.personalBox.Name = "personalBox";
            this.personalBox.Size = new System.Drawing.Size(347, 24);
            this.personalBox.TabIndex = 19;
            this.personalBox.SelectedIndexChanged += new System.EventHandler(this.personalBox_SelectedIndexChanged_1);
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(575, 7);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(200, 22);
            this.DateStart.TabIndex = 20;
            this.DateStart.ValueChanged += new System.EventHandler(this.DateStart_ValueChanged);
            // 
            // DateEnd
            // 
            this.DateEnd.Enabled = false;
            this.DateEnd.Location = new System.Drawing.Point(575, 35);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(200, 22);
            this.DateEnd.TabIndex = 21;
            // 
            // Dismissal
            // 
            this.Dismissal.AutoSize = true;
            this.Dismissal.Location = new System.Drawing.Point(460, 34);
            this.Dismissal.Name = "Dismissal";
            this.Dismissal.Size = new System.Drawing.Size(109, 21);
            this.Dismissal.TabIndex = 22;
            this.Dismissal.Text = "Увольнение";
            this.Dismissal.UseVisualStyleBackColor = true;
            this.Dismissal.CheckedChanged += new System.EventHandler(this.Dismissal_CheckedChanged);
            // 
            // Wage_rate
            // 
            this.Wage_rate.Location = new System.Drawing.Point(368, 148);
            this.Wage_rate.Mask = "0.0";
            this.Wage_rate.Name = "Wage_rate";
            this.Wage_rate.Size = new System.Drawing.Size(24, 22);
            this.Wage_rate.TabIndex = 23;
            this.Wage_rate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Wage_rate_MaskInputRejected);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(14, 32);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(348, 22);
            this.Mail.TabIndex = 24;
            this.Mail.TextChanged += new System.EventHandler(this.Mail_TextChanged);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Wage_rate);
            this.Controls.Add(this.Dismissal);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.personalBox);
            this.Controls.Add(this.PersonalGrid);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.SNILS);
            this.Controls.Add(this.Data_birth);
            this.Controls.Add(this.Delete_Personal);
            this.Controls.Add(this.Update_Personal);
            this.Controls.Add(this.Create_Personal);
            this.Controls.Add(this.FIO);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_Personal;
        private System.Windows.Forms.Button Update_Personal;
        private System.Windows.Forms.Button Create_Personal;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.DateTimePicker Data_birth;
        private System.Windows.Forms.MaskedTextBox SNILS;
        private System.Windows.Forms.ComboBox Departament;
        private System.Windows.Forms.ComboBox CompanyBox;
        private System.Windows.Forms.DataGridView PersonalGrid;
        private System.Windows.Forms.ComboBox personalBox;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.CheckBox Dismissal;
        private System.Windows.Forms.MaskedTextBox Wage_rate;
        private System.Windows.Forms.TextBox Mail;
    }
}