namespace Altbrot.AoC._2022._01.Domain.Entities;

public class ElfBag
{
    public List<Food> Inventory { get; private set; } = new List<Food>();

    public static ElfBag Create()
    {
        return new ElfBag() { };
    }

    public void Add(Food food)
    {
        Inventory.Add(food);
    }

	private ElfBag() { }
}
