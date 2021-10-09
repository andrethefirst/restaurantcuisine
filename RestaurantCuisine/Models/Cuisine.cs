
using System.Collections.Generic;

namespace RestaurantCuisine.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}