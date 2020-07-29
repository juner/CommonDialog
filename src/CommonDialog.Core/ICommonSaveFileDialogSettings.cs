namespace CommonDialog.Core
{
    public interface ICommonSaveFileDialogSettings : ICommonFileDialogSettings
    {
        bool CreatePrompt { get; }
        bool OverwritePrompt { get; }
    }
}
