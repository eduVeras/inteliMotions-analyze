using InteliMotions.Analyze.Facebook.Model;
using InteliMotions.Analyze.Facebook.Service;
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

        public FacebookPosts GetPosts()
        {
            var facebookClient = new Service.FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            
            var getPostsTask = facebookService.GetPost(_accessToken);

            Task.WaitAll(getPostsTask);
            var posts = getPostsTask.Result;
            
            return posts;

        }

        public FacebookMessages GetCommentsPost(string postId)
        {
            var facebookClient = new Service.FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            //var getAccountTask = facebookService.GetAccountAsync("EAAMaVWgCZAXMBABFDJuqFQkQbIgAHNETj81rqlPplf2GfSZCyZBi7cGzTtVxMdzeDJMvtiDDLNax5YyDaOZC9F601KoZA9jeIRzF0RAZCc45fZCo6i37wxSbepILLrdWbPrGyoD6FzgTGbPiqG9D3bhYslaS9znMbUwE8ZASZCpXPH7LunjgX6VP90CkEGdnrvVLVSSudtrdVReYqZAPZAJf5pWFZBbuA2v5h69uZB3uSsOtZB7gZDZD");

            var getPostsTask = facebookService.GetPost(_accessToken);

            Task.WaitAll(getPostsTask);
            var posts = getPostsTask.Result;

            var messageTask = facebookService.GetPostMessage(_accessToken, postId);
            Task.WaitAll(messageTask);

            var messages = messageTask.Result;

            return messages;

        }

    }
}