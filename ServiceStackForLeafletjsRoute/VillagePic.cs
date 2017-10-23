using System.Collections.Generic;
using ServiceStack;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjsRoute
{
    
    [Route("/Village/GetAllPic","Post", Summary = "获取全部的形势图")]
    [Api("形势图的坑")]
    public class VillagePic : IReturn<List<ResponseVillagePic>>
    {
        [ApiMember(IsRequired = false, DataType = "string", Description = "adcd")]
        public string Adcd { get; set; }
    }
}