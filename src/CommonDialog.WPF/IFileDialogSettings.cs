using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public interface IFileDialogSettings : ICommonDialogSettings
    {
        bool AddExtension { get; }
        bool CheckFileExists { get; }
        bool CheckPathExists { get; }
        IList<FileDialogCustomPlace> CustomPlaces { get; set; }
        string DefaultExt { get; }
        bool DereferenceLinks { get; }
        string FileName { set; }
        string[] FileNames { set; }
        string Filter { get; }
        int FilterIndex { get; set; }
        string InitialDirectory { get; }
        string SafeFileName { get; set; }
        string[] SafeFileNames { set; }
        string Title { get; }
        bool ValidateNames { get; set; }
    }
}