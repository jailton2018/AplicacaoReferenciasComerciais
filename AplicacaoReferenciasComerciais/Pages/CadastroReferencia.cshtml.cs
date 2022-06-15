using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoReferenciasComerciais.Pages
{
    public class CadastroReferenciaModel : PageModel
    {
        private readonly ILogger<CadastroReferenciaModel> _logger;

        public CadastroReferenciaModel(ILogger<CadastroReferenciaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}