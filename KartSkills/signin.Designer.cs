﻿namespace KartSkills
{
    partial class signin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Форма авторизации";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(274, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(242, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(336, 231);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(152, 20);
            this.tb_email.TabIndex = 11;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(336, 283);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(152, 20);
            this.tb_password.TabIndex = 12;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "signin";
            this.Text = "v";
            this.Load += new System.EventHandler(this.signin_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.tb_email, 0);
            this.Controls.SetChildIndex(this.tb_password, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
    }
}