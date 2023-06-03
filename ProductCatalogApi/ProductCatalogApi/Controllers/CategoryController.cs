using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuisnessLogic;
using Models;


namespace ProductCatalogApi.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        ILogic logic;
        public CategoryController(ILogic _logic)
        {
            logic = _logic;
        }

        [HttpGet("getallcategories")]
        public IActionResult GetAllCategories()
        {
            try
            {
                return Ok(logic.GetAllCategories());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromBody] CategoryModel categoryModel)
        {
            try
            {
                return Ok(logic.AddCategory(categoryModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteCategoryById/{id}")]
        public IActionResult DeleteCategory([FromRoute] int id)
        {
            try
            {
                return Ok(logic.DeleteCategory(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory([FromBody] CategoryModel categoryModel)
        {
            try
            {
                return Ok(logic.UpdateCategory(categoryModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

