using MySql.Data.MySqlClient;
using ProjetoLoja2dsa.Models;

namespace ProjetoLoja2dsa.Repositorio
{
    public class UsuarioRepositorio(IConfiguration configuration)
    {
        // Declara um campo privado somente leitura para armazenar a string de conexão com o MySQL.
        private readonly string _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");

        public Usuario ObterUsuario(string email)
        {

        }
    }
}
