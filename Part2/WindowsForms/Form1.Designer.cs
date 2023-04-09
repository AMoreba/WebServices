
namespace WindowsForms
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
            this.multBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.num1Box = new System.Windows.Forms.TextBox();
            this.num2Box = new System.Windows.Forms.TextBox();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.encBox = new System.Windows.Forms.TextBox();
            this.decBox = new System.Windows.Forms.TextBox();
            this.encTextLabel = new System.Windows.Forms.Label();
            this.decryptTextLabel = new System.Windows.Forms.Label();
            this.encyrptResult = new System.Windows.Forms.Label();
            this.decryptresultLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.browserLabel = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // multBtn
            // 
            this.multBtn.Location = new System.Drawing.Point(597, 344);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(69, 51);
            this.multBtn.TabIndex = 0;
            this.multBtn.Text = "x";
            this.multBtn.UseVisualStyleBackColor = true;
            this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(672, 401);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(69, 51);
            this.minBtn.TabIndex = 1;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(597, 401);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(69, 51);
            this.divBtn.TabIndex = 2;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(672, 344);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(69, 51);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // num1Box
            // 
            this.num1Box.Location = new System.Drawing.Point(466, 344);
            this.num1Box.Name = "num1Box";
            this.num1Box.Size = new System.Drawing.Size(100, 31);
            this.num1Box.TabIndex = 4;
            this.num1Box.TextChanged += new System.EventHandler(this.num1Box_TextChanged);
            // 
            // num2Box
            // 
            this.num2Box.Location = new System.Drawing.Point(466, 381);
            this.num2Box.Name = "num2Box";
            this.num2Box.Size = new System.Drawing.Size(100, 31);
            this.num2Box.TabIndex = 5;
            this.num2Box.TextChanged += new System.EventHandler(this.num2Box_TextChanged);
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(397, 350);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(68, 25);
            this.num1Label.TabIndex = 6;
            this.num1Label.Text = "Num1";
            this.num1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(397, 381);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(68, 25);
            this.num2Label.TabIndex = 7;
            this.num2Label.Text = "Num2";
            this.num2Label.Click += new System.EventHandler(this.num2Label_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(461, 427);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(73, 25);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Result";
            this.resultLabel.Click += new System.EventHandler(this.resultsumLabel_Click);
            // 
            // encBox
            // 
            this.encBox.Location = new System.Drawing.Point(195, 300);
            this.encBox.Name = "encBox";
            this.encBox.Size = new System.Drawing.Size(153, 31);
            this.encBox.TabIndex = 10;
            this.encBox.TextChanged += new System.EventHandler(this.encBox_TextChanged);
            // 
            // decBox
            // 
            this.decBox.Location = new System.Drawing.Point(195, 378);
            this.decBox.Name = "decBox";
            this.decBox.Size = new System.Drawing.Size(153, 31);
            this.decBox.TabIndex = 11;
            this.decBox.TextChanged += new System.EventHandler(this.decBox_TextChanged);
            // 
            // encTextLabel
            // 
            this.encTextLabel.AutoSize = true;
            this.encTextLabel.Location = new System.Drawing.Point(12, 300);
            this.encTextLabel.Name = "encTextLabel";
            this.encTextLabel.Size = new System.Drawing.Size(155, 25);
            this.encTextLabel.TabIndex = 12;
            this.encTextLabel.Text = "Text to encrypt";
            this.encTextLabel.Click += new System.EventHandler(this.encTextLabel_Click);
            // 
            // decryptTextLabel
            // 
            this.decryptTextLabel.AutoSize = true;
            this.decryptTextLabel.Location = new System.Drawing.Point(12, 381);
            this.decryptTextLabel.Name = "decryptTextLabel";
            this.decryptTextLabel.Size = new System.Drawing.Size(155, 25);
            this.decryptTextLabel.TabIndex = 13;
            this.decryptTextLabel.Text = "Text to decrypt";
            this.decryptTextLabel.Click += new System.EventHandler(this.decryptTextLabel_Click);
            // 
            // encyrptResult
            // 
            this.encyrptResult.AutoSize = true;
            this.encyrptResult.Location = new System.Drawing.Point(195, 344);
            this.encyrptResult.Name = "encyrptResult";
            this.encyrptResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.encyrptResult.Size = new System.Drawing.Size(0, 25);
            this.encyrptResult.TabIndex = 17;
            this.encyrptResult.Click += new System.EventHandler(this.encyrptResult_Click);
            // 
            // decryptresultLabel
            // 
            this.decryptresultLabel.AutoSize = true;
            this.decryptresultLabel.Location = new System.Drawing.Point(195, 427);
            this.decryptresultLabel.Name = "decryptresultLabel";
            this.decryptresultLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.decryptresultLabel.Size = new System.Drawing.Size(0, 25);
            this.decryptresultLabel.TabIndex = 18;
            this.decryptresultLabel.Click += new System.EventHandler(this.decryptresultLabel_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(168, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 31);
            this.searchBox.TabIndex = 19;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(17, 337);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(127, 38);
            this.encryptBtn.TabIndex = 20;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(17, 420);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(127, 38);
            this.decryptBtn.TabIndex = 21;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(340, 64);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(130, 34);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // browserLabel
            // 
            this.browserLabel.AutoSize = true;
            this.browserLabel.Location = new System.Drawing.Point(360, -1);
            this.browserLabel.Name = "browserLabel";
            this.browserLabel.Size = new System.Drawing.Size(90, 25);
            this.browserLabel.TabIndex = 23;
            this.browserLabel.Text = "Browser";
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(17, 104);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(781, 179);
            this.browser.TabIndex = 24;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.browserLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.decryptresultLabel);
            this.Controls.Add(this.encyrptResult);
            this.Controls.Add(this.decryptTextLabel);
            this.Controls.Add(this.encTextLabel);
            this.Controls.Add(this.decBox);
            this.Controls.Add(this.encBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.num2Box);
            this.Controls.Add(this.num1Box);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.multBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.TextBox num1Box;
        private System.Windows.Forms.TextBox num2Box;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox encBox;
        private System.Windows.Forms.TextBox decBox;
        private System.Windows.Forms.Label encTextLabel;
        private System.Windows.Forms.Label decryptTextLabel;
        private System.Windows.Forms.Label encyrptResult;
        private System.Windows.Forms.Label decryptresultLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label browserLabel;
        private System.Windows.Forms.WebBrowser browser;
    }
}

