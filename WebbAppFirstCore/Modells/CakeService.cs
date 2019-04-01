using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Modells
{
    public class CakeService : ICakeService
    {
        private readonly CakeDBContext _cakeDBContext;

        public CakeService(CakeDBContext cakeDBContext)
        {
            _cakeDBContext = cakeDBContext;
        }

        public List<cake> AllCakes()
        {
            return _cakeDBContext.Caked.ToList();
        }

        public cake CreateCake(string name, int price, string details)
        {
            cake cake = new cake() { Name = name, Price = price, Details = details };

            _cakeDBContext.Caked.Add(cake);
            _cakeDBContext.SaveChanges();
            return cake;
        }

        public bool DeleteCake(int id)
        {
            bool wasRemoved = false;

            cake cake = _cakeDBContext.Caked.SingleOrDefault(caked => caked.Id == id);
            if (cake == null)
            {
                return wasRemoved;
            }
            _cakeDBContext.Caked.Remove(cake);
            _cakeDBContext.SaveChanges();

            return wasRemoved;


        }
        public cake FindCake(int id)
        {
            return _cakeDBContext.Caked.SingleOrDefault(Caked => Caked.Id == id);
        }

        public bool UpdateCake(cake cake)
        {
            bool wasUpdated = false;
            cake orginal = _cakeDBContext.Caked.SingleOrDefault(Caked => Caked.Id == cake.Id);

            if (orginal != null)
            {
                orginal.Name = cake.Name;
                orginal.Price = cake.Price;
                orginal.Details = cake.Details;

                _cakeDBContext.SaveChanges();
                wasUpdated = true;
            }

            return wasUpdated;
        }
    }
}
