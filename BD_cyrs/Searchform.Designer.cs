
namespace BD_cyrs
{
    partial class Searchform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.Personal = new System.Windows.Forms.DataGridView();
            this.Departament = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Personal)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyBox
            // 
            this.CompanyBox.Enabled = false;
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(163, 12);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(633, 24);
            this.CompanyBox.TabIndex = 3;
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.CompanyBox_SelectedIndexChanged);
            // 
            // Personal
            // 
            this.Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Personal.Location = new System.Drawing.Point(12, 197);
            this.Personal.Name = "Personal";
            this.Personal.ReadOnly = true;
            this.Personal.RowHeadersWidth = 51;
            this.Personal.RowTemplate.Height = 24;
            this.Personal.Size = new System.Drawing.Size(784, 242);
            this.Personal.TabIndex = 5;
            this.Personal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Personal_CellContentClick);
            // 
            // Departament
            // 
            this.Departament.FormattingEnabled = true;
            this.Departament.Location = new System.Drawing.Point(163, 54);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(633, 24);
            this.Departament.TabIndex = 7;
            this.Departament.SelectedIndexChanged += new System.EventHandler(this.Departament_SelectedIndexChanged);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(603, 150);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(193, 41);
            this.Search.TabIndex = 8;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Отделение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Отдел";
            // 
            // Searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.Personal);
            this.Controls.Add(this.CompanyBox);
            this.Name = "Searchform";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.Personal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CompanyBox;
        private System.Windows.Forms.DataGridView Personal;
        private System.Windows.Forms.ComboBox Departament;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

