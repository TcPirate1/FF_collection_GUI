using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaGUI.ViewModels;
using AvaloniaGUI.Views;
using MongoDB.Driver;
using DotNetEnv;

namespace AvaloniaGUI
{
    public partial class App : Application
    {
        public static MongoDBContext? Mongodbcontext { get; private set; }
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                Env.Load();
                var connectionstring = Env.GetString("ATLAS_URI");
                var databasename = "FFCollection";
                Mongodbcontext = new MongoDBContext(connectionstring, databasename);
                
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}