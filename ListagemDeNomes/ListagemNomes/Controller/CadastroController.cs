using ListagemNomes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemNomes.Controller
{
    public class CadastroController
    {
       static CadastroContext contextDB = new CadastroContext();

        /// <summary>
        /// Método que acessa nosso banco de dados juntamente com a tabela e filtros.
        /// </summary>
        /// <returns></returns>
        public IQueryable<Cadastro> GetCadastros()
        {
            return contextDB.ListaDeCadastros;
        }
        public bool AdicionarNomes (Cadastro parametroCadastro)
        {
            if (string
                .IsNullOrWhiteSpace
                (parametroCadastro.Nome))
                return false;
            contextDB.ListaDeCadastros.Add(parametroCadastro);
            contextDB.SaveChanges();

            return true;
        }
    }
}
