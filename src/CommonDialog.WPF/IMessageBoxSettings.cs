using System.Windows;

namespace CommonDialog.WPF
{
    public interface IMessageBoxSettings
    {
        /// <summary>
        /// A System.Windows.Window that represents the owner window of the message box.
        /// </summary>
        Window? Owner { get; }
        /// <summary>
        /// A System.String that specifies the text to display.
        /// </summary>
        string MessageBoxText { get; }
        /// <summary>
        /// A System.String that specifies the title bar caption to display.
        /// </summary>
        string Caption { get; }
        /// <summary>
        /// A System.Windows.MessageBoxButton value that specifies which button or buttons to display.
        /// </summary>
        MessageBoxButton Button { get; }
        /// <summary>
        /// A System.Windows.MessageBoxImage value that specifies the icon to display.
        /// </summary>
        MessageBoxImage Icon { get; }
        /// <summary>
        /// A System.Windows.MessageBoxResult value that specifies the default result of the message box.
        /// </summary>
        MessageBoxResult DefaultResult { get; }
        /// <summary>
        /// A System.Windows.MessageBoxOptions value object that specifies the options.
        /// </summary>
        MessageBoxOptions Options { get; }
        /// <summary>
        ///  A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.
        /// </summary>
        MessageBoxResult Result { get; set; }
    }
}
