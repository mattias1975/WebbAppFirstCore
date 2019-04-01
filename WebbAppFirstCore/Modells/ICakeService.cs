using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppFirstCore.Modells
{
    public interface ICakeService
       
    {//Crud
        //C
        cake CreateCake(string name, int price, string details);
        //R
        List<cake> AllCakes();
        //R
        cake FindCake(int id);

        //U
       bool UpdateCake(cake cake);

        //Delete
        bool DeleteCake(int id);

        

    }
}
