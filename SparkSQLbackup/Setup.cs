using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace SparkSQLbackup
{
    class Setup
    {
        private string connectionString ;
        private string path ;
        private string dataBaseName;
        //private string installationPath;

        //public Setup(string _connectionString, string _path)
        // {
        //   this.connectionString = _connectionString;
        //   this.path = _path;
        // }
        
        public void SetBackupProperties(string _filePath)
        {
          //  string lineOfText;
            try
            {
                List<string> list = new List<string>();
                // var filestream = new System.IO.FileStream(_filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
                // var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
                string[] Name = { " " };

                try
                {
                   Name = File.ReadAllLines(_filePath, Encoding.Default);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                    File.WriteAllText(Directory.GetCurrentDirectory() + "\\faillog" + DateTime.Now.ToString() + ".txt", exc.ToString());
                    string logPath = Directory.GetCurrentDirectory() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                    try
                    {
                        Email email = new Email();
                        email.SendEmail(logPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        
                    }
                  //  Console.ReadLine();
                }
                for (int i = 0; i < Name.Length; i++)
                {
                    list.Add(Name[i]);
                    // Console.WriteLine(Name[i]);
                }
                this.connectionString = list[0];
                this.path = list[1];
                this.dataBaseName = list[2];
                //this.installationPath = list[3];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                File.WriteAllText(Directory.GetCurrentDirectory() + "\\faillog" + DateTime.Now.ToString() + ".txt", ex.ToString());
                string logPath = Directory.GetCurrentDirectory() + "\\faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
                try
                {
                    Email email = new Email();
                    email.SendEmail(logPath);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.ToString());

                }
                //  Console.ReadKey();
            }
        }

        public string GetConnectionString()
        {
            return connectionString;
        }
        public string GetPath()
        {
            return path;
        }
        public string GetDataBaseName()
        {
            return dataBaseName;
        }
        public string GetInstallationPath()
        {
            return System.IO.Directory.GetCurrentDirectory();
        }
       
    }
}
