namespace Altbrot.AoC._2022._01.Domain.Entities;

public class Food
{
    public int Calorie { get; private set; }

    public static Food Create(int calorie)
    {
        return new Food()
        {
            Calorie = calorie,
        };
    }

    private Food() { }
}
