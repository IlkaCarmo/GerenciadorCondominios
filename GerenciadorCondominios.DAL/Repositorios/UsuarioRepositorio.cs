using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto _contexto;
        private readonly UserManager<Usuario> _gerenciadorUsuarios;
        private readonly SignInManager<Usuario> _gerenciadorLogin;
        public UsuarioRepositorio (Contexto contexto) : base(contexto)
        { 
        }

        public Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            throw new NotImplementedException();
        }

        public Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao)
        {
            throw new NotImplementedException();
        }

        public Task LogarUsuario(Usuario usuario, bool lembrar)
        {
            throw new NotImplementedException();
        }

        public int VerificarSeExisteRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
