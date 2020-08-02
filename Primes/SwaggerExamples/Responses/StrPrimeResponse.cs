using Swashbuckle.AspNetCore.Filters;

namespace WebApplication1.SwaggerExamples.Responses
{
    public class StrPrimeResponse : IExamplesProvider<StrPrimeReturn>
    {
        public StrPrimeReturn GetExamples()
        {
            var obj = new StrPrimeReturn();

            obj.initialValue = "2";
            obj.isInitialValuePrime = true;
            obj.isNextPrimeFound = true;
            obj.nextPrimeValue = "3";
            return obj;
        }
    }
}
