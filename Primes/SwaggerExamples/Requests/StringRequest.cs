using Swashbuckle.AspNetCore.Filters;
using WebApplication1.ViewModels;

namespace WebApplication1.SwaggerExamples.Requests
{
    public class StringRequest : IExamplesProvider<StringPrime>
    {
        public StringPrime GetExamples()
        {
            return new StringPrime { Prime = "2" };
        }
    }
}
