using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public interface ISaveFileSettings: IFileDialogSettings
    {
        bool CreatePrompt { get; }
        bool OverwritePrompt { get; }
    }
}