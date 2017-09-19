using System.Collections.Generic;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public interface IAppService
    {
        List<ResponseAppWarnList> GetWarnList(GetAppWarnList request);
    }
}