﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;

namespace SparkSQLbackup
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = " ";
            Setup configSetup = new Setup();
            try
            {
                path = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";//Path.Combine(Directory.GetCurrentDirectory(), "\\config.ini");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = configSetup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
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
                // Console.ReadLine();
                System.Environment.Exit(0);
               
            }
            // string _filePath = path;//"C:\\Temp\\"+ dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".bak";
            try
            {
                configSetup.SetBackupProperties(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                string logPath = configSetup.GetInstallationPath() + "faillog" + DateTime.Now.ToString("yyMMddhhmm") + ".txt";
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
                //   Console.ReadLine();
                System.Environment.Exit(0);
            }
            string dataBaseName = configSetup.GetDataBaseName();
            DataBase dataBase = new DataBase(configSetup.GetConnectionString());
            try
            {
                
                string plikBazy = configSetup.GetPath() + dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".bak";
                dataBase.dbBackupAction("BACKUP DATABASE " + dataBaseName + " TO DISK =" + "'" + plikBazy + "'" );
                
                using (ZipArchive zip = ZipFile.Open(configSetup.GetPath() + dataBaseName + DateTime.Now.ToString("yyMMddhhmm") +".zip", ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(plikBazy, dataBaseName + DateTime.Now.ToString("yyMMddhhmm") + ".bak");
                }
                File.Delete(plikBazy);
                //  System.IO.Compression.ZipFile.CreateFromDirectory(configSetup.GetPath() + dataBaseName + DateTime.Now.ToString("yyMMdd") + ".bak", zipPath);
                //System.IO.Compression.ZipFile.
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
                    Console.WriteLine(exc.ToString());
                }
                System.Environment.Exit(0);
                //  Console.ReadLine();
            }
          
        }
    }
}
