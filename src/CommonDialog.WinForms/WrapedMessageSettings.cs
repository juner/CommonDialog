using System.Windows.Forms;

namespace CommonDialog.WinForms
{
    internal class WrapedMessageSettings : IMessageBoxSettings
    {
        readonly Core.IMessageBoxSettings Settings;
        public WrapedMessageSettings(Core.IMessageBoxSettings Settings)
            => this.Settings = Settings;
        public IWin32Window? Owner => null;
        public string Text => Settings.Message;
        public string Caption => Settings.Title;
        public MessageBoxButtons Buttons => (MessageBoxButtons)Settings.Button;
        public MessageBoxIcon Icon => (MessageBoxIcon)Settings.Icon;
        public MessageBoxDefaultButton DefaultButton => Settings.ToDefaultButton();
        public MessageBoxOptions Options => (MessageBoxOptions)Settings.Options;
        public string HelpFilePath => string.Empty;
        public HelpNavigator Navigator => default;
        public object? Param => null;
        public string Keyword => string.Empty;
        public DialogResult Result { get => (DialogResult)Settings.Result; set => Settings.Result = (Core.MessageBoxResult)value; }
    }
}
