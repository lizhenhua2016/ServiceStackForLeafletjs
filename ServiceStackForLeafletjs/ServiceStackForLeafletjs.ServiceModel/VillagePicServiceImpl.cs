using System.Collections.Generic;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public class VillagePicServiceImpl: IVillagePicService
    {
        public IDbConnectionFactory DbFactory { get; set; }
        public List<ResponseVillagePic> GetAllVillagePics(ServiceStackForLeafletjsRoute.VillagePic request)
        {
            using (var db= DbFactory.Open())
            {
                var list = db.SqlList<ResponseVillagePic>("exec getallpic",new{});
                return list;
            }
        }
    }
}