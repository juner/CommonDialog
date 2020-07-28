using System.Windows;

namespace CommonDialog.WPF
{
    public interface ICommonDialogSettings
    {
        Window? Owner { get; }
    }
}