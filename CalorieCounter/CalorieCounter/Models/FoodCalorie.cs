using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Models
{
    public class FoodCalorie : INotifyPropertyChanged
    {
        private string _food;
        public string Food
        {
            get { return _food; }
            set
            {
                _food = value;
                OnPropertyChanged();
            }
        }

        private double _calorie;

        public double Calorie
        {
            get { return _calorie; }
            set
            {
                _calorie = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
