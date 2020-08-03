namespace Primes.Contracts
{
    public interface IResponse
    {
         string initialValue { get; set; }
         bool isInitialValuePrime { get; set; }
         bool isNextPrimeFound { get; set; }
         string nextPrimeValue { get; set; }
         string errorMessage { get; set; }
    }
}
