using System.Windows.Forms;

namespace CommonDialog.WinForms
{
    public class MessageBoxSettings : IMessageBoxSettings, Core.IMessageBoxSettings
    {
        public IWin32Window? Owner { get; set; }

        public string Text { get; set; } = string.Empty;

        public string Caption { get; set; } = string.Empty;

        public MessageBoxButtons Buttons { get; set; }

        public MessageBoxIcon Icon { get; set; }

        public MessageBoxDefaultButton DefaultButton { get; set; }

        public MessageBoxOptions Options { get; set; }

        public string HelpFilePath { get; set; } = string.Empty;

        public HelpNavigator Navigator { get; set; }

        public object? Param { get; set; }
        public string Keyword { get; set; } = string.Empty;
        public DialogResult Result { get; set; }

        string Core.IMessageBoxSettings.Message => Text;
        string Core.ICommonDialogSettings.Title => Caption;
        Core.MessageBoxButton Core.IMessageBoxSettings.Button => (Core.MessageBoxButton)Buttons;
        Core.MessageBoxImage Core.IMessageBoxSettings.Icon => (Core.MessageBoxImage)Icon;
        Core.MessageBoxResult Core.IMessageBoxSettings.DefaultResult => this.ToDefaultResult();
        Core.MessageBoxOptions Core.IMessageBoxSettings.Options => (Core.MessageBoxOptions)Options;
        Core.MessageBoxResult Core.IMessageBoxSettings.Result { get => (Core.MessageBoxResult)Result; set => Result = (DialogResult)value; }
    }
}
