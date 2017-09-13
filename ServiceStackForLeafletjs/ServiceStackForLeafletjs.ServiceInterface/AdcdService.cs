using ServiceStackForLeafletjs.ServiceModel;
using ServiceStackForLeafletjsResponse;
using ServiceStackForLeafletjsRoute;

namespace ServiceStackForLeafletjs.ServiceInterface
{
    public class AdcdService
    {
        private IAdcdService Adcdservice { get; set; }

        public ResponseAdcdByUserAdcd post(GetAdcdByUseradcd request)
        {
            return Adcdservice.GetAdcdInfoByAdcd(request);
        }
    }
}