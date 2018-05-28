using System;
using System.Xml.Serialization;

namespace BridgeSuite.Ecrion.ObjectModel
{
    /// <remarks/>

    [Serializable()]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum OutputEncoding
    {

        /// <remarks/>
        ASCII,

        /// <remarks/>
        UTF16,

        /// <remarks/>
        UTF8,
    }

    /// <remarks/>

    [Serializable()]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum PDFConformance
    {

        /// <remarks/>
        PDF14,

        /// <remarks/>
        PDFX,

        /// <remarks/>
        PDFA1A,

        /// <remarks/>
        PDFA1B,

        /// <remarks/>
        PDF508,
    }

    /// <remarks/>

    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum PDFImageCompression
    {

        /// <remarks/>
        FLAT,

        /// <remarks/>
        JPEG,
    }


    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum AFPFonts
    {

        /// <remarks/>
        NativeRasterFonts,

        /// <remarks/>
        NativeOutlineFonts,

        /// <remarks/>
        ConvertToNativeFonts,
    }

    /// <remarks/>

    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum GrayscaleMethod
    {

        /// <remarks/>
        Disabled,

        /// <remarks/>
        RGB,

        /// <remarks/>
        Pattern,

        /// <remarks/>
        Highlight,
    }


    [Serializable()]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum CompressionAlgorithm
    {

        /// <remarks/>
        None,

        /// <remarks/>
        CCITT3,

        /// <remarks/>
        CCITT4,

        /// <remarks/>
        LZW,

        /// <remarks/>
        RLE,
    }


    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum SmoothingMode
    {

        /// <remarks/>
        Default,

        /// <remarks/>
        None,

        /// <remarks/>
        AntiAlias,
    }


    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum ReferenceResolverType
    {

        /// <remarks/>
        Parallel,

        /// <remarks/>
        Serial,

        /// <remarks/>
        Disabled,
    }

    [Serializable()]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum ImageErrorsHandlingMode
    {

        /// <remarks/>
        ThrowError,

        /// <remarks/>
        Ignore,

        /// <remarks/>
        IgnoreAndDisplayImageNotFound,
    }

    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum XsltEngine
    {

        /// <remarks/>
        MSXML,

        /// <remarks/>
        DotNet20,

        /// <remarks/>
        Saxon,
    }


    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum OutputFormat
    {

        /// <remarks/>
        Unknown,

        /// <remarks/>
        PDF,

        /// <remarks/>
        AFP,

        /// <remarks/>
        POSTSCRIPT,

        /// <remarks/>
        WordML,

        /// <remarks/>
        XPS,

        /// <remarks/>
        TIFF,

        /// <remarks/>
        PRN,

        /// <remarks/>
        HTML,

        /// <remarks/>
        JPEG,

        /// <remarks/>
        GIF,

        /// <remarks/>
        PNG,

        /// <remarks/>
        PPTX,

        /// <remarks/>
        EPUB,

        /// <remarks/>
        IOCA,

        /// <remarks/>
        TXT,

        /// <remarks/>
        DOCX,

        /// <remarks/>
        Extended,

        /// <remarks/>
        DICOM,
    }

    [Serializable]
    [XmlType(Namespace = "http://www.ecrion.com/xfws/2.0")]
    public enum InputFormat
    {

        /// <remarks/>
        Unknown,

        /// <remarks/>
        XSLFO,

        /// <remarks/>
        SVG,

        /// <remarks/>
        XML,

        /// <remarks/>
        WordML,

        /// <remarks/>
        DocX,

        /// <remarks/>
        PDF,

        /// <remarks/>
        HTML,

        /// <remarks/>
        EPS,

        /// <remarks/>
        DAL,

        /// <remarks/>
        Extended,
    }

}
