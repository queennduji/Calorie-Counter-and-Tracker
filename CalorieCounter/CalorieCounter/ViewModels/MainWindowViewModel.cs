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
        public ObservableCollection<FoodCalorie> BreakFastCalories { get; set; } = new ObservableCollection<FoodCalorie>
        {
            new FoodCalorie {Food = "Beans", Calorie = 1800},
            new FoodCalorie {Food = "Rice", Calorie = 1900},
            new FoodCalorie {Food = "Yam", Calorie = 1700},
            new FoodCalorie {Food = "Parsnips", Calorie = 1600}
        };


        public ObservableCollection<FoodCalorie> LunchCalories { get; set; } = new ObservableCollection<FoodCalorie>
        {
            new FoodCalorie {Food = "Beans", Calorie = 1800},
            new FoodCalorie {Food = "Rice", Calorie = 1900},
            new FoodCalorie {Food = "Yam", Calorie = 1700},
            new FoodCalorie {Food = "Parsnips", Calorie = 1600}
        };

        public ObservableCollection<FoodCalorie> DinnerCalories { get; set; } = new ObservableCollection<FoodCalorie>
        {
            new FoodCalorie {Food = "Beans", Calorie = 1800},
            new FoodCalorie {Food = "Rice", Calorie = 1900},
            new FoodCalorie {Food = "Yam", Calorie = 1700},
            new FoodCalorie {Food = "Parsnips", Calorie = 1600}
        };

        public ObservableCollection<FoodCalorie> SnacksCalories { get; set; } = new ObservableCollection<FoodCalorie>
        {
            new FoodCalorie {Food = "Beans", Calorie = 1800},
            new FoodCalorie {Food = "Rice", Calorie = 1900},
            new FoodCalorie {Food = "Yam", Calorie = 1700},
            new FoodCalorie {Food = "Parsnips", Calorie = 1600}
        };

        public ObservableCollection<Exercise> ExerciseCalories { get; set; } = new ObservableCollection<Exercise>
        {
            new Exercise {ExerciseType = "Cardio", CalorieBurnt = 1800},
            new Exercise {ExerciseType = "HIT", CalorieBurnt = 1800},
            new Exercise {ExerciseType = "Cardio", CalorieBurnt = 1800},
            new Exercise {ExerciseType = "HIT", CalorieBurnt = 1800}
        };

        public ObservableCollection<double> WaterCalories { get; set; } = new ObservableCollection<double> { 5,6,5};


    }
}
