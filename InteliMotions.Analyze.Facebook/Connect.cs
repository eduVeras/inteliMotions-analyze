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

        private readonly FacebookService _facebookService;

        public Connect(string accessToken, string applicationSecret, string applicationApi)
        {
            _facebookService = new FacebookService(accessToken);
        }
        
        public FacebookPosts GetPosts()
        {
            var getPostsTask = _facebookService.GetPost();

            Task.WaitAll(getPostsTask);
            var posts = getPostsTask.Result;
            
            return posts;

        }

        public FacebookMessages GetCommentsPost(string postId)
        {
            var messageTask = _facebookService.GetPostMessage(postId);
            Task.WaitAll(messageTask);

            var messages = messageTask.Result;

            return messages;

        }

    }
}