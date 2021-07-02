using NET.RESTfull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.RESTfull.Data
{
    public class DataService
    {
        public List<Dish> Dishes { get; set; }

        public DataService()
        {
            Dishes = new List<Dish>();
        }
    }
}
