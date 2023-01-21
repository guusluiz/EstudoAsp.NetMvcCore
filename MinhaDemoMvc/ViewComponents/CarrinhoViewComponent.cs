using Microsoft.AspNetCore.Mvc;

namespace MinhaDemoMVC.ViewComponents
{
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }
        public IViewComponentResult Invoke()
        {
            return View(ItensCarrinho);
        }
    }
}
