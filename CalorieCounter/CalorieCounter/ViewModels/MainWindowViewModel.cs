using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CalorieCounter.Models;
using GalaSoft.MvvmLight.CommandWpf;

namespace CalorieCounter.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Lists

        public ObservableCollection<FoodCalorie> BreakFastCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();

        public ObservableCollection<FoodCalorie> LunchCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();

        public ObservableCollection<FoodCalorie> DinnerCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();

        public ObservableCollection<FoodCalorie> SnacksCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>
                ();

        public ObservableCollection<Exercise> ExerciseCaloriesList { get; set; } = new ObservableCollection<Exercise>
            ();

        public ObservableCollection<double> WaterList { get; set; } = new ObservableCollection<double>();

        #endregion

        #region Commands MainWindowView
        public ICommand AddFoodBreakFastCaloriesCommand
        {
            get
            {
                return new RelayCommand(AddBreakFastCalories);

            }
        }

        public void AddBreakFastCalories()
        {
            OpenAddBreakFast = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddBreakFast");
        }

        public ICommand AddFoodLunchCaloriesCommand
        {
            get
            {
                return new RelayCommand(AddFoodLunchCalories);

            }
        }

        public void AddFoodLunchCalories()
        {
            OpenAddLunch = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddLunch");
        }

        public ICommand AddFoodDinnerCaloriesCommand
        {
            get
            {
                return new RelayCommand(AddFoodDinnerCalories);

            }
        }

        public void AddFoodDinnerCalories()
        {
            OpenAddDinner = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddDinner");
        }

        public ICommand AddFoodSnackCaloriesCommand
        {
            get
            {
                return new RelayCommand(AddFoodSnackCalories);
            }
        }

        public void AddFoodSnackCalories()
        {
            OpenAddSnack = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddSnack");
        }

        public ICommand AddExerciseCaloriesCommand
        {
            get
            {
                return new RelayCommand(AddExerciseCalories);
            }
        }

        public void AddExerciseCalories()
        {
            OpenAddExercise = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddExercise");
        }

        public ICommand AddWaterCommand
        {
            get
            {
                return new RelayCommand(AddWater);
            }
        }

        public void AddWater()
        {
            OpenAddWater = true;
            MainView = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddWater");
        }
        #endregion


        #region Properties MainWindowView

        private bool _mainView = true;
        public bool MainView
        {
            get { return _mainView; }
            set { _mainView = value; }
        }
        private bool _openAddBreakFast = false;

        public bool OpenAddBreakFast
        {
            get { return _openAddBreakFast; }
            set { _openAddBreakFast = value; }
        }

        private bool _openAddLunch = false;

        public bool OpenAddLunch { get; set; }

        private bool _openAddDinner = false;

        public bool OpenAddDinner { get; set; }

        private bool _openAddSnack = false;

        public bool OpenAddSnack { get; set; }

        private bool _openAddExercise = false;

        public bool OpenAddExercise { get; set; }

        private bool _openAddWater = false;

        public bool OpenAddWater { get; set; }

        #endregion

        #region Properties and Commands AddFoodView
        private string _foodAdded;

        public string FoodAdded
        {
            get { return _foodAdded; }
            set
            {
                _foodAdded = value;
                OnPropertyChanged();
            }
        }

        private double _foodCalorieAdded;

        public double FoodCalorieAdded
        {
            get { return _foodCalorieAdded; }
            set
            {
                _foodCalorieAdded = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddFoodCalorieCommand { get { return new RelayCommand(AddFoodCalorie); } }

        public void AddFoodCalorie()
        {
            if (OpenAddBreakFast == true)
            {
                BreakFastCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddBreakFast = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddBreakFast");
            }
            else
            if (OpenAddLunch == true)
            {
                LunchCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddLunch = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddLunch");
            }
            else
            if (OpenAddDinner == true)
            {
                DinnerCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddDinner = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddDinner");
            }
            else if (OpenAddSnack == true)
            {
                SnacksCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddSnack = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddSnack");
            }
        }
        #endregion

        #region Properties and commands AddExerciseView

        private string _cardio = "Cardio";

        public string Cardio
        {
            get { return _cardio; }
        }

        private string _strength = "Strength";

        public string Strength
        {
            get { return _strength; }
        }

        private double _exerciseCalorieBurnt;

        public double ExerciseCalorieBurnt
        {
            get { return _exerciseCalorieBurnt; }
            set
            {
                _exerciseCalorieBurnt = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddExerciseCalorieCommand { get { return new RelayCommand(AddExerciseCalorie); } }

        public void AddExerciseCalorie()
        {
            ExerciseCaloriesList.Add(new Exercise { ExerciseType = FoodAdded, CalorieBurnt = FoodCalorieAdded });
            MainView = true;
            OpenAddExercise = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddExercise");
        }

        #endregion

        #region Properties and Commands AddWaterView

        private double _waterAdded;

        public double WaterAdded
        {
            get { return _waterAdded; }
            set { _waterAdded = value; }
        }

        public ICommand AddedWaterCommand { get { return new RelayCommand(AddedWater); } }

        public void AddedWater()
        {
         
                WaterList.Add(WaterAdded);
                MainView = true;
                OpenAddWater = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddWater");
            
        }

        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
