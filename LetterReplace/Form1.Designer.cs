namespace LetterReplace
{
    partial class Form1
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
            button1 = new Button();
            rtbTemp = new RichTextBox();
            rtbResult = new RichTextBox();
            label3 = new Label();
            rtbOriginal = new RichTextBox();
            label4 = new Label();
            label6 = new Label();
            tbLetter = new ComboBox();
            tbReplaceWith = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            btRemove = new Button();
            listBox1 = new ListBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(163, 10);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Replace";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rtbTemp
            // 
            rtbTemp.BorderStyle = BorderStyle.None;
            rtbTemp.Location = new Point(481, -54);
            rtbTemp.Name = "rtbTemp";
            rtbTemp.Size = new Size(319, 34);
            rtbTemp.TabIndex = 2;
            rtbTemp.Text = "";
            // 
            // rtbResult
            // 
            rtbResult.BorderStyle = BorderStyle.None;
            rtbResult.Location = new Point(433, 128);
            rtbResult.Name = "rtbResult";
            rtbResult.Size = new Size(385, 492);
            rtbResult.TabIndex = 3;
            rtbResult.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 50);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 9;
            label3.Text = "Replace with:";
            // 
            // rtbOriginal
            // 
            rtbOriginal.BorderStyle = BorderStyle.None;
            rtbOriginal.Location = new Point(10, 128);
            rtbOriginal.Name = "rtbOriginal";
            rtbOriginal.Size = new Size(395, 492);
            rtbOriginal.TabIndex = 10;
            rtbOriginal.Text = "";
            rtbOriginal.TextChanged += rtbOriginal_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Original";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 86);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 13;
            label6.Text = "Result";
            // 
            // tbLetter
            // 
            tbLetter.FormattingEnabled = true;
            tbLetter.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            tbLetter.Location = new Point(6, 7);
            tbLetter.Name = "tbLetter";
            tbLetter.Size = new Size(151, 28);
            tbLetter.Sorted = true;
            tbLetter.TabIndex = 14;
            // 
            // tbReplaceWith
            // 
            tbReplaceWith.FormattingEnabled = true;
            tbReplaceWith.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            tbReplaceWith.Location = new Point(109, 47);
            tbReplaceWith.Name = "tbReplaceWith";
            tbReplaceWith.Size = new Size(151, 28);
            tbReplaceWith.Sorted = true;
            tbReplaceWith.TabIndex = 15;
            // 
            // label5
            // 
            label5.Location = new Point(481, -77);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 16;
            label5.Text = "Temp";
            // 
            // panel1
            // 
            panel1.Controls.Add(btRemove);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(rtbOriginal);
            panel1.Controls.Add(rtbResult);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 623);
            panel1.TabIndex = 17;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(824, 582);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(194, 29);
            btRemove.TabIndex = 13;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(824, 131);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 444);
            listBox1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rtbTemp);
            panel2.Controls.Add(tbReplaceWith);
            panel2.Controls.Add(tbLetter);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 125);
            panel2.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Mono Cipher Decryptor";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox rtbTemp;
        private RichTextBox rtbResult;
        private Label label3;
        private RichTextBox rtbOriginal;
        private Label label4;
        private Label label6;
        private ComboBox tbLetter;
        private ComboBox tbReplaceWith;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Button btRemove;
    }
}