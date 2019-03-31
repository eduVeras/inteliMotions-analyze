using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using IBM.WatsonDeveloperCloud.Util;

namespace InteliMotions.Analyze.Facebook.Watson
{
    public class Connect
    {
        public void Main()
        {
            //Gerando primeiro token
            TokenOptions iamAssistantTokenOptions = new TokenOptions()
            {
                IamApiKey = "P1CQWyM1NfM6Zy2YPqdIByyb8EgGUEhvfb05getpaNtx",
                ServiceUrl = "https://gateway.watsonplatform.net/natural-language-understanding/api"
            };

            //AssistantService assistantService = new AssistantService();
            //var listWorkspacesResult = assistantService.ListWorkspaces();
            //_assistant = new AssistantService(iamAssistantTokenOptions, "<version-date>");

            NaturalLanguageUnderstandingService _naturalLanguageUnderstandingService = new NaturalLanguageUnderstandingService(iamAssistantTokenOptions, "2019-03-30");
            
            Parameters parameters = new Parameters()
            {
                Text = "A garota é cheirosa",//positivo //"A garota é fedida" // negativo
                Features = new Features()
                {
                    Keywords = new KeywordsOptions()
                    {
                        Limit = 8,
                        Sentiment = true,
                        Emotion = true
                    }
                }
            };

            var result = _naturalLanguageUnderstandingService.Analyze(parameters);
        }        
    }
}
