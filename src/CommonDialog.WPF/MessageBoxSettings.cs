using System.Windows;

namespace CommonDialog.WPF
{
    public class MessageBoxSettings : IMessageBoxSettings, Core.IMessageBoxSettings
    {
        public Window? Owner { get; set; }
        public string MessageBoxText { get; set; } = string.Empty;
        public string Caption { get; set; } = string.Empty;
        public MessageBoxButton Button { get; }
        public MessageBoxImage Icon { get; }
        public MessageBoxResult DefaultResult { get; }
        public MessageBoxOptions Options { get; }
        public MessageBoxResult Result { get; set; }

        string Core.IMessageBoxSettings.Message => MessageBoxText;
        string Core.ICommonDialogSettings.Title => throw new System.NotImplementedException();
        Core.MessageBoxButton Core.IMessageBoxSettings.Button => (Core.MessageBoxButton)Button;
        Core.MessageBoxImage Core.IMessageBoxSettings.Icon => (Core.MessageBoxImage)Icon;
        Core.MessageBoxResult Core.IMessageBoxSettings.DefaultResult => (Core.MessageBoxResult)DefaultResult;
        Core.MessageBoxOptions Core.IMessageBoxSettings.Options => (Core.MessageBoxOptions)Options;
        Core.MessageBoxResult Core.IMessageBoxSettings.Result { get => (Core.MessageBoxResult)Result; set => Result = (MessageBoxResult)value; }

    }
}
