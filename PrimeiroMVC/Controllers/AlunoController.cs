using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Emanuelly Lima", "emanuelly.v.lima@aluno.senai.br", 380400);
            Aluno a2 = new Aluno(2, "Rayssa Silveira", "rayssa.silveira@aluno.senai.br", 123401);
            Aluno a3 = new Aluno(3, "Ítalo Francesco", "italo.francesco@aluno.senai.br", 567802);
            Aluno a4 = new Aluno(4, "Bruno Alves", "bruno.alves@aluno.senai.br", 910102);
            Aluno a5 = new Aluno(5, "Cristiano de Paula", "cristiano.paula@docnte.senai.br", 112103);

            //Criar uma lista de alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os Objetos Alunos na lista alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            //Enviando a lista de alunos por parâmetro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
