using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace JavaInstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            checkForResources();
        }

        private void closeProgram()
        {
            this.Close();
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            installJava();
            this.Close();
        }




        // Check For Resources
        public void checkForResources()
        {

            string strOutput = findJavaVersion();
            strOutput = strOutput.Split('.')[0];

            Console.WriteLine("\n" + strOutput);

            if(!(strOutput.Contains("15")) || strOutput == null)
            {
                this.installButton.Enabled = true;
            }            
        }

        // Download
        private void installJava()
        {
            string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
            Process.Start("notepad.exe", download + "\\InstallApp\\java_15.txt");
        }

        private string findJavaVersion()
        {
            String output = "";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "java.exe";
                psi.Arguments = " -version";
                psi.RedirectStandardError = true;
                psi.UseShellExecute = false;

                Process pr = Process.Start(psi);
                output = pr.StandardError.ReadLine().Split(' ')[2].Replace("\"", "");

                return output;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex is: " + ex.Message);
            }

            return output;
        }
    }
}
