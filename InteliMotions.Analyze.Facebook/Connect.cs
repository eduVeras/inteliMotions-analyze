using Facebook;
using InteliMotions.Analyze.Facebook.Service;
using RestSharp;
using System.Threading.Tasks;

namespace InteliMotions.Analyze.Facebook
{
    public class Connect
    {
        private readonly string _applicationSecret;
        private readonly string _ApplicationId;

        private readonly string _accessToken = "EAAMaVWgCZAXMBAF39N1UdgBAdlqhOmkR2VUmVEyZCElkZASARRLthFwxbzW5siLXel5agZBZBYex6XSAR5K6b4ha2CyRyw0eTlw1LoLGbZClLD83H0aYKkFcb2B0Ssq7QRi2fwZB8zJucdFaLy50grrXIdS8zZB2edE4C5yI5VtnxVgY82J3t2AikLiicrutrmgYwCUXwwPUdBOX8SeTN8OIWctACl1MBO7ZBFd5ZCdoZBHLQZDZD";

        public Connect(string applicationSecret, string ApplicationId)
        {
            _applicationSecret = applicationSecret;
            _ApplicationId = ApplicationId;
        }

        public void GetFacebookLoginUrl()
        {
            var facebookClient = new Service.FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            //var getAccountTask = facebookService.GetAccountAsync("EAAMaVWgCZAXMBABFDJuqFQkQbIgAHNETj81rqlPplf2GfSZCyZBi7cGzTtVxMdzeDJMvtiDDLNax5YyDaOZC9F601KoZA9jeIRzF0RAZCc45fZCo6i37wxSbepILLrdWbPrGyoD6FzgTGbPiqG9D3bhYslaS9znMbUwE8ZASZCpXPH7LunjgX6VP90CkEGdnrvVLVSSudtrdVReYqZAPZAJf5pWFZBbuA2v5h69uZB3uSsOtZB7gZDZD");

            var getPostsTask = facebookService.GetPost(_accessToken);

            Task.WaitAll(getPostsTask);
            var posts = getPostsTask.Result;

            foreach (var post in posts.Data)
            {
                var messageTask = facebookService.GetPostMessage(_accessToken, post.id);
                Task.WaitAll(messageTask);

                var message = messageTask.Result;

            }

        }

        public string GetAccessToken(string code)
        {
            var client = new RestClient("https://graph.facebook.com/");

            var request = new RestRequest("oauth/access_token" + "?client_id=" + this._ApplicationId + "&client_secret=" + this._applicationSecret + "&code=" + code + "&redirect_uri=http:%2F%2Flocalhost:5176%2F", Method.GET);

            var data = client.Execute(request);

            string accessToken = data.Content.Split('=')[1];

            return accessToken;
        }
    }
}