using Microsoft.Win32;
using System;
using System.Windows;

namespace CommonDialog.WPF
{
    public class SaveFileDialogExecuter : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
    {
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is ISaveFileSettings;
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is ISaveFileSettings;
        public bool? ShowDialog(Core.ICommonDialogSettings Settings) => Settings switch
        {
            ISaveFileSettings s => ShowDialog(s),
            _ => throw new ArgumentException(nameof(Settings) + " is no match."),
        };
        public bool? ShowDialog(ISaveFileSettings Settings)
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
            var Result = Settings switch
            {
                { Owner: Window Owner } => Dialog.ShowDialog(Owner),
                _ => Dialog.ShowDialog(),
            };
            Settings.SafeFileName = Dialog.SafeFileName;
            Settings.SafeFileNames = Dialog.SafeFileNames;
            Settings.FileName = Dialog.FileName;
            Settings.FileNames = Dialog.FileNames;
            Settings.FilterIndex = Dialog.FilterIndex;
            return Result;
        }
    }
}
