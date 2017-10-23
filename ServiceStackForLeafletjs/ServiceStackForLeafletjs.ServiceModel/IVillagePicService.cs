using System.Collections.Generic;
using ServiceStackForLeafletjsRoute;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public interface IVillagePicService
    {
        List<ResponseVillagePic> GetAllVillagePics(VillagePic request);
    }
}