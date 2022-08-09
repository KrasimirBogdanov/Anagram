namespace Anagram
{
    partial class Anagram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkAnagram = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Anagrams = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.inputWordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkAnagram
            // 
            this.checkAnagram.FlatAppearance.BorderSize = 10;
            this.checkAnagram.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkAnagram.Location = new System.Drawing.Point(12, 21);
            this.checkAnagram.Name = "checkAnagram";
            this.checkAnagram.Size = new System.Drawing.Size(174, 102);
            this.checkAnagram.TabIndex = 0;
            this.checkAnagram.Text = "Check Anagram\r\nand \r\nDisplay";
            this.checkAnagram.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Anagrams
            // 
            this.Anagrams.Location = new System.Drawing.Point(27, 121);
            this.Anagrams.Name = "Anagrams";
            this.Anagrams.Size = new System.Drawing.Size(148, 72);
            this.Anagrams.TabIndex = 0;
            this.Anagrams.Text = "Show Anagrams";
            this.Anagrams.UseVisualStyleBackColor = true;
            this.Anagrams.Click += new System.EventHandler(this.Anagrams_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(205, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(616, 307);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // inputWordBox
            // 
            this.inputWordBox.Location = new System.Drawing.Point(27, 76);
            this.inputWordBox.Name = "inputWordBox";
            this.inputWordBox.Size = new System.Drawing.Size(148, 23);
            this.inputWordBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please type word:";
            // 
            // Anagram
            // 
            this.ClientSize = new System.Drawing.Size(833, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputWordBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Anagrams);
            this.Name = "Anagram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button checkAnagram;
        private RichTextBox richTextBox1;
        private Button Anagrams;
        private RichTextBox richTextBox2;
        private TextBox inputWordBox;
        private Label label1;
    }
}