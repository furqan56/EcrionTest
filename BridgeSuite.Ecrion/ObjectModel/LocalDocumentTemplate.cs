namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class LocalDocumentTemplate : DocumentTemplate
    {

        private object contentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public object Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("Content");
            }
        }
    }
}