namespace lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadKey;
        private System.Windows.Forms.TextBox txtKeyPath;
        private System.Windows.Forms.Button btnLoadInput;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.TextBox txtGamma;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
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

        private void InitializeComponent()
        {
            this.btnLoadKey = new System.Windows.Forms.Button();
            this.txtKeyPath = new System.Windows.Forms.TextBox();
            this.btnLoadInput = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.lblGamma = new System.Windows.Forms.Label();
            this.txtGamma = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Location = new System.Drawing.Point(12, 30);
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(120, 23);
            this.btnLoadKey.TabIndex = 0;
            this.btnLoadKey.Text = "Вибрати таблицю-ключ";
            this.btnLoadKey.UseVisualStyleBackColor = true;
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // txtKeyPath
            // 
            this.txtKeyPath.Location = new System.Drawing.Point(150, 32);
            this.txtKeyPath.Name = "txtKeyPath";
            this.txtKeyPath.ReadOnly = true;
            this.txtKeyPath.Size = new System.Drawing.Size(300, 20);
            this.txtKeyPath.TabIndex = 1;
            // 
            // btnLoadInput
            // 
            this.btnLoadInput.Location = new System.Drawing.Point(12, 70);
            this.btnLoadInput.Name = "btnLoadInput";
            this.btnLoadInput.Size = new System.Drawing.Size(120, 23);
            this.btnLoadInput.TabIndex = 2;
            this.btnLoadInput.Text = "Вибрати вхідний файл";
            this.btnLoadInput.UseVisualStyleBackColor = true;
            this.btnLoadInput.Click += new System.EventHandler(this.btnLoadInput_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(150, 72);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(300, 20);
            this.txtInputPath.TabIndex = 3;
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(12, 110);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(120, 23);
            this.btnSaveOutput.TabIndex = 4;
            this.btnSaveOutput.Text = "Вибрати вихідний файл";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(150, 112);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(300, 20);
            this.txtOutputPath.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(150, 190);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(120, 30);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Шифрувати";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(330, 190);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 30);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Дешифрувати";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(150, 15);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(105, 13);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Шлях до таблиці-ключа";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(150, 55);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(87, 13);
            this.lblInput.TabIndex = 11;
            this.lblInput.Text = "Шлях до вхідного файлу";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(150, 95);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(93, 13);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Text = "Шлях до вихідного файлу";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.txtInputPath);
            this.Controls.Add(this.btnLoadInput);
            this.Controls.Add(this.txtKeyPath);
            this.Controls.Add(this.btnLoadKey);
            this.Name = "Form1";
            this.Text = "Шифр Плейфера";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
