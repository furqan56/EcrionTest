namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class TxtOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private OutputEncoding encodingField;

        private string fontFamilyField;

        private float fontSizeField;

        private float lineHeightField;

        private bool useFormFeedField;

        private bool trimPagesField;

        public TxtOutputSettings()
        {
            this.encodingField = OutputEncoding.ASCII;
            this.fontFamilyField = "Courier New";
            this.fontSizeField = ((float)(9F));
            this.lineHeightField = ((float)(1.4F));
            this.useFormFeedField = true;
            this.trimPagesField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(OutputEncoding.ASCII)]
        public OutputEncoding Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
                this.RaisePropertyChanged("Encoding");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute("Courier New")]
        public string FontFamily
        {
            get
            {
                return this.fontFamilyField;
            }
            set
            {
                this.fontFamilyField = value;
                this.RaisePropertyChanged("FontFamily");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "9")]
        public float FontSize
        {
            get
            {
                return this.fontSizeField;
            }
            set
            {
                this.fontSizeField = value;
                this.RaisePropertyChanged("FontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "1.4")]
        public float LineHeight
        {
            get
            {
                return this.lineHeightField;
            }
            set
            {
                this.lineHeightField = value;
                this.RaisePropertyChanged("LineHeight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool UseFormFeed
        {
            get
            {
                return this.useFormFeedField;
            }
            set
            {
                this.useFormFeedField = value;
                this.RaisePropertyChanged("UseFormFeed");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TrimPages
        {
            get
            {
                return this.trimPagesField;
            }
            set
            {
                this.trimPagesField = value;
                this.RaisePropertyChanged("TrimPages");
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