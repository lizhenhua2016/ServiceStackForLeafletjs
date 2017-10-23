using System.Collections.Generic;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public interface IVillagePicService
    {
        List<ServiceStackForLeafletjsResponse.VillagePic> GetAllVillagePics(VillagePic request);
    }
}