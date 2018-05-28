namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class HtmlOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private bool generateHtmlDocumentField;

        private bool useFixedBodyWidthField;

        private bool hideStaticContentField;

        private string renderedImagesBaseUrlField;

        private string renderedImagesOutputFolderField;

        public HtmlOutputSettings()
        {
            this.generateHtmlDocumentField = true;
            this.useFixedBodyWidthField = true;
            this.hideStaticContentField = false;
            this.renderedImagesBaseUrlField = "";
            this.renderedImagesOutputFolderField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool GenerateHtmlDocument
        {
            get
            {
                return this.generateHtmlDocumentField;
            }
            set
            {
                this.generateHtmlDocumentField = value;
                this.RaisePropertyChanged("GenerateHtmlDocument");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool UseFixedBodyWidth
        {
            get
            {
                return this.useFixedBodyWidthField;
            }
            set
            {
                this.useFixedBodyWidthField = value;
                this.RaisePropertyChanged("UseFixedBodyWidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool HideStaticContent
        {
            get
            {
                return this.hideStaticContentField;
            }
            set
            {
                this.hideStaticContentField = value;
                this.RaisePropertyChanged("HideStaticContent");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RenderedImagesBaseUrl
        {
            get
            {
                return this.renderedImagesBaseUrlField;
            }
            set
            {
                this.renderedImagesBaseUrlField = value;
                this.RaisePropertyChanged("RenderedImagesBaseUrl");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RenderedImagesOutputFolder
        {
            get
            {
                return this.renderedImagesOutputFolderField;
            }
            set
            {
                this.renderedImagesOutputFolderField = value;
                this.RaisePropertyChanged("RenderedImagesOutputFolder");
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