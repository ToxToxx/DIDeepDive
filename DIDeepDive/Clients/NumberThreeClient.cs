namespace DIDeepDive.Clients
{
    public class NumberThreeClient : INumbersClient
    {
        private int _number = 3;
        public void Increment()
        {
            _number++;
        }

        public int GetNumber()
        {
            return _number;
        }
    }
}
