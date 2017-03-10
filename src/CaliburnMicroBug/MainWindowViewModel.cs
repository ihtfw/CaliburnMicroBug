using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace CaliburnMicroBug
{
    class MainWindowViewModel : Conductor<Screen>.Collection.OneActive
    {
        public MainWindowViewModel()
        {
            var singletonViewModel = new SingletonViewModel();

            Items.Add(new ScreenViewModel
            {
                DisplayName = "Screen 1",
                SingletonViewModel = singletonViewModel
            });

            Items.Add(new ScreenViewModel
            {
                DisplayName = "Screen 2",
                SingletonViewModel = singletonViewModel
            });

            ActiveItem = Items.First();
        }

        public void ToScreen1()
        {
            ActiveItem = Items.First();
        }
        public void ToScreen2()
        {
            ActiveItem = Items.Last();
        }
    }
}
