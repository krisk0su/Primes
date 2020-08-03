namespace Primes.SwaggerExamples.Requests
{
    using Swashbuckle.AspNetCore.Filters;
    using ViewModels;


    public class StringRequest : IExamplesProvider<StringPrime>
    {
        public StringPrime GetExamples()
        {
            return new StringPrime { Prime = "2" };
        }
    }
}
