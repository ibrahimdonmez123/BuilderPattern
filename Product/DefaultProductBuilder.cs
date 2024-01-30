namespace BuilderPattern.Product
{
    public class DefaultProductBuilder : IProductBuilder
    {
        private Product product = new Product();

        public void BuildName(string name)
        {
            product.Name = name;
        }

        public void BuildCategory(string category)
        {
            product.Category = category;
        }

        public void BuildPrice(decimal price)
        {
            product.Price = price;
        }

        public Product GetProduct()
        {
            return product;
        }
    }

}
