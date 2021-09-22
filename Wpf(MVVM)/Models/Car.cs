using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM_.Models
{
    public class Car:Entity
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Vendor} - {Model} -{Year}";
        }
    }
}
