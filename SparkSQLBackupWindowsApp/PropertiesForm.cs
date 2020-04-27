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

namespace SparkSQLBackupWindowsApp
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void savePropertiesBtn_Click(object sender, EventArgs e)
        {
            var path = System.IO.Directory.GetCurrentDirectory() + "\\config.ini";
            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    using (StreamWriter fw = new StreamWriter(fs))
                    {
                        
                        fw.WriteLine(StringToHash.Encrypt(connectionStringTxtBox.Text,"a"));
                        fw.WriteLine(StringToHash.Encrypt(destinationPathTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(dbNameTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(destinationEmailTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(senderTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(smtpTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(smtpLoginTxtBox.Text, "a"));
                        fw.WriteLine(StringToHash.Encrypt(smtpPasswordTxtBox.Text, "a"));
                    }
                }

                MessageBox.Show("Plik konfiguracyjny zapisany");
                this.Close();
                // File.Encrypt(path);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }


        }
    }
}
