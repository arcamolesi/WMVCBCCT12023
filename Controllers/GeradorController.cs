using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WMVCBCCT12023.Models;

namespace WMVCBCCT12023.Controllers
{
    public class GeradorController : Controller
    {
        private readonly Contexto contexto;

        public GeradorController (Contexto context)
        {
            contexto = context;

        }




        public IActionResult Cursos () {

            contexto.Database.ExecuteSqlRaw("delete from cursos");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('cursos', RESEED, 0)");
            Random randNum = new Random();

              for (int i = 0; i < 10; i++)
            {
                Curso curso = new Curso();
               //
                curso.descricao = "Curso " + (i+1).ToString(); 

                contexto.Cursos.Add(curso);
            }
            contexto.SaveChanges();

            return View(contexto.Cursos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Salas()
        {

            contexto.Database.ExecuteSqlRaw("delete from sala");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('sala', RESEED, 0)");
            Random randNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                Sala sala = new Sala();
                //
                sala.descricao = "Sala " + (i + 1).ToString();
                sala.quantidade = randNum.Next(1, 20);
                int sit = randNum.Next(0, 3);
                sala.situacao = (Situacao) sit; 
                contexto.Salas.Add(sala);
            }
            contexto.SaveChanges();

            return View(contexto.Salas.OrderBy(o => o.id).ToList());
        }


        public IActionResult Alunos()
        {
            contexto.Database.ExecuteSqlRaw("delete from alunos");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('alunos', RESEED, 0)");
            Random randNum = new Random();

            string[] vDominio = { "UOL", "Globo", "FEMA", "FEMANET", "GMAIL", "yahoo" };
            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };

            for (int i = 0; i < 100; i++)
            {

                Aluno aluno = new Aluno();

                aluno.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                aluno.email = aluno.nome.ToLower() + "@" + vDominio[randNum.Next() % 6].ToLower() + ".com.br";
                aluno.cursoID = randNum.Next(1, 20);
                aluno.aniversario = Convert.ToDateTime("01/01/1960").AddDays(randNum.Next(0, 13000));
                aluno.periodo = randNum.Next(0, 3);

                contexto.Alunos.Add(aluno);
            }
            contexto.SaveChanges();

            return View(contexto.Alunos.OrderBy(o => o.id).ToList());
        }

        public IActionResult Atendimentos()
        {

            contexto.Database.ExecuteSqlRaw("delete from atendimentos");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('atendimentos', RESEED, 0)");
            Random randNum = new Random();

            for (int i = 0; i < 5000; i++)
            {
                Atendimento atendimento= new Atendimento();
                atendimento.alunoID = randNum.Next(1, 100);
                atendimento.salaID = randNum.Next(1, 20); 
                atendimento.data = Convert.ToDateTime("01/01/2010").AddDays(randNum.Next(0, 5036));
                int ano = 1950 + randNum.Next(1, 60);
                int mes= randNum.Next(1, 12);
                int dia = randNum.Next(1, 30);
                int hora = randNum.Next(1, 23);
                int minuto = randNum.Next(1, 59);
                atendimento.hora = new DateTime ();  

                contexto.Atendimentos.Add(atendimento);
            }
            contexto.SaveChanges();

            return View(contexto.Salas.OrderBy(o => o.id).ToList());
        }


    }
}
