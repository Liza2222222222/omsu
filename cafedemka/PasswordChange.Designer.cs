namespace cafedemka
{
    partial class PassChange
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warningLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordChange = new System.Windows.Forms.Button();
            this.newBox = new System.Windows.Forms.TextBox();
            this.appBox = new System.Windows.Forms.TextBox();
            this.oldBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warningLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.passwordChange);
            this.groupBox1.Controls.Add(this.newBox);
            this.groupBox1.Controls.Add(this.appBox);
            this.groupBox1.Controls.Add(this.oldBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Измените выданный пароль";
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Location = new System.Drawing.Point(97, 319);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(0, 16);
            this.warningLbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Подтвердите новый пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите новый пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите старый пароль:";
            // 
            // passwordChange
            // 
            this.passwordChange.Location = new System.Drawing.Point(116, 389);
            this.passwordChange.Name = "passwordChange";
            this.passwordChange.Size = new System.Drawing.Size(141, 38);
            this.passwordChange.TabIndex = 4;
            this.passwordChange.Text = "Изменить";
            this.passwordChange.UseVisualStyleBackColor = true;
            this.passwordChange.Click += new System.EventHandler(this.passwordChange_Click);
            // 
            // newBox
            // 
            this.newBox.Location = new System.Drawing.Point(92, 198);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(183, 22);
            this.newBox.TabIndex = 3;
            this.newBox.TextChanged += new System.EventHandler(this.newBox_TextChanged);
            // 
            // appBox
            // 
            this.appBox.Location = new System.Drawing.Point(92, 288);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(183, 22);
            this.appBox.TabIndex = 2;
            this.appBox.TextChanged += new System.EventHandler(this.appBox_TextChanged);
            // 
            // oldBox
            // 
            this.oldBox.Location = new System.Drawing.Point(92, 101);
            this.oldBox.Name = "oldBox";
            this.oldBox.Size = new System.Drawing.Size(183, 22);
            this.oldBox.TabIndex = 0;
            this.oldBox.TextChanged += new System.EventHandler(this.oldBox_TextChanged);
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 567);
            this.Controls.Add(this.groupBox1);
            this.Name = "PassChange";
            this.Text = "Смена пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassChange_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passwordChange;
        private System.Windows.Forms.TextBox newBox;
        private System.Windows.Forms.TextBox appBox;
        private System.Windows.Forms.TextBox oldBox;
        private System.Windows.Forms.Label warningLbl;
    }
}