﻿using Microsoft.AspNetCore.Mvc;
using ToDo.Contracts;
using static ToDo.Util.Controller;
using ToDo.Models;

namespace ToDo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuarioContract;
        public UsuarioController(IUsuario usuarioContract)
        {
            _usuarioContract = usuarioContract;
        }

        [HttpPost("/Create/")]
        public IActionResult Create([FromBody] UsuarioNovoDC usuario)
        {
            return JsonOptionsUtil.Create(_usuarioContract.Create(usuario));
        }

        [HttpPut("Usuario/Update/")]
        public IActionResult Update(UsuarioDC usuario)
        {
            return JsonOptionsUtil.Create(_usuarioContract.Update(usuario));
        }

        [HttpGet("Usuario/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            return JsonOptionsUtil.Create(_usuarioContract.Detail(id));
        }

        [HttpDelete("Usuario/Delete/")]
        public IActionResult Delete([FromQuery] int[] ids)
        {
            _usuarioContract.Delete(ids);
            return Json(null);
        }

        [HttpGet("Usuario/Search/")]
        public IActionResult Search()
        {
            return JsonOptionsUtil.Create(_usuarioContract.Search());
        }
    }
}
