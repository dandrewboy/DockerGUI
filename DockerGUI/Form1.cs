using DockerGUI.Service;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
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
            ImageManager cManager = new ImageManager();
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
            PowerShellService pss = new PowerShellService();
            bool isPhp = false;
            bool isJava = false;
            bool isCsharp = false;
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
                    try
                    {
                        // Reads the contents of the files in the directory that are php files and looks for any files with ".blade" in its contents. This will be used to identify if a project is using the Laravel
                        // framework so the propper dependancies can be added. 
                        var files = from file in Directory.EnumerateFiles(fbd.SelectedPath, "*.php", SearchOption.AllDirectories)
                                    from line in File.ReadLines(file)
                                    where file.Contains(".php")
                                    select new
                                    {
                                        File = file,
                                        Line = line
                                    };
                        foreach (var f in files)
                        {
                            isPhp = true;
                        }
                        if (isPhp == true)
                        {
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
                            pss.addImageAsync();
                            pss.addContainerAsync();
                            process.Close();
                        }
                        else
                        {
                            string UFTmessage = "This file is unsupported by this application, please select a new file.";
                            string UFTcaption = "Unsupported File Type";
                            MessageBoxButtons UFTbutton = MessageBoxButtons.OK;
                            MessageBox.Show(UFTmessage, UFTcaption, UFTbutton);
                            MessageBox.Show(UFTmessage, UFTcaption, UFTbutton);
                        }
                    }
                    
                    catch (UnauthorizedAccessException uAEx)
                        {
                        Console.WriteLine(uAEx.Message); 
                        string UAXmessage = "Current user does not have access to the specified file.";
                        string UAXcaption = "Unauthorized Access";
                        MessageBoxButtons UAXbutton = MessageBoxButtons.OK;
                        MessageBox.Show(UAXmessage, UAXcaption, UAXbutton);
                        MessageBox.Show(UAXmessage, UAXcaption, UAXbutton);
                    }
                    catch (PathTooLongException pathEx)
                        {
                        Console.WriteLine(pathEx.Message);
                        string PTLmessage = "Specified file path is too long.";
                        string PTLcaption = "Unauthorized Access";
                        MessageBoxButtons PTLbutton = MessageBoxButtons.OK;
                        MessageBox.Show(PTLmessage, PTLcaption, PTLbutton);
                        MessageBox.Show(PTLmessage, PTLcaption, PTLbutton);
                    }
                }
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}