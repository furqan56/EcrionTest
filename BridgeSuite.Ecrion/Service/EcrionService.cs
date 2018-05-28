using System;
using System.Threading.Tasks;
using BridgeSuite.Ecrion.ObjectModel;

namespace BridgeSuite.Ecrion.Service
{
    public class EcrionService : IEcrionService
    {
        private readonly IEcrionServiceClient _ecrionServiceClient;

        public EcrionService()
        {
            _ecrionServiceClient = new EcrionServiceClient();
        }
        public EcrionService(IEcrionServiceClient ecrionServiceClient)
        {
            if (ecrionServiceClient == null) throw new ArgumentNullException(nameof(ecrionServiceClient));
            _ecrionServiceClient = ecrionServiceClient;
        }

        public async Task<byte[]> RenderAsync(string xml, string template)
        {
            var request = new RenderRequest
            {
                Input = new XmlDataSource
                {
                    Content = xml,
                    Format = InputFormat.XML
                },
                Parameters = new RenderingParameters
                {
                    OutputFormat = OutputFormat.HTML,
                    PDFOutputSettings = new PDFOutputSettings { ImageCompression = PDFImageCompression.FLAT },
                    Template = new ServerDocumentTemplate { ID = template }
                }
            };
            var response = await _ecrionServiceClient.RenderAsync(request);
            return response.RenderResult;

        }
        public byte[] Render(string xml, string template)
        {
            try
            {
                var request = new RenderRequest
                {
                    Input = new XmlDataSource
                    {
                        Content = xml,
                        Format = InputFormat.XML
                    },
                    Parameters = new RenderingParameters
                    {
                        OutputFormat = OutputFormat.HTML,
                        PDFOutputSettings = new PDFOutputSettings { ImageCompression = PDFImageCompression.FLAT },
                        Template = new ServerDocumentTemplate { ID = template }
                    }
                };

                return _ecrionServiceClient.Render(request).RenderResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
