using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows;

namespace CommonDialog.WindowsAPICodePack
{
    public abstract class CommonFileDialogExecuter<TCommonFileDialogSettings, TCommonDialogSettings>
        : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
        where TCommonDialogSettings : Core.ICommonDialogSettings
        where TCommonFileDialogSettings : ICommonFileDialogSettings
    {
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is TCommonFileDialogSettings;
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is TCommonDialogSettings;
        public bool? ShowDialog(Core.ICommonDialogSettings Settings) => Settings switch
        {
            TCommonFileDialogSettings s => ShowDialog(s),
            TCommonDialogSettings s => ShowDialog(Wrap(s)),
            _ => throw new ArgumentException(nameof(Settings) + " is no matches."),
        };
        protected abstract TCommonFileDialogSettings Wrap(TCommonDialogSettings Settings);
        public bool? ShowDialog(TCommonFileDialogSettings Settings)
        {
            using var Dialog = Create(Settings);
            Settings.Result = Execute(Dialog, Settings);
            return GetResult(Settings);
        }
        public abstract CommonFileDialog Create(TCommonFileDialogSettings Settings);
        public CommonFileDialogResult Execute(CommonFileDialog Dialog, TCommonFileDialogSettings Settings) => Settings switch
        {
            { Window: Window Window } => Dialog.ShowDialog(Window),
            { Window: null, OwnerWindowHandle: IntPtr OwnerWindowHandle } when OwnerWindowHandle != IntPtr.Zero => Dialog.ShowDialog(OwnerWindowHandle),
            _ => Dialog.ShowDialog(),
        };
        public bool? GetResult(TCommonFileDialogSettings Settings) => Settings switch
        {
            { Result: CommonFileDialogResult.Ok } => true,
            { Result: CommonFileDialogResult.Cancel } => false,
            _ => null,
        };
    }
}
