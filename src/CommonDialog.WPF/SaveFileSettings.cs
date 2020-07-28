using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public class SaveFileSettings : ISaveFileSettings
    {
        public bool CreatePrompt { get; set; }
        public bool OverwritePrompt { get; set; }
        public bool AddExtension { get; set; }
        public bool CheckFileExists { get; set; }
        public bool CheckPathExists { get; set; }
        public IList<FileDialogCustomPlace> CustomPlaces { get; set; } = new List<FileDialogCustomPlace>();
        public string DefaultExt { get; set; } = string.Empty;
        public bool DereferenceLinks { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string[] FileNames { get; set; } = new string[0];
        public string Filter { get; set; } = string.Empty;
        public int FilterIndex { get; set; }
        public string InitialDirectory { get; set; } = string.Empty;
        public string SafeFileName { get; set; } = string.Empty;
        public string[] SafeFileNames { get; set; } = new string[0];
        public string Title { get; set; } = string.Empty;
        public bool ValidateNames { get; set; }
        public Window? Owner { get; set; }
    }
}