namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class HtmlInputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string pageWidthField;

        private string pageHeightField;

        private string pageMarginTopField;

        private string pageMarginLeftField;

        private string pageMarginRightField;

        private string pageMarginBottomField;

        private string pageHeaderMarginField;

        private string pageFooterMarginField;

        private bool showPageNumberField;

        private bool showTitleField;

        public HtmlInputSettings()
        {
            this.pageWidthField = "auto";
            this.pageHeightField = "auto";
            this.pageMarginTopField = "1in";
            this.pageMarginLeftField = "1in";
            this.pageMarginRightField = "1in";
            this.pageMarginBottomField = "1in";
            this.pageHeaderMarginField = "0.5in";
            this.pageFooterMarginField = "0.5in";
            this.showPageNumberField = true;
            this.showTitleField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute("auto")]
        public string PageWidth
        {
            get
            {
                return this.pageWidthField;
            }
            set
            {
                this.pageWidthField = value;
                this.RaisePropertyChanged("PageWidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute("auto")]
        public string PageHeight
        {
            get
            {
                return this.pageHeightField;
            }
            set
            {
                this.pageHeightField = value;
                this.RaisePropertyChanged("PageHeight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute("1in")]
        public string PageMarginTop
        {
            get
            {
                return this.pageMarginTopField;
            }
            set
            {
                this.pageMarginTopField = value;
                this.RaisePropertyChanged("PageMarginTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute("1in")]
        public string PageMarginLeft
        {
            get
            {
                return this.pageMarginLeftField;
            }
            set
            {
                this.pageMarginLeftField = value;
                this.RaisePropertyChanged("PageMarginLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("1in")]
        public string PageMarginRight
        {
            get
            {
                return this.pageMarginRightField;
            }
            set
            {
                this.pageMarginRightField = value;
                this.RaisePropertyChanged("PageMarginRight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute("1in")]
        public string PageMarginBottom
        {
            get
            {
                return this.pageMarginBottomField;
            }
            set
            {
                this.pageMarginBottomField = value;
                this.RaisePropertyChanged("PageMarginBottom");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute("0.5in")]
        public string PageHeaderMargin
        {
            get
            {
                return this.pageHeaderMarginField;
            }
            set
            {
                this.pageHeaderMarginField = value;
                this.RaisePropertyChanged("PageHeaderMargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute("0.5in")]
        public string PageFooterMargin
        {
            get
            {
                return this.pageFooterMarginField;
            }
            set
            {
                this.pageFooterMarginField = value;
                this.RaisePropertyChanged("PageFooterMargin");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ShowPageNumber
        {
            get
            {
                return this.showPageNumberField;
            }
            set
            {
                this.showPageNumberField = value;
                this.RaisePropertyChanged("ShowPageNumber");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ShowTitle
        {
            get
            {
                return this.showTitleField;
            }
            set
            {
                this.showTitleField = value;
                this.RaisePropertyChanged("ShowTitle");
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