namespace ServiceStackForLeafletjsRoute
{
    using ServiceStack;
    using ServiceStackForLeafletjsResponse;
    
    [Route("/ZZTX/GetZZTX","GET",Summary ="获取全部的")]
    [Api("adcd")]
    public class GetAdcdByUseradcd : IReturn<ResponseAdcdByUserAdcd>
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
