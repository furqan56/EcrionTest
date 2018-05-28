using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BridgeSuite.Ecrion.ObjectModel;

namespace BridgeSuite.Ecrion
{
    [ServiceContract(Namespace = "http://www.ecrion.com/xfws/2.0", ConfigurationName = "EcrionService.xfwsSoap")]
    public interface IEcrionServiceClient
    {
        // CODEGEN: Parameter 'RenderResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [OperationContract(Action = "http://www.ecrion.com/xfws/2.0/Render", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        RenderResponse Render(RenderRequest request);

        [OperationContract(Action = "http://www.ecrion.com/xfws/2.0/Render", ReplyAction = "*")]
        Task<RenderResponse> RenderAsync(RenderRequest request);
    }

}
