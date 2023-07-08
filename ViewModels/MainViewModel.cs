using BMS_INIT.Base;
using BMS_INIT.Models;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BMS_INIT.ViewModels
{
    public class MainViewModel : NotifyBase

    {
        public static List<MainModel> arg = new List<MainModel>();
        #region Monitor 页面数据
        public List<string> BatteryGroup { get; set; } = new List<string>();
        private object _pageObject;


        public List<string> BatteryMessage { get; set; } = new List<string>();
       



        #endregion
      
        public object PageObject
        {
            get { return _pageObject; }
            set { SetProperty(ref _pageObject, value); }
        }

        public Command NavCommand { get; set; }
        public MainViewModel()
        {
            NavCommand = new Command(SwitchPage);
            this.SwitchPage("MonitorPage");


            for (int i = 0;i<100;i++)
            {
                BatteryGroup.Add(i.ToString()); 
            }
            for (int i = 0;i<10;i++)
            {
                BatteryMessage.Add(i.ToString());
            }
        }

        private void SwitchPage(object page)
        {
            Type type = Assembly.GetExecutingAssembly().GetType("BMS_INIT.Views.Pages." + page.ToString());
            this.PageObject = Activator.CreateInstance(type);
        }
    }
}


