using System.Collections.Generic;
using System.Text;

namespace CommonDialog.Core
{
    public interface ICommonDialogService
    {
        /// <summary>
        /// show registed common dialog.
        /// </summary>
        /// <param name="Settings"></param>
        /// <returns></returns>
        bool ShowDialog(ICommonDialogSettings Settings);
        ICommonDialogExecuter GetExecuter(ICommonDialogSettings Settings);
    }
}
