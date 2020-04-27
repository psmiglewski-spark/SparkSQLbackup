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
            this.taskSchedulerTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taskSchedulerIntervaltxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
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
            this.schedulerBtn.Location = new System.Drawing.Point(39, 304);
            this.schedulerBtn.Name = "schedulerBtn";
            this.schedulerBtn.Size = new System.Drawing.Size(239, 72);
            this.schedulerBtn.TabIndex = 1;
            this.schedulerBtn.Text = "Dodaj harmonogram automatycznych kopii zapasowych";
            this.schedulerBtn.UseVisualStyleBackColor = true;
            this.schedulerBtn.Click += new System.EventHandler(this.schedulerBtn_Click);
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
            this.iniConfigBtn.Click += new System.EventHandler(this.iniConfigBtn_Click);
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
            this.connectioCheckBtn.Click += new System.EventHandler(this.connectioCheckBtn_Click);
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
            // taskSchedulerTimePicker
            // 
            this.taskSchedulerTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.taskSchedulerTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.taskSchedulerTimePicker.Location = new System.Drawing.Point(39, 278);
            this.taskSchedulerTimePicker.Name = "taskSchedulerTimePicker";
            this.taskSchedulerTimePicker.Size = new System.Drawing.Size(112, 20);
            this.taskSchedulerTimePicker.TabIndex = 6;
            // 
            // taskSchedulerIntervaltxt
            // 
            this.taskSchedulerIntervaltxt.FormattingEnabled = true;
            this.taskSchedulerIntervaltxt.Items.AddRange(new object[] {
            "Codziennie",
            "Raz w tygodniu",
            "Raz w miesiącu",
            "Jednorazowo"});
            this.taskSchedulerIntervaltxt.Location = new System.Drawing.Point(157, 278);
            this.taskSchedulerIntervaltxt.Name = "taskSchedulerIntervaltxt";
            this.taskSchedulerIntervaltxt.Size = new System.Drawing.Size(121, 21);
            this.taskSchedulerIntervaltxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz datę i częstotliwość kopii zapasowych";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.infoLbl.Location = new System.Drawing.Point(58, 195);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 24);
            this.infoLbl.TabIndex = 9;
            // 
            // SparkSqlBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskSchedulerIntervaltxt);
            this.Controls.Add(this.taskSchedulerTimePicker);
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
        private System.Windows.Forms.DateTimePicker taskSchedulerTimePicker;
        private System.Windows.Forms.ComboBox taskSchedulerIntervaltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLbl;
    }
}

