# Advent of code
## Intro
This is the domain driven aproach to solving puzzels at https://adventofcode.com

For the matter of simplicity, all 3 layers (Domain, Application and Infrastructure) are kept in one Project. If separated, inversion of dependency should be followed from the outside to the inside:

Infrastructure -> Application -> Domain

## Overview
The Project is build with .net 6.

It uses DI and nunit for testing.

To run, clone this repo and run with `dotnet run`

