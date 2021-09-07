namespace Encryption_Device
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputText = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.encryptingOption = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.PaleTurquoise;
            this.inputText.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(15, 160);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(365, 130);
            this.inputText.TabIndex = 0;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.ForeColor = System.Drawing.Color.Gold;
            this.version.Location = new System.Drawing.Point(0, 293);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(57, 15);
            this.version.TabIndex = 1;
            this.version.Text = "Version 1.5";
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credits.ForeColor = System.Drawing.Color.Gold;
            this.credits.Location = new System.Drawing.Point(721, 293);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(133, 15);
            this.credits.TabIndex = 2;
            this.credits.Text = "Made by: Stefan Deliivanov";
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.PaleTurquoise;
            this.outputText.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(475, 160);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(365, 130);
            this.outputText.TabIndex = 3;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.inputLabel.Location = new System.Drawing.Point(141, 144);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 13);
            this.inputLabel.TabIndex = 4;
            this.inputLabel.Text = "Входен текст/код";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.outputLabel.Location = new System.Drawing.Point(597, 144);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(121, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Изходен тескт/код";
            // 
            // encryptButton
            // 
            this.encryptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encryptButton.BackgroundImage")));
            this.encryptButton.Location = new System.Drawing.Point(407, 250);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(40, 40);
            this.encryptButton.TabIndex = 7;
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.GreenYellow;
            this.Title.Location = new System.Drawing.Point(241, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(387, 116);
            this.Title.TabIndex = 8;
            this.Title.Text = "Encrypt.Me";
            // 
            // encryptingOption
            // 
            this.encryptingOption.BackColor = System.Drawing.Color.LawnGreen;
            this.encryptingOption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.encryptingOption.Location = new System.Drawing.Point(388, 162);
            this.encryptingOption.Name = "encryptingOption";
            this.encryptingOption.Size = new System.Drawing.Size(78, 23);
            this.encryptingOption.TabIndex = 9;
            this.encryptingOption.Text = "Encryption";
            this.encryptingOption.UseVisualStyleBackColor = false;
            this.encryptingOption.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.Color.PeachPuff;
            this.button2.Location = new System.Drawing.Point(388, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Decryption";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.encryptingOption);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.version);
            this.Controls.Add(this.inputText);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Encrypt.Me";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button encryptingOption;
        private System.Windows.Forms.Button button2;
    }
}