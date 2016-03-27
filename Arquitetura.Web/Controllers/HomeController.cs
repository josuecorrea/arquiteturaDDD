using Arquitetura.Aplicacao.Interfaces;
using Arquitetura.Dominio.Aggregates.ProdutoAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arquitetura.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoAppServico _produtoServico;

        public HomeController(IProdutoAppServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        public ActionResult Index()
        {
            _produtoServico.GravarProduto(new Produto { Nome = "Vick", Preco = 10});

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}