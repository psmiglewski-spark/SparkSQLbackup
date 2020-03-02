using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SparkSQLbackupWindowsApp;
using System.IO.Compression;

namespace SparkSQLBackupWindowsApp
{
    public partial class SparkSqlBackup : Form
    {
        string path = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";
        Setup configSetup = new Setup();
        
        public SparkSqlBackup()
        {
            
            InitializeComponent();
            connectionCheckLbl.Text = "";
            //string path = " ";
            Setup configSetup = new Setup();
            try
            {
                bool configFileExists = File.Exists(path);
                if (configFileExists == true)
                    {
                    this.configCheckLbl.ForeColor = Color.Green;
                    this.configCheckLbl.Text = "Jest config.ini";
                }
                else
                {
                    this.configCheckLbl.ForeColor = Color.Red;
                    this.configCheckLbl.Text = "Brak config.ini";
                    backupBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                string logPath = configSetup.GetInstallationPath() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                

            }

            

        }

        private async void backupBtn_Click(object sender, EventArgs e)
        {

            await Task.Run(() => DoBackup());

        }

        private async Task DoBackup()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";
            Setup configSetup = new Setup();
            bool configFileExists = File.Exists(path);

            try
            {
                configSetup.SetBackupProperties(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = configSetup.GetInstallationPath() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }
            string dataBaseName = configSetup.GetDataBaseName();
            DataBase dataBase = new DataBase(configSetup.GetConnectionString());
            try
            {

                string plikBazy = configSetup.GetPath() + dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".bak";

              

                await DataBaseBackup(dataBase, dataBaseName, plikBazy);
                
                using (ZipArchive zip = ZipFile.Open(configSetup.GetPath() + dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".zip", ZipArchiveMode.Create))
                {
                    await Task.Run(() => zip.CreateEntryFromFile(plikBazy, dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".bak"));
                }
                File.Delete(plikBazy);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = Directory.GetCurrentDirectory() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }
        }

        

        private async Task DataBaseBackup(DataBase _dataBase, string _dataBaseName, string _plikBazy)
        {
            await _dataBase.dbBackupAction("BACKUP DATABASE " + _dataBaseName + " TO DISK =" + "'" + _plikBazy + "'");
            
        }

        private void connectioCheckBtn_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";
            Setup configSetup = new Setup();
            bool configFileExists = File.Exists(path);

            try
            {
                configSetup.SetBackupProperties(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = configSetup.GetInstallationPath() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }

            }
            //string dataBaseName = configSetup.GetDataBaseName();
            DataBase dataBase = new DataBase(configSetup.GetConnectionString());
            
            bool _connectionCheck = dataBase.connectionCheck();

            if (_connectionCheck == true)
            {
                this.connectionCheckLbl.ForeColor = Color.Green;
                this.connectionCheckLbl.Text = "Jest połączenie z bazą";
            }
            else
            {
                this.connectionCheckLbl.ForeColor = Color.Red;
                this.connectionCheckLbl.Text = "Brak połączenia z bazą";
                backupBtn.Enabled = false;
            }


        }
    }
}

