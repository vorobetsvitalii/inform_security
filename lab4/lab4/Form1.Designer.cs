namespace lab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button OpenTextFileButton;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox TextFilePathTextBox;
        private System.Windows.Forms.TextBox GammaTextBox;
        private System.Windows.Forms.TextBox ResultFilePathTextBox;
        private System.Windows.Forms.Label GammaLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.OpenTextFileButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.TextFilePathTextBox = new System.Windows.Forms.TextBox();
            this.GammaTextBox = new System.Windows.Forms.TextBox();
            this.ResultFilePathTextBox = new System.Windows.Forms.TextBox();
            this.GammaLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();

            // OpenTextFileButton
            this.OpenTextFileButton.Location = new System.Drawing.Point(12, 12);
            this.OpenTextFileButton.Name = "OpenTextFileButton";
            this.OpenTextFileButton.Size = new System.Drawing.Size(150, 23);
            this.OpenTextFileButton.TabIndex = 0;
            this.OpenTextFileButton.Text = "Вибрати вхідний файл";
            this.OpenTextFileButton.UseVisualStyleBackColor = true;
            this.OpenTextFileButton.Click += new System.EventHandler(this.OpenTextFileButton_Click);

            // TextFilePathTextBox
            this.TextFilePathTextBox.Location = new System.Drawing.Point(180, 14);
            this.TextFilePathTextBox.Name = "TextFilePathTextBox";
            this.TextFilePathTextBox.Size = new System.Drawing.Size(300, 20);
            this.TextFilePathTextBox.TabIndex = 1;

            // GammaLabel
            this.GammaLabel.AutoSize = true;
            this.GammaLabel.Location = new System.Drawing.Point(12, 50);
            this.GammaLabel.Name = "GammaLabel";
            this.GammaLabel.Size = new System.Drawing.Size(38, 13);
            this.GammaLabel.TabIndex = 2;
            this.GammaLabel.Text = "Гамма";

            // GammaTextBox
            this.GammaTextBox.Location = new System.Drawing.Point(180, 47);
            this.GammaTextBox.Name = "GammaTextBox";
            this.GammaTextBox.Size = new System.Drawing.Size(300, 20);
            this.GammaTextBox.TabIndex = 3;

            // SaveFileButton
            this.SaveFileButton.Location = new System.Drawing.Point(12, 80);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(150, 23);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Вибрати файл результату";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);

            // ResultFilePathTextBox
            this.ResultFilePathTextBox.Location = new System.Drawing.Point(180, 82);
            this.ResultFilePathTextBox.Name = "ResultFilePathTextBox";
            this.ResultFilePathTextBox.Size = new System.Drawing.Size(300, 20);
            this.ResultFilePathTextBox.TabIndex = 5;

            // EncryptButton
            this.EncryptButton.Location = new System.Drawing.Point(12, 120);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(150, 23);
            this.EncryptButton.TabIndex = 6;
            this.EncryptButton.Text = "Шифрувати";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);

            // DecryptButton
            this.DecryptButton.Location = new System.Drawing.Point(180, 120);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(150, 23);
            this.DecryptButton.TabIndex = 7;
            this.DecryptButton.Text = "Дешифрувати";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 160);
            this.Controls.Add(this.OpenTextFileButton);
            this.Controls.Add(this.TextFilePathTextBox);
            this.Controls.Add(this.GammaLabel);
            this.Controls.Add(this.GammaTextBox);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.ResultFilePathTextBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptButton);
            this.Name = "Form1";
            this.Text = "Модульний шифр гамування";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
