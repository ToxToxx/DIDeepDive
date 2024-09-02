namespace DIDeepDive.Clients
{
    public class NumbersClient
    {
        private readonly int _number = new Random().Next(0, 100);
    
        public int GetNumber()
        {
            return _number;
        }
    }
}
