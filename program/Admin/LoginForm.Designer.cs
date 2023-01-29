namespace Admin
{
    partial class LoginForm
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
            this.Reg_Label = new System.Windows.Forms.Label();
            this.PassText = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reg_Label
            // 
            this.Reg_Label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Reg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Reg_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Reg_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reg_Label.Location = new System.Drawing.Point(146, 38);
            this.Reg_Label.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.Reg_Label.Name = "Reg_Label";
            this.Reg_Label.Size = new System.Drawing.Size(176, 79);
            this.Reg_Label.TabIndex = 1;
            this.Reg_Label.Text = "Login";
            this.Reg_Label.UseWaitCursor = true;
            this.Reg_Label.Click += new System.EventHandler(this.Reg_Label_Click);
            // 
            // PassText
            // 
            this.PassText.AllowDrop = true;
            this.PassText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassText.Location = new System.Drawing.Point(199, 276);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(234, 37);
            this.PassText.TabIndex = 14;
            // 
            // email_text
            // 
            this.email_text.AllowDrop = true;
            this.email_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_text.Location = new System.Drawing.Point(199, 197);
            this.email_text.Multiline = true;
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(234, 37);
            this.email_text.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Password.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F);
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Password.Location = new System.Drawing.Point(64, 276);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(118, 37);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Email.Location = new System.Drawing.Point(65, 197);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(118, 37);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.FName_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(502, 364);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 57);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Submit";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Admin.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(747, 490);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Reg_Label);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg_Label;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button btnLogin;
    }
}

