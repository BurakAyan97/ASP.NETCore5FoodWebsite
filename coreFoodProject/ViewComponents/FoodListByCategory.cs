﻿using coreFoodProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreFoodProject.ViewComponents
{
    public class FoodListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id) 
        {
         
            FoodRepository foodRepository = new FoodRepository();
            var foodlist = foodRepository.List(x => x.CategoryID == id);
            return View(foodlist);
        }
    }
}
