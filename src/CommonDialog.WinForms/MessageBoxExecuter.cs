using System;
using System.Windows.Forms;

namespace CommonDialog.WinForms
{
    public class MessageBoxExecuter : Core.ICommonDialogExecuter, Core.ICommonDialogPrecedence
    {
        public bool UseDialog(Core.ICommonDialogSettings Settings) => Settings is Core.IMessageBoxSettings;
        public bool IsPrecedence(Core.ICommonDialogSettings Settings) => Settings is IMessageBoxSettings;
        public bool? ShowDialog(Core.ICommonDialogSettings Settings) => Settings switch
        {
            IMessageBoxSettings s => ShowDialog(s),
            Core.IMessageBoxSettings s => ShowDialog(Wrap(s)),
            _ => throw new ArgumentException(nameof(Settings) + " is not IMessageBoxSettings", nameof(Settings)),
        };
        public IMessageBoxSettings Wrap(Core.IMessageBoxSettings Settings) => new WrapedMessageSettings(Settings);
        public bool ShowDialog(IMessageBoxSettings Settings)
        {
            Settings.Result = Execute(Settings);
            return GetResult(Settings);
        }
        private DialogResult Execute(IMessageBoxSettings Settings) => Settings switch
        {
            { Owner: IWin32Window Owner, HelpFilePath: string HelpFilePath, Param: object Param } when HelpFilePath != string.Empty => MessageBox.Show(Owner, Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator, Param),
            { Owner: null, HelpFilePath: string HelpFilePath, Param: object Param } when HelpFilePath != string.Empty => MessageBox.Show(Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator, Param),
            { Owner: IWin32Window Owner, HelpFilePath: string HelpFilePath, Param: null } when HelpFilePath != string.Empty => MessageBox.Show(Owner, Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator),
            { Owner: null, HelpFilePath: string HelpFilePath, Param: null } when HelpFilePath != string.Empty => MessageBox.Show(Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator),
            { Owner: IWin32Window Owner, HelpFilePath: string HelpFilePath, Navigator: 0, Keyword: string Keyword } when HelpFilePath != string.Empty && Keyword != string.Empty => MessageBox.Show(Owner, Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator, Keyword),
            { Owner: null, HelpFilePath: string HelpFilePath, Navigator: 0, Keyword: string Keyword } when HelpFilePath != string.Empty && Keyword != string.Empty => MessageBox.Show(Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options, HelpFilePath, Settings.Navigator, Keyword),
            { Owner: IWin32Window Owner, } => MessageBox.Show(Owner, Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options),
            _ => MessageBox.Show(Settings.Text, Settings.Caption, Settings.Buttons, Settings.Icon, Settings.DefaultButton, Settings.Options),
        };
        private bool GetResult(IMessageBoxSettings Settings) => Settings switch
        {
            { Buttons: MessageBoxButtons.OK, } => true,
            { Buttons: MessageBoxButtons.OKCancel, Result: DialogResult.OK, } => true,
            { Buttons: MessageBoxButtons.YesNo, Result: DialogResult.Yes, } => true,
            { Buttons: MessageBoxButtons.YesNoCancel, Result: DialogResult.Yes, } => true,
            _ => false,
        };
    }

}
