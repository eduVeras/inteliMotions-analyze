
using InteliMotions.Analyze.Facebook.Account;
using InteliMotions.Analyze.Facebook.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InteliMotions.Analyze.Facebook.Service
{
    public interface IFacebookService
    {
        Task PostOnWallAsync(string message);
    }

    public class FacebookService : IFacebookService
    {
        private readonly IFacebookClient _facebookClient;
        private readonly string _accessToken;

        public FacebookService(string accessToken)
        {
            _accessToken = accessToken;
            _facebookClient = new FacebookClient();
        }
        
        public async Task<FacebookPosts> GetPost()
        {
            var result = await _facebookClient.GetAsync<FacebookPosts>(
                _accessToken, "me/posts");
            
            return result;
        }

        public async Task<FacebookMessages> GetPostMessage(string postId)
        {
            var result = await _facebookClient.GetAsync<FacebookMessages>(
                _accessToken, $"{postId}/comments");
            
            return result;
        }

        public async Task PostOnWallAsync(string message)
            => await _facebookClient.PostAsync(_accessToken, "me/feed", new { message });
    }
}
