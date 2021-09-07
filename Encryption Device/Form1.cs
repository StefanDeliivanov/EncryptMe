namespace Encryption_Device
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        bool isItForEncryption = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = inputLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Encrypting each odd  letter + (3 + letter position in the current word)
            // each even letter - (3 + letter position in the current word)

            string input = this.inputText.Text.ToString();
            string[] words = input.Split();
            string password = "";
            if (isItForEncryption)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i];
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char currentLetter = currentWord[j];
                        if (j % 2 == 0)
                        {
                            char cryptedLetter = Convert.ToChar((Convert.ToInt32(currentLetter) + (3 + j)));
                            password += cryptedLetter;
                        }
                        else if (j % 2 == 1)
                        {
                            char cryptedLetter = Convert.ToChar((Convert.ToInt32(currentLetter) - (3 + j)));
                            password += cryptedLetter;
                        }

                    }
                    password += " ";
                }
            }
            else if (isItForEncryption == false)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i];
                    for (int j = 0; j < currentWord.Length; j++)
                    {
                        char currentLetter = currentWord[j];
                        if (j % 2 == 0)
                        {
                            char cryptedLetter = Convert.ToChar((Convert.ToInt32(currentLetter) - (3 + j)));
                            password += cryptedLetter;
                        }
                        else if (j % 2 == 1)
                        {
                            char cryptedLetter = Convert.ToChar((Convert.ToInt32(currentLetter) + (3 + j)));
                            password += cryptedLetter;
                        }

                    }
                    password += " ";
                }
            }
            
            this.outputText.Text = password;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isItForEncryption = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isItForEncryption = false;
        }
    }
}