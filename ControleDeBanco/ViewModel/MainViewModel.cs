using ControleDeBanco.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBanco.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CreateViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public CreateViewModel CreateVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            HomeVM = new();
            CreateVM = new();
            CurrentView = CreateVM;

            HomeViewCommand = new(_ =>
            {
                CurrentView = HomeVM;
            });


            CreateViewCommand = new (_ =>
            {
                CurrentView = CreateVM;
            });
        }
    }
}
