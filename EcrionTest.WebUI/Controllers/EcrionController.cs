using System;
using System.IO;
using System.Web.Mvc;
using BridgeSuite.Ecrion.ObjectModel;
using BridgeSuite.Ecrion.Service;
using EcrionTest.WebUI.Models;

namespace EcrionTest.WebUI.Controllers
{
    [RoutePrefix("ecrion")]
    public class EcrionController : Controller
    {
        private EcrionService _ecrionService;

        public EcrionController()
        {
            _ecrionService = new EcrionService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RenderPDF(RenderingRequest request)
        {
            var pdfBytes= _ecrionService.Render(request.Xml, request.TemplateName,OutputFormat.PDF);
            return File(pdfBytes,"application/pdf",$"{Guid.NewGuid():N}.pdf");
        }

        [HttpPost]
        public ActionResult RenderHtml(RenderingRequest request)
        {
            var htmlBYtes = _ecrionService.Render(request.Xml, request.TemplateName, OutputFormat.HTML);
            ViewBag.Html = ReadHtmlAsString(htmlBYtes);
            return View();
        }

        private string ReadHtmlAsString(byte[] htmlBytes)
        {
            using (var stream= new MemoryStream(htmlBytes))
            using (var streamReader = new StreamReader(stream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}