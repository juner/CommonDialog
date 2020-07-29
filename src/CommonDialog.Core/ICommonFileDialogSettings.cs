namespace CommonDialog.Core
{
    public interface ICommonFileDialogSettings : ICommonDialogSettings
    {
        string DefaultFileName { get; }
        string FileName { get; set; }
        string InitialDirectory { get; set; }
        string Filter { get; }
    }
}
