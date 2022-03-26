using Huit.FaceitAPI.Interfaces;
using Huit.FaceitAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class Matches : ApiBase, IMatches
    {
        private HttpResponseMessage httpResponseMessage;
        private string ResponseContent;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer();
        IHttpClient httpClient = new Client();
        protected Authorization authorization;
        public Matches(Authorization authorization) : base (authorization)
        {
            this.authorization = authorization;
        }
        public MatchDetails GetMatch(string MatchID)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/matches/" + MatchID, authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<MatchDetails>(ResponseContent);
            }
            return null;
        }

        // matches
        // /matches/{match_id}/stats
        public MatchStats GetMatchStatistics(string MatchID)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/matches/" + MatchID + "/stats", authorization);
            ResponseContent = httpResponseMessage.Content.ReadAsStringAsync().Result;
            if (ResponseContent != "Unauthorized" &&
                ResponseContent != "Forbidden" &&
                ResponseContent != "Not Found")
            {
                return jsonDeserializer.Deserialize<MatchStats>(ResponseContent);
            }
            return null;
        }
    }
}
