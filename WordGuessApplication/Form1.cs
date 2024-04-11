using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "creampuff";
        private List<string> wrongGuesses = new List<string>();


        public Form1()
        {
            InitializeComponent();
            label1.Text = "Word to Guess: ";
            InitializeHiddenWord();
        }
        private void InitializeHiddenWord()
        {
            StringBuilder hiddenWord = new StringBuilder();
            hiddenWord.Append(wordToGuess[0]);
            for (int i = 1; i < wordToGuess.Length - 1; i++)
            {
                hiddenWord.Append('?');
            }
            hiddenWord.Append(wordToGuess[wordToGuess.Length - 1]);
            label1.Text += hiddenWord.ToString();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string guessedWord = textBox1.Text.ToLower();

            if (guessedWord == wordToGuess)
            {
                label1.Text = $"Correct! The word was {wordToGuess}.";
            }
            else
            {
                wrongGuesses.Add(guessedWord);
                UpdateWrongGuessesList();
            }
        } 
            private void UpdateWrongGuessesList()
            {
                StringBuilder sb = new StringBuilder();
                foreach (string wrongGuess in wrongGuesses)
                {
                    sb.Append(wrongGuess);
                    sb.Append(Environment.NewLine);
                }
                label3.Text = sb.ToString();
            }
        }
    }
