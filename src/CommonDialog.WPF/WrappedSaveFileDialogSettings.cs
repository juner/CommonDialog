using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    internal class WrappedSaveFileDialogSettings : ISaveFileDialogSettings
    {
        readonly Core.ICommonSaveFileDialogSettings Settings;
        public WrappedSaveFileDialogSettings(Core.ICommonSaveFileDialogSettings Settings)
            => this.Settings = Settings;
        public bool CreatePrompt => Settings.CreatePrompt;

        public bool OverwritePrompt => Settings.OverwritePrompt;

        public bool AddExtension => default;

        public bool CheckFileExists => default;

        public bool CheckPathExists => default;

        public IList<FileDialogCustomPlace> CustomPlaces => new List<FileDialogCustomPlace>().AsReadOnly();

        public string DefaultExt => string.Empty;

        public bool DereferenceLinks => default;

        public string FileName { set => Settings.FileName = value; }
        public string[] FileNames { set { } }

        public string Filter => Settings.Filter;

        public int FilterIndex { get => default; set { } }

        public string InitialDirectory => Settings.InitialDirectory;

        public string SafeFileName { get => Settings.FileName; set => Settings.FileName = value; }
        public string[] SafeFileNames { set { } }

        public string Title => Settings.Title;

        public bool ValidateNames { get => default; set { } }

        public Window? Owner => null;
    }
}