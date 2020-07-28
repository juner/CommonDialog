using System;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public interface ICommonFileDialogSettings
    {
        Window? Window { get; }
        IntPtr OwnerWindowHandle { get; }
        bool ShowPlacesList { get; }
        string DefaultDirectory { get; }
        string DefaultExtension { get; }
        string DefaultFileName { get; }
        bool EnsureFileExists { get; }
        bool EnsurePathExists { get; }
        bool EnsureReadOnly { get; }
        string Title { get; }
        bool EnsureValidNames { get; }
        bool AllowPropertyEditing { get; }
        IList<(string RawDisplayName, string ExtensionList)> Filters { get; }
        string InitialDirectory { get; }
        bool NavigateToShortcut { get; }
        int SelectedFileTypeIndex { get; }
        bool ShowHiddenItems { get; }
        string FileName { get; }
        bool AddToMostRecentlyUsedList { get; }
    }
}
