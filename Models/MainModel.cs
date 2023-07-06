using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_INIT.Models
{
    public class MainModel:Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
    {
        private object _pageObject;
        private object PageObject
        {
            get { return _pageObject; }
            set { SetProperty(ref _pageObject, value); }
        }
    }
}
