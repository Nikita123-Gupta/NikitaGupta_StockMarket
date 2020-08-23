using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using StockMarket.ExcelAPI.Repository;
using System.IO;
using OfficeOpenXml;
using System.Text;

namespace StockMarket.ExcelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        private IExcelRepository repo;
        public ExcelController(IExcelRepository _repo)
        {
            repo = _repo;
        }
        [HttpGet]
        [Route("Import/{*filepath}")]

        public IActionResult ImportData(string filePath)
        {
            
            try
            {
                repo.ImportData(filePath);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("Export")]
        public IActionResult ExportData()
        {
           
                try
                {
                    repo.ExportData();
                    return Ok();
                }
                catch (Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }

            
        }
    
}
}