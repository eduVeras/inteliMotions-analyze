using Facebook;

namespace InteliMotions.Analyze.Facebook
{
    public class Connect
    {
        public void GetFacebookLoginUrl()
        {
            FacebookClient client = new FacebookClient("9bc127f0540eaf272447d465b2f3136b");
            var result = client.Get("me/feed");



        }
    }
}