using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecrion.Test.Helper
{
    public class EcrionServiceHelper
    {
        private static Uri BaseUri => new Uri(ConfigurationManager.AppSettings["EcrionWebServiceURI"]);

        public static Uri PdfServiceUri => new Uri(BaseUri, "/ecrion/renderpdf");
        public static Uri HtmlServiceUri => new Uri(BaseUri, "/ecrion/renderhtml");
    }
}
