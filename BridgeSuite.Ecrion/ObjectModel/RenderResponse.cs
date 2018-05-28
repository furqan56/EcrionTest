namespace BridgeSuite.Ecrion.ObjectModel
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "RenderResponse", WrapperNamespace = "http://www.ecrion.com/xfws/2.0", IsWrapped = true)]
    public partial class RenderResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.ecrion.com/xfws/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] RenderResult;

        public RenderResponse()
        {
        }

        public RenderResponse(byte[] RenderResult)
        {
            this.RenderResult = RenderResult;
        }
    }
}