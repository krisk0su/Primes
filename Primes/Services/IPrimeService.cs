namespace Primes.Services
{
    using Contracts;
    public interface IPrimeService
    {
        public IResponse FindPrime(long number);
    }
}
