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
   
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [Consumes("application/json")]
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
