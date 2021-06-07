namespace Patterns
{
    public interface IFurnitureFactory
    {
        IGreenFurniture ProduceGreenFurniture();

        IRedFurniture ProduceRedFurniture();
    }
}