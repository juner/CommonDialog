using System;
using System.Collections.Generic;
using System.Text;

namespace CommonDialog.Core.Extensions
{
    public static class MessageBoxExtensions
    {
        public static MessageBoxResult ShowMessage(this ICommonDialogService DialogService, string Message)
            => DialogService.ShowMessage(Message, string.Empty);
        public static MessageBoxResult ShowMessage(this ICommonDialogService DialogService, string Message, string Title, MessageBoxButton Button = default, MessageBoxImage Icon = default, MessageBoxResult DefaultResult = default, MessageBoxOptions Options = default)

            => DialogService.ShowMessage(new MessageBoxSettings {
                Title = Title,
                Message = Message,
                Button = Button,
                Icon = Icon,
                DefaultResult = DefaultResult,
                Options = Options,
            });
        public static MessageBoxResult ShowMessage(this ICommonDialogService DialogService, IMessageBoxSettings Settings)
        {
            DialogService.ShowDialog(Settings);
            return Settings.Result;
        }
    }
}
