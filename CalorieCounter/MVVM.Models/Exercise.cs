using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    [Table("Exercise")]
    public class Exercise : ModelBase,INotifyPropertyChanged
    {
        public String Time { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
        private double _calorieBurnt;
        public double CalorieBurnt
        {
            get { return _calorieBurnt; }
            set
            {
                _calorieBurnt = value;
                OnPropertyChanged("CalorieBurnt");
            }
        }

        private string _exerciseType;
        public string ExerciseType
        {
            get { return _exerciseType; }
            set
            {
                _exerciseType = value;
                OnPropertyChanged("ExerciseType");
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
