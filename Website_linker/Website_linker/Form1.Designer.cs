﻿namespace Website_linker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WebOne = new System.Windows.Forms.TextBox();
            this.WebTwo = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Website Two";
            // 
            // WebOne
            // 
            this.WebOne.Location = new System.Drawing.Point(13, 30);
            this.WebOne.Name = "WebOne";
            this.WebOne.Size = new System.Drawing.Size(180, 20);
            this.WebOne.TabIndex = 2;
            this.WebOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WebTwo
            // 
            this.WebTwo.Location = new System.Drawing.Point(264, 29);
            this.WebTwo.Name = "WebTwo";
            this.WebTwo.Size = new System.Drawing.Size(198, 20);
            this.WebTwo.TabIndex = 3;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(183, 56);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 4;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(16, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 194);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Testing box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.WebTwo);
            this.Controls.Add(this.WebOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WebOne;
        private System.Windows.Forms.TextBox WebTwo;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
