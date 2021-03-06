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
        public void removeImage(string imgName)
        {
            // Create an empty process 
            Process process;
            // Set the process to be a single instance of Powershell with a docker remove command for an image
            ProcessStartInfo processInfo = new ProcessStartInfo($@"C:\Windows\system32\WindowsPowerShell\v1.0\powershell.exe", $@"docker rmi " + imgName);

            // Parameters for the process instance, CreateNoWindow is commented out for testing purposes
            //processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            process = Process.Start(processInfo);

            //the line below locks the original form window until the powershell window is closed
            //process.WaitForExit();
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

            //the line below locks the original form window until the powershell window is closed
            //process.WaitForExit();
            process.Close();

        }
    }
}
