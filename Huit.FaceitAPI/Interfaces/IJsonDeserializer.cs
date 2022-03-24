using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huit.FaceitAPI.Interfaces
{
    public interface IJsonDeserializer
    {
        T Deserialize<T>(string json);
    }
}
