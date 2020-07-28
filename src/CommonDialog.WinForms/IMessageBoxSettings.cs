using System.Windows.Forms;

namespace CommonDialog.WinForms
{
    public interface IMessageBoxSettings
    {
        /// <summary>
        /// An implementation of System.Windows.Forms.IWin32Window that will own the modal dialog box.
        /// </summary>
        IWin32Window? Owner { get; }
        /// <summary>
        /// The text to display in the message box.
        /// </summary>
        string Text { get;}
        /// <summary>
        /// The text to display in the title bar of the message box.
        /// </summary>
        string Caption { get; }
        /// <summary>
        /// One of the System.Windows.Forms.MessageBoxButtons values that specifies which buttons to display in the message box.
        /// </summary>
        MessageBoxButtons Buttons { get; }
        /// <summary>
        /// One of the System.Windows.Forms.MessageBoxIcon values that specifies which icon to display in the message box.
        /// </summary>
        MessageBoxIcon Icon { get; }
        /// <summary>
        /// One of the System.Windows.Forms.MessageBoxDefaultButton values that specifies the default button for the message box.
        /// </summary>
        MessageBoxDefaultButton DefaultButton { get; }
        /// <summary>
        /// One of the System.Windows.Forms.MessageBoxOptions values that specifies which
        /// display and association options will be used for the message box. You may pass
        /// in 0 if you wish to use the defaults.
        /// </summary>
        MessageBoxOptions Options { get; }
        /// <summary>
        /// The path and name of the Help file to display when the user clicks the Help button.
        /// </summary>
        string HelpFilePath { get; }
        /// <summary>
        /// One of the System.Windows.Forms.HelpNavigator values.
        /// </summary>
        HelpNavigator Navigator { get; }
        /// <summary>
        /// The numeric ID of the Help topic to display when the user clicks the Help button.
        /// </summary>
        object? Param { get; }
        /// <summary>
        /// The Help keyword to display when the user clicks the Help button.
        /// </summary>
        string Keyword { get; }
        /// <summary>
        /// One of the System.Windows.Forms.DialogResult values.
        /// </summary>
        DialogResult Result { get; set; }
    }
}
