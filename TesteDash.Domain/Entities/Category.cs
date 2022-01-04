namespace TesteDash.Domain.Entities
{
	public class Category
	{
		public int ID_Category { get; set; }
		public string Name { get; set; }

		// Relationships
		public ICollection<Product> Product { get; set; }
	}
}
