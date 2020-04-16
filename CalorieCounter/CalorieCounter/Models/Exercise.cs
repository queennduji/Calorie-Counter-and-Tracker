using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalorieCounter.ViewModels
{
    public class Exercise : INotifyPropertyChanged
    {
        public string ExerciseType { get; set; }

        public double CalorieBurnt { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}