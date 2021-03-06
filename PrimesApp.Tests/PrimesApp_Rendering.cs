using Xunit;
using PrimesApp.Library;
using System;

namespace PrimesApp.Tests
{
    public class PrimesApp_GridRender
    {
        private readonly GridRender _renderer;
        private readonly PrimesFinder _primeFinder;

        public PrimesApp_GridRender()
        {
            _renderer = new GridRender();
            _primeFinder = new PrimesFinder();
        }


        [Theory]
        [InlineData(5)]
        public void SmallGrid(int value)
        {
            //When
            int[] primes = _primeFinder.FindPrimes(value);
            var result = _renderer.Output(primes);
            var knownTable = "table string";
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        }


        [Theory]
        [InlineData(20)]
        public void MediumGrid(int value)
        {
            //When
            int[] primes = _primeFinder.FindPrimes(value);
            var result = _renderer.Output(primes);
            var knownTable = "table string";
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        }

        [Theory]
        [InlineData(200)]
        public void LargeGrid(int value)
        {
            //When
            int[] primes = _primeFinder.FindPrimes(value);
            var result = _renderer.Output(primes);
            var knownTable = "table string";
            //Then
            Console.WriteLine(result);
            // Later validate the result against a known correct table string.
            // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        }


        // [Theory]
        // [InlineData(20000)]
        // public void ProductionGrid(int value) 
        // { 
        //     //When
        //     int[] primes = _primeFinder.FindPrimes(value);
        //     var result = _renderer.Output(primes);
        //     var knownTable = "table string";
        //     //Then
        //     Console.WriteLine(result);
        //     // Later validate the result against a known correct table string.
        //     // Assert.True(result == knownTable, $"The rendered grid and known grid match for input {values}");
        // } 

        // Add some tests with purposefully failing grids.
    }
}