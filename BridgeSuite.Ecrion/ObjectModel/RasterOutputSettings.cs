namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public partial class RasterOutputSettings : object, System.ComponentModel.INotifyPropertyChanged
    {

        private CompressionAlgorithm compressionAlgorithmField;

        private float zoomFactorField;

        private int xResolutionField;

        private int yResolutionField;

        private SmoothingMode smoothingModeField;

        private int pageIdxField;

        private bool imageTransparentBackgroundField;

        private int imageScaleWidthField;

        private int imageScaleHeightField;

        public RasterOutputSettings()
        {
            this.compressionAlgorithmField = CompressionAlgorithm.None;
            this.zoomFactorField = ((float)(100F));
            this.xResolutionField = 0;
            this.yResolutionField = 0;
            this.smoothingModeField = SmoothingMode.Default;
            this.pageIdxField = -1;
            this.imageTransparentBackgroundField = false;
            this.imageScaleWidthField = -1;
            this.imageScaleHeightField = -1;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.ComponentModel.DefaultValueAttribute(CompressionAlgorithm.None)]
        public CompressionAlgorithm CompressionAlgorithm
        {
            get
            {
                return this.compressionAlgorithmField;
            }
            set
            {
                this.compressionAlgorithmField = value;
                this.RaisePropertyChanged("CompressionAlgorithm");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(typeof(float), "100")]
        public float ZoomFactor
        {
            get
            {
                return this.zoomFactorField;
            }
            set
            {
                this.zoomFactorField = value;
                this.RaisePropertyChanged("ZoomFactor");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int XResolution
        {
            get
            {
                return this.xResolutionField;
            }
            set
            {
                this.xResolutionField = value;
                this.RaisePropertyChanged("XResolution");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public int YResolution
        {
            get
            {
                return this.yResolutionField;
            }
            set
            {
                this.yResolutionField = value;
                this.RaisePropertyChanged("YResolution");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(SmoothingMode.Default)]
        public SmoothingMode SmoothingMode
        {
            get
            {
                return this.smoothingModeField;
            }
            set
            {
                this.smoothingModeField = value;
                this.RaisePropertyChanged("SmoothingMode");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int PageIdx
        {
            get
            {
                return this.pageIdxField;
            }
            set
            {
                this.pageIdxField = value;
                this.RaisePropertyChanged("PageIdx");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ImageTransparentBackground
        {
            get
            {
                return this.imageTransparentBackgroundField;
            }
            set
            {
                this.imageTransparentBackgroundField = value;
                this.RaisePropertyChanged("ImageTransparentBackground");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ImageScaleWidth
        {
            get
            {
                return this.imageScaleWidthField;
            }
            set
            {
                this.imageScaleWidthField = value;
                this.RaisePropertyChanged("ImageScaleWidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int ImageScaleHeight
        {
            get
            {
                return this.imageScaleHeightField;
            }
            set
            {
                this.imageScaleHeightField = value;
                this.RaisePropertyChanged("ImageScaleHeight");
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