using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemNomes.Model
{
     class CadastroContext : DbContext
     {
        public DbSet<Cadastro> ListaDeCadastros { get; set; }
     }
}
