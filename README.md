# Advent of code
Advent of Code is an Advent calendar of small programming puzzles for a variety of skill sets and skill levels that can be solved in any programming language you like. For more details got to https://adventofcode.com/
## Intro
This is the domain driven aproach to solving these puzzels.

For the matter of simplicity, all 3 layers (Domain, Application and Infrastructure) are kept in one Project. If separated, inversion of dependency should be followed from the outside to the inside:

Infrastructure -> Application -> Domain

## Overview
The Project is build with .net 6.

It uses DI and nunit for testing.

To run, clone this repo and run with e.g. `dotnet run --project .\2022\Altbrot.AoC.2022.01\Altbrot.AoC.2022.01.csproj`

