﻿namespace Primes.Services
{
    using Contracts;

    public class PrimeService:IPrimeService
    {
        private long initialValue;
        private IResponse response { get; set; }
        private IResponse nextPrime()
        {
            IResponse result = new Response();
            long prime = this.initialValue;
            bool found = false;
            while (!found)
            {
                if (prime < long.MaxValue)
                {
                    prime++;

                    if (isPrime(prime))
                        found = true;
                }
                else
                {
                    result.initialValue = this.initialValue.ToString();
                    result.isInitialValuePrime = this.isPrime(this.initialValue);
                    result.isNextPrimeFound = false;
                    result.nextPrimeValue = "0";
                    result.errorMessage = "";
                    return  result;
                }
            }

            result.initialValue = this.initialValue.ToString();
            result.isInitialValuePrime = this.isPrime(this.initialValue);
            result.isNextPrimeFound = true;
            result.nextPrimeValue = prime.ToString();
            result.errorMessage = "";
            return result;
        }
        public IResponse FindPrime(long initialValue)
        {
            this.initialValue = initialValue;
            this.response = new Response();
            this.response = nextPrime();
            return this.response;
        }
        private bool isPrime(long n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (long i = 5; long.MaxValue <= n  || n*n <= n; i = i + 6)
                if (n % i == 0 ||
                    n % (i + 2) == 0)
                    return false;

            return true;
        }
    }
}
