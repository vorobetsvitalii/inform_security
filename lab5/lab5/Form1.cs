using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int length;
        private char[,] playfairTable;
        private Dictionary<char, Tuple<int, int>> charPositions = new Dictionary<char, Tuple<int, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Виберіть файл таблиці-ключа";
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtKeyPath.Text = ofd.FileName;
                LoadPlayfairKey(ofd.FileName);
            }
        }

        private void LoadPlayfairKey(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                length = lines.Length;
                playfairTable = new char[length, length];

                for (int i = 0; i < length; i++)
                {
                    string line = lines[i].Replace(" ", "").Replace(",", "").Replace("\t", "");
                    if (line.Length != length)
                    {
                        MessageBox.Show($"Рядок {i + 1} таблиці-ключа повинен містити {length} символів.");
                        return;
                    }

                    for (int j = 0; j < length; j++)
                    {
                        playfairTable[i, j] = line[j];
                        if (!charPositions.ContainsKey(line[j]))
                        {
                            charPositions.Add(line[j], Tuple.Create(i, j));
                        }
                        else
                        {
                            MessageBox.Show($"Літера '{line[j]}' повторюється у таблиці-ключі.");
                            return;
                        }
                    }
                }

                MessageBox.Show("Таблиця-ключ успішно завантажена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні таблиці-ключа: {ex.Message}");
            }
        }

        private void btnLoadInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Виберіть вхідний файл";
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtInputPath.Text = ofd.FileName;
            }
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Виберіть вихідний файл";
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = sfd.FileName;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string openText = File.ReadAllText(txtInputPath.Text);
            string processedText = PrepareText(openText);
            List<string> bigrams = CreateBigrams(processedText);
            string encryptedText = "";

            foreach (var bigram in bigrams)
            {
                encryptedText += EncryptBigram(bigram);
            }

            File.WriteAllText(txtOutputPath.Text, encryptedText);
            MessageBox.Show("Шифрування завершено.");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string encryptedText = File.ReadAllText(txtInputPath.Text);
            List<string> bigrams = CreateBigrams(encryptedText);
            string decryptedText = "";

            foreach (var bigram in bigrams)
            {
                decryptedText += DecryptBigram(bigram);
            }

            File.WriteAllText(txtOutputPath.Text, decryptedText);
            MessageBox.Show("Дешифрування завершено.");
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtKeyPath.Text))
            {
                MessageBox.Show("Будь ласка, виберіть файл таблиці-ключа.");
                return false;
            }

            if (string.IsNullOrEmpty(txtInputPath.Text))
            {
                MessageBox.Show("Будь ласка, виберіть вхідний файл.");
                return false;
            }

            if (string.IsNullOrEmpty(txtOutputPath.Text))
            {
                MessageBox.Show("Будь ласка, виберіть вихідний файл.");
                return false;
            }

            if (playfairTable.Cast<char>().All(c => c == '\0'))
            {
                MessageBox.Show("Будь ласка, завантажте таблицю-ключ.");
                return false;
            }

            return true;
        }

        private string PrepareText(string text)
        {
            // Видаляємо всі символи, крім літер
            var letters = text.Where(c => char.IsLetter(c)).ToList();

            // Замінюємо 'J' на 'I' (для англійської, адаптуємо для української)
            for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] == 'Й')
                    letters[i] = 'Ї';
                else if (letters[i] == 'й')
                    letters[i] = 'ї';
            }

            // Якщо кількість літер непарна, додаємо 'X' (або інший символ)
            if (letters.Count % 2 != 0)
                letters.Add('X');

            return new string(letters.ToArray());
        }

        private List<string> CreateBigrams(string text)
        {
            List<string> bigrams = new List<string>();

            for (int i = 0; i < text.Length; i += 2)
            {
                string bigram = text.Substring(i, 2);

                // Якщо літери однакові, замінюємо другу на 'X'
                if (bigram[0] == bigram[1])
                {
                    bigram = bigram[0] + "X";
                    i--; // Повторюємо цей крок з новим символом
                }

                bigrams.Add(bigram);
            }

            return bigrams;
        }

        private string EncryptBigram(string bigram)
        {
            char a = bigram[0];
            char b = bigram[1];

            try
            {

                Tuple<int, int> posA = charPositions[a];
                Tuple<int, int> posB = charPositions[b];

                if (posA.Item1 == posB.Item1)
                {
                    // Правило 2: однаковий рядок
                    int colA = (posA.Item2 + 1) % length;
                    int colB = (posB.Item2 + 1) % length;
                    return playfairTable[posA.Item1, colA].ToString() + playfairTable[posB.Item1, colB].ToString();
                }
                else if (posA.Item2 == posB.Item2)
                {
                    // Правило 3: однаковий стовпець
                    int rowA = (posA.Item1 + 1) % length;
                    int rowB = (posB.Item1 + 1) % length;
                    return playfairTable[rowA, posA.Item2].ToString() + playfairTable[rowB, posB.Item2].ToString();
                }
                else
                {
                    // Правило 1: утворюють прямокутник
                    return playfairTable[posA.Item1, posB.Item2].ToString() + playfairTable[posB.Item1, posA.Item2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при обробці тексту: {ex.Message}");
                return "";
            }
        }

        private string DecryptBigram(string bigram)
        {
            char a = bigram[0];
            char b = bigram[1];

            Tuple<int, int> posA = charPositions[a];
            Tuple<int, int> posB = charPositions[b];

            if (posA.Item1 == posB.Item1)
            {
                // Правило 2: однаковий рядок
                int colA = (posA.Item2 - 1 + length) % length;
                int colB = (posB.Item2 - 1 + length) % length;
                return playfairTable[posA.Item1, colA].ToString() + playfairTable[posB.Item1, colB].ToString();
            }
            else if (posA.Item2 == posB.Item2)
            {
                // Правило 3: однаковий стовпець
                int rowA = (posA.Item1 - 1 + length) % length;
                int rowB = (posB.Item1 - 1 + length) % length;
                return playfairTable[rowA, posA.Item2].ToString() + playfairTable[rowB, posB.Item2].ToString();
            }
            else
            {
                // Правило 1: утворюють прямокутник
                return playfairTable[posA.Item1, posB.Item2].ToString() + playfairTable[posB.Item1, posA.Item2].ToString();
            }
        }
    }
}