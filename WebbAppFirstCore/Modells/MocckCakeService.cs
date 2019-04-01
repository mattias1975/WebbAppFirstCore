using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Modells
{
    public class MocckCakeService : ICakeService
    {
 
        private List<cake> cakes= new List<cake>();
        private int idCount = 1;

        public MocckCakeService()
        {
            cakes.Add(new cake() { Id = 0, Name = "Chocklad", Price = 10, Details = "good" });
        }

        public List<cake> AllCakes()
        {
            return cakes;
        }

        public cake CreateCake(string name, int price, string details)
        {
            cake cake = new cake() { Id = idCount, Name = name, Price = price, Details = details };
            idCount++;
            cakes.Add(cake);
            return cake;
        }

        public bool DeleteCake(int id)
        {
            bool wasRemoved = false;
            foreach(var item in cakes)
                if(item.Id==id)
             {
                    cakes.Remove(item);
                    wasRemoved = true;
                    break;
            }
     
            return wasRemoved;
        }

        public cake FindCake(int id)
        {
            foreach(cake item in cakes)
            {
                if(item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }

        public bool UpdateCake(cake cake)
        {
            bool wasUpdated = false;
            foreach(cake orginal in cakes)
            {
                if(orginal.Id==cake.Id)
                {
                    orginal.Name = cake.Name;
                    orginal.Price = cake.Price;
                    orginal.Details = cake.Details;
                    wasUpdated = true;
                    break;
                }
            }
            return wasUpdated;
        }
    }
}
