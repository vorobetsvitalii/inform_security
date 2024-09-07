using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private const string UkrainianAlphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
        private const string EnglishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,.!? ";

        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt(string text, int shift, string alphabet)
        {
            var encryptedText = new StringBuilder();
            foreach (var c in text)
            {
                int index = alphabet.IndexOf(c);
                if (index == -1)
                {
                    encryptedText.Append(c);
                }
                else
                {
                    int newIndex = (index + shift) % alphabet.Length;
                    encryptedText.Append(alphabet[newIndex]);
                }
            }
            return encryptedText.ToString();
        }

        private string Decrypt(string text, int shift, string alphabet)
        {
            return Encrypt(text, alphabet.Length - shift, alphabet);
        }

        private bool IsTextValidForAlphabet(string text, string alphabet)
        {
            foreach (var c in text)
            {
                if (!char.IsWhiteSpace(c) && !alphabet.Contains(c.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int shift;
            if (!int.TryParse(txtKey.Text, out shift))
            {
                MessageBox.Show("Введіть коректне числове значення для ключа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string text = txtInput.Text;

            if (rbUkrainian.Checked)
            {
                if (!IsTextValidForAlphabet(text, UkrainianAlphabet))
                {
                    MessageBox.Show("Текст містить символи, що не належать українському алфавіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtOutput.Text = Encrypt(text, shift, UkrainianAlphabet);
            }
            else if (rbEnglish.Checked)
            {
                if (!IsTextValidForAlphabet(text, EnglishAlphabet))
                {
                    MessageBox.Show("Текст містить символи, що не належать англійському алфавіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtOutput.Text = Encrypt(text, shift, EnglishAlphabet);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int shift;
            if (!int.TryParse(txtKey.Text, out shift))
            {
                MessageBox.Show("Введіть коректне числове значення для ключа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string text = txtInput.Text;

            if (rbUkrainian.Checked)
            {
                if (!IsTextValidForAlphabet(text, UkrainianAlphabet))
                {
                    MessageBox.Show("Текст містить символи, що не належать українському алфавіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtOutput.Text = Decrypt(text, shift, UkrainianAlphabet);
            }
            else if (rbEnglish.Checked)
            {
                if (!IsTextValidForAlphabet(text, EnglishAlphabet))
                {
                    MessageBox.Show("Текст містить символи, що не належать англійському алфавіту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtOutput.Text = Decrypt(text, shift, EnglishAlphabet);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}
