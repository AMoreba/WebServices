///////////////////////////////////////////////////////
///Name: Abdulelah Bin Morebah
///Class: CSE 445 MW
///Email: abinmore@asu.edu
///Description: This class contain question 5 from 
///         Assignment 1 and the first two parts of 
///         Assingment 2 (calculator and encryption decryption)
///////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calculator:

        //the sum function
        private void plusBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (Convert.ToInt32(num1Box.Text)
                + Convert.ToInt32(num2Box.Text)).ToString();
        }

        //the multiplication function
        private void multBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (Convert.ToInt32(num1Box.Text)
                * Convert.ToInt32(num2Box.Text)).ToString();
        }

        //the subtraction function
        private void minBtn_Click(object sender, EventArgs e)
        {
            int t = Int32.Parse(num1Box.Text);
            resultLabel.Text = (Convert.ToInt32(num1Box.Text)
                - Convert.ToInt32(num2Box.Text)).ToString();
        }

        //the division function
        private void divBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = (Convert.ToInt32(num1Box.Text)
                / Convert.ToInt32(num2Box.Text)).ToString();
        }

        //the button for the browser search
        private void searchBtn_Click(object sender, EventArgs e)
        {
            browser.Navigate(searchBox.Text);
        }

        //the decryption function
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionDecryptionService.ServiceClient EncryptionDecryptionService = new EncryptionDecryptionService.ServiceClient();
            decryptresultLabel.Text = EncryptionDecryptionService.Decrypt(decBox.Text);
        }

        //the encryption function
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            EncryptionDecryptionService.ServiceClient EncryptionDecryptionService = new EncryptionDecryptionService.ServiceClient();
            encyrptResult.Text = EncryptionDecryptionService.Encrypt(encBox.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void encBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void encTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void encyrptResult_Click(object sender, EventArgs e)
        {

        }

        private void decBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decryptTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void decryptresultLabel_Click(object sender, EventArgs e)
        {

        }

        private void decLabel_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void resultsumLabel_Click(object sender, EventArgs e)
        {

        }

        private void num1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void num2Label_Click(object sender, EventArgs e)
        {

        }
    }
}
