namespace SparkSQLBackupWindowsApp
{
    partial class PropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionStringTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationPathTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dbNameTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.destinationEmailTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.senderTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.smtpTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.smtpLoginTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.smtpPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.savePropertiesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ustawienia konfiguracyjne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ścieżka serwera bazy danych (Connection string):";
            // 
            // connectionStringTxtBox
            // 
            this.connectionStringTxtBox.Location = new System.Drawing.Point(278, 63);
            this.connectionStringTxtBox.Name = "connectionStringTxtBox";
            this.connectionStringTxtBox.Size = new System.Drawing.Size(239, 20);
            this.connectionStringTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ścieżka kopii zapasowej:";
            // 
            // destinationPathTxtBox
            // 
            this.destinationPathTxtBox.Location = new System.Drawing.Point(278, 112);
            this.destinationPathTxtBox.Name = "destinationPathTxtBox";
            this.destinationPathTxtBox.Size = new System.Drawing.Size(204, 20);
            this.destinationPathTxtBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nazwa bazy danych:";
            // 
            // dbNameTxtBox
            // 
            this.dbNameTxtBox.Location = new System.Drawing.Point(278, 154);
            this.dbNameTxtBox.Name = "dbNameTxtBox";
            this.dbNameTxtBox.Size = new System.Drawing.Size(145, 20);
            this.dbNameTxtBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(149, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ustawienia poczty wychodzącej";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adres dostarczenia (gdzie wysłać raport błędu):";
            // 
            // destinationEmailTxtBox
            // 
            this.destinationEmailTxtBox.Location = new System.Drawing.Point(278, 266);
            this.destinationEmailTxtBox.Name = "destinationEmailTxtBox";
            this.destinationEmailTxtBox.Size = new System.Drawing.Size(204, 20);
            this.destinationEmailTxtBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wysyłający maila:";
            // 
            // senderTxtBox
            // 
            this.senderTxtBox.Location = new System.Drawing.Point(278, 303);
            this.senderTxtBox.Name = "senderTxtBox";
            this.senderTxtBox.Size = new System.Drawing.Size(204, 20);
            this.senderTxtBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Serwer SMTP:";
            // 
            // smtpTxtBox
            // 
            this.smtpTxtBox.Location = new System.Drawing.Point(278, 344);
            this.smtpTxtBox.Name = "smtpTxtBox";
            this.smtpTxtBox.Size = new System.Drawing.Size(155, 20);
            this.smtpTxtBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "SMTP login:";
            // 
            // smtpLoginTxtBox
            // 
            this.smtpLoginTxtBox.Location = new System.Drawing.Point(278, 378);
            this.smtpLoginTxtBox.Name = "smtpLoginTxtBox";
            this.smtpLoginTxtBox.Size = new System.Drawing.Size(155, 20);
            this.smtpLoginTxtBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "SMTP password:";
            // 
            // smtpPasswordTxtBox
            // 
            this.smtpPasswordTxtBox.Location = new System.Drawing.Point(278, 407);
            this.smtpPasswordTxtBox.Name = "smtpPasswordTxtBox";
            this.smtpPasswordTxtBox.Size = new System.Drawing.Size(155, 20);
            this.smtpPasswordTxtBox.TabIndex = 17;
            // 
            // savePropertiesBtn
            // 
            this.savePropertiesBtn.Location = new System.Drawing.Point(416, 444);
            this.savePropertiesBtn.Name = "savePropertiesBtn";
            this.savePropertiesBtn.Size = new System.Drawing.Size(125, 23);
            this.savePropertiesBtn.TabIndex = 18;
            this.savePropertiesBtn.Text = "Zapisz";
            this.savePropertiesBtn.UseVisualStyleBackColor = true;
            this.savePropertiesBtn.Click += new System.EventHandler(this.savePropertiesBtn_Click);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 489);
            this.Controls.Add(this.savePropertiesBtn);
            this.Controls.Add(this.smtpPasswordTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.smtpLoginTxtBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.smtpTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.senderTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destinationEmailTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dbNameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destinationPathTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectionStringTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PropertiesForm";
            this.Text = "PropertiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectionStringTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationPathTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbNameTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox destinationEmailTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox senderTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox smtpTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox smtpLoginTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox smtpPasswordTxtBox;
        private System.Windows.Forms.Button savePropertiesBtn;
    }
}