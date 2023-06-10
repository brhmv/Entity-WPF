using Entity3.DBContext;
using Entity3.ViewModels;
using Entity3.Views;
using System.Windows;

namespace Entity3
{
    public partial class App : Application
    {
        internal  SchoolBusDB SDBContext = new();




        public static new MainView? MainWindow { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainView
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
        }
    }
}
