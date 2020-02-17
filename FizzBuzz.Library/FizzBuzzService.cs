namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int n)
        {
            if (n % 3== 0 )
            {
                return "Fizz";
            }
            
            
            else
            {
            return n.ToString();
            }
        }
    }
}