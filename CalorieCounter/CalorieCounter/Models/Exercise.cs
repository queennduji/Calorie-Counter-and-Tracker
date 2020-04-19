using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalorieCounter.ViewModels
{
    public class Exercise : INotifyPropertyChanged
    {
        private string _exerciseType;

        public string ExerciseType
        {
            get { return _exerciseType; }
            set
            {
                _exerciseType = value;
                OnPropertyChanged();
            }
        }

        private double _calorieBurnt;

        public double CalorieBurnt
        {
            get { return _calorieBurnt; }
            set
            {
                _calorieBurnt = value;
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