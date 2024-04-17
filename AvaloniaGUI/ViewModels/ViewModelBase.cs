using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using System;
using System.Reactive;

namespace AvaloniaGUI.ViewModels
{
    public class ViewModelBase : ReactiveObject
    {
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public ViewModelBase()
        {
            CancelCommand = ReactiveCommand.Create(CloseCurrentPage);
        }

        protected virtual void CloseCurrentPage()
        {
            (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow.Close();
        }
    }
}
