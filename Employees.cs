using System;
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
                HumaneSocietyDataContext context = new HumaneSocietyDataContext();
                context.Dogs.InsertOnSubmit(dog);
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
                HumaneSocietyDataContext context = new HumaneSocietyDataContext();
                context.Cats.InsertOnSubmit(cat);
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
                HumaneSocietyDataContext context = new HumaneSocietyDataContext();
                context.Dogs.InsertOnSubmit(dog);
                context.SubmitChanges();
            }
        }
        public void CatAdoptStatus(Cat cat)
        {
            if (animal == "Adopted")
            {
                HumaneSocietyDataContext context = new HumaneSocietyDataContext();
                context.Cats.InsertOnSubmit(cat);
                context.SubmitChanges();
            }
        }
        public void DogFoodTracker(Dog dog)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            foreach (var search in context.Dogs)
            {
               if (search.AmountOfFoodNeeded == "dog")
                {
                    Console.WriteLine("AmountOfFoodNeeded: ");
                    Console.ReadLine();
                }
            }
        }
        public void CatFoodTracker(Cat cat)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            foreach (var search in context.Cats)
            {
                if (search.AmountOfFoodNeeded == "cat")
                {
                    Console.WriteLine("AmountOfFoodNeeded: ");
                    Console.ReadLine();
                }
            }
        }
        public void DogShotStatus(Dog dog)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            
            if (dog.ShotStatus == true)
            {
                Console.WriteLine("Shots are up to-date!");
            }
            else if (dog.ShotStatus == false)
            {
                Console.WriteLine("Shots are not up to-date!");
            }
            else
            {

            }
        }
        public void CatShotStatus(Cat cat)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();

            if (cat.ShotStatus == true)
            {
                Console.WriteLine("Shots are up to-date!");
            }
            else if (cat.ShotStatus == false)
            {
                Console.WriteLine("Shots are not up to-date!");
            }
            else
            {

            }
        }
        public int CollectMoney()
        {
            int number = 0;
            int num;

            Console.WriteLine("The adoption fee for a dog is $200 and for a cat it is $100.");          
            number = int.Parse(Console.ReadLine());
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }







    }
}
