namespace CommonDialog.WindowsAPICodePack
{
    public class CommonSaveFileDialogSettings : CommonFileDialogSettings, ICommonSaveFileDialogSettings, Core.ICommonSaveFileDialogSettings
    {
        public bool AlwaysAppendDefaultExtension { get; set; }

        public bool CreatePrompt { get; set; }

        public bool IsExpandedMode { get; set; }

        public bool OverwritePrompt { get; set; }
    }
}
