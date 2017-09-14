using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStackForLeafletjsModel;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;
using System;
using System.Collections.Generic;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public class AdcdServiceImpl : IAdcdService
    {
        public IDbConnectionFactory DbFactory { get; set; }

        public List<ADCDInfo> GetAdcdInfo()
        {
            throw new NotImplementedException();
        }

        public ResponseAdcdByUserAdcd GetAdcdInfoByAdcd(GetAdcdByUseradcd request)
        {
            using (var db = DbFactory.Open())
            {
            }
            throw new NotImplementedException();
        }

        public List<ResponseAdcdByUserAdcd> GetAdcdInfoByAdcdForTree(GetAdcdByUseradcd request)
        {
            if (string.IsNullOrEmpty(request.UserAdcd))
            {
                return null;
            }
            else
            {
                using (var db = DbFactory.Open())
                {
                    return db.SqlList<ResponseAdcdByUserAdcd>("exec GetAdcdInfoByAdcdForTree @adcd", new { adcd = request.UserAdcd });
                }
            }
        }

        public List<ADCDInfo> GetAdcdInfoByGrad(int grad)
        {
            throw new NotImplementedException();
        }

        public List<ADCDInfo> GetAdcdInfoByParentId(string adcd)
        {
            throw new NotImplementedException();
        }
    }
}