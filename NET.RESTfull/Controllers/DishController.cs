using Microsoft.AspNetCore.Mvc;
using NET.RESTfull.Data;
using NET.RESTfull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.RESTfull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishController : ControllerBase
    {
        private readonly DataService _dataService;

        public DishController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public List<Dish> GetAll()
        {
            return _dataService.Dishes;
        }

        [HttpGet("{id}")]
        public Dish GetById(int id)
        {
            var item = _dataService.Dishes.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }
            return item;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _dataService.Dishes.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }
            _dataService.Dishes.Remove(item);
        }

        [HttpPost]
        public void Create(Dish item)
        {
            _dataService.Dishes.Add(item);
        }

        [HttpPut]

        public void Edit(Dish item)
        {
            var itemToReplace = _dataService.Dishes.FirstOrDefault(i => i.Id == item.Id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }
            _dataService.Dishes[item.Id] = item;
        }
    }
}
