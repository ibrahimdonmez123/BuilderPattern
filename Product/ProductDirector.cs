namespace BuilderPattern.Product
{
    public class ProductDirector
    {
        private IProductBuilder productBuilder;

        public ProductDirector(IProductBuilder builder)
        {
            productBuilder = builder;
        }

        public void ConstructProduct(string name, string category, decimal price)
        {
            productBuilder.BuildName(name);
            productBuilder.BuildCategory(category);
            productBuilder.BuildPrice(price);
        }
    }

}
