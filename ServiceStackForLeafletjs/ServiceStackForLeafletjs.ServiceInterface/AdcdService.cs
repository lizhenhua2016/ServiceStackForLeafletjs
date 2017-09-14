using ServiceStack;
using ServiceStackForLeafletjs.ServiceModel;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;
using System.Collections.Generic;

namespace ServiceStackForLeafletjs.ServiceInterface
{
    public class AdcdService : Service
    {
        public IAdcdService Adcdservice { get; set; }

        public List<ResponseAdcdByUserAdcd> post(GetAdcdByUseradcd request)
        {
            return Adcdservice.GetAdcdInfoByAdcdForTree(request);
        }
    }
}