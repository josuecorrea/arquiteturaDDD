using Arquitetura.Dominio.Repositorio.Interfaces;
using Arquitetura.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Infra.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {
        private ArquiteturaContexto _contexto;

        public RepositorioBase()
        {
            _contexto = new ArquiteturaContexto();
        }

        public void Alterar(TEntidade obj)
        {            
            _contexto.Entry(obj).State = EntityState.Modified;
        }

        public void Excluir(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Remove(obj);
        }

        public void Inserir(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Add(obj);
        }

        public IEnumerable<TEntidade> Obter()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public TEntidade Obter(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }
    }
}
