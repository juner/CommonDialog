using System;
using System.Collections.Generic;
using System.Windows;

namespace CommonDialog.WPF
{
    public class CommonSaveFileDialogExecuter : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
    {
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is ICommonSaveFileDialogSettings;
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is ICommonSaveFileDialogSettings;

        public bool? ShowDialog(Core.ICommonDialogSettings Settings)
        {
            throw new NotImplementedException();
        }

    }
    public class CommonSaveFileDialogSettings : ICommonSaveFileDialogSettings
    {
        public bool AlwaysAppendDefaultExtension => throw new NotImplementedException();

        public bool CreatePrompt => throw new NotImplementedException();

        public bool IsExpandedMode => throw new NotImplementedException();

        public bool OverwritePrompt => throw new NotImplementedException();

        public Window? Window => throw new NotImplementedException();

        public IntPtr OwnerWindowHandle => throw new NotImplementedException();

        public bool ShowPlacesList => throw new NotImplementedException();

        public string DefaultDirectory => throw new NotImplementedException();

        public string DefaultExtension => throw new NotImplementedException();

        public string DefaultFileName => throw new NotImplementedException();

        public bool EnsureFileExists => throw new NotImplementedException();

        public bool EnsurePathExists => throw new NotImplementedException();

        public bool EnsureReadOnly => throw new NotImplementedException();

        public string Title => throw new NotImplementedException();

        public bool EnsureValidNames => throw new NotImplementedException();

        public bool AllowPropertyEditing => throw new NotImplementedException();

        public IList<(string RawDisplayName, string ExtensionList)> Filters => throw new NotImplementedException();

        public string InitialDirectory => throw new NotImplementedException();

        public bool NavigateToShortcut => throw new NotImplementedException();

        public int SelectedFileTypeIndex => throw new NotImplementedException();

        public bool ShowHiddenItems => throw new NotImplementedException();

        public string FileName => throw new NotImplementedException();

        public bool AddToMostRecentlyUsedList => throw new NotImplementedException();
    }
}
