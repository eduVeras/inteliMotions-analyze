
namespace InteliMotions.Analyze.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook.Connect _coonnect = new Facebook.Connect();

            _coonnect.GetFacebookLoginUrl();
        }
    }
}
