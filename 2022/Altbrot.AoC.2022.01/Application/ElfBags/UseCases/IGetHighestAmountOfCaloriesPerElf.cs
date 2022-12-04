namespace Altbrot.AoC._2022._01.Application.ElfBags.UseCases;

public interface IGetHighestAmountOfCaloriesPerElf
{
    Task<int> ExecuteAsync(string data);
}
