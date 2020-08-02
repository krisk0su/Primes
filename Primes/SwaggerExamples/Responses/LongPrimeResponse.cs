using Swashbuckle.AspNetCore.Filters;

namespace WebApplication1.SwaggerExamples.Responses
{
    public class LongPrimeResponse : IExamplesProvider<LongPrimeReturn>
    {
    

        public LongPrimeReturn GetExamples()
        {
            var obj = new LongPrimeReturn();

            obj.initialValue = "1";
            obj.isInitialValuePrime = false;
            obj.isNextPrimeFound = true;
            obj.nextPrimeValue = "2";
            return obj;
        }
    }
}
