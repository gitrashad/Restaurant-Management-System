using System.Collections.Generic;
using FoodieRestaurant.Models;

namespace FoodieRestaurant.ViewModels;

public class HomeViewModel
{
    public List<Category> Categories { get; set; } = new();
    public List<Food> PopularFoods { get; set; } = new();
}
