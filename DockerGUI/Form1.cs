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
            String root = @"home\DockerGUI";
            String subdir = @"home\DockerGUI\Dockerfiles";
            String fileName = "";
            bool isPhp = false;
            bool isJava = false;
            bool isCsharp= false;
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
                        bool hasLaravel = false;
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
                        files = from file in Directory.EnumerateFiles(fbd.SelectedPath, "*.php", SearchOption.AllDirectories)
                                    from line in File.ReadLines(file)
                                    where line.Contains(".blade")
                                    select new
                                    {
                                        File = file,
                                        Line = line
                                    };
                        foreach (var f in files)
                        {
                            hasLaravel = true;
                        }
                        if (isPhp == true)
                        {
                            Console.WriteLine("File has been read and confirmed for PhP files");
                            // Creates a file inside the Dockerfile directory. the df_ represents Dockerfile and the filename denotes the project directory name to help identify each Dockerfile created.
                            String path = @"home\DockerGUI\Dockerfiles\df_" + fileName + ".txt";
                            if (!File.Exists(path))
                            {
                                // Starts writting the docker file
                                using (System.IO.StreamWriter sw = File.CreateText(path))
                                {
                                    // Tell debconf to run in non-interactive mode
                                    sw.WriteLine("FROM php:7.3");
                                    sw.WriteLine("ENV DEBIAN_FRONTEND noninteractive");
                                    sw.WriteLine("RUN apt-get update && apt-get install -y \\");
                                    sw.WriteLine("apt-transport-https \\");
                                    sw.WriteLine("ca-certificates \\");
                                    sw.WriteLine("curl \\");
                                    sw.WriteLine("gnupg \\");
                                    sw.WriteLine("git \\");
                                    sw.WriteLine("--no-install-recommends");
                                    // Add the vscode debian repo
                                    sw.WriteLine("RUN curl -sSL https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor | apt-key add -");
                                    sw.WriteLine("RUN echo " + '"' + "deb[arch = amd64] https://packages.microsoft.com/repos/vscode stable main" + '"' + " > /etc/apt/sources.list.d/vscode.list");
                                    sw.WriteLine("RUN apt-get update && apt-get -y install \\");
                                    sw.WriteLine("code \\");
                                    sw.WriteLine("libasound2 \\");
                                    sw.WriteLine("libatk1.0-0 \\");
                                    sw.WriteLine("libcairo2 \\");
                                    sw.WriteLine("libcups2 \\");
                                    sw.WriteLine("libexpat1 \\");
                                    sw.WriteLine("libfontconfig1 \\");
                                    sw.WriteLine("libfreetype6 \\");
                                    sw.WriteLine("libgtk2.0-0 \\");
                                    sw.WriteLine("libpango-1.0-0 \\");
                                    sw.WriteLine("libx11-xcb1 \\");
                                    sw.WriteLine("libxcomposite1 \\");
                                    sw.WriteLine("libxcursor1 \\");
                                    sw.WriteLine("libxdamage1 \\");
                                    sw.WriteLine("libxext6 \\");
                                    sw.WriteLine("libxfixes3 \\");
                                    sw.WriteLine("libxi6 \\");
                                    sw.WriteLine("libxrandr2 \\");
                                    sw.WriteLine("libxrender1 \\");
                                    sw.WriteLine("libxss1 \\");
                                    sw.WriteLine("libxtst6 \\");
                                    sw.WriteLine("--no-install-recommends \\");
                                    sw.WriteLine("&& rm -rf /var/lib/apt/lists/*");
                                    sw.WriteLine("ENV HOME /home/user");
                                    sw.WriteLine("RUN useradd --create-home --home-dir $HOME user \\");
                                    sw.WriteLine("&& mkdir /var/www/html -p \\");
                                    sw.WriteLine("&& chown -R user:user $HOME /var/www/html");
                                    // package vscode extension for PHP dev
                                    sw.WriteLine("ENV VSCODEEXT /var/vscode-ext");
                                    sw.WriteLine("RUN mkdir $VSCODEEXT \\");
                                    sw.WriteLine("&& chown -R user:user $VSCODEEXT \\");
                                    sw.WriteLine("&& su user -c " + '"' + "code --extensions-dir $VSCODEEXT --install-extension felixfbecker.php-intellisense --install-extension felixfbecker.php-debug --install-extension whatwedo.twig --install-extension ikappas.phpcs" + '"'+" \\");
                                    sw.WriteLine("COPY home/DockerGUI/Dockerfile/start.sh /usr/local/bin/start.sh");
                                    sw.WriteLine("WORKDIR /var/www/html");
                                    sw.WriteLine("RUN chmod +x /usr/local/bin/start.sh");
                                    sw.WriteLine("CMD [" + '"' + "start.sh" + '"' + "]");
                                    // Locates the instances of .blade file extension in files in directories
                                    if (hasLaravel == true)
                                    {
                                        Console.WriteLine("File has been read and confirmed for Laravell");
                                        // Laravel Dependancies
                                        // Install dev dependencies
                                        sw.WriteLine("RUN apk add --no-cache --virtual.build-deps");
                                        sw.WriteLine("$PHPIZE_DEPS");
                                        sw.WriteLine("curl-dev");
                                        sw.WriteLine("imagemagick-dev");
                                        sw.WriteLine("libtool");
                                        sw.WriteLine("libxml2-dev");
                                        sw.WriteLine("postgresql-dev");
                                        sw.WriteLine("sqlite-dev");
                                        // Install production dependencies
                                        sw.WriteLine("RUN apk add --no-cache");
                                        sw.WriteLine("bash");
                                        sw.WriteLine("curl");
                                        sw.WriteLine("freetype-dev");
                                        sw.WriteLine("g++");
                                        sw.WriteLine("gcc");
                                        sw.WriteLine("git");
                                        sw.WriteLine("icu-dev");
                                        sw.WriteLine("icu-libs");
                                        sw.WriteLine("imagemagick");
                                        sw.WriteLine("libc-dev");
                                        sw.WriteLine("libjpeg-turbo-dev");
                                        sw.WriteLine("libpng-dev");
                                        sw.WriteLine("libzip-dev");
                                        sw.WriteLine("make");
                                        sw.WriteLine("mysql-client");
                                        sw.WriteLine("nodejs");
                                        sw.WriteLine("nodejs-npm");
                                        sw.WriteLine("yarn");
                                        sw.WriteLine("openssh-client");
                                        sw.WriteLine("postgresql-libs");
                                        sw.WriteLine("rsync");
                                        sw.WriteLine("zlib-dev");
                                        // Install PECL and PEAR extensions
                                        sw.WriteLine("RUN pecl install");
                                        sw.WriteLine("redis");
                                        sw.WriteLine("imagick");
                                        sw.WriteLine("xdebug");
                                        // Enable PECL and PEAR extensions
                                        sw.WriteLine("RUN docker-php - ext - enable");
                                        sw.WriteLine("redis");
                                        sw.WriteLine("imagick");
                                        sw.WriteLine("xdebug");
                                        // Configure php extensions
                                        sw.WriteLine("RUN docker-php-ext-configure gd --with-freetype-dir = /usr/include/ --with-jpeg-dir = /usr/include/");
                                        sw.WriteLine("&& docker-php-ext-configure zip --with-libzip");
                                        // Install php extensions
                                        sw.WriteLine("RUN docker-php-ext-install");
                                        sw.WriteLine("bcmath");
                                        sw.WriteLine("calendar");
                                        sw.WriteLine("curl");
                                        sw.WriteLine("exif");
                                        sw.WriteLine("gd");
                                        sw.WriteLine("iconv");
                                        sw.WriteLine("intl");
                                        sw.WriteLine("mbstring");
                                        sw.WriteLine("pdo");
                                        sw.WriteLine("pdo_mysql");
                                        sw.WriteLine("pdo_pgsql");
                                        sw.WriteLine("pdo_sqlite");
                                        sw.WriteLine("pcntl");
                                        sw.WriteLine("tokenizer");
                                        sw.WriteLine("xml");
                                        sw.WriteLine("zip");
                                        // Install composer
                                        sw.WriteLine("ENV COMPOSER_HOME/composer");
                                        sw.WriteLine("ENV PATH./vendor/ bin:/composer/vendor/bin:$PATH");
                                        sw.WriteLine("ENV COMPOSER_ALLOW_SUPERUSER 1");
                                        sw.WriteLine("RUN curl -s https://getcomposer.org/installer | php -- --install-dir=/usr/local/bin/ --filename=composer");
                                        // Install PHP_CodeSniffer
                                        sw.WriteLine("RUN composer global require " + '"' + "squizlabs/php_codesniffer = *" + '"');
                                        // Cleanup dev dependencies
                                        sw.WriteLine("RUN apk del -f .build-deps");
                                        // Setup working directory
                                        sw.WriteLine("WORKDIR /var/www");

                                    }
                                }
                            }
                            else
                            {
                                string EImessage = "An image for this file already exsists";
                                string EIcaption = "Exsisting Image";
                                MessageBoxButtons EIbutton = MessageBoxButtons.OK;
                                MessageBox.Show(EImessage, EIcaption, EIbutton);
                            }
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
                    }
                    catch (PathTooLongException pathEx)
                    {
                        Console.WriteLine(pathEx.Message);
                    }
                    // Build Docker file from newly created image file
                    var processInfo = new ProcessStartInfo("docker", $"build -f home/DockerGUI/Dockerfile/" + fileName);

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
    }
}