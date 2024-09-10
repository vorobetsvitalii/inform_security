using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, char> reverseSubstitutionTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            // Вибір файлу для завантаження таблиці шифрування
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Завантаження таблиці шифрування з файлу
                    reverseSubstitutionTable = LoadReverseSubstitutionTable(openFileDialog.FileName);
                    MessageBox.Show("Таблиця шифрування завантажена.");
                }
            }
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            if (reverseSubstitutionTable == null)
            {
                MessageBox.Show("Спочатку завантажте таблицю шифрування.");
                return;
            }

            // Вибір файлу для зчитування зашифрованого тексту
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Зчитування зашифрованого тексту з файлу
                    string encryptedText = File.ReadAllText(openFileDialog.FileName);
                    string decryptedText = DecryptText(encryptedText, reverseSubstitutionTable);

                    // Виведення розшифрованого тексту в текстове поле
                    txtDecryptedText.Text = decryptedText;
                    MessageBox.Show("Текст розшифровано.");
                }
            }
        }

        // Завантаження таблиці шифрування з файлу
        private Dictionary<string, char> LoadReverseSubstitutionTable(string filePath)
        {
            var reverseTable = new Dictionary<string, char>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    char key = parts[0][0];
                    var values = parts[1].Split(',');
                    foreach (var value in values)
                    {
                        reverseTable[value] = key;
                    }
                }
            }
            return reverseTable;
        }

        // Розшифрування тексту з використанням таблиці заміни
        private string DecryptText(string encryptedText, Dictionary<string, char> reverseTable)
        {
            var decryptedText = "";
            var currentCode = "";

            foreach (char c in encryptedText)
            {
                currentCode += c;
                if (reverseTable.ContainsKey(currentCode))
                {
                    decryptedText += reverseTable[currentCode];
                    currentCode = "";
                }
            }

            return decryptedText;
        }
    }
}
