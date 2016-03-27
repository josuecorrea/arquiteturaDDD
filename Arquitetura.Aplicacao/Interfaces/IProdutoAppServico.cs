using Arquitetura.Dominio.Aggregates.ProdutoAgg;

namespace Arquitetura.Aplicacao.Interfaces
{
    public interface IProdutoAppServico
    {
        void GravarProduto(Produto produto);
    }
}