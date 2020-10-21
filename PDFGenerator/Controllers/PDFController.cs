using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PDFGenerator.Models;
using PDFGenerator.Services;

namespace PDFGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PDFController : ControllerBase
    {
        private readonly IPDFService _pdfService;

        public PDFController(
            IPDFService pdfService)
        {
            _pdfService = pdfService;
        }

        [HttpPost]
        public async Task<IActionResult> GeneratePDF([FromBody] PDFGenerationOptions options)
        {
            try
            {
                var fileContentResult = await _pdfService.GeneratePDFAsync(options.Url);
                var escapedFileName = Uri.EscapeDataString(options.Filename);

                Response.Headers.Add("content-disposition", $"attachment; filename={escapedFileName}");

                return fileContentResult;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
