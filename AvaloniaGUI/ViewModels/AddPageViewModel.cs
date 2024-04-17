using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;

namespace AvaloniaGUI.ViewModels
{
    public class AddPageViewModel: ViewModelBase
    {
        protected override void CloseCurrentPage()
        {
            (Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow.Close();
        }
    }
}
