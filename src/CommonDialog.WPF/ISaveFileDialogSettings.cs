namespace CommonDialog.WPF
{
    public interface ISaveFileDialogSettings : IFileDialogSettings
    {
        bool CreatePrompt { get; }
        bool OverwritePrompt { get; }
    }
}