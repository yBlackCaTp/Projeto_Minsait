using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaDeTarefasDBContext _dbContext;

        public Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TarefaModel>> BuscarTarefas()
        {
            throw new NotImplementedException();
        }

        public Task<List<TarefaModel>> BuscarTodostarefas()
        {
            throw new NotImplementedException();
        }
    }

}
