namespace DIDeepDive.Services
{
    public class NumbersService
    {
        private readonly int _number = new Random().Next(0, 100);
        public int GetNumber()
        {
            return _number;
        }
    }
}
