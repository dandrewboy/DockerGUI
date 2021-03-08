using System;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows.Forms;
using PowerShell = System.Management.Automation.PowerShell;

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
                }
                // Create an empty process 
                Process process;
                // Set the process to be a single instance of Powershell with a Docker command
                ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker run -it --rm -p 8081:8080 -e PASSWORD=test -v " + fbd.SelectedPath + " --name vscode codercom/code-server");

                // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
                //processInfo.CreateNoWindow = true;
                processInfo.UseShellExecute = false;
                process = Process.Start(processInfo);

                //the line below locks the original form window until the powershell window is closed
                process.WaitForExit();
                process.Close();
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}