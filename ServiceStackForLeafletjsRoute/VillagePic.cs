using System.Collections.Generic;
using ServiceStack;

namespace ServiceStackForLeafletjsRoute
{
    [Api("形势图的坑")]
    [Route("/Village/GetAllPic","post", Summary = "获取全部的形势图")]
    public class VillagePic: IReturn<List<ServiceStackForLeafletjsResponse.VillagePic>>
    {
        
    }
}