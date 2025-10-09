// importa as bibliotecas que serao utilzaads no projeto
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja2dsa.Models;
using ProjetoLoja2dsa.Repositorio;
using ProjetoLoja2dsa.Models;

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

        //INTERFACE É UMA REPRESENTAÇAO DO RESULTADO (TELA)
       // [HttpGet]
        public IActionResult Login()
        {
            //RETORNA A PAGINA INDEX
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);

            if (usuario != null && usuario.Senha == senha)
            {
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "Email / senha Inválidos");


            //RETORNA A PAGINA LOGIN
            return View();
        }

        //CADASTRO DO USUARIO 
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (ModelState.IsValid) 
            {
                _usuarioRepositorio.AdicionarUsuario(usuario);
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
    }
}
