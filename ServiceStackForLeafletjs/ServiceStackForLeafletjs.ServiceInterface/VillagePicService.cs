using System.Collections.Generic;
using ServiceStackForLeafletjs.ServiceModel;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceInterface
{
    public class VillagePicService
    {
        public IVillagePicService Manager { get; set; }
        public List<ServiceStackForLeafletjsResponse.VillagePic> post(VillagePic request)
        {
           return Manager.GetAllVillagePics(request);
        }
    }
    
}