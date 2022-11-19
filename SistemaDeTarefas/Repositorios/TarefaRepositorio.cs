using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly SistemaDeTarefasDBContext _dbContext;

        public TarefaRepositorio(SistemaDeTarefasDBContext sistemaDeTarefasDBContext)
        {
            _dbContext = sistemaDeTarefasDBContext;
        }

        public async Task<TarefaModel> Adicionar(TarefaModel tarefa)
        {
            _dbContext.Tarefas.Update(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<bool> Apagar(int id)
        {
            TarefaModel tarefa = await BuscarPorId(id);

            if (tarefa == null)
            {
                throw new Exception($"Id do Usuario: {tarefa} não localizado");

            }

            _dbContext.Tarefas.Remove(tarefa);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<TarefaModel> Atualizar(TarefaModel tarefa, int id)
        {
            TarefaModel tarefaModel  = await BuscarPorId(id);

            if (tarefa == null)
            {   
                throw new Exception($"Id do tarefa: {tarefa} não localizado");

            }

            tarefa.Nome = tarefa.Nome;
           

            _dbContext.Tarefas.Update(tarefa);
            await _dbContext.SaveChangesAsync();

            return tarefa;
        }

        public async Task<TarefaModel> BuscarPorId(int id)
        {
            return await _dbContext.Tarefas.Include(x => x.Id).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TarefaModel>> BuscarTodostarefas()
        {
            return await _dbContext.Tarefas.ToListAsync();
        }
    }    
}      
