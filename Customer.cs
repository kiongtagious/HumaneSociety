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
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            var result = from r in context.Adopters select r;
            return result.ToList();
        }
        public Dog SearchForDog(string dog)
        {
            HumaneSocietyDataContext context = new HumaneSocietyDataContext();
            Dog dogResult = (from r in context.Dogs
                                          where r.dog == dog
                                          select r).First();
            return dogResult;
        }
    }
}
