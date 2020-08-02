using Swashbuckle.AspNetCore.Filters;
using WebApplication1.ViewModels;

namespace WebApplication1.SwaggerExamples.Requests
{
    public class LongRequest : IExamplesProvider<LongPrime>
    {
        public LongPrime GetExamples()
        {
            return new LongPrime { Prime = 1 };
        }
    }
}
