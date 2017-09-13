using ServiceStackForLeafletjsModel;
using ServiceStackForLeafletjsResponse;
using System.Collections.Generic;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public interface IAdcdService
    {
        /// <summary>
        /// 获取全部的Adcd
        /// </summary>
        /// <returns></returns>
        List<ADCDInfo> GetAdcdInfo();
        /// <summary>
        /// 通过Adcd获取单个
        /// </summary>
        /// <param name="adcd"></param>
        /// <returns></returns>
        ResponseAdcdByUserAdcd GetAdcdInfoByAdcd(GetAdcdByUseradcd request);
        /// <summary>
        /// 通过层级获取
        /// </summary>
        /// <param name="grad"></param>
        /// <returns></returns>
        List<ADCDInfo> GetAdcdInfoByGrad(int grad);
        /// <summary>
        /// 通过这个ADCD获取下一级的本adcd下面的所有的信息
        /// </summary>
        /// <param name="adcd"></param>
        /// <returns></returns>
        List<ADCDInfo> GetAdcdInfoByParentId(string adcd);
        /// <summary>
        /// 通过adcd获取下一级的adcd列表
        /// </summary>
        /// <returns></returns>
        List<ResponseAdcdByUserAdcd> GetAdcdInfoByAdcdForTree(GetAdcdByUseradcd request);
        
    }
}
