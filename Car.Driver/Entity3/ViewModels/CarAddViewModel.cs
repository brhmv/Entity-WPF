using Entity3.DBContext;
using Entity3.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace Entity3.ViewModels
{
    internal class CarAddViewModel : ViewModelBase
    {
        internal SchoolBusDB SDBContext = new();


        public Car? _NewCar = new();

        public Car? NewCar
        {
            get { return _NewCar; }
            set { Set(ref _NewCar, value); }
        }

        public RelayCommand Add_Button
        {
            get => new(() =>
            {
                try
                {
                    //MessageBox.Show($"{NewCar!.Name} {NewCar.Number} {NewCar.SeatCount}");
                    SDBContext.Cars.Add(NewCar!);
                    CarViewModel._CarListboxSource!.Add(NewCar!);
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