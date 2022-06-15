using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoReferenciasComerciais.Pages
{
    public class PesquisarReferenciaModel : PageModel
    {
        private readonly ILogger<PesquisarReferenciaModel> _logger;

        public PesquisarReferenciaModel(ILogger<PesquisarReferenciaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}