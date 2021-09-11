﻿using System;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Threading.Tasks;

namespace MediaPlayer
{
    /// <summary>
    /// This class is responsible for the media behavior 
    /// </summary>
    public class MediaViewModel : ObservableObject
    {
        #region Media Properties 
        public bool MediaLoaded { get; set; } = true;

        public static Uri MediaSource { get; set; }

        public MediaState Load { get; set; }

        public Stretch AspectRatio { get; set; } = Stretch.Uniform;

        #endregion

        #region Constructor 

        public MediaViewModel()
        {

            LoadMedia();

            UnLoadSpinner();

            //// create timer instance 
            //DispatcherTimer Timer = new DispatcherTimer();

            //// start in 1s 
            //Timer.Interval = TimeSpan.FromSeconds(1);

            //// tick clock 
            //Timer.Tick += Timer_Tick;

            //// Start clock
            //Timer.Start();
        }

        #endregion

        #region Media Controls 

        /// <summary>
        /// Plays current media
        /// </summary>
        public static void Play()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pauses current media 
        /// </summary>
        public static void Pause()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stops current media
        /// </summary>
        public static void Stop()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Skips to the next media on playlist
        /// </summary>
        public static void Next()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Plays previous media on playlist
        /// </summary>
        public static void Previous()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Skips media's duration 
        /// </summary>
        public static void Forward()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Rewinds media's duration
        /// </summary>
        public static void Rewind()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Increases the media's volume 
        /// </summary>
        public static void VolumeUp()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Decreases the media's volume 
        /// </summary>
        public static void VolumeDown()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Helpers 

        private void LoadMedia()
        {
            Load = MediaState.Play;
        }

        private void UnLoadSpinner()
        {
            MediaLoaded = false;
        }

        /// <summary>
        /// Runs the media timer and updates media progress slider every second 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves current media to recently played 
        /// </summary>
        private void SaveCurrentMediaToRecentlyPlayed()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
