using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;


namespace prjVocabulary
{

    public partial class Form1 : Form
    {
        // declaring the variabels
        public string strFileName, strFilePath;
        Random rndRandom = new Random();
        // declaring the dictionary
        Dictionary<string, string> dicVocabulary = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            // Initializing the Press Key Down on textBox 
            txtWord.KeyDown += txtWord_KeyDown;
        }

        private void btnChooseTheVocab_Click(object sender, EventArgs e)
        {
            //  Uploading JSON 
            if (ofdVocabulary.ShowDialog() == DialogResult.OK)
            {
                strFileName = ofdVocabulary.SafeFileName;
                strFilePath = ofdVocabulary.FileName;
                lblChosen.Text = "You have chosen the: " + strFileName;

            }

        }
        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            // Declaring the variabel

            string strInput;

            if (e.KeyCode == Keys.Enter)
            {
                strInput = txtWord.Text;
                e.SuppressKeyPress = true;
                // checks if input is empty   
                if (string.IsNullOrEmpty(strInput))
                {
                    MessageBox.Show("Your input is wrong", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Checks the input with Value 
                    if (strInput == dicVocabulary[lblWord.Text])
                    {
                        lblAnswer.Text = "Your answer was right!";
                        
                        RemoveFromDictionary();
                    }
                    else
                    {
                        lblAnswer.Text = "Your answer wasn't right, try again";
                    }
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string strVocab;
            // Fills in the dictionary with words   
            if (strFileName == null)
            {
                MessageBox.Show("First choose the vocabulary list to work with", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            strVocab = File.ReadAllText(strFilePath);
            dicVocabulary = JsonSerializer.Deserialize<Dictionary<string, string>>(strVocab);
            RandomWord();
        }


        // Picks the random number to choose random word 
        private void RandomWord()
        {
            int intRandomNumber;
            // Checks if you have words to complete 
            if (dicVocabulary.Count == 0)
            {
                MessageBox.Show("You succesfully ended your vocabulary", "The end", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            intRandomNumber = rndRandom.Next(dicVocabulary.Count);
            lblWord.Text = dicVocabulary.ElementAt(intRandomNumber).Key;
        }
        private void RemoveFromDictionary()
        {
            if (chbInfinityMode.Checked)
            {
                RandomWord();
            }
            else if (!chbInfinityMode.Checked)
            {
                dicVocabulary.Remove(lblWord.Text);
                RandomWord();
            }
        }
    }
}
