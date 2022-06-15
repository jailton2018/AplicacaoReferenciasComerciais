using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoReferenciasComerciais.Pages
{
    public class EditarReferenciaModel : PageModel
    {
        private readonly ILogger<EditarReferenciaModel> _logger;

        public EditarReferenciaModel(ILogger<EditarReferenciaModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}