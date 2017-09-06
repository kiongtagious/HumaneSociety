using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Customer
    {
        public Customer()
        {

        }
        public static List<Adopter> AdopterProfile()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var result = from r in context.Adopter select r;
            return result.ToList();
        }
        public Dog SearchForDog(string dog)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            Dog dogResult = (from r in context.dog
                                          where r.dog == dog
                                          select r).First();
            return dogResult;
        }
    }
}
