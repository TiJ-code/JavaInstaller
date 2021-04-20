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
                this.label1.ForeColor = System.Drawing.Color.Red;
                this.label1.Text = "Ihre Version ist älter als die Notewendige. Bitte drücken Sie den Blauen Button.";
            }

            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Text = "Sie haben die aktuelle Java Version";
        }

        // Download
        private void installJava()
        {
            string download = Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads";
            Process proc = new Process();

            try
            {
                proc.StartInfo.UseShellExecute = false;

                proc.StartInfo.FileName = download + "\\InstallApp\\java_15.exe";
                proc.Start();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
