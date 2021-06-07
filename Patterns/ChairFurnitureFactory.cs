namespace Patterns
{
    class ChairFurnitureFactory : IFurnitureFactory
    {
        public IGreenFurniture ProduceGreenFurniture()
        {
            return new GreenChair();
        }

        public IRedFurniture ProduceRedFurniture()
        {
            return new RedChair();
        }
    }
}