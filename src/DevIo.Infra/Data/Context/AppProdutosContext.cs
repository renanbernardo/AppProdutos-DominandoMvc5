using DevIo.Business.Models.Fornecedores;
using DevIo.Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIo.Infra.Data.Context
{
    public class AppProdutosContext : DbContext
    {
        public AppProdutosContext() : base("DefaultConnection")
        { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
