namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public class AFPOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private AFPFonts fontsField;

        private bool writeSentinelsField;

        private GrayscaleMethod grayscaleField;

        private bool autoRotateLandscapePagesField;

        public AFPOutputSettings()
        {
            this.fontsField = AFPFonts.NativeRasterFonts;
            this.writeSentinelsField = false;
            this.grayscaleField = GrayscaleMethod.Disabled;
            this.autoRotateLandscapePagesField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(AFPFonts.NativeRasterFonts)]
        public AFPFonts Fonts
        {
            get
            {
                return this.fontsField;
            }
            set
            {
                this.fontsField = value;
                this.RaisePropertyChanged("Fonts");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool WriteSentinels
        {
            get
            {
                return this.writeSentinelsField;
            }
            set
            {
                this.writeSentinelsField = value;
                this.RaisePropertyChanged("WriteSentinels");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(GrayscaleMethod.Disabled)]
        public GrayscaleMethod Grayscale
        {
            get
            {
                return this.grayscaleField;
            }
            set
            {
                this.grayscaleField = value;
                this.RaisePropertyChanged("Grayscale");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AutoRotateLandscapePages
        {
            get
            {
                return this.autoRotateLandscapePagesField;
            }
            set
            {
                this.autoRotateLandscapePagesField = value;
                this.RaisePropertyChanged("AutoRotateLandscapePages");
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