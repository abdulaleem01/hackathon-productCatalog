using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuisnessLogic;
using Microsoft.AspNetCore.Mvc;
using Models;


namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        ILogic logic;
        public ProductsController(ILogic _logic)
        {
            logic = _logic;

        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] ProductModel productModel)
        {
            try
            {
                return Ok(logic.AddProduct(productModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProductByID/{id}")]
        public IActionResult GetProductByID([FromRoute] int id)
        {
            try
            {

                return Ok(logic.GetProductByID(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            try
            {
                return Ok(logic.GetAllProduct());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProductByCategoryID/{id}")]
        public IActionResult GetProductByCategoryID([FromRoute] int id)
        {
            try
            {
                return Ok(logic.GetProductByCategoryID(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] ProductModel productModel)
        {
            try
            {
                return Ok(logic.UpdateProduct(productModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteProductById/{id}")]
        public IActionResult DeleteProductById([FromRoute] int id)
        {
            try
            {
                return Ok(logic.DeleteProductById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

