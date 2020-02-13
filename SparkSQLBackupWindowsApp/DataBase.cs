using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;


namespace SparkSQLbackupWindowsApp
{
    class DataBase
    {
        private string connectionString = "";

        public DataBase(string _connectionString)
        {
            this.connectionString = _connectionString;
        }

        public void dbBackupAction(string _path)
        {
            
            Setup setup = new Setup();
            try
            {
                setup.SetBackupProperties(System.IO.Directory.GetCurrentDirectory() + "\\config.ini");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = setup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                }
                //  Console.ReadLine();
                System.Environment.Exit(0);
            }
            Console.WriteLine("Tworzenie backup bazy. Proszę czekać");
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
                Console.WriteLine(ex.ToString());
                string logPath = setup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                File.WriteAllText(logPath, ex.ToString());
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                }
                System.Environment.Exit(0);
                // Console.ReadLine();
            }
            Console.WriteLine("Zakończono tworzenie backup bazy");

        }
        

    }
}
