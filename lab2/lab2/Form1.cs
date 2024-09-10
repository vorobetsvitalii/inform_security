using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private Dictionary<char, List<string>> substitutionTable;

        public Form1()
        {
            InitializeComponent();
            substitutionTable = CreateSubstitutionTable();
        }

        private Dictionary<char, List<string>> CreateSubstitutionTable()
        {
            return new Dictionary<char, List<string>>
            {
                { 'А', new List<string> { "001", "002", "003", "004" } },
                { 'Б', new List<string> { "005", "006" } },
                { 'В', new List<string> { "007", "008", "009" } },
                { 'Г', new List<string> { "010", "011" } },
                { 'Ґ', new List<string> { "012" } },
                { 'Д', new List<string> { "013", "014" } },
                { 'Е', new List<string> { "015", "016", "017", "018" } },
                { 'Є', new List<string> { "019" } },
                { 'Ж', new List<string> { "020" } },
                { 'З', new List<string> { "021", "022", "023" } },
                { 'И', new List<string> { "024" } },
                { 'І', new List<string> { "025", "026" } },
                { 'Ї', new List<string> { "027" } },
                { 'Й', new List<string> { "028" } },
                { 'К', new List<string> { "029", "030" } },
                { 'Л', new List<string> { "031", "032" } },
                { 'М', new List<string> { "033" } },
                { 'Н', new List<string> { "034", "035" } },
                { 'О', new List<string> { "036", "037", "038", "039" } },
                { 'П', new List<string> { "040" } },
                { 'Р', new List<string> { "041", "042" } },
                { 'С', new List<string> { "043", "044" } },
                { 'Т', new List<string> { "045", "046" } },
                { 'У', new List<string> { "047", "048" } },
                { 'Ф', new List<string> { "049" } },
                { 'Х', new List<string> { "050", "051" } },
                { 'Ц', new List<string> { "052" } },
                { 'Ч', new List<string> { "053" } },
                { 'Ш', new List<string> { "054" } },
                { 'Щ', new List<string> { "055" } },
                { 'Ь', new List<string> { "056" } },
                { 'Ю', new List<string> { "057" } },
                { 'Я', new List<string> { "058" } },

                // Аналогічно для малих літер
                { 'а', new List<string> { "066", "067", "068", "069" } },
                { 'б', new List<string> { "070", "071" } },
                { 'в', new List<string> { "072", "073", "074" } },
                { 'г', new List<string> { "075", "076" } },
                { 'ґ', new List<string> { "077" } },
                { 'д', new List<string> { "078", "079" } },
                { 'е', new List<string> { "080", "081", "082", "083" } },
                { 'є', new List<string> { "084" } },
                { 'ж', new List<string> { "085" } },
                { 'з', new List<string> { "086", "087", "088" } },
                { 'и', new List<string> { "089", "059", "060" } },
                { 'і', new List<string> { "090", "091" } },
                { 'ї', new List<string> { "092" } },
                { 'й', new List<string> { "093" } },
                { 'к', new List<string> { "094", "095" } },
                { 'л', new List<string> { "096", "097" } },
                { 'м', new List<string> { "098", "061" } },
                { 'н', new List<string> { "099", "100" } },
                { 'о', new List<string> { "101", "102", "103", "104" } },
                { 'п', new List<string> { "105" } },
                { 'р', new List<string> { "106", "107" } },
                { 'с', new List<string> { "108", "109" } },
                { 'т', new List<string> { "110", "111" } },
                { 'у', new List<string> { "112", "113" } },
                { 'ф', new List<string> { "114" } },
                { 'х', new List<string> { "115", "116" } },
                { 'ц', new List<string> { "117" } },
                { 'ч', new List<string> { "118" } },
                { 'ш', new List<string> { "119" } },
                { 'щ', new List<string> { "120" } },
                { 'ь', new List<string> { "121" } },
                { 'ю', new List<string> { "122" } },
                { 'я', new List<string> { "123" } },
                { ' ', new List<string> { "124", "125", "126", "127", "128" } }
            };
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = inputTextBox.Text;
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Будь ласка, введіть текст для шифрування.");
                    return;
                }

                string encryptedText = EncryptText(inputText, substitutionTable);
                File.WriteAllText("encrypted_text.txt", encryptedText);
                SaveSubstitutionTableToFile(substitutionTable, "substable.txt");
                WriteOpenTextToFile(inputText, "opentext.txt");
                statusLabel.Text = "Текст успішно зашифровано та збережено у файл encrypted_text.txt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка: " + ex.Message);
            }
        }

        private Dictionary<char, List<string>> LoadSubstitutionTable(string filePath)
        {
            var table = new Dictionary<char, List<string>>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    var key = parts[0][0];
                    var values = parts[1].Split(',').ToList();
                    table[key] = values;
                }
            }
            return table;
        }


        private void SaveSubstitutionTableToFile(Dictionary<char, List<string>> substitutionTable, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var kvp in substitutionTable)
                {
                    sw.WriteLine($"{kvp.Key}:{string.Join(",", kvp.Value)}");
                }
            }
        }

        private string EncryptText(string input, Dictionary<char, List<string>> substitutionTable)
        {
            var random = new Random();
            var encryptedChars = input.Select(c =>
            {
                if (substitutionTable.TryGetValue(c, out var codes))
                {
                    // Вибрати випадковий код з таблиці
                    return codes[random.Next(codes.Count)];
                }
                return c.ToString();
            });

            // Об'єднати всі коди в один рядок
            return string.Concat(encryptedChars);
        }

        private void WriteOpenTextToFile(string text, string filePath)
        {
            File.WriteAllText(filePath, text);
        }
    }
}