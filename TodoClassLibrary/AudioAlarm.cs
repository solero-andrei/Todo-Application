using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;


namespace TodoClassLibrary
{
    public class AudioAlarm : AudioDirectories, IAudioCommand
    {
        #region Class Fields

        static WindowsMediaPlayer player = new WindowsMediaPlayer();

        #endregion

        #region Functions

        /// <summary>
        /// Plays the selected sound
        /// </summary>
        /// <param name="filename">Filename can be .mp3 or .wav file extension</param>
        public void Play(string filename)
        {
            player = new WindowsMediaPlayer();
            player.URL = path + "\\" + filename;
            player.controls.play();
        }

        /// <summary>
        /// Stop the current sound that is playing
        /// </summary>
        public void Stop()
        {
            player.controls.stop();
        }

        #endregion
    }
}
