namespace Primes.SwaggerExamples.Requests
{
    using Swashbuckle.AspNetCore.Filters;
    using ViewModels;
    public class LongRequest : IExamplesProvider<LongPrime>
    {
        public LongPrime GetExamples()
        {
            return new LongPrime { Prime = 1 };
        }
    }
}
