using System.Net.Http;

namespace Huit.FaceitAPI.Interfaces
{
    public interface IResponse
    {
        void ReadResponse(string response, HttpResponseMessage message);
    }
}
