using System.Data;
using AssignmentDay5.Data;
using AssignmentDay5.Services;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentDay5.Controllers
{
    public class RookiesController : Controller
    {
        private readonly IRookiesService _rookiesService;
        private readonly ILogger<RookiesController> _logger;

        public RookiesController(ILogger<RookiesController> logger, IRookiesService rookiesService)
        {
            _logger = logger;
            _rookiesService = rookiesService;
        }

        [Route("Rookies/MaleRookies")]
        public IActionResult GetMaleRookies()
        {
            return Ok(_rookiesService.GetMaleRookies());
        }

        [Route("Rookies/OldestRookie")]
        public IActionResult OldestRookies()
        {
            return Ok(_rookiesService.OldestRookie());
        }

        [Route("Rookies/FullName")]
        public IActionResult FullNameRookies()
        {
            return Ok(_rookiesService.FullNameRookies());
        }

        [Route("Rookies/GetRookiesByYear")]
        public IActionResult GetRookiesByYear(int year)
        {
            return Ok(_rookiesService.GetRookiesByYear(2000));
        }

        [Route("Rookies/ExportExcel")]
        public FileResult ExportExcelFile()
        {
            var table = _rookiesService.GetDataTable();
            using (XLWorkbook workBook = new XLWorkbook())
            {
                workBook.Worksheets.Add(table, "Rookies");
                using (MemoryStream stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
                }
            }
        }
    }
}