namespace CommonDialog.Core
{
    public class MessageBoxSettings : IMessageBoxSettings
    {
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

        public MessageBoxButton Button { get; set; }

        public MessageBoxImage Icon { get; set; }

        public MessageBoxResult DefaultResult { get; set; }

        public MessageBoxOptions Options { get; set; }
        public MessageBoxResult Result { get; set; }
    }
}
