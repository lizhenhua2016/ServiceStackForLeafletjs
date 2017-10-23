using System.Collections.Generic;
using ServiceStackForLeafletjs.ServiceModel;
using ServiceStackForLeafletjsRoute;
using ServiceStackForLeafletjsResponse;
using ServiceStack;

namespace ServiceStackForLeafletjs.ServiceInterface
{
    public class VillagePicService : Service
    {
        public IVillagePicService Manager { get; set; }

        public List<ResponseVillagePic> Post(VillagePic request)
        {
            return Manager.GetAllVillagePics(request);
        }
    }
}