using Entity3.DBContext;
using Entity3.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;

namespace Entity3.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        internal SchoolBusDB SDBContext = new();


        private UserControl? _currentView;
        public UserControl? CurrentView
        {
            get { return _currentView; }
            set { Set(ref _currentView, value); }
        }

        public RelayCommand Car_Button
        {
            get => new(() =>
            {
                CurrentView = new CarView();    
                CurrentView.DataContext = new CarViewModel();
            });
        }

        public RelayCommand Driver_Button
        {
            get => new(() =>
            {
                CurrentView = new DriverView();               
            });
        }

        public RelayCommand Ride_Button
        {
            get => new(() =>
            {
                CurrentView = new RideView();
            });
        }

        public MainViewModel()
        {
            CurrentView = new CarView();
            CurrentView.DataContext = new CarViewModel();
        }
    }
}