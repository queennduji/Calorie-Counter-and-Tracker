using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;

namespace MVVM.Data
{
   public class CalorieCounterContext : DbContext
    {

        public CalorieCounterContext() : base("default")
        {

        }
        public DbSet<FoodCalorie> FoodsAndCalories { get; set; }
        public DbSet<Exercise> ExerciseAndCalories { get; set; }
        public DbSet<Water> WaterDrank { get; set; }
    }
}
