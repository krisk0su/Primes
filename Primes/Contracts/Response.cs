namespace Primes.Contracts
{
    public  class Response:IResponse
    {
        public Response()
        {
            this.initialValue = "0";
            this.isInitialValuePrime = false;
            this.isInitialValuePrime = false;
            this.nextPrimeValue = "0";
            this.errorMessage = "";
        }
        public string initialValue { get; set; }
        public bool isInitialValuePrime { get; set; }
        public bool isNextPrimeFound { get; set; }
        public string nextPrimeValue { get; set; }
        public string errorMessage { get; set; }
    }
}
