using Altbrot.AoC._2022._01.Application.ElfBags.Contracts;
using Altbrot.AoC._2022._01.Application.ElfBags.UseCases;
using Altbrot.AoC._2022._01.Infrastructur.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Altbrot.AoC._2022._01;

public static class DependencyInjection
{
    public static IServiceCollection AddAdventOfCode(this IServiceCollection services)
    {
        services.AddScoped<IReadElfBagRepository, ReadElfBagRepository>();
        services.AddScoped<IGetHighestAmountOfCaloriesPerElf, GetHighestAmountOfCaloriesPerElf>();

        return services;
    }
}
