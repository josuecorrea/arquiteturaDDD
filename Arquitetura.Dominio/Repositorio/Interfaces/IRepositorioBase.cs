using System.Collections;
using System.Collections.Generic;

namespace Arquitetura.Dominio.Repositorio.Interfaces
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        void Inserir(TEntidade obj);

        void Alterar(TEntidade obj);

        void Excluir(TEntidade obj);

        TEntidade Obter(int id);

        IEnumerable<TEntidade> Obter();
    }
}