using Altbrot.AoC._2022._01.Application.ElfBags.Contracts;
using Altbrot.AoC._2022._01.Domain.Entities;

namespace Altbrot.AoC._2022._01.Infrastructur.Repositories;

public class ReadElfBagRepository : IReadElfBagRepository
{
    private const string Separator = "\r\n";

    public async Task<IEnumerable<ElfBag>> ReadElfBagsAsync(string data)
    {
        var calories = data.Split(Separator).Select(line => {
            if (Int32.TryParse(line, out int calorie))
            {
                return calorie;
            }
            else
            {
                return default;
            }
        });

        List<ElfBag> list = new();

        foreach (var calorie in calories)
        {
            if (list.Count <= 0 || calorie == default)
            {
                list.Add(ElfBag.Create());
            }

            if (calorie > 0)
            {
                list.Last().Add(Food.Create(calorie));
            }
        }

        return await Task.Factory.StartNew(() => list);
    }
}
