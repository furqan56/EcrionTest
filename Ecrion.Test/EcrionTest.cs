using System;
using System.IO;
using System.Windows.Forms;
using BridgeSuite.Ecrion.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHtmlUnit;
using NHtmlUnit.Html;

namespace Ecrion.Test
{
    [TestClass]
    public class EcrionTest
    {
        private EcrionService _ecrionService;

        public EcrionTest()
        {
            _ecrionService = new EcrionService();
        }

        [TestInitialize]
        public void SetUp()
        {
            if (!Directory.Exists("..\\..\\Files\\Temp"))
                Directory.CreateDirectory("..\\..\\Files\\Temp");
        }

        [TestMethod]
        public void TestMethod1()
        {
            var htmlFilePath =RenderHtml("..\\..\\Files\\Kaiser\\KaiserSureNet_OutReach.xml", "KP:KP_B12_BS_PROD.xfd");
            var page =new WebClient().GetHtmlPage(htmlFilePath);
        }

        private string RenderHtml(string xmlPath,string template)
        {
            var xml = File.ReadAllText(xmlPath);
            var htmlbytes = _ecrionService.Render(xml, template);
            var filePath = $"..\\..\\Files\\Temp\\{Guid.NewGuid():N}.html";
            File.WriteAllBytes(filePath, htmlbytes);
            return filePath;
        }

        [TestCleanup]
        public void TearDown()
        {
          Directory.Delete("..\\..\\Files\\Temp",true);  
        }
    }
}
