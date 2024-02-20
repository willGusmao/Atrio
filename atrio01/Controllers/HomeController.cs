using atrio01.Data;
using atrio01.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Security.Claims;

namespace atrio01.Controllers
{
    public class HomeController : Controller
    {

        readonly private ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        { 
            _db = db;
        }




        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VwPaciente(int? id)
        {
            
            

            if(id== null || id==0) 
            {
            
                return NotFound();

            }

            PacientesModel pacientes = _db.Pacientes.FirstOrDefault(x => x.Id_Paciente == id);

            if (pacientes == null)
            {
                return RedirectToAction("ListaP");
            }


            return View(pacientes);
        }

        [HttpPost]
        public IActionResult VwPaciente(int id, PacientesModel pacientes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Atualiza os dados do paciente
                    var existingPatient = _db.Pacientes.FirstOrDefault(x => x.Id_Paciente == id);
                    if (existingPatient != null)
                    {
                        existingPatient.Nome = pacientes.Nome;
                        existingPatient.SobreNome = pacientes.SobreNome;
                        existingPatient.DataNascimento = pacientes.DataNascimento;
                        existingPatient.EstadoCivil = pacientes.EstadoCivil;
                        existingPatient.Genero = pacientes.Genero;
                        existingPatient.CPF = pacientes.CPF;
                        existingPatient.RG = pacientes.RG;

                        existingPatient.Cidade = pacientes.Cidade;
                        existingPatient.Estado = pacientes.Estado;
                        existingPatient.Endereco = pacientes.Endereco;
                        existingPatient.Celular = pacientes.Celular;
                        existingPatient.Email = pacientes.Email;    
                        existingPatient.Observacao = pacientes.Observacao;


                        // Continue para os outros campos...

                        // Salva as alterações no banco de dados
                        _db.SaveChanges();

                       
                        return RedirectToAction("VwPaciente");
                       

                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception ex)
                {
                    // Registre a exceção para ajudar na depuração
                    Console.WriteLine($"Erro ao salvar os dados: {ex.Message}");
                    throw;
                }
            }

            // Se a ModelState não for válida, retorne a View com os dados do paciente
            return View(pacientes);
        }


        [HttpPost]
        public IActionResult Excluir(int id)
        {
            PacientesModel paciente = _db.Pacientes.FirstOrDefault(x => x.Id_Paciente == id);

            if (paciente == null)
            {
                return NotFound();
            }

            _db.Pacientes.Remove(paciente);
            _db.SaveChanges();

            return RedirectToAction("ListaP");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Conta()
        {
            return View();
        }

        public IActionResult Notificacao()
        {
            return View();
        }

        
        public IActionResult CadastroP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroP(PacientesModel pacientes)
        {
            
            if(ModelState.IsValid)
            {

                _db.Pacientes.Add(pacientes);
                _db.SaveChanges();

                return RedirectToAction("listaP");


            }

            return View();

        }



        public IActionResult ListaP()
        {
            IEnumerable<PacientesModel> pacientes = _db.Pacientes;
            return View(pacientes);
        }

        public IActionResult Login()
        {
            return View();
        }
        
        

        // Consulta o usuario no banco de dados 
        [HttpPost]
        public IActionResult Logar(string inpEmail, string inpSenha)
        {
            // Verificar se as credenciais correspondem ao usuário admin e senha admin
            if (inpEmail == "admin@admin.com" && inpSenha == "admin")
            {
                // Credenciais corretas, você pode redirecionar para a página desejada
                // Por exemplo, redirecionar para a página inicial
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Credenciais incorretas, você pode adicionar uma mensagem de erro
                ModelState.AddModelError("", "Credenciais inválidas. Tente novamente.");
                return View(); // ou você pode redirecionar para a mesma página de login
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
