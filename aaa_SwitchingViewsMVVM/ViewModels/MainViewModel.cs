using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace aaa_SwitchingViewsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel = new HomeViewModel();

        public BaseViewModel SelectedViewMode
        {
            get 
            { 
                return _selectedViewModel; 
            }
            set 
            {
                _selectedViewModel = value; 
            }
        }

        public ICommand UpdateViewCommand { get; set; }

    }
}
