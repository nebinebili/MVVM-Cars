using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_.Models;

namespace Wpf_MVVM_.Repository
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }

        public FakeRepo()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Id=1,
                    Vendor="BMW",
                    Model="X5",
                    Year=2019
                },
                new Car
                {
                    Id=2, 
                    Vendor="Mercedes",
                    Model="C-class", 
                    Year=2020
                },
                new Car
                {
                    Id=3, 
                    Vendor="KIA", 
                    Model="Sportage", 
                    Year=2017
                },
            };
        }
    }
}
