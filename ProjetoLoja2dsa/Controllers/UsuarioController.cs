// importa as bibliotecas que serao utilzaads no projeto
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja2dsa.Repositorio;

// define o nome e onde a classe esta usuarioController esta utilizada
// namespace ajuda a organizar o codigo e evitar conflitos
namespace ProjetoLoja2dsa.Controllers
{
    // classe usuariocontroller que esta herdando da classe pai controller 
    public class UsuarioController : Controller
    {
        // declara a variavel prvada e somente leitura do tipo usuariorepositorio que 
        //instancia o _usuarioController para ser atribuido no construtor e interagir com os dados
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //define o construtor da classe UsuarioController 
        // recebe a instancia de usuariorepositorio com parametros
        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            // o construtor é chamado quando uma nova instancia é criada
            _usuarioRepositorio = usuarioRepositorio;
        }

        //interface que representa o resultado da pagina 
        public IActionResult Index()
        {
            return View();
        }
    }
}
