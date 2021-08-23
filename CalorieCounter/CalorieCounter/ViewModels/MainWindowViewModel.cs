using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using MVVM.Data;
using MVVM.Models;

namespace CalorieCounter.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        CalorieCounterContext context = new CalorieCounterContext();

        #region Constructor
        public MainWindowViewModel()
        {
            SelectedExerciseType = ExerciseTypeList[0];
        }
        #endregion

        #region Lists
        //Observable collection for each item that can be added
        public ObservableCollection<FoodCalorie> BreakFastCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();
        public ObservableCollection<FoodCalorie> LunchCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();
        public ObservableCollection<FoodCalorie> DinnerCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();
        public ObservableCollection<FoodCalorie> SnacksCaloriesList { get; set; } = new ObservableCollection<FoodCalorie>();
        public ObservableCollection<Exercise> ExerciseCaloriesList { get; set; } = new ObservableCollection<Exercise>();
        public ObservableCollection<Water> WaterList { get; set; } = new ObservableCollection<Water>();
        #endregion

        #region Commands MainWindowView
        //commands that open the view where the user inputs his/her data
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
        //properties binding the visibility of each view including mainwindow view
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
        /// <summary>
        /// Function for when the "add food" button is clicked in addfoodview
        /// </summary>
        public void AddFoodCalorie()
        {
            if (OpenAddBreakFast == true)
            {
                //add to breakfastlist
                BreakFastCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddBreakFast = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddBreakFast");

                //store in database
                var t = new FoodCalorie()
                {
                    Breakfast = true,
                    Food = FoodAdded,
                    Calorie = FoodCalorieAdded
                };
                context.FoodsAndCalories.Add(t);
                context.SaveChanges();
            }
            else
            if (OpenAddLunch == true)
            {
                LunchCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddLunch = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddLunch");

                var t = new FoodCalorie()
                {
                    Lunch = true,
                    Food = FoodAdded,
                    Calorie = FoodCalorieAdded
                };
                context.FoodsAndCalories.Add(t);
                context.SaveChanges();
            }
            else
            if (OpenAddDinner == true)
            {
                DinnerCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddDinner = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddDinner");

                //store in database
                var t = new FoodCalorie()
                {
                    Dinner = true,
                    Food = FoodAdded,
                    Calorie = FoodCalorieAdded
                };
                context.FoodsAndCalories.Add(t);
                context.SaveChanges();
            }
            else if (OpenAddSnack == true)
            {
                SnacksCaloriesList.Add(new FoodCalorie { Food = FoodAdded, Calorie = FoodCalorieAdded });
                MainView = true;
                OpenAddSnack = false;
                OnPropertyChanged("MainView");
                OnPropertyChanged("OpenAddSnack");

                //store in database
                var t = new FoodCalorie()
                {
                    Snacks = true,
                    Food = FoodAdded,
                    Calorie = FoodCalorieAdded
                };
                context.FoodsAndCalories.Add(t);
                context.SaveChanges();
            }
        }
        #endregion

        #region Properties and commands AddExerciseView

        //itemsource for the combobox control
        public ObservableCollection<string> _exerciseTypeList = new ObservableCollection<string>
            {"Cardio", "Strength" };
        public ObservableCollection<string> ExerciseTypeList
        {
            get { return _exerciseTypeList; }
            set { _exerciseTypeList = value; }
        }

        //property binding the selected item of item control;
        private string _selectedExerciseType;
        public string SelectedExerciseType
        {
            get { return _selectedExerciseType; }
            set
            {
                _selectedExerciseType = value;
                OnPropertyChanged();
            }
        }

        //property binding the textbox of exercise calorie added
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

        //command for addexercise button
        //this button adds the exercise and calories to the list and then stores it in the database
        public ICommand AddExerciseCalorieCommand { get { return new RelayCommand(AddExerciseCalorie); } }
        public void AddExerciseCalorie()
        {
            //add and display to exercise list
            ExerciseCaloriesList.Add(new Exercise { ExerciseType = SelectedExerciseType, CalorieBurnt = ExerciseCalorieBurnt });
            MainView = true;
            OpenAddExercise = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddExercise");

            //add to exercise table in database
            var t = new Exercise()
            {
                ExerciseType = SelectedExerciseType,
                CalorieBurnt = ExerciseCalorieBurnt
            };
            context.ExerciseAndCalories.Add(t);
            context.SaveChanges();
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
        {//add water amount to list

            WaterList.Add(new Water { WaterAdded = WaterAdded });
            MainView = true;
            OpenAddWater = false;
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddWater");

            //add to water amount to water table in database
            var t = new Water()
            {
                WaterAdded = WaterAdded
            };
            context.WaterDrank.Add(t);
            context.SaveChanges();
        }

        public ICommand ReturnButtonCommand { get { return new RelayCommand(Return); } }
        public void Return()
        {
            MainView = true;
            if (OpenAddWater || OpenAddExercise || OpenAddSnack || OpenAddBreakFast || OpenAddLunch || OpenAddDinner)
            {
                OpenAddWater = false;
                OpenAddExercise = false;
                OpenAddSnack = false;
                OpenAddBreakFast = false;
                OpenAddLunch = false;
                OpenAddDinner = false;
            }
            OnPropertyChanged("MainView");
            OnPropertyChanged("OpenAddWater");
            OnPropertyChanged("OpenAddExercise");
            OnPropertyChanged("OpenAddSnack");
            OnPropertyChanged("OpenAddBreakFast");
            OnPropertyChanged("OpenAddLunch");
            OnPropertyChanged("OpenAddDinner");
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
