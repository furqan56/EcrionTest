namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class XmlDataSource : DataSource
    {

        private object contentField;

        private InputFormat formatField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public InputFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
                this.RaisePropertyChanged("Format");
            }
        }
    }
}