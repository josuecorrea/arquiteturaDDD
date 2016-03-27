using Arquitetura.Dominio.Repositorio.Interfaces;
using Arquitetura.Infra.Contexto;

namespace Arquitetura.Infra.Repositorios
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private ArquiteturaContexto _context;

        public void AbrirTransacao()
        {
            _context = new ArquiteturaContexto();
        }

        public void FecharTransacao()
        {
            _context.SaveChanges();
        }
    }
}