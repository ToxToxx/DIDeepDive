namespace DIDeepDive.Clients
{
    public class NumbersClient : INumbersClient
    {
        private int _number = 1;
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
