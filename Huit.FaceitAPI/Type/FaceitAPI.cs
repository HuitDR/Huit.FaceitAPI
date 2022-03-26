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

        
        

    }
}
