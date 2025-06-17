namespace cafedemka
{
    partial class DeleteWorkers
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
            this.DelBox = new System.Windows.Forms.ComboBox();
            this.Delbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DelBox
            // 
            this.DelBox.FormattingEnabled = true;
            this.DelBox.Location = new System.Drawing.Point(94, 124);
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(257, 24);
            this.DelBox.TabIndex = 0;
            // 
            // Delbutton
            // 
            this.Delbutton.Location = new System.Drawing.Point(128, 183);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(160, 50);
            this.Delbutton.TabIndex = 1;
            this.Delbutton.Text = "Удалить";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удалить сотрудника из БД:";
            // 
            // DeleteWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.DelBox);
            this.Name = "DeleteWorkers";
            this.Text = "Удалить сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteWorkers_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DelBox;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Label label1;
    }
}