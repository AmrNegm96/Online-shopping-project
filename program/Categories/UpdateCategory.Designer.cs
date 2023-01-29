namespace Categories
{
    partial class UpdateCategory
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.ctg_old = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.ctg_new = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg_Label
            // 
            this.Reg_Label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Reg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Reg_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Reg_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reg_Label.Location = new System.Drawing.Point(10, 38);
            this.Reg_Label.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.Reg_Label.Name = "Reg_Label";
            this.Reg_Label.Size = new System.Drawing.Size(409, 66);
            this.Reg_Label.TabIndex = 1;
            this.Reg_Label.Text = "Update Category";
            this.Reg_Label.UseWaitCursor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(522, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 57);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ctg_old
            // 
            this.ctg_old.AllowDrop = true;
            this.ctg_old.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctg_old.Location = new System.Drawing.Point(267, 221);
            this.ctg_old.Multiline = true;
            this.ctg_old.Name = "ctg_old";
            this.ctg_old.Size = new System.Drawing.Size(234, 37);
            this.ctg_old.TabIndex = 16;
            this.ctg_old.TextChanged += new System.EventHandler(this.fN_text_TextChanged);
            // 
            // FName
            // 
            this.FName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FName.Location = new System.Drawing.Point(14, 221);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(203, 37);
            this.FName.TabIndex = 15;
            this.FName.Text = "Category Name";
            this.FName.Click += new System.EventHandler(this.FName_Click);
            // 
            // ctg_new
            // 
            this.ctg_new.AllowDrop = true;
            this.ctg_new.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctg_new.Location = new System.Drawing.Point(267, 299);
            this.ctg_new.Multiline = true;
            this.ctg_new.Name = "ctg_new";
            this.ctg_new.Size = new System.Drawing.Size(234, 37);
            this.ctg_new.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "New Category Name";
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Categories.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(747, 490);
            this.Controls.Add(this.ctg_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ctg_old);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Reg_Label);
            this.Name = "UpdateCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg_Label;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox ctg_old;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox ctg_new;
        private System.Windows.Forms.Label label1;
    }
}