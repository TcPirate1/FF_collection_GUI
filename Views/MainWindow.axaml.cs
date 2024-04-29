using Avalonia.ReactiveUI;
using AvaloniaGUI.ViewModels;
using ReactiveUI;
using System.Threading.Tasks;

namespace AvaloniaGUI.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WhenActivated(disposable =>
            disposable(ViewModel!.ShowAddPage.RegisterHandler(AddDialogAsync)));

            this.WhenActivated(disposable =>
            disposable(ViewModel!.ShowEditPage.RegisterHandler(EditDialogAsync)));

            this.WhenActivated(disposable =>
            disposable(ViewModel!.ShowDeletePage.RegisterHandler(DeleteDialogAsync)));

            this.WhenActivated(disposable =>
            disposable(ViewModel!.ShowSearchPage.RegisterHandler(SearchDialogAsync)));
        }
        public async Task AddDialogAsync(InteractionContext<MainWindowViewModel, AddPageViewModel?> interaction)
        {
            var dialog = new AddPage
            {
                DataContext = interaction.Input
            };
            // Above is same as below
            //var dialog = new AddPage();
            //dialog.DataContext = interaction.Input;
            var result = await dialog.ShowDialog<AddPageViewModel?>(this);
            interaction.SetOutput(result);
        }
        public async Task EditDialogAsync(InteractionContext<MainWindowViewModel, EditPageViewModel?> interaction)
        {
            var dialog = new EditPage
            {
                DataContext = interaction.Input
            };
            var result = await dialog.ShowDialog<EditPageViewModel?>(this);
            interaction.SetOutput(result);
        }
        public async Task DeleteDialogAsync(InteractionContext<MainWindowViewModel, DeletePageViewModel?> interaction)
        {
            var dialog = new DeletePage
            {
                DataContext = interaction.Input
            };
            var result = await dialog.ShowDialog<DeletePageViewModel?>(this);
            interaction.SetOutput(result);
        }
        public async Task SearchDialogAsync(InteractionContext<MainWindowViewModel, SearchPageViewModel?> interaction)
        {
            var dialog = new SearchPage
            {
                DataContext = interaction.Input
            };
            var result = await dialog.ShowDialog<SearchPageViewModel?>(this);
            interaction.SetOutput(result);
        }
    }
}