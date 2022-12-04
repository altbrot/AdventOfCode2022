using Altbrot.AoC._2022._01.Application.ElfBags.Contracts;
using Altbrot.AoC._2022._01.Application.ElfBags.UseCases;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Altbrot.AoC._2022._01.Test
{
    public class Tests
    {
        string[] _args = Array.Empty<string>();
        IHost _host;

        [SetUp]
        public void Setup()
        {
            _host = Host.CreateDefaultBuilder(_args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddAdventOfCode();
                }).Build();
        }

        [Test]
        [TestCaseSource(typeof(CaloriesCases))]
        public async Task ShouldReturnMaxCalorieOfAllElfBags(string data)
        {
            // when
            var result = await _host.Services
                .GetRequiredService<IGetHighestAmountOfCaloriesPerElf>()
                .ExecuteAsync(data);

            // then
            result.Should().Be(24000);
        }

        [Test]
        [TestCaseSource(typeof(CaloriesCases))]
        public async Task ShouldReturnListOfElfBags(string data)
        {
            // when
            var result = (await _host.Services
                .GetRequiredService<IReadElfBagRepository>()
                .ReadElfBagsAsync(data))
                .ToList();

            // then
            result.Should().HaveCount(5);

            result[0].Inventory.Should().HaveCount(3);
            result[1].Inventory.Should().HaveCount(1);
            result[2].Inventory.Should().HaveCount(2);
            result[3].Inventory.Should().HaveCount(3);
            result[4].Inventory.Should().HaveCount(1);

            result[0].Inventory[0].Calorie.Should().Be(1000);
            result[0].Inventory[1].Calorie.Should().Be(2000);
            result[0].Inventory[2].Calorie.Should().Be(3000);

            result[1].Inventory[0].Calorie.Should().Be(4000);

            result[2].Inventory[0].Calorie.Should().Be(5000);
            result[2].Inventory[1].Calorie.Should().Be(6000);

            result[3].Inventory[0].Calorie.Should().Be(7000);
            result[3].Inventory[1].Calorie.Should().Be(8000);
            result[3].Inventory[2].Calorie.Should().Be(9000);

            result[4].Inventory[0].Calorie.Should().Be(10000);
        }
    }
}