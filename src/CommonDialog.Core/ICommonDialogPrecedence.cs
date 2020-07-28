namespace CommonDialog.Core
{
    /// <summary>
    /// procedence common dialog interface
    /// </summary>
    public interface ICommonDialogPrecedence
    {
        /// <summary>
        /// precedence checking.
        /// </summary>
        /// <param name="Settings"></param>
        /// <returns></returns>
        bool IsPrecedence(ICommonDialogSettings Settings);
    }
}
