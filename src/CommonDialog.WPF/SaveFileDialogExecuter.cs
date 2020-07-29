using Microsoft.Win32;
using System;

namespace CommonDialog.WPF
{
    public class SaveFileDialogExecuter : FileDialogExecuter<ISaveFileDialogSettings, Core.ICommonSaveFileDialogSettings, SaveFileDialog>
    {
        protected override ISaveFileDialogSettings Wrap(Core.ICommonSaveFileDialogSettings Settings)
        {
            throw new NotImplementedException();
        }

        public override SaveFileDialog Create(ISaveFileDialogSettings Settings)
        {
            var Dialog = new SaveFileDialog
            {
                AddExtension = Settings.AddExtension,
                CheckFileExists = Settings.CheckFileExists,
                CheckPathExists = Settings.CheckPathExists,
                CreatePrompt = Settings.CreatePrompt,
                DefaultExt = Settings.DefaultExt,
                DereferenceLinks = Settings.DereferenceLinks,
                Filter = Settings.Filter,
                FilterIndex = Settings.FilterIndex,
                InitialDirectory = Settings.InitialDirectory,
                OverwritePrompt = Settings.OverwritePrompt,
                Title = Settings.Title,
                ValidateNames = Settings.ValidateNames,
            };
            foreach (var CustomPlace in Settings.CustomPlaces)
                Dialog.CustomPlaces.Add(CustomPlace);
            return Dialog;
        }

        public override void SetSettings(ISaveFileDialogSettings Settings, SaveFileDialog Dialog)
        {
            Settings.SafeFileName = Dialog.SafeFileName;
            Settings.SafeFileNames = Dialog.SafeFileNames;
            Settings.FileName = Dialog.FileName;
            Settings.FileNames = Dialog.FileNames;
            Settings.FilterIndex = Dialog.FilterIndex;
        }
    }
}
