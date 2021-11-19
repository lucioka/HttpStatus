using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Novit.HttpStatus.Controllers.V1.ViewModels;
using System.Collections.Generic;

namespace Novit.HttpStatus.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursosController : ControllerBase
    {
        List<RecursoViewModel> recurso = new List<RecursoViewModel>

        {
            new RecursoViewModel {nombre = "Lucio", id = 1, estado = 1},
            new RecursoViewModel {nombre = "Joaquin",  id = 2, estado = 1},
            new RecursoViewModel {nombre = "Ana", id = 1, estado = 1}

        };

        [HttpGet]
        public ActionResult<List<RecursoViewModel>> Get()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult<RecursoViewModel> Put()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] RecursoViewModel http)
        {
            return Ok();
        }

        [HttpDelete]


        public ActionResult<RecursoViewModel> Delete()
        {
            return Ok();
        }
    }
}
