using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeAnalysis.Models;
using ResumeAnalysis.Services;

namespace ResumeAnalysis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController : ControllerBase
    {

        private readonly GroqService _groqService;

        public ResumeController(GroqService groqService)
        {
            _groqService = groqService;
        }


        [HttpPost("analyze")]
        public async Task<IActionResult> AnalyzeResume([FromBody] ResumeRequest request)
        {
            try
            {
                byte[] pdfBytes;

                // Case 1: HTTP or HTTPS URL
                if (request.ResumePdfUrl.StartsWith("http"))
                {
                    using var httpClient = new HttpClient();
                    pdfBytes = await httpClient.GetByteArrayAsync(request.ResumePdfUrl);
                }
                // Case 2: Local file path
                else if (System.IO.File.Exists(request.ResumePdfUrl))
                {
                    pdfBytes = await System.IO.File.ReadAllBytesAsync(request.ResumePdfUrl);
                }
                else
                {
                    return BadRequest(new { message = "Invalid file path or file not found." });
                }

                using var stream = new MemoryStream(pdfBytes);
                using var pdfReader = new PdfReader(stream);
                using var pdfDoc = new PdfDocument(pdfReader);

                string resumeText = "";

                for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
                {
                    resumeText += PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i));
                }

                var aiResponse = await _groqService.AnalyzeResumeAsync(
                    resumeText,
                    request.CompanyName,
                    request.Role
                );

                return Ok(new ResumeResponse
                {
                    RawAiResponse = aiResponse
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }



    }
}
