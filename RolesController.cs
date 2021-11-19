using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Novit.HttpStatus.Controllers.V1.ViewModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        List<RolViewModel> recurso = new List<RolViewModel>
        {
            new RolViewModel {nombre = "Lucio", id = 1, estado = 1},
            new RolViewModel {nombre = "Joaquin",  id = 2, estado = 1},
            new RolViewModel {nombre = "Ana", id = 1, estado = 1 }

        };

        [HttpGet]
        public ActionResult<List<RolViewModel>> Get()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult<RolViewModel> Put()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] RolViewModel http)
        {
            return Ok();
        }

        [HttpDelete]


        public ActionResult<RolViewModel> Delete()
        {
            return Ok();
        }
    }
}
