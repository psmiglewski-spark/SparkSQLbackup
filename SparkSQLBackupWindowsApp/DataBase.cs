using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using SparkSQLBackupWindowsApp;

namespace SparkSQLbackupWindowsApp
{
    class DataBase
    {
        private string connectionString = "";

        public DataBase(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        public async Task dbBackupAction(string _path)
        {

            Setup setup = new Setup();
            try
            {
               await Task.Run(() => setup.SetBackupProperties(System.IO.Directory.GetCurrentDirectory() + "\\config.ini"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                string logPath = setup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
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
           
            try
            {
               
                using (SqlConnection defaultSqlConnection = new SqlConnection(connectionString))
                {
                    string backupDb = _path;

                    using (SqlCommand backupCommand = new SqlCommand(backupDb, defaultSqlConnection))
                    {
                        defaultSqlConnection.Open();
                        backupCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                string logPath = setup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
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
            
           // MessageBox.Show("Zakończono tworzenie backup bazy");

        }
        
        

    }
}
