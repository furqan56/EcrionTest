

namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalDocumentTemplate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerDocumentTemplate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public abstract partial class DocumentTemplate : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string xSLTParametersField;

        private XsltEngine xSLTEngineField;

        private string languageIDField;

        public DocumentTemplate()
        {
            this.xSLTParametersField = "";
            this.xSLTEngineField = XsltEngine.MSXML;
            this.languageIDField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string XSLTParameters
        {
            get
            {
                return this.xSLTParametersField;
            }
            set
            {
                this.xSLTParametersField = value;
                this.RaisePropertyChanged("XSLTParameters");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(XsltEngine.MSXML)]
        public XsltEngine XSLTEngine
        {
            get
            {
                return this.xSLTEngineField;
            }
            set
            {
                this.xSLTEngineField = value;
                this.RaisePropertyChanged("XSLTEngine");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string LanguageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
                this.RaisePropertyChanged("LanguageID");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}