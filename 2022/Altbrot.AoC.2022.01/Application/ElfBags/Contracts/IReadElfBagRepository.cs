using Altbrot.AoC._2022._01.Domain.Entities;

namespace Altbrot.AoC._2022._01.Application.ElfBags.Contracts;

public interface IReadElfBagRepository
{
    Task<IEnumerable<ElfBag>> ReadElfBagsAsync(string data);
}
