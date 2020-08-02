# Primes

running the programm with IIS Express leads to https://localhost:44389/api/primes to check if the conenction is alive

running the programm with Docker leadads to https://localhost:32774/api/primes to check if the conenction is alive

/swagger/index.html here you can check the routes that are provided by the api

I have implemented 2 end points the /LongPrime accept number as input integers and longs if the user enters floating point number the api parse this number to long on it`s own with Math.round()

This is why i implemented another end point /StringPrime which accepts number as strings. In this endpoint users are restricted so they can only enter whole number without floating points.

If the given input is valid both endpoints will return a json object with the following properties

{
"initialValue": "1", --- initial value is the value that the user entered to check if it is a prime number
"isInitialValuePrime": false, --- this params tells as if the initial value is prime number
"isNextPrimeFound": true, --- this param tells as if the we have another primer bigger than the initial value
"nextPrimeValue": "2", --- this is the actual value of the bigger found prime number
"errorMessage": "" --- this property tells us if there is any error
}

i am using long data type so the user will have bigger range for the numbers . let`s assume that the use entered 9223372036854775807 which is the max value of long type the end point will return this object

initialValue = 9223372036854775807
isInitialValuePrime = false;
isNextPrimeFound = false;
nextPrimeValue = "0";
errorMessage = "";
