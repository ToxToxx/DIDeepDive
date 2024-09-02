using DIDeepDive.Clients;

namespace DIDeepDive.Services
{
    public class NumbersService(NumbersClient _numbersClient)
    {
        private readonly int _number = new Random().Next(0, 100);
        public int GetNumber()
        {
            return _numbersClient.GetNumber();
        }
    }
}
