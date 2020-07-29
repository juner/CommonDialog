using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CommonDialog.WindowsAPICodePack
{
    internal class WrappedCommonSaveFileDialogSettings : ICommonSaveFileDialogSettings
    {
        readonly Core.ICommonSaveFileDialogSettings Settings;
        public WrappedCommonSaveFileDialogSettings(Core.ICommonSaveFileDialogSettings Settings)
            => this.Settings = Settings;

        public bool AlwaysAppendDefaultExtension => default;

        public bool CreatePrompt => default;

        public bool IsExpandedMode => default;

        public bool OverwritePrompt => Settings.OverwritePrompt;

        public Window? Window => null;

        public IntPtr OwnerWindowHandle => IntPtr.Zero;

        public string Title => Settings.Title;

        public bool ShowPlacesList => default;

        public string DefaultDirectory => string.Empty;

        public string DefaultExtension => string.Empty;

        public string DefaultFileName => string.Empty;

        public bool EnsureFileExists => default;

        public bool EnsurePathExists => default;

        public bool EnsureReadOnly => default;

        public bool EnsureValidNames => default;

        public bool AllowPropertyEditing => default;

        public IList<(string RawDisplayName, string ExtensionList)> Filters
            => Buffer(Settings.Filter.Split('|'), 2).Select(v => (v[0], v[1] ?? string.Empty)).ToList();
        private static IEnumerable<IList<T>> Buffer<T>(IEnumerable<T> source, int count)
        {
            var buffer = new List<T>(count);
            foreach (var item in source)
            {
                buffer.Add(item);
                if (buffer.Count >= count)
                {
                    yield return buffer;
                    buffer = new List<T>(count);
                }
            }
            if (buffer.Count > 0)
                yield return buffer;
        }


        public string InitialDirectory => Settings.InitialDirectory;

        public bool NavigateToShortcut => default;

        public int SelectedFileTypeIndex => default;

        public bool ShowHiddenItems => default;

        public string FileName => Settings.FileName;

        public bool AddToMostRecentlyUsedList => default;

        public CommonFileDialogResult Result { get; set; }
    }
}
