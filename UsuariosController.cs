using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Novit.HttpStatus.Controllers.V1.ViewModels;
using System.Collections.Generic;

namespace Novit.HttpStatus.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {


        List<UsuarioViewModel> usuarios = new List<UsuarioViewModel>
        {
            new UsuarioViewModel {nombre = "Lucio", apellido = "Kliszczewski", id = 1, email = "luciokli@hotmail.com", username = "lucioka", password = "123", estado = 1},
            new UsuarioViewModel {nombre = "Joaquin", apellido = "Lopez", id = 2, email = "lopez@hotmail.com", username = "lopez", password = "123", estado = 1},
            new UsuarioViewModel {nombre = "Ana", apellido = "Lisa", id = 1, email = "ana@hotmail.com", username = "lisa", password = "123", estado = 1}

        };

         [HttpGet] 
        public ActionResult<List<UsuarioViewModel>> Get()
        {
            return Ok();
        }

        [HttpPut]
        public ActionResult<UsuarioViewModel> Put()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Post([FromBody] UsuarioViewModel http)
        {
            return Ok();
        }

        [HttpDelete]


        public ActionResult<UsuarioViewModel> Delete()
        {
            return Ok();
        }


    }
}
