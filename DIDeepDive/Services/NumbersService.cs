using DIDeepDive.Clients;

namespace DIDeepDive.Services
{
    public class NumbersService(NumbersClient _numbersClient)
    {
        public int GetNumber()
        {
            return _numbersClient.GetNumber();
        }
    }
}
