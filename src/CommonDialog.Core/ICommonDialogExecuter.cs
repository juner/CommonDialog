namespace CommonDialog.Core
{
    /// <summary>
    /// common dialog executer interface
    /// </summary>
    public interface ICommonDialogExecuter
    {
        /// <summary>
        /// setting use dialog checking
        /// </summary>
        /// <param name="Settings"></param>
        /// <returns></returns>
        bool UseDialog(ICommonDialogSettings Settings);
        /// <summary>
        /// show dialog
        /// </summary>
        /// <param name="Settings"></param>
        /// <returns></returns>
        bool? ShowDialog(ICommonDialogSettings Settings);
    }
}
