namespace RestaurantCuisine.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurants { get; set; }
  }
}