using Microsoft.Win32;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public class SaveFileDialogSettings : FileDialogSettings, ISaveFileDialogSettings, Core.ICommonSaveFileDialogSettings
    {
        public bool CreatePrompt { get; set; }
        public bool OverwritePrompt { get; set; }
    }
}