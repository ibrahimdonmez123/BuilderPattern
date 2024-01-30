namespace BuilderPattern.Product
{
    public interface IProductBuilder
    {
        void BuildName(string name);
        void BuildCategory(string category);
        void BuildPrice(decimal price);
        Product GetProduct();
    }
}
