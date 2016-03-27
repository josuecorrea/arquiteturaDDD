using Arquitetura.Dominio.Aggregates.ProdutoAgg;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Infra.Contexto
{
    public class ArquiteturaContexto:DbContext
    {

        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
