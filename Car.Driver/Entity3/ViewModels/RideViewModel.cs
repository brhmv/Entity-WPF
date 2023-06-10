using Entity3.DBContext;
using Entity3.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Entity3.ViewModels
{
    internal class RideViewModel  : ViewModelBase
    {

        public ObservableCollection<Ride>? _RideListboxSource = new();

        public ObservableCollection<Ride>? RideListboxSource
        {
            get { return _RideListboxSource; }
            set { Set(ref _RideListboxSource, value); }
        }

        
        public Ride? _SelectedRide = new();

        public Ride? SelectedRide
        {
            get { return _SelectedRide; }
            set { Set(ref _SelectedRide, value); }
        }

        internal SchoolBusDB SDBContext = new();

        public RideViewModel()
        {
            foreach (var item in SDBContext.Rides)
            {
                RideListboxSource!.Add(item);
            }
        }


        public RelayCommand Add_Button
        {
            get => new(() =>
            {

            });
        }

        public RelayCommand Delete_Button
        {
            get => new(() =>
            {
                try
                {
                    SDBContext.Rides.Remove(SelectedRide!);
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