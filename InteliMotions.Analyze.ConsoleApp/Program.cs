
namespace InteliMotions.Analyze.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook.Connect _coonnect = new Facebook.Connect("9bc127f0540eaf272447d465b2f3136b", "873379049661811");

            _coonnect.GetFacebookLoginUrl();
        }
    }
}
