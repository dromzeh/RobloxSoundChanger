using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RobloxSoundChanger
{
    public partial class Form1 : Form
    {
        public string mostrecentversion;
        public string mp3File;

        public Form1()
        {
            InitializeComponent();
        }

        private void autoLocateButton_Click(object sender, EventArgs e)
        {
            // attempt to automatically locate the most recent roblox installation.
            string directory = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Roblox\Versions\";
            // Console.WriteLine(directory);
            try
            {
                if (Directory.Exists(directory))
                {
                    var dir = new DirectoryInfo(directory);
                    // look for the most recent created file.
                    string mostrecentversion = directory + dir.GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).First().ToString(); ;
                    MessageBox.Show("Found the roblox directory and most recent version: " + mostrecentversion);
                    robloxLocationBtn.Text = mostrecentversion;

                }
                else
                {
                    MessageBox.Show("Unable to locate your Roblox folder, please enter it manually.", "Roblox Sound Changer");
                }
            }
            catch
            {
                MessageBox.Show("Unable to locate your Roblox folder, please enter it manually.", "Roblox Sound Changer");
            }

        }

        private void robloxLocationBtn_Click(object sender, EventArgs e)
        {
            // select version folder
            FolderBrowserDialog robloxDir = new FolderBrowserDialog();
            robloxDir.Description = @"Location should look like C:\Users\username\AppData\Local\Roblox\Versions\";
            try
            {
                if (robloxDir.ShowDialog() == DialogResult.OK)
                {
                    string chosenRobloxDir = robloxDir.SelectedPath;
                    var robloxDirNew = new DirectoryInfo(chosenRobloxDir);
                    string mostrecentversion = chosenRobloxDir + robloxDirNew.GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).First().ToString(); ;
                    MessageBox.Show("Setting " + mostrecentversion + "as most recent version.");
                    robloxLocationBtn.Text = mostrecentversion;
                }
                else
                {
                    MessageBox.Show("An error occured and was unable to check for directories.", "Roblox Sound Changer");
                }
            } catch // incase a directory with no folders inside was entered..
            {
                MessageBox.Show("An error occured and was unable to check for directories.", "Roblox Sound Changer");
            }

        }

        private void mp3fileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog mp3fileLocation = new OpenFileDialog();
            if (mp3fileLocation.ShowDialog() == DialogResult.OK)
            {
                string mp3File = mp3fileLocation.FileName;

                if (mp3File.Contains("ogg"))
                {
                    MessageBox.Show("Selected the ogg file as " + mp3File + ".");
                    mp3fileBtn.Text = mp3File;
                }
                else
                {
                    MessageBox.Show("The file " + mp3File + " is not an ogg.");
                }
            }
        }

        private void githubLabel_Click(object sender, EventArgs e)
        {
            // open a URL into the web browser.
            System.Diagnostics.Process.Start("http://github.com/dromzeh/robloxsoundchanger");
        }

        public void updateButton_Click(object sender, EventArgs e)
        {
            string mostrecentversion = robloxLocationBtn.Text;
            string mp3File = mp3fileBtn.Text;
            updateTheFile(mostrecentversion, mp3File);
        }


        public void updateTheFile (string mostrecentversion, string mp3File)
        {
            Console.WriteLine(mostrecentversion + mp3File);

            if (!string.IsNullOrEmpty(mostrecentversion) && !string.IsNullOrEmpty(mp3File))
            {
                // check if ouch.ogg exists in the most recent version\content\sounds.
                string ouch = mostrecentversion + @"\content\sounds\ouch.ogg";

                if (File.Exists(ouch))
                {
                    // if it does, delete it.
                    File.Delete(ouch);
                }

                // get the file name of the ogg file.
                string mp3FileName = Path.GetFileName(mp3File);

                // move the ogg file mostrecentversion\content\sounds
                string mp3FilePath = mostrecentversion + @"\content\sounds\" + mp3FileName;

                // copy the ogg file to the mp3FilePath.
                File.Copy(mp3File, mp3FilePath, true);

                // rename the moved ogg file to ouch.ogg.
                File.Move(mp3FilePath, ouch);

                MessageBox.Show("The ogg file "+ mp3File +" has been updated and moved.");

            }
            else
            {
                MessageBox.Show("There are no selected file locations.");
            }

        }
    
    }
}
