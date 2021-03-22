using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Management.Automation;
using System.Text;

namespace DockerGUI.Service
{
    class PowerShellService
    {
        public async System.Threading.Tasks.Task<Collection<PSObject>> addImageAsync()
        {
            // Start an instance of Power Shell
            using (PowerShell ps = PowerShell.Create())
            {
                // Set Commands and Parameters for Power Shell
                ps.AddCommand("Set-ExecutionPolicy")
                  .AddParameter("ExecutionPolicy", "Bypass")
                  .AddParameter("Scope", "Process")
                  .AddParameter("Force");

                // Add script to retrive a list of Images from Power Shell
                ps.AddCommand(@"docker image ls");

                Collection<PSObject> result = ps.Invoke();
                // outputObject contains the result of the powershell script
                foreach (var outputObject in result)
                {
                    // Testing for a successful retrival of the image list
                    using StreamWriter file = new StreamWriter("ImageListTest.txt");
                    string container = outputObject.ToString();
                    await file.WriteLineAsync(container);
                }
                return result;
            }
        }

        public async System.Threading.Tasks.Task<Collection<PSObject>> addContainerAsync()
        {
            // Start an instance of Power Shell
            using (PowerShell ps = PowerShell.Create())
            {
                // Set Commands and Parameters for Power Shell
                ps.AddCommand("Set-ExecutionPolicy")
                  .AddParameter("ExecutionPolicy", "Bypass")
                  .AddParameter("Scope", "Process")
                  .AddParameter("Force");

                // Add script to retrive a list of Containers from Power Shell
                ps.AddCommand(@"docker container ls");

                Collection<PSObject> result = ps.Invoke();
                // outputObject contains the result of the powershell script
                foreach (var outputObject in result)
                {
                    // Testing for successful retrival of the container list
                    using StreamWriter file = new StreamWriter("ContainerListTest.txt");
                    string container = outputObject.ToString();
                    await file.WriteLineAsync(container);
                }
                return result;
            }
        }

        public void removeImage(string imgName)
        {
            // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for an image
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"");

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

            //the line below locks the original form window until the powershell window is closed
            process.Close();
        }

        public void removeContainer(string conName)
        {
            // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for a container
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"");

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

            //the line below locks the original form window until the powershell window is closed
            process.Close();

        }
    }
}
