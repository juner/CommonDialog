using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CommonDialog.WindowsAPICodePack
{
    public abstract class CommonFileDialogSettings : ICommonFileDialogSettings, Core.ICommonFileDialogSettings
    {
        public Window? Window { get; set; }

        public IntPtr OwnerWindowHandle { get; set; }

        public string Title { get; set; } = string.Empty;

        public bool ShowPlacesList { get; set; }

        public string DefaultDirectory { get; set; } = string.Empty;

        public string DefaultExtension { get; set; } = string.Empty;

        public string DefaultFileName { get; set; } = string.Empty;

        public bool EnsureFileExists { get; set; }

        public bool EnsurePathExists { get; set; }

        public bool EnsureReadOnly { get; set; }

        public bool EnsureValidNames { get; set; }

        public bool AllowPropertyEditing { get; set; }

        public IList<(string RawDisplayName, string ExtensionList)> Filters { get; } = new List<(string, string)>();

        string Core.ICommonFileDialogSettings.Filter => string.Join("|", Filters.Select(v => string.Join("|", v.RawDisplayName, v.ExtensionList)));

        public string InitialDirectory { get; set; } = string.Empty;

        public bool NavigateToShortcut { get; set; }

        public int SelectedFileTypeIndex { get; set; }

        public bool ShowHiddenItems { get; set; }

        public string FileName { get; set; } = string.Empty;

        public bool AddToMostRecentlyUsedList { get; set; }

        public CommonFileDialogResult Result { get; set; }
    }
}
