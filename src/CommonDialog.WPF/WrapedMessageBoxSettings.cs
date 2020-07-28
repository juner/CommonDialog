using System.Windows;

namespace CommonDialog.WPF
{
    internal class WrapedMessageBoxSettings : IMessageBoxSettings
    {
        private Core.IMessageBoxSettings Settings;
        public WrapedMessageBoxSettings(Core.IMessageBoxSettings Settings)
            => this.Settings = Settings;
        public Window? Owner => null;

        public string MessageBoxText => Settings.Message;

        public string Caption => Settings.Title;

        public MessageBoxButton Button => (MessageBoxButton)Settings.Button;

        public MessageBoxImage Icon => (MessageBoxImage)Settings.Icon;

        public MessageBoxResult DefaultResult => (MessageBoxResult)Settings.DefaultResult;

        public MessageBoxOptions Options => (MessageBoxOptions)Settings.Options;

        public MessageBoxResult Result
        {
            get => (MessageBoxResult)Settings.Result;
            set => Settings.Result = (Core.MessageBoxResult)value;
        }
    }
}
