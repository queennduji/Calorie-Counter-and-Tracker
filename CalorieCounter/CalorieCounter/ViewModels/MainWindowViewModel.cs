using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCounter.Models;

namespace CalorieCounter.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<FoodCalorie> FoodCalories { get; set; } = new ObservableCollection<FoodCalorie>
        {
            new FoodCalorie {Food = "Beans", Calorie = 1800},
            new FoodCalorie {Food = "Rice", Calorie = 1900},
            new FoodCalorie {Food = "Yam", Calorie = 1700},
            new FoodCalorie {Food = "Parsnips", Calorie = 1600}
        };


        //public ObservableCollection<FoodCalorie> FoodCalories { get; set; }



    }
}
