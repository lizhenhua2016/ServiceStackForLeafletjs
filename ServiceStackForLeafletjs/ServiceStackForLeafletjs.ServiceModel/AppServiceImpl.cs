using System.Collections.Generic;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public class AppServiceImpl : IAppService
    {
        public IDbConnectionFactory DbFactory { get; set; }

        public List<ResponseAppWarnList> GetWarnList(GetAppWarnList request)
        {
            using (var db = DbFactory.Open())
            {
                var list = db.SqlList<ResponseAppWarnList>("exec GetWarnListByAdcd @adcd", new {adcd = request.UserAdcd});
                return list;
            }
        }
    }
}