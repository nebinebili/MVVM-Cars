using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_.Command;
using Wpf_MVVM_.Models;
using Wpf_MVVM_.Views;

namespace Wpf_MVVM_.ViewModels
{
    public class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public EditView EditView { get; set; }

        public EditViewModel()
        {
            CloseCommand = new RelayCommand(
             e =>
             {
                 EditView.Close();
             },
             p => { return true; }
             );
            
        }
    }
}
