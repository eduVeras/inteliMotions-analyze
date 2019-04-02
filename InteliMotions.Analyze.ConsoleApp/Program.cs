
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using System;

namespace InteliMotions.Analyze.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook.Connect _coonnect = new Facebook.Connect("EAAMaVWgCZAXMBAK3Ll2jUY5DkfiTOFacIWNhyzRm4UQYYSQWno1i21VVH5RvCGZA3ZB9ZAJc048nYAJa47uidfCWGBG00e9Iksy97LIvp2z4m5kdNDhZCOXGbAmhMQMFbsQTMq38V8UZA5oOYvFxPbaxEAUuW1tleHbZC1Wk6qJMMuZCs75xbh6uAZCAenfYGaZBRNjDxGANz6r11kZAlxtEhIF6iFz23jQMCKNmNUECo1UVwZDZD",
                "9bc127f0540eaf272447d465b2f3136b", "873379049661811");

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
