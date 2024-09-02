using DIDeepDive.Clients;

namespace DIDeepDive.Services
{
    public class NumbersService(INumbersClient _numbersClient)
    {
        public int GetNumber()
        {
            return _numbersClient.GetNumber();
        }
    }
}
