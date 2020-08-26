using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.UserAPI.Models;
using StockMarket.UserAPI.Services;

namespace StockMarket.UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService ser;
        public UserController(IUserService _ser)
        {
            ser = _ser;
        }
        [HttpGet]
        [Route("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            try
            {
                List<Company> list = ser.GetAllCompany();
                return Ok(list);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllIpo")]
        public IActionResult GetAllIpo()
        {
            try
            {
                List<IpoDetails> list = ser.GetAllIpo();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompany/{CompanyCode}")]
        public IActionResult GetCompany(string CompanyCode)
        {
            try
            {
                Company list = ser.GetCompanyById(CompanyCode);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIpo/{Id}")]
        public IActionResult GetIpo(int Id)
        {
            try
            {
                IpoDetails list = ser.GetIpoById(Id);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetStock/{CompanyCode}/{RowId}")]
        public IActionResult GetStockById(string CompanyCode , int RowId)
        {
            try
            {
                StockPrice list = ser.GetStockById(CompanyCode, RowId);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetAllStock/{CompanyCode}")]
        public IActionResult GetStockForCompany(string CompanyCode)
        {
            try
            {
                List<StockPrice> list = ser.GetStockForCompany(CompanyCode);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
