
namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocalDiagram))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServerDiagram))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public abstract partial class Diagram : object, System.ComponentModel.INotifyPropertyChanged
    {

        private JobProperty[] propertiesField;

        private string inputBytesIDField;

        private string outputBytesIDField;

        public Diagram()
        {
            this.inputBytesIDField = "";
            this.outputBytesIDField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        public JobProperty[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
                this.RaisePropertyChanged("Properties");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string InputBytesID
        {
            get
            {
                return this.inputBytesIDField;
            }
            set
            {
                this.inputBytesIDField = value;
                this.RaisePropertyChanged("InputBytesID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OutputBytesID
        {
            get
            {
                return this.outputBytesIDField;
            }
            set
            {
                this.outputBytesIDField = value;
                this.RaisePropertyChanged("OutputBytesID");
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