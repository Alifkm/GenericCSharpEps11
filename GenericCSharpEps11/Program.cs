namespace GenericCSharpEps11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new product
            Product product = new Product
            {
                Id = 1,
                Name = "Laptop"
            };

            // Create a repository for Product type
            ProductRepository<Product> productRepository = new ProductRepository<Product>();

            // Add the product to the repository
            productRepository.Add(product);
            Console.WriteLine($"Product added: {product.Name}");

            // Remove the product from the repository (though no logic is implemented)
            productRepository.Remove(product);
            Console.WriteLine($"Product removed: {product.Name}");
        }
    }

    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class ProductRepository<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            if (entity.GetType() == typeof(Product))
            {
                // Normally here, you'd add the product to some data store or list
                Console.WriteLine("Product added to repository.");
            }
        }

        public void Remove(T entity)
        {
            if (entity.GetType() == typeof(Product))
            {
                // Normally here, you'd remove the product from some data store or list
                Console.WriteLine("Product removed from repository.");
            }
        }
    }
}