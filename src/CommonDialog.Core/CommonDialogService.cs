using CommonDialog.Core.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CommonDialog.Core
{
    public class CommonDialogService : ICommonDialogService
    {
        readonly IEnumerable<ICommonDialogExecuter> Executers;
        public CommonDialogService(IEnumerable<ICommonDialogExecuter> Executers)
            => this.Executers = Executers;

        public ICommonDialogExecuter GetExecuter(ICommonDialogSettings Settings)
        {
            var Executers = new List<ICommonDialogExecuter>();
            foreach (var Executer in this.Executers.UseDialog(Settings))
            {
                if (Executer.IsPrecedence(Settings))
                    return Executer;
                Executers.Add(Executer);
            }
            return Executers.First();
        }

        public bool ShowDialog(ICommonDialogSettings Settings) => GetExecuter(Settings).ShowDialog(Settings);
    }
}
