﻿using System.IO;
using System.Reflection;

namespace EmergenceGuardian.FFmpeg {
    public static class FFmpegConfig {
        /// <summary>
        /// Gets or sets the path to FFmpeg.exe
        /// </summary>
        public static string FFmpegPath { get; set; } = "ffmpeg.exe";
        /// <summary>
        /// Gets or sets the path to avs2yuv.exe to use AviSynth in a separate process.
        /// </summary>
        public static string Avs2yuvPath { get; set; } = "avs2yuv.exe";
        /// <summary>
        /// Gets or sets a class that will manage graphical interface instances when DisplayMode = Interface
        /// </summary>
        public static UserInterfaceManagerBase UserInterfaceManager { get; set; }
        /// <summary>
        /// Occurs when a process needs to be closed. This needs to be managed manually for Console applications.
        /// See http://stackoverflow.com/a/29274238/3960200
        /// </summary>
        public static CloseProcessEventHandler CloseProcess;

        internal static string ApplicationPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        internal static string FFmpegPathAbsolute => Path.IsPathRooted(FFmpegPath) ? FFmpegPath : Path.Combine(ApplicationPath, FFmpegPath);
        internal static string Avs2yuvPathAbsolute => Path.IsPathRooted(Avs2yuvPath) ? Avs2yuvPath : Path.Combine(ApplicationPath, Avs2yuvPath);
    }
}
