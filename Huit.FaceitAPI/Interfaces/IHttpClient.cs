using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Huit.FaceitAPI.Interfaces
{
    public interface IHttpClient
    {
        HttpResponseMessage SendRequest(string url, IAuthorizable authorizable);
    }
}
