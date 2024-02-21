

namespace SwinAdventureProg
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);

        string Name
        {
            get;
        }

        Inventory Inventory
        {
            get; 
        }
    }
}
