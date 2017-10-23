using System.Collections.Generic;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public class VillagePicServiceImpl: IVillagePicService
    {
        public IDbConnectionFactory DbFactory { get; set; }
        public List<VillagePic> GetAllVillagePics(ServiceStackForLeafletjsRoute.VillagePic request)
        {
            using (var db= DbFactory.Open())
            {
                var list = db.SqlList<VillagePic>("exec getallpic",new{});
                return list;
            }
        }
    }
}