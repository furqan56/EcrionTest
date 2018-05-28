namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class MiscellaneousSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private ReferenceResolverType referenceResolverTypeField;

        private int autoLayoutRowCountField;

        private ImageErrorsHandlingMode imageErrorsHandlingModeField;

        public MiscellaneousSettings()
        {
            this.referenceResolverTypeField = ReferenceResolverType.Parallel;
            this.autoLayoutRowCountField = 100;
            this.imageErrorsHandlingModeField = ImageErrorsHandlingMode.IgnoreAndDisplayImageNotFound;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(ReferenceResolverType.Parallel)]
        public ReferenceResolverType ReferenceResolverType
        {
            get
            {
                return this.referenceResolverTypeField;
            }
            set
            {
                this.referenceResolverTypeField = value;
                this.RaisePropertyChanged("ReferenceResolverType");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(100)]
        public int AutoLayoutRowCount
        {
            get
            {
                return this.autoLayoutRowCountField;
            }
            set
            {
                this.autoLayoutRowCountField = value;
                this.RaisePropertyChanged("AutoLayoutRowCount");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(ImageErrorsHandlingMode.IgnoreAndDisplayImageNotFound)]
        public ImageErrorsHandlingMode ImageErrorsHandlingMode
        {
            get
            {
                return this.imageErrorsHandlingModeField;
            }
            set
            {
                this.imageErrorsHandlingModeField = value;
                this.RaisePropertyChanged("ImageErrorsHandlingMode");
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