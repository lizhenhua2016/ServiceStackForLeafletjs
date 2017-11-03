using System.Collections.Generic;
using ServiceStack;
using ServiceStackForLeafletjsResponse;

namespace ServiceStackForLeafletjsRoute
{
    [Api("用户")]
    [Route("/UserInfo/Login", "post", Summary = "登录")]
    public class Login : IReturn<List<ResponseUserLogin>>
    {
        [ApiMember(IsRequired = true, DataType = "string", Description = "用户名")]
        public string Username { get; set; }

        [ApiMember(IsRequired = true, DataType = "string", Description = "密码")]
        public string Password { get; set; }
    }
}