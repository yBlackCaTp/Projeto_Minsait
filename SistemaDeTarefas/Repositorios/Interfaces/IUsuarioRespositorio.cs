﻿using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRespositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> Adicionar (UsuarioModel usuario);

        Task<UsuarioModel> Atualizar (UsuarioModel usuario, int id);

        Task<bool> Apagar (int id);
    }
}
