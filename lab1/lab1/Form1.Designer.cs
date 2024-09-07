namespace lab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.RadioButton rbUkrainian;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.rbUkrainian = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(100, 30);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(100, 100);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 100);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(100, 250); 
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(300, 100);
            this.txtOutput.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(450, 70);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Шифрувати";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(450, 110);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "Дешифрувати";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(450, 150);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(100, 30);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "Зберегти у файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(450, 190);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(100, 30);
            this.btnLoadFromFile.TabIndex = 6;
            this.btnLoadFromFile.Text = "Завантажити з файлу";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // rbUkrainian
            // 
            this.rbUkrainian.AutoSize = true;
            this.rbUkrainian.Location = new System.Drawing.Point(450, 30);
            this.rbUkrainian.Name = "rbUkrainian";
            this.rbUkrainian.Size = new System.Drawing.Size(104, 21);
            this.rbUkrainian.TabIndex = 7;
            this.rbUkrainian.TabStop = true;
            this.rbUkrainian.Text = "Українська";
            this.rbUkrainian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(560, 30);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(96, 21);
            this.rbEnglish.TabIndex = 8;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Англійська";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(30, 33);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(46, 17);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Ключ:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(30, 73);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(64, 17);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "Вхідний текст:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(30, 223); 
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(64, 17);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.Text = "Вихідний текст:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400); 
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbUkrainian);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtKey);
            this.Name = "MainForm";
            this.Text = "Caesar Cipher App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}