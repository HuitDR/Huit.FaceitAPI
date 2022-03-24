using Huit.FaceitAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class Client : IHttpClient
    {
        public static readonly string ContentType = nameof(ContentType);
        public static readonly string MimeContentType = "application/json";
        public HttpMethod HttpMethod = HttpMethod.Get;

        public HttpResponseMessage SendRequest(
          string url,
          IAuthorizable authorizable)
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.Headers.Add(authorizable.GetHeaderName(), authorizable.GetBearer());
            request.Headers.Add(Client.ContentType, Client.MimeContentType);
            request.RequestUri = new Uri(url);
            request.Method = this.HttpMethod;
            return new HttpClient().SendAsync(request).Result;
        }
    }
}
