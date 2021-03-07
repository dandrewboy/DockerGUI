using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerGUI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Click event for the Container Manager navigation button
        private void b_ContainerManager_Click(object sender, EventArgs e)
        {
            ContainerManager cManager = new ContainerManager();
            cManager.Show();
            Hide();
        }

        // Click event for the Presets navigation button
        private void b_Presets_Click(object sender, EventArgs e)
        {
            Presets preset = new Presets();
            preset.Show();
            Hide();
        }

        // Click event for the Open File button
        private void b_OpenFile_Click(object sender, EventArgs e)
        {
            // File paths for the applications directory and subdirectory
            String root = @"C:\DockerGUI";
            String subdir = @"C:\DockerGUI\Dockerfiles";
            String fileName = "";
            // If the root directory doesn't exsist the root directory is created
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            // If the subdirectory doesn't exsist the subdirectory is created
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            // Create FolderBroswerDialog, allowing the user to select all the files within a directory. From here we can access all the files within a project directory to help construct the Docker File.
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                // Checks to see if the a project directory was selected and that it is not white space or null. 
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Console.WriteLine("File has been recived");
                    fileName = Path.GetFileName(fbd.SelectedPath);
                  
                    // Build Docker file from newly created image file
                    var processInfo = new ProcessStartInfo("docker", $"run -it --rm -p 8081:8080 -e PASSWORD=test -v " + fileName + $" --name vscode codercom/code-server" );

                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    processInfo.RedirectStandardOutput = true;
                    processInfo.RedirectStandardError = true;

                    int exitCode;
                    using (var process = new Process())
                    {
                        //DataReceivedEventHandler dreh = new DataReceivedEventHandler();

                        //process.StartInfo = processInfo;
                        //process.OutputDataReceived += dreh;
                        //process.ErrorDataReceived += dreh;

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit(1200000);
                        if (!process.HasExited)
                        {
                            process.Kill();
                            string UBEmessage = "An Unexpected error occured during the build preocess.";
                            string UBEcaption = "Unexpectd Build Error";
                            MessageBoxButtons UBEbutton = MessageBoxButtons.OK;
                            MessageBox.Show(UBEmessage, UBEcaption, UBEbutton);
                            MessageBox.Show(UBEmessage, UBEcaption, UBEbutton);
                        }
                        string BSmessage = "An Unexpected error occured during the build preocess.";
                        string BScaption = "Unexpectd Build Error";
                        MessageBoxButtons BSbutton = MessageBoxButtons.OK;
                        MessageBox.Show(BSmessage, BScaption, BSbutton);
                        MessageBox.Show(BSmessage, BScaption, BSbutton);

                        exitCode = process.ExitCode;
                        process.Close();
                    }

                }
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}