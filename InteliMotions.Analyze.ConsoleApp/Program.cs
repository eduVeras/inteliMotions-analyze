
namespace InteliMotions.Analyze.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {



            new InteliMotions.Analyze.Facebook.Watson.Connect().Main();
            Facebook.Connect _coonnect = new Facebook.Connect();

            _coonnect.GetFacebookLoginUrl();
        }
    }
}
