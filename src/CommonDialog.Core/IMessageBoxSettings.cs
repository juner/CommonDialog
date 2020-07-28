namespace CommonDialog.Core
{
    public interface IMessageBoxSettings : ICommonDialogSettings
    {
        string Message { get; }
        MessageBoxButton Button { get; }
        MessageBoxImage Icon { get; }
        MessageBoxResult DefaultResult { get; }
        MessageBoxOptions Options { get; }
        MessageBoxResult Result { get; set; }
    }
}
