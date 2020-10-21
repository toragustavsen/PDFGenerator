using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PDFGenerator.Services
{
    public interface IPDFService
    {
        Task<FileContentResult> GeneratePDFAsync(string url);
    }
}
