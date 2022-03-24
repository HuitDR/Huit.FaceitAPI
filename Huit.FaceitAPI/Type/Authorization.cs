using Huit.FaceitAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class Authorization : IAuthorizable
    {
        public static readonly string Header = nameof(Authorization);
        public string Key { get; set; }
        public Authorization(string apikey) => this.Key = apikey;
        public string GetBearer() => "Bearer " + this.Key;
        public string GetHeaderName() => Authorization.Header;
    }
}
