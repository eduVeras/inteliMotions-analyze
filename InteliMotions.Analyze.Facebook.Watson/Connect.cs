using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using IBM.WatsonDeveloperCloud.Util;


namespace InteliMotions.Analyze.Facebook.Watson
{
    public class Connect
    {
        public AnalysisResults Main(string message)
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
                Text = message,//positivo //"A garota é fedida" // negativo
                Features = new Features()
                {
                    Keywords = new KeywordsOptions()
                    {
                        Limit = 8,
                        Sentiment = true,
                        Emotion = true
                    }
                },
                Language = "pt"
            };

            var result = _naturalLanguageUnderstandingService.Analyze(parameters);
            
            return result;

            
        }        
    }
}
