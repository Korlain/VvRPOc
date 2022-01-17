
namespace BD_cyrs
{
    partial class Mainform
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
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Redactbutton = new System.Windows.Forms.Button();
            this.Statisticabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(466, 186);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(153, 70);
            this.Searchbutton.TabIndex = 0;
            this.Searchbutton.Text = "Поиск данных";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Redactbutton
            // 
            this.Redactbutton.Location = new System.Drawing.Point(202, 188);
            this.Redactbutton.Name = "Redactbutton";
            this.Redactbutton.Size = new System.Drawing.Size(132, 68);
            this.Redactbutton.TabIndex = 1;
            this.Redactbutton.Text = "Работа с данными";
            this.Redactbutton.UseVisualStyleBackColor = true;
            this.Redactbutton.Click += new System.EventHandler(this.Redactbutton_Click);
            // 
            // Statisticabutton
            // 
            this.Statisticabutton.Location = new System.Drawing.Point(340, 186);
            this.Statisticabutton.Name = "Statisticabutton";
            this.Statisticabutton.Size = new System.Drawing.Size(120, 70);
            this.Statisticabutton.TabIndex = 2;
            this.Statisticabutton.Text = "Статистика";
            this.Statisticabutton.UseVisualStyleBackColor = true;
            this.Statisticabutton.Click += new System.EventHandler(this.Statisticabutton_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Statisticabutton);
            this.Controls.Add(this.Redactbutton);
            this.Controls.Add(this.Searchbutton);
            this.Name = "Mainform";
            this.Text = "Главный экран";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Redactbutton;
        private System.Windows.Forms.Button Statisticabutton;
    }
}