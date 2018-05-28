namespace BridgeSuite.Ecrion.ObjectModel
{

    [System.ServiceModel.MessageContractAttribute(WrapperName = "Render", WrapperNamespace = "http://www.ecrion.com/xfws/2.0", IsWrapped = true)]
    public partial class RenderRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.ecrion.com/xfws/2.0", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public DataSource Input;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.ecrion.com/xfws/2.0", Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public RenderingParameters Parameters;

        public RenderRequest()
        {
        }

        public RenderRequest(DataSource Input, RenderingParameters Parameters)
        {
            this.Input = Input;
            this.Parameters = Parameters;
        }
    }
}