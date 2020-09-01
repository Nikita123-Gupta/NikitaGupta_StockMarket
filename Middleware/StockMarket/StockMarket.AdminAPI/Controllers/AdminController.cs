using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Services;

namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService adminService;
        public AdminController(IAdminService ser)
        {
            adminService = ser;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Admin Service");
        }
        [HttpGet]
        [Route("GetCompany")]
        public IActionResult GetAllCompany()
        {
            try
            {
                List<Company> list = adminService.GetAllCompany();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIpo")]
        public IActionResult GetAllIpo()
        {
            try
            {
                List<IpoDetails> list = adminService.GetAllIpo();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]

        public IActionResult Add(Company company) {
            try
            {
                adminService.AddCompany(company);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("EditCompany")]

        public IActionResult Edit(Company company)
        {
            try
            {
                adminService.EditCompany(company);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteCompany/{code}")]

        public IActionResult Delete(string code)
        {
            try
            {
                adminService.DeleteCompany(code);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateIpo")]

        public IActionResult UpdateIPO(IpoDetails ipo)
        {
            try
            {
                adminService.UpdateIpo(ipo);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("AddIpo")]
        public IActionResult AddIPO(IpoDetails item)
        {
            try
            {
                adminService.AddIpo(item);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString());
            }
        }
        [HttpDelete]
        [Route("DeleteIpo/{Id}")]
        public IActionResult DeleteIPO(int Id)
        {
            try
            {
                adminService.DeleteIpo(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
