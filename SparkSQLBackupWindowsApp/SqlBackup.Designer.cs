namespace SparkSQLBackupWindowsApp
{
    partial class SparkSqlBackup
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backupBtn = new System.Windows.Forms.Button();
            this.schedulerBtn = new System.Windows.Forms.Button();
            this.configCheckLbl = new System.Windows.Forms.Label();
            this.iniConfigBtn = new System.Windows.Forms.Button();
            this.connectioCheckBtn = new System.Windows.Forms.Button();
            this.connectionCheckLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupBtn
            // 
            this.backupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backupBtn.Location = new System.Drawing.Point(12, 54);
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.Size = new System.Drawing.Size(219, 100);
            this.backupBtn.TabIndex = 0;
            this.backupBtn.Text = "Kopia zapasowa bazy danych";
            this.backupBtn.UseVisualStyleBackColor = true;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // schedulerBtn
            // 
            this.schedulerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schedulerBtn.Location = new System.Drawing.Point(12, 173);
            this.schedulerBtn.Name = "schedulerBtn";
            this.schedulerBtn.Size = new System.Drawing.Size(219, 100);
            this.schedulerBtn.TabIndex = 1;
            this.schedulerBtn.Text = "Dodaj harmonogram automatycznych kopii zapasowych";
            this.schedulerBtn.UseVisualStyleBackColor = true;
            // 
            // configCheckLbl
            // 
            this.configCheckLbl.AutoSize = true;
            this.configCheckLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.configCheckLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.configCheckLbl.Location = new System.Drawing.Point(464, 58);
            this.configCheckLbl.Name = "configCheckLbl";
            this.configCheckLbl.Size = new System.Drawing.Size(95, 24);
            this.configCheckLbl.TabIndex = 2;
            this.configCheckLbl.Text = "config.ini";
            // 
            // iniConfigBtn
            // 
            this.iniConfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iniConfigBtn.Location = new System.Drawing.Point(270, 54);
            this.iniConfigBtn.Name = "iniConfigBtn";
            this.iniConfigBtn.Size = new System.Drawing.Size(176, 28);
            this.iniConfigBtn.TabIndex = 3;
            this.iniConfigBtn.Text = "Ustawienia aplikacji";
            this.iniConfigBtn.UseVisualStyleBackColor = true;
            // 
            // connectioCheckBtn
            // 
            this.connectioCheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectioCheckBtn.Location = new System.Drawing.Point(270, 90);
            this.connectioCheckBtn.Name = "connectioCheckBtn";
            this.connectioCheckBtn.Size = new System.Drawing.Size(176, 53);
            this.connectioCheckBtn.TabIndex = 4;
            this.connectioCheckBtn.Text = "Sprawdź połączenie z bazą danych";
            this.connectioCheckBtn.UseVisualStyleBackColor = true;
            // 
            // connectionCheckLbl
            // 
            this.connectionCheckLbl.AutoSize = true;
            this.connectionCheckLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionCheckLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectionCheckLbl.Location = new System.Drawing.Point(464, 103);
            this.connectionCheckLbl.Name = "connectionCheckLbl";
            this.connectionCheckLbl.Size = new System.Drawing.Size(206, 24);
            this.connectionCheckLbl.TabIndex = 5;
            this.connectionCheckLbl.Text = "db connection check";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(423, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ustawienia aplikacji";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SparkSqlBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectionCheckLbl);
            this.Controls.Add(this.connectioCheckBtn);
            this.Controls.Add(this.iniConfigBtn);
            this.Controls.Add(this.configCheckLbl);
            this.Controls.Add(this.schedulerBtn);
            this.Controls.Add(this.backupBtn);
            this.Name = "SparkSqlBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spark SQL Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backupBtn;
        private System.Windows.Forms.Button schedulerBtn;
        private System.Windows.Forms.Label configCheckLbl;
        private System.Windows.Forms.Button iniConfigBtn;
        private System.Windows.Forms.Button connectioCheckBtn;
        private System.Windows.Forms.Label connectionCheckLbl;
        private System.Windows.Forms.Button button1;
    }
}

