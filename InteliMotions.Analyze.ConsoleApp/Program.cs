
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using System;

namespace InteliMotions.Analyze.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook.Connect _coonnect = new Facebook.Connect("9bc127f0540eaf272447d465b2f3136b", "873379049661811");

            var posts = _coonnect.GetPosts();

            foreach (var post in posts.Data)
            {
                var comments = _coonnect.GetCommentsPost(post.id);

                foreach (var comment in comments.Data)
                {
                    AnalysisResults a = new Facebook.Watson.Connect().Main(comment.message);
                    Console.WriteLine(a.ResponseJson);
                }

                
            }

            
            
            
        }
    }
}
