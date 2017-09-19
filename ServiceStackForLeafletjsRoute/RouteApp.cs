using System.Collections.Generic;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjsRoute
{
    using ServiceStack;
    
    [Route("/App/GetAllWarn","post",Summary ="获取全部的事件")]
    [Api("App")]
    public class GetAppWarnList:IReturn<List<ResponseAppWarnList>>
    {
        [ApiMember(IsRequired =false,DataType ="int",Description ="Id")]
        public int Id { get; set; }
        [ApiMember(IsRequired =false,DataType ="string",Description ="UserAdcd")]
        public string UserAdcd { get; set; }
        [ApiMember(IsRequired =false,DataType ="string",Description ="地点名称")]
        public string UserAdnm { get; set; }
    }
}
