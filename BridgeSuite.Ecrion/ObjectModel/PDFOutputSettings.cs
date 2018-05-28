namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class PDFOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private PDFConformance pDFConformanceField;

        private bool allowPrintingField;

        private bool allowModifyContentsField;

        private bool allowCopyField;

        private bool allowModifyAnnotationsField;

        private bool allowFillInField;

        private bool allowScreenReadersField;

        private bool allowAssemblyField;

        private bool allowDegradedPrintingField;

        private int encryptionStrengthField;

        private string userPasswordField;

        private string ownerPasswordField;

        private PDFImageCompression imageCompressionField;

        public PDFOutputSettings()
        {
            this.pDFConformanceField = PDFConformance.PDF14;
            this.allowPrintingField = false;
            this.allowModifyContentsField = false;
            this.allowCopyField = false;
            this.allowModifyAnnotationsField = false;
            this.allowFillInField = false;
            this.allowScreenReadersField = false;
            this.allowAssemblyField = false;
            this.allowDegradedPrintingField = false;
            this.encryptionStrengthField = 40;
            this.userPasswordField = "";
            this.ownerPasswordField = "";
            this.imageCompressionField = PDFImageCompression.JPEG;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(PDFConformance.PDF14)]
        public PDFConformance PDFConformance
        {
            get
            {
                return this.pDFConformanceField;
            }
            set
            {
                this.pDFConformanceField = value;
                this.RaisePropertyChanged("PDFConformance");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowPrinting
        {
            get
            {
                return this.allowPrintingField;
            }
            set
            {
                this.allowPrintingField = value;
                this.RaisePropertyChanged("AllowPrinting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowModifyContents
        {
            get
            {
                return this.allowModifyContentsField;
            }
            set
            {
                this.allowModifyContentsField = value;
                this.RaisePropertyChanged("AllowModifyContents");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowCopy
        {
            get
            {
                return this.allowCopyField;
            }
            set
            {
                this.allowCopyField = value;
                this.RaisePropertyChanged("AllowCopy");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowModifyAnnotations
        {
            get
            {
                return this.allowModifyAnnotationsField;
            }
            set
            {
                this.allowModifyAnnotationsField = value;
                this.RaisePropertyChanged("AllowModifyAnnotations");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowFillIn
        {
            get
            {
                return this.allowFillInField;
            }
            set
            {
                this.allowFillInField = value;
                this.RaisePropertyChanged("AllowFillIn");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowScreenReaders
        {
            get
            {
                return this.allowScreenReadersField;
            }
            set
            {
                this.allowScreenReadersField = value;
                this.RaisePropertyChanged("AllowScreenReaders");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowAssembly
        {
            get
            {
                return this.allowAssemblyField;
            }
            set
            {
                this.allowAssemblyField = value;
                this.RaisePropertyChanged("AllowAssembly");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowDegradedPrinting
        {
            get
            {
                return this.allowDegradedPrintingField;
            }
            set
            {
                this.allowDegradedPrintingField = value;
                this.RaisePropertyChanged("AllowDegradedPrinting");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        [System.ComponentModel.DefaultValueAttribute(40)]
        public int EncryptionStrength
        {
            get
            {
                return this.encryptionStrengthField;
            }
            set
            {
                this.encryptionStrengthField = value;
                this.RaisePropertyChanged("EncryptionStrength");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserPassword
        {
            get
            {
                return this.userPasswordField;
            }
            set
            {
                this.userPasswordField = value;
                this.RaisePropertyChanged("UserPassword");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OwnerPassword
        {
            get
            {
                return this.ownerPasswordField;
            }
            set
            {
                this.ownerPasswordField = value;
                this.RaisePropertyChanged("OwnerPassword");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        [System.ComponentModel.DefaultValueAttribute(PDFImageCompression.JPEG)]
        public PDFImageCompression ImageCompression
        {
            get
            {
                return this.imageCompressionField;
            }
            set
            {
                this.imageCompressionField = value;
                this.RaisePropertyChanged("ImageCompression");
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