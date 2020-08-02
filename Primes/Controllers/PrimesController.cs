using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;
using WebApplication1.ErrorMsgs;
using WebApplication1.Services;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PrimesController : ControllerBase
    {

        private readonly IPrimeService prmService;
        public PrimesController(IPrimeService prmService)
        {
            this.prmService = prmService;
        }
        // GET: api/<PrimesController>
        [HttpGet]
        public string Get()
        {
            return "Health check connection alive";
        }

        /// <summary>
        /// returns a json object with the current value if is prime and the next found prime number
        /// </summary>
        /// <remarks>
        ///     Sample request: 
        ///         POST /api/primes/LongPrime
        ///         {
        ///             Prime: 33
        ///         }
        ///     this endpoint works with numbers as well as with numbers passed into a string format
        /// </remarks>
        [HttpPost("LongPrime")]
        public ActionResult<LongPrimeReturn> LongPrime([FromBody] LongPrime prime)
        {
            LongPrimeReturn response = new LongPrimeReturn();
            IReturnObj res = this.prmService.findPrime(prime.Prime);
            response = (LongPrimeReturn)this.mapProps(response, res);
            return response;
        }

        /// <summary>
        /// this api accepts not only integer values but also numbers with decimal values
        /// returns a json object with the current value if is prime and the next found prime number
        /// </summary>
        /// <remarks>
        ///     Sample request: 
        ///         POST /api/primes/StringPrime
        ///         {
        ///             Prime: "33"
        ///         }
        ///     this endpoint works with string values as well as with integer numbers
        /// </remarks>
        [HttpPost("StringPrime")]
        public ActionResult<StrPrimeReturn> StringPrime([FromBody] StringPrime prime)
        {
            StrPrimeReturn response = new StrPrimeReturn();
            string strPrime = prime.Prime;
            if (strPrime.Contains(".") || strPrime.Contains(","))
            {
                response.errorMessage = ErrorMessages.floatingPointsError;
                return response;
            }
            if (!long.TryParse(strPrime, out long lngPrime))
            {
                response.errorMessage = ErrorMessages.outOfLongBoundariesError;
                return response;

            }
            IReturnObj res = this.prmService.findPrime(lngPrime);
            response = (StrPrimeReturn)this.mapProps(response, res);
            return response;
        }

        private IReturnObj mapProps(IReturnObj response, IReturnObj res)
        {
            response.initialValue = res.initialValue;
            response.isInitialValuePrime = res.isInitialValuePrime;
            response.isNextPrimeFound = res.isNextPrimeFound;
            response.nextPrimeValue = res.nextPrimeValue;
            response.errorMessage = res.errorMessage;

            return response;
        }

    }
}
