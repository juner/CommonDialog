using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WindowsAPICodePack
{
    public interface ICommonFileDialogSettings
    {
        Window? Window { get; }
        IntPtr OwnerWindowHandle { get; }
        string Title { get; }
        bool ShowPlacesList { get; }
        string DefaultDirectory { get; }
        string DefaultExtension { get; }
        string DefaultFileName { get; }
        bool EnsureFileExists { get; }
        bool EnsurePathExists { get; }
        bool EnsureReadOnly { get; }
        bool EnsureValidNames { get; }
        bool AllowPropertyEditing { get; }
        IList<(string RawDisplayName, string ExtensionList)> Filters { get; }
        string InitialDirectory { get; }
        bool NavigateToShortcut { get; }
        int SelectedFileTypeIndex { get; }
        bool ShowHiddenItems { get; }
        string FileName { get; }
        bool AddToMostRecentlyUsedList { get; }
        CommonFileDialogResult Result { get; set; }
    }
}
