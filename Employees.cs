﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Employees
    {
        string animal = "newAnimal";

        public static bool AddDog(Dog dog)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(dog);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AddCat(Cat cat)
        {
            try
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(cat);
                context.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void DogAdoptStatus(Dog dog)
        {

            if (animal == "Adopted")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(dog);
                context.SubmitChanges();
            }
        }
        public void CatAdoptStatus(Cat cat)
        {
            if (animal == "Adopted")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(cat);
                context.SubmitChanges();
            }
        }
        public void DogFoodTracker(Dog dog)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            foreach (var search in context.Dog)
            {
               if (search.Food == dog)
                {
                    Console.WriteLine("FoodType: ");
                    Console.ReadLine();
                }
            }
        }
        public void CatFoodTracker(Cat cat)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            foreach (var search in context.Cat)
            {
                if (search.Food == cat)
                {
                    Console.WriteLine("FoodType: ");
                    Console.ReadLine();
                }
            }
        }
    }
}
