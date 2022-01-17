
namespace BD_cyrs
{
    partial class Redactform
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
            this.Companybutton = new System.Windows.Forms.Button();
            this.Personalbutton = new System.Windows.Forms.Button();
            this.Positionbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Companybutton
            // 
            this.Companybutton.AutoSize = true;
            this.Companybutton.Location = new System.Drawing.Point(198, 230);
            this.Companybutton.Name = "Companybutton";
            this.Companybutton.Size = new System.Drawing.Size(150, 100);
            this.Companybutton.TabIndex = 0;
            this.Companybutton.Text = "Отделения";
            this.Companybutton.UseVisualStyleBackColor = true;
            this.Companybutton.Click += new System.EventHandler(this.Companybutton_Click);
            // 
            // Personalbutton
            // 
            this.Personalbutton.AutoSize = true;
            this.Personalbutton.Location = new System.Drawing.Point(354, 230);
            this.Personalbutton.Name = "Personalbutton";
            this.Personalbutton.Size = new System.Drawing.Size(150, 100);
            this.Personalbutton.TabIndex = 1;
            this.Personalbutton.Text = "Персонал";
            this.Personalbutton.UseVisualStyleBackColor = true;
            this.Personalbutton.Click += new System.EventHandler(this.Personalbutton_Click);
            // 
            // Positionbutton
            // 
            this.Positionbutton.AutoSize = true;
            this.Positionbutton.Location = new System.Drawing.Point(510, 230);
            this.Positionbutton.Name = "Positionbutton";
            this.Positionbutton.Size = new System.Drawing.Size(150, 100);
            this.Positionbutton.TabIndex = 2;
            this.Positionbutton.Text = "Должности";
            this.Positionbutton.UseVisualStyleBackColor = true;
            this.Positionbutton.Click += new System.EventHandler(this.Positionbutton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Companybutton);
            this.panel1.Controls.Add(this.Positionbutton);
            this.panel1.Controls.Add(this.Personalbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 583);
            this.panel1.TabIndex = 3;
            // 
            // Redactform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(872, 583);
            this.Controls.Add(this.panel1);
            this.Name = "Redactform";
            this.Text = "Redactform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Companybutton;
        private System.Windows.Forms.Button Personalbutton;
        private System.Windows.Forms.Button Positionbutton;
        private System.Windows.Forms.Panel panel1;
    }
}