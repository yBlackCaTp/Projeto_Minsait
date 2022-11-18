using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        
        public string? Nome { get; set; }

        public string? Email { get; set; }


        [ForeignKey("usuarioID")]
        public TarefaModel? tarefa { get; set; }
    }

}
