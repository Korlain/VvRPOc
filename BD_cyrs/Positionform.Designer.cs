
namespace BD_cyrs
{
    partial class Positionform
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
            this.Create_Position = new System.Windows.Forms.Button();
            this.Name_Position = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete_Position = new System.Windows.Forms.Button();
            this.Update_Position = new System.Windows.Forms.Button();
            this.PositionBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create_Position
            // 
            this.Create_Position.Location = new System.Drawing.Point(542, 42);
            this.Create_Position.Name = "Create_Position";
            this.Create_Position.Size = new System.Drawing.Size(112, 23);
            this.Create_Position.TabIndex = 0;
            this.Create_Position.Text = "Создать";
            this.Create_Position.UseVisualStyleBackColor = true;
            this.Create_Position.Click += new System.EventHandler(this.Create_Position_Click);
            // 
            // Name_Position
            // 
            this.Name_Position.Location = new System.Drawing.Point(542, 12);
            this.Name_Position.Multiline = true;
            this.Name_Position.Name = "Name_Position";
            this.Name_Position.Size = new System.Drawing.Size(348, 24);
            this.Name_Position.TabIndex = 1;
            this.Name_Position.TextChanged += new System.EventHandler(this.Name_Position_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PositionBox);
            this.panel1.Controls.Add(this.Delete_Position);
            this.panel1.Controls.Add(this.Update_Position);
            this.panel1.Controls.Add(this.Create_Position);
            this.panel1.Controls.Add(this.Name_Position);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 465);
            this.panel1.TabIndex = 2;
            // 
            // Delete_Position
            // 
            this.Delete_Position.Location = new System.Drawing.Point(778, 42);
            this.Delete_Position.Name = "Delete_Position";
            this.Delete_Position.Size = new System.Drawing.Size(112, 23);
            this.Delete_Position.TabIndex = 4;
            this.Delete_Position.Text = "Удалить";
            this.Delete_Position.UseVisualStyleBackColor = true;
            this.Delete_Position.Click += new System.EventHandler(this.Delete_Position_Click);
            // 
            // Update_Position
            // 
            this.Update_Position.Location = new System.Drawing.Point(660, 42);
            this.Update_Position.Name = "Update_Position";
            this.Update_Position.Size = new System.Drawing.Size(112, 23);
            this.Update_Position.TabIndex = 3;
            this.Update_Position.Text = "Обновить";
            this.Update_Position.UseVisualStyleBackColor = true;
            this.Update_Position.Click += new System.EventHandler(this.Update_Position_Click);
            // 
            // PositionBox
            // 
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.ItemHeight = 16;
            this.PositionBox.Location = new System.Drawing.Point(6, 3);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(310, 452);
            this.PositionBox.TabIndex = 2;
            this.PositionBox.SelectedIndexChanged += new System.EventHandler(this.PositionBox_SelectedIndexChanged);
            // 
            // Positionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 465);
            this.Controls.Add(this.panel1);
            this.Name = "Positionform";
            this.Text = "Редактирование должностей";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_Position;
        private System.Windows.Forms.TextBox Name_Position;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox PositionBox;
        private System.Windows.Forms.Button Delete_Position;
        private System.Windows.Forms.Button Update_Position;
    }
}