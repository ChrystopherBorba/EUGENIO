using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using eugenio.Models;

namespace eugenio.Controllers
{
    public class HomeController : Controller
    {
        //GET: Produto
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult Desconto()
        {
            return View();

        }
        public ActionResult GeranoDesconto()
        {
            return View();
        }
        public ActionResult Produtos()
        {
            ProdutoModel model = new ProdutoModel();
            Produto produto = new Produto();
            List<Produto> lista = model.Consultarproduto("9781305399099");
            return View(lista);
        
        }
        public ActionResult Produtos2()
        {
            return View();
        }
        public ActionResult Leitor()
        {
           return View();
           
        }
        public ActionResult teste()
        {
            return View();

        }



    }
}