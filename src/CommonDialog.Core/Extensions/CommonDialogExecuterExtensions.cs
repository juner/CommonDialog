using System.Collections.Generic;
using System.Linq;

namespace CommonDialog.Core.Extensions
{
    public static class CommonDialogExecuterExtensions
    {
        public static IEnumerable<ICommonDialogExecuter> UseDialog(this IEnumerable<ICommonDialogExecuter> Executers, ICommonDialogSettings Settings)
            => Executers.Where(Executer => Executer.UseDialog(Settings));
        public static bool IsPrecedence(this ICommonDialogExecuter Executer, ICommonDialogSettings Settings)
            => Executer is ICommonDialogPrecedence Precedence && Precedence.IsPrecedence(Settings);
        public static IEnumerable<ICommonDialogExecuter> IsPrecedence(this IEnumerable<ICommonDialogExecuter> Executers, ICommonDialogSettings Settings)
            => Executers.Where(Executer => Executer.IsPrecedence(Settings));
    }
}
