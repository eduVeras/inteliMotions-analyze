
using InteliMotions.Analyze.Facebook.Account;
using InteliMotions.Analyze.Facebook.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InteliMotions.Analyze.Facebook.Service
{
    public interface IFacebookService
    {
        Task<FacebookAccount> GetAccountAsync(string accessToken);
        Task PostOnWallAsync(string accessToken, string message);
    }

    public class FacebookService : IFacebookService
    {
        private readonly IFacebookClient _facebookClient;

        public FacebookService(IFacebookClient facebookClient)
        {
            _facebookClient = facebookClient;
        }

        public async Task<FacebookAccount> GetAccountAsync(string accessToken)
        {
            var result = await _facebookClient.GetAsync<dynamic>(
                accessToken, "me", "fields=id,name,email,first_name,last_name,age_range,birthday,gender,locale");

            if (result == null)
            {
                return null;
            }

            var account = new FacebookAccount
            {
                Id = result.id,
                Email = result.email,
                Name = result.name,
                UserName = result.username,
                FirstName = result.first_name,
                LastName = result.last_name,
                Locale = result.locale
            };

            return account;
        }

        public async Task<FacebookPosts> GetPost(string accessToken)
        {
            var result = await _facebookClient.GetAsync<FacebookPosts>(
                accessToken, "me/posts");

            if (result == null)
            {
                return null;
            }
            

            return result;
        }

        public async Task<FacebookMessages> GetPostMessage(string accessToken, string postId)
        {
            var result = await _facebookClient.GetAsync<FacebookMessages>(
                accessToken, $"{postId}/comments");

            if (result == null)
            {
                return null;
            }

            return result;
        }

        public async Task PostOnWallAsync(string accessToken, string message)
            => await _facebookClient.PostAsync(accessToken, "me/feed", new { message });
    }
}
