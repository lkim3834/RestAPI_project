
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI_project.Controllers
{
    // indicates that a type and all derived types are used to serve HTTP API responses
    [ApiController]
    // controller is Character, which comes before Controller on the class name
    [Route("api/[controller]")] 
    public class CharacterController: ControllerBase
    {
         private static Character knight = new Character();
         // enables us to send specific HTTP status codes back to the client
        [HttpGet]
         public ActionResult <Character> Get()
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)
            return Ok(knight);
         }
    }
}