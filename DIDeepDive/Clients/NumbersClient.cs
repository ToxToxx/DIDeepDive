namespace DIDeepDive.Clients
{
    public class NumbersClient
    {
        private int _number = 0;
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
