using Huit.FaceitAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class ApiBase
    {
        protected Authorization Authorization;
        public IResponse Response;
        public IHttpClient HttpClient = (IHttpClient)new Client();
        public IJsonDeserializer Deserializer = (IJsonDeserializer)new JsonDeserializer();
        private HttpResponseMessage ResponseMessage;
        private HttpResponseMessage httpResponseMessage;
        private string ResponseContent;
        private JsonDeserializer jsonDeserializer = new JsonDeserializer();

        public ApiBase(Authorization authorization) => this.Authorization = authorization;
        protected T Get<T>(string url)
        {
            try
            {
                this.ResponseMessage = this.HttpClient.SendRequest(url, this.Authorization);
                this.ResponseContent = this.ResponseMessage.Content.ReadAsStringAsync().Result;
                object obj = (object)this.Deserializer.Deserialize<T>(this.ResponseContent);
                return (T)obj;
            }
            catch (Exception ex)
            {
                if (this.ResponseMessage.StatusCode == HttpStatusCode.Unauthorized)
                    throw ex;
                throw ex;
            }
        }
    }
}
