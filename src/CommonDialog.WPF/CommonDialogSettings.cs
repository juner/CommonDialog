using System.Windows;

namespace CommonDialog.WPF
{
    public abstract class CommonDialogSettings : ICommonDialogSettings
    {
        public Window? Owner { get; set; }
    }
}