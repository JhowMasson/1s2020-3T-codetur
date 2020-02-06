using Senai.CodeTur.Dominio.Entidades;

namespace Senai.CodeTur.Dominio.Interfaces.Repositorios
{
    public interface IUsuarios
    {
        UsuarioDominio EfetuarLogin(string email, string senha);
    }
}
