using ListagemNomes.Controller;
using ListagemNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace InterfaceCadastros
{
    class AddNomes
    {
        static CadastroController controllerDB = new CadastroController();
        static void Main(string[] args)
        {
            ListarNomes();
            Console.ReadKey();
        }
        public static void AdicionarNomes()
        {
            Console.WriteLine("Insira o nome que deseja cadastrar:");
            var nomeAdd = Console.ReadLine();

            controllerDB
               .AdicionarNomes(new Cadastro()
               {
                   Nome = nomeAdd
               });

            Console.WriteLine($"{nomeAdd} está cadastrado!");
        }
        public static void ListarNomes()
        {
            Console.WriteLine("Lista de nomes:");
                controllerDB.GetCadastros().ToList<Cadastro>().ForEach(x => Console.WriteLine($"Nome: {x.Nome}"));
        }
    }
}
