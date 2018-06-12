namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.plaintextField = new System.Windows.Forms.TextBox();
            this.rc4kField = new System.Windows.Forms.TextBox();
            this.vigenerekField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptedMBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decryptMBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label8 = new System.Windows.Forms.Label();
            this.plainTextLField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.randomPField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "VRC4 Encryption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(412, 339);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(173, 41);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.TabStop = false;
            this.encryptButton.Text = "Encrypt && Decrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // plaintextField
            // 
            this.plaintextField.Location = new System.Drawing.Point(235, 100);
            this.plaintextField.Name = "plaintextField";
            this.plaintextField.Size = new System.Drawing.Size(513, 20);
            this.plaintextField.TabIndex = 3;
            // 
            // rc4kField
            // 
            this.rc4kField.Location = new System.Drawing.Point(235, 138);
            this.rc4kField.Name = "rc4kField";
            this.rc4kField.Size = new System.Drawing.Size(513, 20);
            this.rc4kField.TabIndex = 4;
            // 
            // vigenerekField
            // 
            this.vigenerekField.Location = new System.Drawing.Point(235, 175);
            this.vigenerekField.Name = "vigenerekField";
            this.vigenerekField.Size = new System.Drawing.Size(513, 20);
            this.vigenerekField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(162, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "PlainText:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "RC4 Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vigenere Key:";
            // 
            // encryptedMBox
            // 
            this.encryptedMBox.Location = new System.Drawing.Point(235, 271);
            this.encryptedMBox.Name = "encryptedMBox";
            this.encryptedMBox.ReadOnly = true;
            this.encryptedMBox.Size = new System.Drawing.Size(513, 20);
            this.encryptedMBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Message Encrypted:";
            // 
            // decryptMBox
            // 
            this.decryptMBox.Location = new System.Drawing.Point(235, 304);
            this.decryptMBox.Name = "decryptMBox";
            this.decryptMBox.ReadOnly = true;
            this.decryptMBox.Size = new System.Drawing.Size(513, 20);
            this.decryptMBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Message Decrypted:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.Font = new System.Drawing.Font("Freestyle Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(1, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "By: Arturo \'n\' Nelson";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "PlainText Length:";
            // 
            // plainTextLField
            // 
            this.plainTextLField.Location = new System.Drawing.Point(235, 211);
            this.plainTextLField.Name = "plainTextLField";
            this.plainTextLField.ReadOnly = true;
            this.plainTextLField.Size = new System.Drawing.Size(33, 20);
            this.plainTextLField.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Random Partition At:";
            // 
            // randomPField
            // 
            this.randomPField.Location = new System.Drawing.Point(235, 243);
            this.randomPField.Name = "randomPField";
            this.randomPField.ReadOnly = true;
            this.randomPField.Size = new System.Drawing.Size(33, 20);
            this.randomPField.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 427);
            this.Controls.Add(this.randomPField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plainTextLField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decryptMBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encryptedMBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vigenerekField);
            this.Controls.Add(this.rc4kField);
            this.Controls.Add(this.plaintextField);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VRC4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plaintextField;
        private System.Windows.Forms.TextBox rc4kField;
        private System.Windows.Forms.TextBox vigenerekField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox encryptedMBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decryptMBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox randomPField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox plainTextLField;
        private System.Windows.Forms.Label label8;
    }
}

