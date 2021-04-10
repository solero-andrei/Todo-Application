using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace TodoClassLibrary
{
    public class AudioDirectories
    {
        #region Methods

        /// <summary>
        /// Returns all the audio sounds present on the "My Documents\All Day List\" folder
        /// </summary>
        /// <returns>All audio sounds</returns>
        private List<string> Audio()
        {
            CreateDirectory(); //This will automatically create a directory in the "My Documents" Folder before the audio will be uploaded to the program

            List<string> audio = new List<string>();
            DirectoryInfo directory = new DirectoryInfo(path);  
            FileInfo[] files = directory.GetFiles("*.*");

            foreach (FileInfo file in files)
            {
                audio.Add(file.ToString());
            }

            return audio;
        }
        
        /// <summary>
        /// This will create a directory on the "My Documents" Folder on the machine that will store all the sound
        /// </summary>
        private void CreateDirectory()
        {
            Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Method for adding a sound to created directory
        /// </summary>
        /// <param name="Path">Path of your selected files/sounds</param>
        public void AddAudioToFolder(params FileInfo[] Path)
        {
            for (int i = 0; i < Path.Length; i++)
            {
                string sourcePath = Path[i].FullName; //Path of the original audio file presented on the bin/debug folder
                string destinationPath = path + "\\" + Path[i].Name; //Path of the destination for the original audio file to be moved
                if (!File.Exists(destinationPath))
                {
                    File.Copy(sourcePath, destinationPath); //copies the original audio file to the destination path
                }

                Audio().Add(Path[i].ToString());
            }
        }

        #endregion

        #region Class Fields

        public static List<string> AudioList
        {
            get
            {
                AudioDirectories a = new AudioDirectories();
                return a.Audio();
            }
        }
        internal string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\All Day List\\App\\Data\\Audios\\";

        #endregion

    }
}
