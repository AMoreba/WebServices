﻿
namespace WindowsFormsApp
{
    partial class form
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
            this.sortBtn = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.sortResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(319, 172);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(122, 48);
            this.sortBtn.TabIndex = 0;
            this.sortBtn.Text = "sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(319, 109);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(137, 31);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // sortResult
            // 
            this.sortResult.Location = new System.Drawing.Point(319, 261);
            this.sortResult.Name = "sortResult";
            this.sortResult.ReadOnly = true;
            this.sortResult.Size = new System.Drawing.Size(137, 31);
            this.sortResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(212, 109);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 25);
            this.label.TabIndex = 4;
            this.label.Text = "Enter";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortResult);
            this.Controls.Add(this.input);
            this.Controls.Add(this.sortBtn);
            this.Name = "form";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox sortResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}