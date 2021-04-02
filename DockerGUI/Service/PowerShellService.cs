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
            // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for an image
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker image ls");

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

              Collection<PSObject> result = process;
                // outputObject contains the result of the powershell script
                foreach (var outputObject in result)
                {
                    // Testing for successful retrival of the container list
                    using StreamWriter file = new StreamWriter("C:\\Test\\ImageListTest.txt");
                    string container = outputObject.ToString();
                    await file.WriteLineAsync(container);
                }
            //the line below locks the original form window until the powershell window is closed
            process.Close();
            return result;
        }

        public async System.Threading.Tasks.Task<Collection<PSObject>> addContainerAsync()
        {
             // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for an image
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker container ls");

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

              Collection<PSObject> result = process;
                // outputObject contains the result of the powershell script
                foreach (var outputObject in result)
                {
                    // Testing for successful retrival of the container list
                    using StreamWriter file = new StreamWriter("C:\\Test\\ContainerListTest.txt");
                    string container = outputObject.ToString();
                    await file.WriteLineAsync(container);
                }
            //the line below locks the original form window until the powershell window is closed
            process.Close();
            return result;
            
        }

        public void removeImage(string imgName)
        {
            // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for an image
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker image rmi " + imgName +":latest");

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
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker stop " + conName);

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

            processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker rm -v " + conName);
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

            //the line below locks the original form window until the powershell window is closed
            process.Close();

        }
    }
}
