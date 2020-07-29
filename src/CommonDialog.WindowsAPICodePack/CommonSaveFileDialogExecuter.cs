using Microsoft.WindowsAPICodePack.Dialogs;
using System;

namespace CommonDialog.WindowsAPICodePack
{
    public class CommonSaveFileDialogExecuter : CommonFileDialogExecuter<ICommonSaveFileDialogSettings, Core.ICommonSaveFileDialogSettings>
    {
        public override CommonFileDialog Create(ICommonSaveFileDialogSettings Settings)
        {
            CommonSaveFileDialog? Dialog = null;
            try
            {
                Dialog = new CommonSaveFileDialog
                {
                    AddToMostRecentlyUsedList = Settings.AddToMostRecentlyUsedList,
                    AllowPropertyEditing = Settings.AllowPropertyEditing,
                    AlwaysAppendDefaultExtension = Settings.AlwaysAppendDefaultExtension,
                    CreatePrompt = Settings.CreatePrompt,
                    DefaultDirectory = Settings.DefaultDirectory,
                    DefaultExtension = Settings.DefaultExtension,
                    DefaultFileName = Settings.DefaultFileName,
                    EnsureFileExists = Settings.EnsureFileExists,
                    EnsurePathExists = Settings.EnsurePathExists,
                    EnsureReadOnly = Settings.EnsureReadOnly,
                    EnsureValidNames = Settings.EnsureValidNames,
                    InitialDirectory = Settings.InitialDirectory,
                    IsExpandedMode = Settings.IsExpandedMode,
                    NavigateToShortcut = Settings.NavigateToShortcut,
                    OverwritePrompt = Settings.OverwritePrompt,
                    ShowHiddenItems = Settings.ShowHiddenItems,
                    Title = Settings.Title,
                };
                foreach (var (RowDisplayName, ExtensionsList) in Settings.Filters)
                    Dialog.Filters.Add(new CommonFileDialogFilter(RowDisplayName, ExtensionsList));
                return Dialog;
            }
            catch (Exception)
            {
                if (Dialog is IDisposable)
                    Dialog.Dispose();
                throw;
            }
        }

        protected override ICommonSaveFileDialogSettings Wrap(Core.ICommonSaveFileDialogSettings Settings)
        {
            throw new NotImplementedException();
        }
    }
}
