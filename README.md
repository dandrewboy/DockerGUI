# DockerGUI
## Abstract
  The main goal this project aims to achieve is to offer a solution to helping use and manage the Docker software. Docker normally runs off the command line, which to some users can be difficult to use if they’re not familiar with using the command line. It also becomes difficult to manage multiple containers at the same time. With this project a user can open a container for any project they might have and manage and organize multiple containers being able to create containers for additional projects and delete containers for project they have since finished working on. 
## High Level/Non-Functional Requirments
### High Level Requirments
- Setting up the GUI
	- Allows for the user to have an easy-to-understand interface for interacting with Docker.
- Opening/Reading Files
  - Allows users to select a project file.
  - Application reads the file and identifies languages and technologies used.
- Communicate with Docker.
  - Application sends docker commands on behalf of the user.
  - This involves running, managing, and deleting containers and images.
- Manage Containers
  - Displays a list of containers so users know what’s currently running.
  - Selecting a container gives the option for the user to delete a container.
- PhP/Java/C# Support
  - Allows the user to make containers for PhP, Java, and C# applications

### Non-Functional Requirments
- Manage Images
  - Allows the user to manage multiple containers.
  - Allows for the use of multiple IDE's and other technologies.
- Preference Settings
  - Allows the user to use a preferred IDE for specific languages.
  - Can also be used for preferred Database services.

## Technologies
- Docker Desktop v3.2.2
> Note: This version of Docker was built to work for Windows, allowing for PowerShell to run docker.
> Should versions of this application be created for use on another OS Docker Desktop is not specifically
> required for the application to work.
- Visual Studio 2019 v16.8.4
- .NET Core v5.0
- .NET Framework v3.0
> Note: >NET Core & .NET Framework where used to support the specific C# framework I was using for the application.
> A version not using C# or the .NET framework would not need these to run the application
- VMware Workstation Player v16.1.1
> Note: I had to use VMware due to some technical difficulties during development and therfore not required to run the application
## Technical Approach
Before I began working on the code I wanted to get a vauge idea on what the application would look like. These wireframes where used as a way to help visualize the application and give an idea on what each page would need such as buttons, grid veiws, and other user interface objects.
![Wireframes for the three forms](https://github.com/dandrewboy/CapstonePortfolio/blob/main/DockerGUI%20V.2.png)

Next I would determine the logical flow of teh application. Utilizing a flow chart I was able to map out where a user would need to make a choice, navigating to another form as an example. Then I would write out what the application would need to do in order to accomplish the task the user wanted to do.
![Flowchart for the application](https://github.com/dandrewboy/CapstonePortfolio/blob/main/DockerGUICoreFunctionFlowchart.png)

Finally, I would begin to layout how the logic would be built. Using a UML diagram as a blueprint for the classes seperated out the logic for interacting with Docker to a Service class and had the forms call its methods to delete containers and images.
![UML Diagram for the application](https://github.com/dandrewboy/CapstonePortfolio/blob/main/MainWindowUML%20(1).png)
> Note: The Main Page of the application makes calls to the Command Line outside of the service class. This was leftover from initial testing during the early stages of
> development. It was intended to move the logic for creating containers into the service class at the end of development.
## Risks & Challenges
- Issues working with diffrent Operating Systems
  - I had attempted to use both Windows 10 and Linux Ubuntu
  - I was unaware at the time that Ubuntu was not compatable with the .NET Framework
  - This lead me to switch back to Windows 10
- Issues with Virtual Machines
  - Due to some technical issues with my host machine I had to use a Virtual Machine in order to run Docker propperly.
  - This made testing take longer since I had to download a copy of my application to the Virtual Machine before I could propperly test it.
- Issues with Docker Images
  - I had tried to use Ubuntu based images in the begining of development in trying to have multiple images for diffrent IDEs
  -  Since my application was incompatable with Linux based system I had to switch to using Windows 10 based images
  -  Becasue of this I only had the one image for vscode
## Outstanding Issues
For this current iteration of tha application it is unable to utalize ant additional docker images preventing the use of the preset function of the application and does not allow the user any real customization. Additionally, the user can not utalize a databse which many application use thus making it difficult to run these application in the container. Finally, thes application only supports three languages. This is very limiting for developers who may be using other languages such as C++ or JavaScript.
