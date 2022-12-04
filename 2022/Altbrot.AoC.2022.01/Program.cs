using Altbrot.AoC._2022._01;
using Altbrot.AoC._2022._01.Application.ElfBags.UseCases;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var host = CreateHostBuilder(args).Build();

var service = host.Services.GetRequiredService<IGetHighestAmountOfCaloriesPerElf>();

var data = File.ReadAllText(Path.Combine(
    Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!,
    "data.txt"));
var highestAmount = await service.ExecuteAsync(data);

Console.WriteLine($"The answer is {highestAmount}");

Console.ReadLine();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddAdventOfCode();
        });
