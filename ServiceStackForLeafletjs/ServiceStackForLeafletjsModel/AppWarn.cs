using Dy.Common;
using ServiceStack.DataAnnotations;

namespace ServiceStackForLeafletjsModel
{
    public class AppWarn
    {
        [PrimaryKey]
        [AutoIncrement]
        [field("自增Id","int")]
        public int Id { get; set; }
        [field("用户名","string",null,null)]
        public string UserPhone { get; set; }
        [field("真实姓名","string",null,null)]
        public string UserName { get; set; }
        [field("事件名称","string",null,null)]
        public string EventName { get; set; }
        [field("是否进行中","string",null,null)]
        public int IsStartWarning { get; set; }
        [field("开始时间","string",null,null)]
        public string StartTime { get; set; }
        [field("结束时间","string",null,null)]
        public string EndTime { get; set; }
    }
}