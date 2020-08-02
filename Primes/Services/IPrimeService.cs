using WebApplication1.Contracts;

namespace WebApplication1.Services
{
    public interface IPrimeService
    {
        public IReturnObj findPrime(long number);
    }
}
