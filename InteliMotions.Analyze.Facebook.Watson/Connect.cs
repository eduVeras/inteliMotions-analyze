using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using IBM.WatsonDeveloperCloud.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            NaturalLanguageUnderstandingService _naturalLanguageUnderstandingService = new NaturalLanguageUnderstandingService(iamAssistantTokenOptions, "30 DE MAR DE 2019 - 09:11:59 PM");
            
            Parameters parameters = new Parameters()
            {
                Text = "Oi eu sou um teste de programadores do brasil, isso quer dizer que vamos escutar musica e programar todo o conteudo.",
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
