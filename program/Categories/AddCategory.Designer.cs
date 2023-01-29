namespace Categories
{
    partial class AddCategory
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
            this.categoryName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reg_Label
            // 
            this.Reg_Label.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Reg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Reg_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Reg_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reg_Label.Location = new System.Drawing.Point(14, 55);
            this.Reg_Label.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.Reg_Label.Name = "Reg_Label";
            this.Reg_Label.Size = new System.Drawing.Size(473, 79);
            this.Reg_Label.TabIndex = 1;
            this.Reg_Label.Text = "Add New Category";
            this.Reg_Label.UseWaitCursor = true;
            // 
            // categoryName
            // 
            this.categoryName.AllowDrop = true;
            this.categoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryName.Location = new System.Drawing.Point(277, 237);
            this.categoryName.Multiline = true;
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(234, 37);
            this.categoryName.TabIndex = 9;
            // 
            // FName
            // 
            this.FName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FName.Location = new System.Drawing.Point(56, 237);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(203, 37);
            this.FName.TabIndex = 8;
            this.FName.Text = "Category Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(509, 381);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 57);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Categories.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(747, 490);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.Reg_Label);
            this.Name = "AddCategory";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg_Label;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Button btnSubmit;
    }
}

