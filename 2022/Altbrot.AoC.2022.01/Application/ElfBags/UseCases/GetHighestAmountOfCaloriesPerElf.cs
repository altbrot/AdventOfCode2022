using Altbrot.AoC._2022._01.Application.ElfBags.Contracts;

namespace Altbrot.AoC._2022._01.Application.ElfBags.UseCases;

public class GetHighestAmountOfCaloriesPerElf : IGetHighestAmountOfCaloriesPerElf
{
    private readonly IReadElfBagRepository readElfBagRepository;

    public GetHighestAmountOfCaloriesPerElf(
        IReadElfBagRepository readElfBagRepository)
    {
        this.readElfBagRepository = readElfBagRepository;
    }

    public async Task<int> ExecuteAsync(string data)
    {
        return (await readElfBagRepository
            .ReadElfBagsAsync(data))
            .Select(bag => bag.Inventory.Sum(i => i.Calorie))
            .OrderByDescending(cal => cal)
            .First();
    }
}
