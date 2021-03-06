﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Animal
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

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
        public void DogAdoptStatus()
        {
            if (dog.adoptStatus == "Adopted")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(dog);
                context.SubmitChanges();
            }
        }
        public void CatAdoptStatus()
        {
            if (cat.adoptStatus == "Adopted")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                context.Animals.InsertOnSubmit(cat);
                context.SubmitChanges();
            }
        }
    }
}
