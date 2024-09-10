namespace lab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.btnDecryptText = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(12, 12);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(200, 30);
            this.btnLoadTable.TabIndex = 0;
            this.btnLoadTable.Text = "Завантажити таблицю";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);

            // 
            // btnDecryptText
            // 
            this.btnDecryptText.Location = new System.Drawing.Point(12, 48);
            this.btnDecryptText.Name = "btnDecryptText";
            this.btnDecryptText.Size = new System.Drawing.Size(200, 30);
            this.btnDecryptText.TabIndex = 1;
            this.btnDecryptText.Text = "Розшифрувати текст";
            this.btnDecryptText.UseVisualStyleBackColor = true;
            this.btnDecryptText.Click += new System.EventHandler(this.btnDecryptText_Click);

            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(12, 84);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(480, 200);
            this.txtDecryptedText.TabIndex = 2;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.txtDecryptedText);
            this.Controls.Add(this.btnDecryptText);
            this.Controls.Add(this.btnLoadTable);
            this.Name = "MainForm";
            this.Text = "Дешифратор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Button btnDecryptText;
        private System.Windows.Forms.TextBox txtDecryptedText;
    }
}
