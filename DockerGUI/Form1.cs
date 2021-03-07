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
            string filePath = "";
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
                    filePath = subdir + "\\" + fileName + "_df.ps1";
                    if (!Directory.Exists(filePath)) 
                    {
                        FileStream fs = File.Create(filePath);
                        fs.Close();
                    }

                    // Construct an empty InitialSessionState
                    //InitialSessionState iss = InitialSessionState.Create($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe");
                    // Add Docker run command to the session
                    //SessionStateScriptEntry script = new SessionStateScriptEntry("docker run -it --rm -p 8081:8080 -e PASSWORD=test -v " + fbd.SelectedPath + " --name vscode codercom/code-server");
                    //iss.Commands.Add(script);

                    // Open Runspace
                    //using (Runspace runSpace = RunspaceFactory.CreateRunspace(iss))
                    //{
                    //    runSpace.Open();
                    //    using (PowerShell ps = PowerShell.Create())
                    //    {
                    //        ps.Runspace = runSpace;
                    //        ps.AddScript("docker run -it --rm -p 8081:8080 -e PASSWORD=test -v " + fbd.SelectedPath + " --name vscode codercom/code-server");
                    //        ps.Invoke();
                    //    }
                    //}

                }
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    file.Write("docker run -it --rm -p 8081:8080 -e PASSWORD=test -v " + fbd.SelectedPath + " --name vscode codercom/code-server");
                    file.Close();
                }

                Process process;
                ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"" + filePath);

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