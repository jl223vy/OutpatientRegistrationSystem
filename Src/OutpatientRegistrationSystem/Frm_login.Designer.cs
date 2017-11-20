﻿namespace OutpatientRegistrationSystem
{
    partial class Frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            this.texbox_psw = new System.Windows.Forms.TextBox();
            this.texbox_userName = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lab_psw = new System.Windows.Forms.Label();
            this.lab_userName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // texbox_psw
            // 
            this.texbox_psw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbox_psw.Location = new System.Drawing.Point(228, 339);
            this.texbox_psw.Name = "texbox_psw";
            this.texbox_psw.PasswordChar = '*';
            this.texbox_psw.Size = new System.Drawing.Size(143, 21);
            this.texbox_psw.TabIndex = 20;
            // 
            // texbox_userName
            // 
            this.texbox_userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texbox_userName.Location = new System.Drawing.Point(228, 293);
            this.texbox_userName.Name = "texbox_userName";
            this.texbox_userName.Size = new System.Drawing.Size(143, 21);
            this.texbox_userName.TabIndex = 19;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(155, 386);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 27);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(284, 386);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(87, 27);
            this.btn_logIn.TabIndex = 17;
            this.btn_logIn.Text = "登录";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // lab_psw
            // 
            this.lab_psw.AutoSize = true;
            this.lab_psw.Location = new System.Drawing.Point(153, 343);
            this.lab_psw.Name = "lab_psw";
            this.lab_psw.Size = new System.Drawing.Size(65, 12);
            this.lab_psw.TabIndex = 16;
            this.lab_psw.Text = "用户密码：";
            // 
            // lab_userName
            // 
            this.lab_userName.AutoSize = true;
            this.lab_userName.Location = new System.Drawing.Point(153, 295);
            this.lab_userName.Name = "lab_userName";
            this.lab_userName.Size = new System.Drawing.Size(65, 12);
            this.lab_userName.TabIndex = 15;
            this.lab_userName.Text = "用户工号：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 265);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_login
            // 
            this.AcceptButton = this.btn_logIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(539, 438);
            this.Controls.Add(this.texbox_psw);
            this.Controls.Add(this.texbox_userName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.lab_psw);
            this.Controls.Add(this.lab_userName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_login";
            this.Text = "门诊预约挂号系统 -【用户登录】";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texbox_psw;
        private System.Windows.Forms.TextBox texbox_userName;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Label lab_psw;
        private System.Windows.Forms.Label lab_userName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}