using Microsoft.Win32;
using System;
using System.Windows;

namespace CommonDialog.WPF
{
    public abstract class FileDialogExecuter<TFileDialogSettings, TCommonDialogSettings, TFileDialog>
        : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
        where TCommonDialogSettings : Core.ICommonDialogSettings
        where TFileDialogSettings : IFileDialogSettings
        where TFileDialog : FileDialog
    {
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is TFileDialogSettings;
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is TCommonDialogSettings;
        public bool? ShowDialog(Core.ICommonDialogSettings Settings) => Settings switch
        {
            TFileDialogSettings s => ShowDialog(s),
            TCommonDialogSettings s => ShowDialog(Wrap(s)),
            _ => throw new ArgumentException(nameof(Settings) + " is no matches."),
        };
        protected abstract TFileDialogSettings Wrap(TCommonDialogSettings Settings);
        public bool? ShowDialog(TFileDialogSettings Settings)
        {
            var Dialog = Create(Settings);
            var Result = Execute(Dialog, Settings);
            SetSettings(Settings, Dialog);
            return Result;
        }
        public abstract TFileDialog Create(TFileDialogSettings Settings);
        public bool? Execute(TFileDialog Dialog, TFileDialogSettings Settings) => Settings switch
        {
            { Owner: Window Window } => Dialog.ShowDialog(Window),
            _ => Dialog.ShowDialog(),
        };
        public abstract void SetSettings(TFileDialogSettings Settings, TFileDialog Dialog);
    }
}
