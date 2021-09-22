using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Wpf_MVVM_.Command;
using Wpf_MVVM_.Models;
using Wpf_MVVM_.Repository;
using Wpf_MVVM_.Views;

namespace Wpf_MVVM_.ViewModels
{
    public class MainViewModel
    {
        public Car Car { get; set; } 
        public ObservableCollection<Car> Cars{ get; set; }

        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand SelectCommand { get; set; }

        public EditViewModel EditViewModel { get; set; }
        public EditView editView { get; set; }

        public MainViewModel()
        {
            //Car = new Car
            //{
            //    Id = 1,
            //    Model = "F10",
            //    Vendor = "BMW",
            //    Year = 2021
            //};

            Cars = new FakeRepo().Cars;


            SelectCommand = new RelayCommand(
              a =>
              {
                  Car = ((MainView)Application.Current.MainWindow).cmbBox.SelectedItem as Car;
              },
              p => { return true; });

            ShowCommand = new RelayCommand(
             a => { MessageBox.Show($"{Car.Vendor} - {Car.Model} - {Car.Year}"); },
             p => { return true; });

            EditCommand = new RelayCommand(
             a =>
             {
                 EditViewModel = new EditViewModel();
                 EditViewModel.Car = Car;

                 editView = new EditView();
                 editView.DataContext = EditViewModel;
                 EditViewModel.EditView = editView;

                 editView.ShowDialog();               
             }
             );
        }
    }
}
