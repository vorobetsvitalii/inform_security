using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private Dictionary<char, int> letterToNumber;
        private Dictionary<int, char> numberToLetter;
        private int alphabetLength;

        public Form1()
        {
            InitializeComponent();
            LoadAlphabetTable("alphabet_table.txt"); // Зчитуємо таблицю при запуску програми
        }

        // Завантаження таблиці відповідностей з файлу
        private void LoadAlphabetTable(string filePath)
        {
            letterToNumber = new Dictionary<char, int>();
            numberToLetter = new Dictionary<int, char>();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(' '); // Розділяємо пробіл
                if (parts.Length == 2)
                {
                    char letter = parts[0][0];
                    int number = int.Parse(parts[1]);

                    letterToNumber[letter] = number;
                    numberToLetter[number] = letter;
                }
            }

            alphabetLength = letterToNumber.Count; // Кількість символів у таблиці
        }

        // Вибір файлу вхідного тексту
        private void OpenTextFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextFilePathTextBox.Text = openFileDialog1.FileName;
            }
        }

        // Вибір файлу для збереження результату
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ResultFilePathTextBox.Text = saveFileDialog1.FileName;
            }
        }

        // Шифрування
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string inputFilePath = TextFilePathTextBox.Text;
            string outputFilePath = ResultFilePathTextBox.Text;
            string gamma = GammaTextBox.Text;

            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(gamma))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            try
            {
                string plaintext = File.ReadAllText(inputFilePath);
                string ciphertext = Encrypt(plaintext, gamma);
                File.WriteAllText(outputFilePath, ciphertext);
                MessageBox.Show("Шифрування завершено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        // Дешифрування
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string inputFilePath = TextFilePathTextBox.Text;
            string outputFilePath = ResultFilePathTextBox.Text;
            string gamma = GammaTextBox.Text;

            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath) || string.IsNullOrEmpty(gamma))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            try
            {
                string ciphertext = File.ReadAllText(inputFilePath);
                string plaintext = Decrypt(ciphertext, gamma);
                File.WriteAllText(outputFilePath, plaintext);
                MessageBox.Show("Дешифрування завершено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private string Encrypt(string plaintext, string gamma)
        {
            return ProcessText(plaintext, gamma, true);
        }

        private string Decrypt(string ciphertext, string gamma)
        {
            return ProcessText(ciphertext, gamma, false);
        }

        private string ProcessText(string text, string gamma, bool encrypting)
        {
            char[] result = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (!letterToNumber.ContainsKey(currentChar))
                {
                    result[i] = currentChar; // якщо символ не входить в таблицю, залишаємо без змін
                    continue;
                }

                int letterIndex = letterToNumber[currentChar];
                int gammaIndex = letterToNumber[gamma[i % gamma.Length]];

                if (encrypting)
                {
                    letterIndex = (letterIndex + gammaIndex) % alphabetLength;
                }
                else
                {
                    letterIndex = (letterIndex - gammaIndex + alphabetLength) % alphabetLength;
                }

                result[i] = numberToLetter[letterIndex];
            }
            return new string(result);
        }
    }
}
