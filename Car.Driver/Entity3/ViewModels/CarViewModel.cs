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
    internal class CarViewModel : ViewModelBase
    {
        internal SchoolBusDB SDBContext = new();


        public static ObservableCollection<Car>? _CarListboxSource;

        public ObservableCollection<Car>? CarListboxSource
        {
            get { return _CarListboxSource; }
            set { Set(ref _CarListboxSource, value); }
        }


        Car? _SelectedCar = new();

        public Car? SelectedCar
        {
            get { return _SelectedCar; }
            set { Set(ref _SelectedCar, value); }
        }


        public CarViewModel()
        {
            if (CarListboxSource == null)
            {
                CarListboxSource = new();
                foreach (var item in SDBContext.Cars)
                    CarListboxSource!.Add(item);
            }
        }



        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                CarAddView a = new();
                a.Show();
                a.DataContext = new CarAddViewModel();

            });
        }

        public RelayCommand Delete_Button
        {
            get => new(() =>
            {
                try
                {
                    Car car = SelectedCar!;
                    CarListboxSource!.Remove(car!);
                    SDBContext.Cars.Remove(car!);
                    SDBContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}