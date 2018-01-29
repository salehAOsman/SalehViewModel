using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalehViewModel.Models
{
    //3  efter create this static List we create ---> new controller 
    public class MyList
    {
        static public List<Person> myList = new List<Person>();
        //static constractor
      static MyList()
        {
            MyList.myList.Add(new Person { Id = 1, Name = "samer", City = "Lund" });
            MyList.myList.Add(new Person { Id = 2, Name = "sami", City = "Växjö" });
        }
    }
}