using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStackForLeafletjsModel;
using ServiceStackForLeafletjsResponse;
using System;
using System.Collections.Generic;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceModel
{
    public class AdcdServiceImpl : IAdcdService
    {
        private IDbConnectionFactory DbFactory { get; set; }

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
            using (var db = DbFactory.Open())
            {
                return db.SqlList<ResponseAdcdByUserAdcd>("exec ", new { });
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