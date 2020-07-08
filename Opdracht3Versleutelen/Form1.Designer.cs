namespace Opdracht3Versleutelen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxUnedited = new System.Windows.Forms.RichTextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.richTextBoxEdited = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCipherMode = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPaddingMode = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxUnedited
            // 
            this.richTextBoxUnedited.Location = new System.Drawing.Point(13, 102);
            this.richTextBoxUnedited.Name = "richTextBoxUnedited";
            this.richTextBoxUnedited.Size = new System.Drawing.Size(335, 336);
            this.richTextBoxUnedited.TabIndex = 0;
            this.richTextBoxUnedited.Text = "text";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(363, 13);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 35);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // richTextBoxEdited
            // 
            this.richTextBoxEdited.Location = new System.Drawing.Point(453, 12);
            this.richTextBoxEdited.Name = "richTextBoxEdited";
            this.richTextBoxEdited.Size = new System.Drawing.Size(335, 188);
            this.richTextBoxEdited.TabIndex = 3;
            this.richTextBoxEdited.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(363, 99);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 35);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "save to destop";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(83, 13);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(265, 20);
            this.textBoxKey.TabIndex = 5;
            this.textBoxKey.Text = "key";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(363, 54);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 35);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "cipherMode";
            // 
            // listBoxCipherMode
            // 
            this.listBoxCipherMode.FormattingEnabled = true;
            this.listBoxCipherMode.Location = new System.Drawing.Point(83, 40);
            this.listBoxCipherMode.Name = "listBoxCipherMode";
            this.listBoxCipherMode.Size = new System.Drawing.Size(87, 56);
            this.listBoxCipherMode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "paddingMode";
            // 
            // listBoxPaddingMode
            // 
            this.listBoxPaddingMode.FormattingEnabled = true;
            this.listBoxPaddingMode.Location = new System.Drawing.Point(261, 39);
            this.listBoxPaddingMode.Name = "listBoxPaddingMode";
            this.listBoxPaddingMode.Size = new System.Drawing.Size(87, 56);
            this.listBoxPaddingMode.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxPaddingMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCipherMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBoxEdited);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.richTextBoxUnedited);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUnedited;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.RichTextBox richTextBoxEdited;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxCipherMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPaddingMode;
        private System.Windows.Forms.Label label4;
    }
}

