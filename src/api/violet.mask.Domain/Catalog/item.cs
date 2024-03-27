namespace violet.mask.Domain.Catalog;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }
    public List<Rating> Ratings { get; set; } = new List<Rating>();

    public Item(string name, string description, string brand, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Item name is required");
        }

        if(string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Item description is required");
        }

        if(string.IsNullOrWhiteSpace(brand))
        {
            throw new ArgumentException("Brand name is required");
        }

        if(price <= 0)
        {
            throw new ArgumentException("Price cannot be negative or zero");
        }

        Name = name;
        Description = description;
        Brand = brand;
        Price = price;
    }

    public void AddRating(Rating rating)
    {
        Ratings.Add(rating);
    }
}