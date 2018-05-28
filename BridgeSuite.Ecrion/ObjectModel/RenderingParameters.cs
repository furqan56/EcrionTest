
namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class RenderingParameters : object, System.ComponentModel.INotifyPropertyChanged
    {

        private OutputFormat outputFormatField;

        private string baseUrlField;

        private string inputBytesIDField;

        private string outputBytesIDField;

        private string serverVersionField;

        private bool preloadDocumentField;

        private bool performLayoutField;

        private DocumentTemplate templateField;

        private MiscellaneousSettings miscellaneousSettingsField;

        private HtmlInputSettings htmlInputSettingsField;

        private RasterOutputSettings rasterOutputSettingsField;

        private AFPOutputSettings aFPOutputSettingsField;

        private PDFOutputSettings pDFOutputSettingsField;

        private PrintOutputSettings printOutputSettingsField;

        private HtmlOutputSettings htmlOutputSettingsField;

        private TxtOutputSettings txtOutputSettingsField;

        public RenderingParameters()
        {
            this.baseUrlField = "";
            this.inputBytesIDField = "";
            this.outputBytesIDField = "";
            this.serverVersionField = "0.0.0";
            this.preloadDocumentField = false;
            this.performLayoutField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public OutputFormat OutputFormat
        {
            get
            {
                return this.outputFormatField;
            }
            set
            {
                this.outputFormatField = value;
                this.RaisePropertyChanged("OutputFormat");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BaseUrl
        {
            get
            {
                return this.baseUrlField;
            }
            set
            {
                this.baseUrlField = value;
                this.RaisePropertyChanged("BaseUrl");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("0.0.0")]
        public string ServerVersion
        {
            get
            {
                return this.serverVersionField;
            }
            set
            {
                this.serverVersionField = value;
                this.RaisePropertyChanged("ServerVersion");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PreloadDocument
        {
            get
            {
                return this.preloadDocumentField;
            }
            set
            {
                this.preloadDocumentField = value;
                this.RaisePropertyChanged("PreloadDocument");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool PerformLayout
        {
            get
            {
                return this.performLayoutField;
            }
            set
            {
                this.performLayoutField = value;
                this.RaisePropertyChanged("PerformLayout");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public DocumentTemplate Template
        {
            get
            {
                return this.templateField;
            }
            set
            {
                this.templateField = value;
                this.RaisePropertyChanged("Template");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public MiscellaneousSettings MiscellaneousSettings
        {
            get
            {
                return this.miscellaneousSettingsField;
            }
            set
            {
                this.miscellaneousSettingsField = value;
                this.RaisePropertyChanged("MiscellaneousSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public HtmlInputSettings HtmlInputSettings
        {
            get
            {
                return this.htmlInputSettingsField;
            }
            set
            {
                this.htmlInputSettingsField = value;
                this.RaisePropertyChanged("HtmlInputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public RasterOutputSettings RasterOutputSettings
        {
            get
            {
                return this.rasterOutputSettingsField;
            }
            set
            {
                this.rasterOutputSettingsField = value;
                this.RaisePropertyChanged("RasterOutputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public AFPOutputSettings AFPOutputSettings
        {
            get
            {
                return this.aFPOutputSettingsField;
            }
            set
            {
                this.aFPOutputSettingsField = value;
                this.RaisePropertyChanged("AFPOutputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public PDFOutputSettings PDFOutputSettings
        {
            get
            {
                return this.pDFOutputSettingsField;
            }
            set
            {
                this.pDFOutputSettingsField = value;
                this.RaisePropertyChanged("PDFOutputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public PrintOutputSettings PrintOutputSettings
        {
            get
            {
                return this.printOutputSettingsField;
            }
            set
            {
                this.printOutputSettingsField = value;
                this.RaisePropertyChanged("PrintOutputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public HtmlOutputSettings HtmlOutputSettings
        {
            get
            {
                return this.htmlOutputSettingsField;
            }
            set
            {
                this.htmlOutputSettingsField = value;
                this.RaisePropertyChanged("HtmlOutputSettings");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public TxtOutputSettings TxtOutputSettings
        {
            get
            {
                return this.txtOutputSettingsField;
            }
            set
            {
                this.txtOutputSettingsField = value;
                this.RaisePropertyChanged("TxtOutputSettings");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            propertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}