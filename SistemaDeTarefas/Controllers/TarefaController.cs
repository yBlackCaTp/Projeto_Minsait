using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tarefaContorller : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public tarefaContorller ( ITarefaRepositorio tarefaRespositorio)
        {
            _tarefaRepositorio = tarefaRespositorio;

        }
         
        [HttpGet]
        public async Task<ActionResult<List<TarefaModel>>> BuscarTodostarefas()
        {
            List<TarefaModel> tarefas = await _tarefaRepositorio.BuscarTodostarefas();
            return Ok(tarefas);

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<TarefaModel>>> BuscarPorId(int id)
        {
            TarefaModel tarefa = await _tarefaRepositorio.BuscarPorId(id);
            return Ok();
        }

        [HttpPost]

        public async Task<ActionResult<TarefaModel>> Cadastrar([FromBody] TarefaModel TarefaModel)
        {
            TarefaModel tarefa = await _tarefaRepositorio.Adicionar(TarefaModel);
            return Ok(tarefa);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<TarefaModel>> Atualizar([FromBody] TarefaModel TarefaModel, int id)
        {
            TarefaModel.Id = id;
            TarefaModel tarefa = await _tarefaRepositorio.Atualizar(TarefaModel, id);
            return Ok(tarefa);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<TarefaModel>> Apagar(int id)
        {
            bool apagado = await _tarefaRepositorio.Apagar(id);
            return Ok(apagado);
        }

    }
}