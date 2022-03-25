using Huit.FaceitAPI.Interfaces;
using Huit.FaceitAPI.Models;
using Huit.FaceitAPI.Models.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class APIFaceit  :   SimpleContainer<ApiBase>
    {
        protected Authorization authorization;
        private HttpResponseMessage httpResponseMessage;
        private string ResponseContent;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer();
        IHttpClient httpClient = new Client();
        public APIFaceit(Authorization _authorization)
        {
            authorization = _authorization;
        }

        public T GetObject<T>() where T : ApiBase
        {
            if (this.Exist<T>())
                return this.Get<T, T>();
            ApiBase instance = (ApiBase)Activator.CreateInstance(typeof(T), (object)this.authorization);
            this.RegisterObject<T>(instance);
            return (T)instance;
        }

        // matches
        // /matches/{match_id}/stats
        public MatchStats GetMatchStatistic(string MatchID)
        {
            httpResponseMessage = httpClient.SendRequest("https://open.faceit.com/data/v4/matches/"+MatchID+"/stats", authorization);
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
