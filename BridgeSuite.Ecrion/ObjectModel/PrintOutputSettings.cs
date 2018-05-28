namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class PrintOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string printerNameField;

        private string outputPrintFileField;

        private string inputTrayField;

        private string outputTrayField;

        private int copyCountField;

        private bool duplexField;

        public PrintOutputSettings()
        {
            this.printerNameField = "";
            this.outputPrintFileField = "";
            this.inputTrayField = "";
            this.outputTrayField = "";
            this.copyCountField = -1;
            this.duplexField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PrinterName
        {
            get
            {
                return this.printerNameField;
            }
            set
            {
                this.printerNameField = value;
                this.RaisePropertyChanged("PrinterName");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OutputPrintFile
        {
            get
            {
                return this.outputPrintFileField;
            }
            set
            {
                this.outputPrintFileField = value;
                this.RaisePropertyChanged("OutputPrintFile");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string InputTray
        {
            get
            {
                return this.inputTrayField;
            }
            set
            {
                this.inputTrayField = value;
                this.RaisePropertyChanged("InputTray");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string OutputTray
        {
            get
            {
                return this.outputTrayField;
            }
            set
            {
                this.outputTrayField = value;
                this.RaisePropertyChanged("OutputTray");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int CopyCount
        {
            get
            {
                return this.copyCountField;
            }
            set
            {
                this.copyCountField = value;
                this.RaisePropertyChanged("CopyCount");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Duplex
        {
            get
            {
                return this.duplexField;
            }
            set
            {
                this.duplexField = value;
                this.RaisePropertyChanged("Duplex");
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