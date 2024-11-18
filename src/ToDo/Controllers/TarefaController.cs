﻿using Microsoft.AspNetCore.Mvc;
using ToDo.Contracts;
using static ToDo.Util.Controller;

namespace ToDo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : Controller
    {
        private readonly ITarefa _tarefaContract;
        public TarefaController(ITarefa tarefaContract)
        {
            _tarefaContract = tarefaContract;
        }

        [HttpPost("/Create/Tarefa/")]
        public IActionResult Create([FromBody] TarefaDC tarefa)
        {
            return JsonOptionsUtil.Create(_tarefaContract.Create(tarefa));
        }

        [HttpPut("/Update/Tarefa/")]
        public IActionResult Update(TarefaDC tarefa)
        {
            return JsonOptionsUtil.Create(_tarefaContract.Update(tarefa));
        }

        [HttpGet("/Detail/Tarefa/{id}")]
        public IActionResult Detail(int id)
        {
            return JsonOptionsUtil.Create(_tarefaContract.Detail(id));
        }

        [HttpDelete("/Delete/Tarefa/")]
        public IActionResult Delete([FromQuery] int[] ids)
        {
            _tarefaContract.Delete(ids);
            return Json(null);
        }

        [HttpGet("/Search/Tarefa/")]
        public IActionResult Search()
        {
            return JsonOptionsUtil.Create(_tarefaContract.Search().ToList());
        }
    }
}
