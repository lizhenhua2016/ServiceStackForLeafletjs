namespace ServiceStackForLeafletjsRoute
{
    using ServiceStack;
    using ServiceStackForLeafletjsResponse;
    using System.Collections.Generic;

    [Route("/ZZTX/GetAdcdByUseradcd", "POST",Summary ="获取全部的")]
    [Api("全部的adcd")]
    public class GetAdcdByUseradcd : IReturn<List<ResponseAdcdByUserAdcd> >
    {
        [ApiMember(IsRequired =false,DataType ="string",Description ="这个是输入的adcd")]
        public string UserAdcd { get; set; }
        [ApiMember(IsRequired =false,DataType ="int",Description ="父级Id")]
        public int parentId { get; set; }
        [ApiMember(IsRequired =false,DataType ="int",Description ="这里是输入的等级（省1，市2，县3，镇4，村5）")]
        public int grade { get; set; }
        [ApiMember(IsRequired =false,DataType ="string",Description ="地点名称")]
        public string adnm { get; set; }
    }
}
