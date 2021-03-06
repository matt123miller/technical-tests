using Xunit;
using PrimesApp.Library;
using System;

namespace PrimesApp.Tests
{
    public class PrimesApp_IsPrime
    {
        private readonly PrimesFinder _primes;

        public PrimesApp_IsPrime()
        {
            // I'm not sure if this is proper TDD practice,
            // I feel like you're meant to start fresh in every test function.
            // But I'm creating the Primes object once and reusing it.
            _primes = new PrimesFinder();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ValuesLessThanTwo(int value)
        {
            //When
            var result = _primes.IsPrime(value);
            //Then
            Assert.False(result, $"{value}should not be prime");
        }

        [Theory] 
        [InlineData(2)] 
        [InlineData(3)] 
        [InlineData(5)] 
        [InlineData(7)] 
        public void PrimesLessThan10(int value) 
        { 
            //When
            var result = _primes.IsPrime(value); 
            //Then
            Assert.True(result, $"{value} should be prime"); 
        } 
 
        [Theory] 
        [InlineData(4)] 
        [InlineData(6)] 
        [InlineData(8)] 
        [InlineData(9)] 
        public void NonPrimesLessThan10(int value) 
        { 
            //When
            var result = _primes.IsPrime(value); 
            //Then
            Assert.False(result, $"{value} should not be prime"); 
        } 

        // [Theory] 
        // [InlineData(20000)]
        // public void DebugRunning(int value) 
        // { 
        //     Console.WriteLine($"Testing for the first {value} prime numbers.");
        //     //When
        //     var result = _primes.FindPrimes(value); 
        //     Console.WriteLine(result);
        // }
    }
}