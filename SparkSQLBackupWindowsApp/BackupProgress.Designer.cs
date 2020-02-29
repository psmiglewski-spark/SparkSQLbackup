namespace SparkSQLBackupWindowsApp
{
    partial class BackupProgress
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.okBtn = new System.Windows.Forms.Button();
            this.successLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tworzenie kopii zapasowej bazy danych. Proszę czekać";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(124, 74);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(314, 23);
            this.progressBar.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(224, 129);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(102, 32);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // successLbl
            // 
            this.successLbl.AutoSize = true;
            this.successLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.successLbl.ForeColor = System.Drawing.Color.Green;
            this.successLbl.Location = new System.Drawing.Point(107, 102);
            this.successLbl.Name = "successLbl";
            this.successLbl.Size = new System.Drawing.Size(355, 24);
            this.successLbl.TabIndex = 3;
            this.successLbl.Text = "Kopia bazy danych utworzona poprawnie";
            // 
            // BackupProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 173);
            this.Controls.Add(this.successLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Name = "BackupProgress";
            this.Text = "BackupProgress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label successLbl;
    }
}