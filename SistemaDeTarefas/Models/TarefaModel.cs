using SistemaDeTarefas.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public StatusTarefa Status { get; set; }

        //public virtual List<UsuarioModel> Usuarios { get; set; }

        
    }
}
