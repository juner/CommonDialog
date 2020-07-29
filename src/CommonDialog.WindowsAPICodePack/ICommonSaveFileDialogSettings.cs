namespace CommonDialog.WindowsAPICodePack
{
    public interface ICommonSaveFileDialogSettings : ICommonFileDialogSettings
    {
        bool AlwaysAppendDefaultExtension { get; }
        bool CreatePrompt { get; }
        bool IsExpandedMode { get; }
        bool OverwritePrompt { get; }
    }
}
