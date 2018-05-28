using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using BridgeSuite.Ecrion.ObjectModel;

namespace BridgeSuite.Ecrion
{
    public class EcrionServiceClient : ClientBase<IEcrionServiceClient>, IEcrionServiceClient
    {
        static readonly BasicHttpBinding ServiceBinding;
        static readonly EndpointAddress RemoteAddress;
        static EcrionServiceClient()
        {
            ServiceBinding = new BasicHttpBinding
            {
                MaxReceivedMessageSize = 2147483647,
                MaxBufferSize = 2147483647
            };
            RemoteAddress = new EndpointAddress(ConfigurationManager.AppSettings["EcrionWebServiceURI"]);
        }

        public EcrionServiceClient():this(ServiceBinding, RemoteAddress)
        {
        }

        public EcrionServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public EcrionServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public EcrionServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public EcrionServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public RenderResponse Render(RenderRequest request)
        {
            return base.Channel.Render(request);
        }

        public Task<RenderResponse> RenderAsync(RenderRequest request)
        {
            return  base.Channel.RenderAsync(request);
        }
    }
}