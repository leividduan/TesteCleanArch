namespace TesteDash.Domain.Entities
{
	public class Product
	{
		public int ID_Product { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int ID_Category { get; set; }

		// Relationships
		public Category Category { get; set; }
	}
}
