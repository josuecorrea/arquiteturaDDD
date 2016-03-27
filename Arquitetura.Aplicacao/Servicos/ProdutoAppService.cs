using Arquitetura.Aplicacao.Interfaces;
using Arquitetura.Dominio.Aggregates.ProdutoAgg;
using Arquitetura.Dominio.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Aplicacao.Servicos
{
    public class ProdutoAppService: IProdutoAppServico
    {

        private readonly IRepositorioBase<Produto> _repositorioDeProduto;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        public ProdutoAppService(IRepositorioBase<Produto> repositorioDeProduto, IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            _repositorioDeProduto = repositorioDeProduto;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }


        public void GravarProduto(Produto produto)
        {

            _unidadeDeTrabalho.AbrirTransacao();
            _repositorioDeProduto.Inserir(produto);

            _unidadeDeTrabalho.FecharTransacao();
        }
    }
}
