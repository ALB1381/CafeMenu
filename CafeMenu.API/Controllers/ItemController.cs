using CafeMenu.Core.DTOs;
using CafeMenu.Core.Services.Interfaces;
using CafeMenu.Data.Entities.Item;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CafeMenu.API.Controllers
{
    [ApiController]
    [Route("api/Item")]
    public class ItemController : ControllerBase
    {
        IItemServices _service;
        public ItemController(IItemServices itemServices)
        {
            _service = itemServices;
        }
        //Actions Input Parameters
        //[FromBody] Is Normally use for complex data types and Core will undrestand the type and it will taken by Json {Name: Ali;Age: 21} defined as User{string Name; int Age}
        //[FromForm] it will be inserted by a form how ever the name of Inputs in form should be as same as property name
        //FromHeader] it means the value should be inserted in header of the http request. We will noramlly use this for geting API key
        //[FromQuery] It will be taken by URL string parameter (api/Item?name=ali;age=12)
        //[FromRoute] It will be taken by URL string parameter (api/Item/ali/12)
        //[FromServices] Use DI in Input Of an Action or API Endpoint
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Consumes("application/json")]
        //[Consumes("application/xml")]
        //[Consumes("application/x-www-form-urlencoded")]
        //the two up parametters are normally will be used to not accept any types of input and inputs should be limited as json or XML
        //the thered one is telling that the action will accept jus form types inputs


        //GET /api/todoitems	Get all to-do items	None	Array of to-do items
        // GET /api/todoitems/{id}	Get an item by ID None    To-do item
        //POST /api/todoitems Add a new item To-do item To-do item
        //PUT /api/todoitems/{id}
        //Update an existing item  	To-do item	None
        //DELETE /api/todoitems/{id}    
        //



        //public ActionResult<ItemBoxDTO> GetItems([FromQuery] int GroupId = 0)
        //{
        //    var result = _service.GetItemBoxInformation(GroupId);
        //    if (result == null)
        //    {
        //        return NoContent();
        //    }
        //    return Ok(result);
        //}
        public async Task<ActionResult<ItemBoxDTO>> GetItems([FromQuery] int GroupId = 0)
        {
            var result = await _service.GetItemBoxInformation(GroupId);
            if (result == null)
            {
                return NoContent();
            }
            return Ok(result);
        }

        [HttpGet("GetGroups")]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<ItemGroupDTO>> GetGroups()
        {
            var res = await _service.GetAllGroups();
            if (res == null) 
            {
                return NoContent();
            }
            return Ok(res);
        }
    }
}