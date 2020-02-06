using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senai.CodeTur.Infra.Data.Repositorios
{
    public class UsuarioRepositorio : IUsuarios
    {
        private CodeTurContext _context;

        public UsuarioRepositorio(CodeTurContext context)
        {
            _context = context;
        }

        public UsuarioDominio EfetuarLogin(string email, string senha)
        {
            try
            {
                //Busca um usuário a partir do seu e-mail e senha
                return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        UsuarioDominio IUsuarios.EfetuarLogin(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
