using ReactiveUI;
using System.Windows.Input;
using System.Reactive.Linq;

namespace AvaloniaGUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand OpenAddPage { get; }
        public ICommand OpenEditPage { get; }
        public ICommand OpenDeletePage { get; }
        public ICommand OpenSearchPage { get; }
        public Interaction<MainWindowViewModel ,AddPageViewModel?> ShowAddPage { get; }
        public Interaction<MainWindowViewModel, EditPageViewModel?> ShowEditPage { get; }
        public Interaction<MainWindowViewModel, DeletePageViewModel?> ShowDeletePage { get; }
        public Interaction<MainWindowViewModel, SearchPageViewModel?> ShowSearchPage { get; }

        public MainWindowViewModel()
        {
            ShowAddPage = new Interaction<MainWindowViewModel, AddPageViewModel?>();

            OpenAddPage = ReactiveCommand.CreateFromTask(async () =>
            {
                var addPage = new MainWindowViewModel();
                await ShowAddPage.Handle(addPage);
            });

            ShowEditPage = new Interaction<MainWindowViewModel, EditPageViewModel?>();

            OpenEditPage = ReactiveCommand.CreateFromTask(async () =>
            {
                var editPage = new MainWindowViewModel();
                await ShowEditPage.Handle(editPage);
            });

            ShowDeletePage = new Interaction<MainWindowViewModel, DeletePageViewModel?>();

            OpenDeletePage = ReactiveCommand.CreateFromTask(async () =>
            {
                var deletePage = new MainWindowViewModel();
                await ShowDeletePage.Handle(deletePage);
            });

            ShowSearchPage = new Interaction<MainWindowViewModel, SearchPageViewModel?>();

            OpenSearchPage = ReactiveCommand.CreateFromTask(async () =>
            {
                var searchPage = new MainWindowViewModel();
                await ShowSearchPage.Handle(searchPage);
            });
        }
    }
}
