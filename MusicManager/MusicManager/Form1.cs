using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Id3;

namespace MusicManager
{
    public partial class Form1 : Form
    {

        FolderBrowserDialog fdgSource, fdgDestination;

        public Form1()
        {
            InitializeComponent();

            //Step1: Get the root of the directory containing the music files
            
            fdgSource = new FolderBrowserDialog()
            {
                Description = "Please select the source folder",
                ShowNewFolderButton = false                
            };

            fdgDestination = new FolderBrowserDialog()
            {
                Description = "Please select the destination folder",
                ShowNewFolderButton = true
            };

        }

        private void txtSource_Click(object sender, EventArgs e)
        {
            if (fdgSource.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = fdgSource.SelectedPath;
            }
        }

        private void txtDestination_Click(object sender, EventArgs e)
        {
            if (fdgDestination.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = fdgDestination.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get all the files that are mp3
            string[] FileList = Directory.GetFiles(txtSource.Text, "*.mp3", SearchOption.AllDirectories);
            foreach (string originalFile in FileList)
            {
                var file = new Mp3(originalFile);

                Id3Tag tags = file.GetTag(Id3TagFamily.Version2X);
                
                string artist = tags.Artists;
                string fullAlbumDesc = $"{tags.Year.Value} - {tags.Album.Value}";
                string fileName = RemoveInvalidChars($"{tags.Track.Value} - {tags.Title.Value}.mp3");
                string destination = $"{fdgDestination.SelectedPath}//{artist}//{fullAlbumDesc}//{fileName}";

                System.IO.Directory.CreateDirectory(destination);
                System.IO.File.Copy(originalFile, destination );
            }
        }

        private string RemoveInvalidChars(string source)
        {
            var invalidChars = Path.GetInvalidFileNameChars();

            return new string(source
              .Where(x => !invalidChars.Contains(x))
              .ToArray());
        }
    }
}
