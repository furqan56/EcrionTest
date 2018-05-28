namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class JobProperty : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string objectIDField;

        private string propertyNameField;

        private string propertyValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string ObjectID
        {
            get
            {
                return this.objectIDField;
            }
            set
            {
                this.objectIDField = value;
                this.RaisePropertyChanged("ObjectID");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
                this.RaisePropertyChanged("PropertyName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string PropertyValue
        {
            get
            {
                return this.propertyValueField;
            }
            set
            {
                this.propertyValueField = value;
                this.RaisePropertyChanged("PropertyValue");
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