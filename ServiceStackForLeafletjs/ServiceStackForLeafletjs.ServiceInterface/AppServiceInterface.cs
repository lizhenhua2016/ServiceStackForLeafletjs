using System.Collections.Generic;
using ServiceStack;
using ServiceStackForLeafletjs.ServiceModel;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceInterface
{
    public class AppServiceInterface:Service
    {
        public IAppService AppService { get; set; }

        public List<ResponseAppWarnList> post(GetAppWarnList request)
        {
            return AppService.GetWarnList(request);
        }
    }
}