using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuisnessLogic;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    public class SpecificationController : Controller
    {
        ILogic logic;

        public SpecificationController(ILogic _logic)
        {
            logic = _logic;
        }

        [HttpPost("AddSpecification")]
        public IActionResult AddSpecification([FromBody] SpecificationModel specificationModel)
        {
            try
            {
                return Ok(logic.AddSpecification(specificationModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetSpecificationsByProductId/{id}")]
        public IActionResult GetSpecificationsByProductId([FromRoute] int id)
        {
            try
            {
                return Ok(logic.GetSpecificationsByProductId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteSpecificationByID/{id}")]
        public IActionResult DeleteSpecificationByID([FromRoute] int id)
        {
            try
            {
                return Ok(logic.DeleteSpecificationByID(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateSpecification")]
        public IActionResult UpdateSpecification([FromBody] SpecificationModel specificationModel)
        {
            try
            {
                return Ok(logic.UpdateSpecification(specificationModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}

