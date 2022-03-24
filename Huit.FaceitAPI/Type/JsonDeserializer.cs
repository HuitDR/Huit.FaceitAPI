using Huit.FaceitAPI.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Type
{
    public class JsonDeserializer : IJsonDeserializer
    {
        public T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
