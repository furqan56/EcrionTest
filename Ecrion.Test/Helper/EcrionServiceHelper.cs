using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ecrion.Test.Helper
{
    public class EcrionServiceHelper
    {
        public static Uri BaseUri => new Uri(ConfigurationManager.AppSettings["EcrionWebServiceURI"]);

        public static Uri PdfServiceUri => new Uri(BaseUri, "/ecrion/renderpdf");
        public static Uri HtmlServiceUri => new Uri(BaseUri, "/ecrion/renderhtml");

        internal static string ReadXml(string path)
        {
            var document = XDocument.Parse(File.ReadAllText(path));
            return document.ToString(SaveOptions.DisableFormatting);
        }
    }
}
