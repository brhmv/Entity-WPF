using Entity3.DBContext;
using Entity3.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace Entity3.ViewModels
{
    internal class DriverAddViewModel : ViewModelBase
    {
        internal SchoolBusDB SDBContext = new();


        Driver? newDriver = new();

        public Driver? NewDriver
        {
            get { return newDriver; }
            set { Set(ref newDriver, value); }
        }


        Car? selectedCar;

        public Car? SelectedCar
        {
            get { return selectedCar; }
            set { Set(ref selectedCar, value); }
        }


        ObservableCollection<Car>? _carListboxSource = new();

        public ObservableCollection<Car>? CarListboxSource
        {
            get { return _carListboxSource; }
            set { Set(ref _carListboxSource, value); }
        }



        public DriverAddViewModel()
        {
            var a = SDBContext.Cars.ToList();
            var b = SDBContext.Drivers.ToList();

            foreach (Car car in a)
            {
                if (car.Driver == null)
                    CarListboxSource!.Add(car);
            }
        }

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    NewDriver!.Car = SelectedCar;
                    if (SelectedCar != null)
                    {
                        SDBContext.Drivers.Add(NewDriver);
                        SDBContext.SaveChanges();
                        DriverViewModel.driverListboxSource!.Add(newDriver!);

                    }
                    else MessageBox.Show("Choose Car!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}