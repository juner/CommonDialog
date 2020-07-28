using System.Windows.Forms;

namespace CommonDialog.WinForms
{
    internal static class MessageBoxSettingsExtensions
    {
        public static Core.MessageBoxResult ToDefaultResult(this IMessageBoxSettings Settings) => Settings switch
        {
            { Buttons: MessageBoxButtons.OK, } => Core.MessageBoxResult.OK,
            { Buttons: MessageBoxButtons.OKCancel, DefaultButton: MessageBoxDefaultButton.Button2, } => Core.MessageBoxResult.Cancel,
            { Buttons: MessageBoxButtons.OKCancel, } => Core.MessageBoxResult.OK,
            { Buttons: MessageBoxButtons.YesNo, DefaultButton: MessageBoxDefaultButton.Button2, } => Core.MessageBoxResult.No,
            { Buttons: MessageBoxButtons.YesNo, } => Core.MessageBoxResult.Yes,
            { Buttons: MessageBoxButtons.YesNoCancel, DefaultButton: MessageBoxDefaultButton.Button3, } => Core.MessageBoxResult.Cancel,
            { Buttons: MessageBoxButtons.YesNoCancel, DefaultButton: MessageBoxDefaultButton.Button2, } => Core.MessageBoxResult.No,
            { Buttons: MessageBoxButtons.YesNoCancel, } => Core.MessageBoxResult.Yes,
            _ => default,
        };
        public static MessageBoxDefaultButton ToDefaultButton(this Core.IMessageBoxSettings Settings) => Settings switch
        {
            { Button: Core.MessageBoxButton.OK, } => MessageBoxDefaultButton.Button1,
            { Button: Core.MessageBoxButton.OKCancel, DefaultResult: Core.MessageBoxResult.Cancel, } => MessageBoxDefaultButton.Button2,
            { Button: Core.MessageBoxButton.OKCancel, } => MessageBoxDefaultButton.Button1,
            { Button: Core.MessageBoxButton.YesNo, DefaultResult: Core.MessageBoxResult.No, } => MessageBoxDefaultButton.Button2,
            { Button: Core.MessageBoxButton.YesNo, } => MessageBoxDefaultButton.Button1,
            { Button: Core.MessageBoxButton.YesNoCancel, DefaultResult: Core.MessageBoxResult.Cancel, } => MessageBoxDefaultButton.Button3,
            { Button: Core.MessageBoxButton.YesNoCancel, DefaultResult: Core.MessageBoxResult.No, } => MessageBoxDefaultButton.Button2,
            { Button: Core.MessageBoxButton.YesNoCancel, } => MessageBoxDefaultButton.Button1,
            _ => default,
        };
    }
}
