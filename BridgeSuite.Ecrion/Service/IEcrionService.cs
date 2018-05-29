using System.Threading.Tasks;
using BridgeSuite.Ecrion.ObjectModel;

namespace BridgeSuite.Ecrion.Service
{
    public interface IEcrionService
    {
        Task<byte[]> RenderAsync(string xml, string template);
        byte[] Render(string xml, string template);
        byte[] Render(string xml, string template, OutputFormat outputFormat);
    }
}