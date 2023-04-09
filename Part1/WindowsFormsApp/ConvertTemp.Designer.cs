
namespace WindowsFormsApp
{
    partial class ConvertTemp
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
            this.ftoc = new System.Windows.Forms.Button();
            this.ctof = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortResult = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ftoc
            // 
            this.ftoc.Location = new System.Drawing.Point(306, 192);
            this.ftoc.Name = "ftoc";
            this.ftoc.Size = new System.Drawing.Size(151, 43);
            this.ftoc.TabIndex = 0;
            this.ftoc.Text = "Convert to C";
            this.ftoc.UseVisualStyleBackColor = true;
            this.ftoc.Click += new System.EventHandler(this.ftoc_Click);
            // 
            // ctof
            // 
            this.ctof.Location = new System.Drawing.Point(101, 192);
            this.ctof.Name = "ctof";
            this.ctof.Size = new System.Drawing.Size(141, 43);
            this.ctof.TabIndex = 1;
            this.ctof.Text = "Convert to F";
            this.ctof.UseVisualStyleBackColor = true;
            this.ctof.Click += new System.EventHandler(this.ctof_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(218, 119);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 31);
            this.textBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(525, 122);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 25);
            this.label.TabIndex = 10;
            this.label.Text = "Enter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // sortResult
            // 
            this.sortResult.Location = new System.Drawing.Point(632, 274);
            this.sortResult.Name = "sortResult";
            this.sortResult.ReadOnly = true;
            this.sortResult.Size = new System.Drawing.Size(137, 31);
            this.sortResult.TabIndex = 8;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(632, 122);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(137, 31);
            this.input.TabIndex = 7;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(632, 185);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(122, 48);
            this.sortBtn.TabIndex = 6;
            this.sortBtn.Text = "sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // ConvertTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortResult);
            this.Controls.Add(this.input);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ctof);
            this.Controls.Add(this.ftoc);
            this.Name = "ConvertTemp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ftoc;
        private System.Windows.Forms.Button ctof;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sortResult;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button sortBtn;
    }
}

