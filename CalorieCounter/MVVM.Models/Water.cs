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
    [Table("Water")]
    public class Water : ModelBase,INotifyPropertyChanged
   {
       private double _water;
        public double WaterAdded
        {
            get { return _water; }
            set
            {
                _water = value;
                OnPropertyChanged("Water");
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
