using Arquitetura.Aplicacao.Interfaces;
using Arquitetura.Aplicacao.Servicos;
using Arquitetura.Dominio.Repositorio.Interfaces;
using Arquitetura.Infra.Repositorios;
using Ninject.Modules;

namespace Arquitetura.Ioc
{
    public class ArquiteturaModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProdutoAppServico>().To<ProdutoAppService>();
            Bind<IUnidadeDeTrabalho>().To<UnidadeDeTrabalho>();


            Bind(typeof(IRepositorioBase<>)).To(typeof(RepositorioBase<>));
        }
    }
}