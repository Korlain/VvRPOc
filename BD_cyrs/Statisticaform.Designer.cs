
namespace BD_cyrs
{
    partial class Statisticaform
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
            this.Statistica = new System.Windows.Forms.Button();
            this.Years = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dismissal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Statistica
            // 
            this.Statistica.Location = new System.Drawing.Point(330, 160);
            this.Statistica.Name = "Statistica";
            this.Statistica.Size = new System.Drawing.Size(75, 23);
            this.Statistica.TabIndex = 25;
            this.Statistica.Text = "Рассчёт";
            this.Statistica.UseVisualStyleBackColor = true;
            this.Statistica.Click += new System.EventHandler(this.Statistica_Click);
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Location = new System.Drawing.Point(377, 122);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(0, 17);
            this.Years.TabIndex = 26;
            this.Years.Click += new System.EventHandler(this.Years_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Средний возраст";
            // 
            // Dismissal
            // 
            this.Dismissal.Location = new System.Drawing.Point(411, 160);
            this.Dismissal.Name = "Dismissal";
            this.Dismissal.Size = new System.Drawing.Size(115, 23);
            this.Dismissal.TabIndex = 28;
            this.Dismissal.Text = "Увольнение";
            this.Dismissal.UseVisualStyleBackColor = true;
            this.Dismissal.Click += new System.EventHandler(this.Dismissal_Click);
            // 
            // Statisticaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dismissal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Years);
            this.Controls.Add(this.Statistica);
            this.Name = "Statisticaform";
            this.Text = "Statistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Statistica;
        private System.Windows.Forms.Label Years;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dismissal;
    }
}