using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    [Table("FoodCalorie")]
    public class FoodCalorie : ModelBase,INotifyPropertyChanged
    {
        private string _food;
        [Required, StringLength(50)]
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
        [Required]
        public double Calorie
        {
            get { return _calorie; }
            set
            {
                _calorie = value;
                OnPropertyChanged();
            }
        }

        public String Time { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");

        public bool Breakfast { get; set; } = false;
        public bool Lunch { get; set; } = false;
        public bool Dinner { get; set; } = false;
        public bool Snacks { get; set; } = false;

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
