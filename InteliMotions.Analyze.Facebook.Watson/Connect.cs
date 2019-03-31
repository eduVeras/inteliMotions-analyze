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
        private object _naturalLanguageUnderstandingService;

        public void Main()
        {


            //Gerando primeiro token
            //TokenOptions iamAssistantTokenOptions = new TokenOptions()
            //{
            //    IamApiKey = "<iam-apikey>",
            //    ServiceUrl = "<service-endpoint>"
            //};


            //AssistantService assistantService = new AssistantService();
            //var listWorkspacesResult = assistantService.ListWorkspaces();

            //_assistant = new AssistantService(iamAssistantTokenOptions, "<version-date>");


            //Parameters parameters = new Parameters()
            //{
            //    Text = "",
            //    Features = new Features()
            //    {
            //        Keywords = new KeywordsOptions()
            //        {
            //            Limit = 8,
            //            Sentiment = true,
            //            Emotion = true
            //        }
            //    }
            //};

            //var result = _naturalLanguageUnderstandingService.Analyze(parameters);
        }

        
    }
}
