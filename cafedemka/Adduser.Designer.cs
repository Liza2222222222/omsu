namespace cafedemka
{
    partial class AddUser
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
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.Button();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.FullnameBox = new System.Windows.Forms.TextBox();
            this.HireBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddBox);
            this.groupBox1.Controls.Add(this.RoleBox);
            this.groupBox1.Controls.Add(this.PassBox);
            this.groupBox1.Controls.Add(this.FullnameBox);
            this.groupBox1.Controls.Add(this.HireBox);
            this.groupBox1.Controls.Add(this.LogBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить сотрудника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер телефона:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(63, 260);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(210, 22);
            this.PhoneBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Должность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата найма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин:";
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(90, 421);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(161, 61);
            this.AddBox.TabIndex = 5;
            this.AddBox.Text = "Добавить";
            this.AddBox.UseVisualStyleBackColor = true;
            this.AddBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoleBox
            // 
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(63, 375);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(210, 24);
            this.RoleBox.TabIndex = 4;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(63, 137);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(210, 22);
            this.PassBox.TabIndex = 3;
            // 
            // FullnameBox
            // 
            this.FullnameBox.Location = new System.Drawing.Point(63, 201);
            this.FullnameBox.Name = "FullnameBox";
            this.FullnameBox.Size = new System.Drawing.Size(210, 22);
            this.FullnameBox.TabIndex = 2;
            // 
            // HireBox
            // 
            this.HireBox.Location = new System.Drawing.Point(63, 320);
            this.HireBox.Name = "HireBox";
            this.HireBox.Size = new System.Drawing.Size(210, 22);
            this.HireBox.TabIndex = 1;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(63, 74);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(210, 22);
            this.LogBox.TabIndex = 0;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 560);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUser";
            this.Text = "Добавить сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBox;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox FullnameBox;
        private System.Windows.Forms.TextBox HireBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneBox;
    }
}