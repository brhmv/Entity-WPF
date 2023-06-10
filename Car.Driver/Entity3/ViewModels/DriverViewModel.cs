using Entity3.DBContext;
using Entity3.Models;
using Entity3.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Entity3.ViewModels
{
    internal class DriverViewModel : ViewModelBase
    {
        public static ObservableCollection<Driver>? driverListboxSource ;

        public ObservableCollection<Driver>? DriverListboxSource
        {
            get { return driverListboxSource; }
            set { Set(ref driverListboxSource, value); }
        }
                
        
        Driver? selectedDriver = new();

        public Driver? SelectedDriver
        {
            get { return selectedDriver; }
            set { Set(ref selectedDriver, value); }
        }


        internal SchoolBusDB SDBContext = new();


        public DriverViewModel()
        {
            if (driverListboxSource == null)
            {
                driverListboxSource = new();
                foreach (var item in SDBContext.Drivers)
                {
                    DriverListboxSource!.Add(item);
                }
            }
        }

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                DriverAddView window = new();
                window.Show();
                window.DataContext = new DriverAddViewModel();
            });
        }

        public RelayCommand Delete_Button
        {
            get => new(() =>
            {
                try
                {
                    SDBContext.Drivers.Remove(SelectedDriver!);
                    SDBContext.SaveChanges();
                    driverListboxSource!.Remove(SelectedDriver!);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}