using System;
using System.Windows;

namespace CommonDialog.WPF
{
    public class MessageBoxExecuter : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
    {
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is Core.IMessageBoxSettings;
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is IMessageBoxSettings;
        public bool? ShowDialog(Core.ICommonDialogSettings Settings) => Settings switch
        {
            IMessageBoxSettings WPFSettings => ShowDialog(WPFSettings),
            Core.IMessageBoxSettings _Settings => ShowDialog(new WrapedMessageBoxSettings(_Settings)),
            _ => throw new ArgumentException(nameof(Settings) + " is not IMessageBoxSettings", nameof(Settings)),
        };
        public bool? ShowDialog(IMessageBoxSettings Settings)
        {
            Settings.Result = Execute(Settings);
            return GetResult(Settings);
        }
        private MessageBoxResult Execute(IMessageBoxSettings Settings) => Settings switch
        {
            { Owner: null } => MessageBox.Show(Settings.MessageBoxText, Settings.Caption),
            { Owner: Window Owner } => MessageBox.Show(Owner, Settings.MessageBoxText, Settings.Caption, Settings.Button, Settings.Icon, Settings.DefaultResult, Settings.Options),
        };
        private bool GetResult(IMessageBoxSettings Settings) => Settings switch
        {
            { Button: MessageBoxButton.OK, } => true,
            { Button: MessageBoxButton.OKCancel, Result: MessageBoxResult.OK, } => true,
            { Button: MessageBoxButton.YesNo, Result: MessageBoxResult.Yes, } => true,
            { Button: MessageBoxButton.YesNoCancel, Result: MessageBoxResult.Yes } => true,
            _ => false,
        };
    }
}
