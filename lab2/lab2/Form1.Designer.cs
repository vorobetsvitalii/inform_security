namespace lab2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label statusLabel;

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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // inputTextBox
            this.inputTextBox.Location = new System.Drawing.Point(12, 12);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(360, 200);
            this.inputTextBox.TabIndex = 0;

            // encryptButton
            this.encryptButton.Location = new System.Drawing.Point(12, 220);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(100, 23);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.Text = "Зашифрувати";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);

            // statusLabel
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 250);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 2;

            // MainForm
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainForm";
            this.Text = "Шифрувальник тексту";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
