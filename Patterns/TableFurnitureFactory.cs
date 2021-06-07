namespace Patterns
{
    class TableFurnitureFactory : IFurnitureFactory
    {
        public IGreenFurniture ProduceGreenFurniture()
        {
            return new GreenTable();
        }
        public IRedFurniture ProduceRedFurniture()
        {
            return new RedTable();
        }
    }
}