using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (plaintextField.Text == "" || rc4kField.Text == "" || vigenerekField.Text == "")
            {
                MessageBox.Show(this, "Please fill all the text boxes",
                                   "Error", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1,
                                   0,
                                   "mspaint.chm");
                
            }
            else
            {
               string encryptedMessage;
               string decryptedMessage;
               int randomValue = new Random().Next(1, plaintextField.Text.Length);
               VRC4 objVRC4 = new VRC4(plaintextField.Text, rc4kField.Text, vigenerekField.Text,randomValue);
               encryptedMessage = objVRC4.encrypt();
               decryptedMessage = objVRC4.desencrypt(encryptedMessage);
               plainTextLField.Text = Convert.ToString(plaintextField.Text.Length);
               randomPField.Text = Convert.ToString(randomValue); 
               encryptedMBox.Text = encryptedMessage;
               decryptMBox.Text = decryptedMessage;

            }
            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
