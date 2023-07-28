using MarketplaceCompleto.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarketplaceCompleto.App.Extensions
{
    public class SumaryViewComponent : ViewComponent
    {
        private readonly INotificador _notificador;

        public SumaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());

            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Mensagem));

            return View();
        }
    }
}
