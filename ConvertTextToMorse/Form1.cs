using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTextToMorse
{
    public partial class Form1 : Form
    {
        private static Dictionary<char, string> _morseAlphabetDictionary;

        /// <summary>
        /// Dot = 1 unit
        /// Dash = 3 units
        ///
        /// Between dots and dashes in char = 1 unit
        /// Between Chars = 3 units
        /// Between words = 7 units
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDictionary();
        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            string input = rchtxtxbx_input.Text;

            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower();
            }

            Translate(input);

        }

        private static void InitializeDictionary()
        {
            _morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ". -"},
                                       {'b', "- . . ."},
                                       {'c', "- . - ."},
                                       {'d', "- . ."},
                                       {'e', "."},
                                       {'f', ". . - ."},
                                       {'g', "- - ."},
                                       {'h', ". . . ."},
                                       {'i', ". ."},
                                       {'j', ". - - -"},
                                       {'k', "- . -"},
                                       {'l', ". - . ."},
                                       {'m', "- -"},
                                       {'n', "- ."},
                                       {'o', "- - -"},
                                       {'p', ". - - ."},
                                       {'q', "- - . -"},
                                       {'r', ". - ."},
                                       {'s', ". . ."},
                                       {'t', "-"},
                                       {'u', ". . -"},
                                       {'v', ". . . -"},
                                       {'w', ". - -"},
                                       {'x', "- . . -"},
                                       {'y', "- . - -"},
                                       {'z', "- - . ."},
                                       {'0', "- - - - -"},
                                       {'1', ". - - - -"},
                                       {'2', ". . - - -"},
                                       {'3', ". . . - -"},
                                       {'4', ". . . . -"},
                                       {'5', ". . . . ."},
                                       {'6', "- . . . ."},
                                       {'7', "- - . . ."},
                                       {'8', "- - - . ."},
                                       {'9', "- - - - ."},
                                       {'.', ". . . . ."},
                                       {',', ". - . - . -"},
                                       {';', "- . - . - ."},
                                       {':', "- - - . . ."},
                                       {'?', ". . - - . ."},
                                       {'!', "- - . . - -"},
                                       {'/', "- . . - ."},
                                       {'+', ". - . - ."},
                                       {'-', "- . . . . -"},
                                       {'=', "- . . . -"},
                                       {'(', "- . - - . -"},
                                       {')', "- . - - . -"}
                                   };
        }



        private void Translate(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            rchtxtxbx_output.Clear();


            foreach (char character in input)
            {
                if (_morseAlphabetDictionary.ContainsKey(character))
                {
                    stringBuilder.Append(_morseAlphabetDictionary[character] + "   "); //Add spaces after letter
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("    "); //Between Words
                }
                else
                {
                    stringBuilder.Append("* "); //Not in Morse Table
                }
            }

            rchtxtxbx_output.Text = stringBuilder.ToString();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            string morseCode = rchtxtxbx_output.Text;

            foreach (char morseLetter in morseCode)
            {
                if (morseLetter == '.') { Console.Beep(3000, 100); Thread.Sleep(500); } //Dot
                else if (morseLetter == '-') { Console.Beep(3000, 300); Thread.Sleep(500); } //Dash
                else if (morseLetter == ' ') { Thread.Sleep(500); } //Space no noise
                else { Console.Beep(200, 400); Task.Delay(400).Wait(); } //Error
            }
        }

        private void btn_translate_to_string_Click(object sender, EventArgs e)
        {
            string morseCode = rchtxtxbx_output.Text;

            string[] morseCodeWords = Regex.Split(morseCode, "       ");    //Between Words
            string output = "";

            foreach (string morseWord in morseCodeWords)
            {
                string[] morseLetters = Regex.Split(morseWord, "   ");  //Between Letters in Word
                string outputWord = "";

                foreach (string morseLetter in morseLetters)
                {
                    outputWord += _morseAlphabetDictionary.FirstOrDefault(x => x.Value == morseLetter).Key;
                }

                output += (output == "") ? outputWord : " " + outputWord;
            }

            rchtxtxbx_translated.AppendText(output);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_text_Click(object sender, EventArgs e)
        {
            rchtxtxbx_input.Clear();
        }

        private void btn_clear_morse_Click(object sender, EventArgs e)
        {
            rchtxtxbx_output.Clear();
        }

        private void btn_clear_translated_text_Click(object sender, EventArgs e)
        {
            rchtxtxbx_translated.Clear();
        }

        private void btn_clear_all_Click(object sender, EventArgs e)
        {
            rchtxtxbx_input.Clear();
            rchtxtxbx_output.Clear();
            rchtxtxbx_translated.Clear();
        }
    }
}
