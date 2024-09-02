using DIDeepDive.Clients;

namespace DIDeepDive.Services
{
    public class NumbersService(IEnumerable<INumbersClient> _numbersClient)
    {
        public int GetNumber()
        {
            return _numbersClient.Sum(client => client.GetNumber());
        }
    }
}
