using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string nome, string cpf)
        {
            // Aqui você pode processar os dados do formulário conforme necessário
            _logger.LogInformation($"Nome: {nome}, CPF: {cpf}");

            // Redireciona de volta para a página Index após o envio do formulário
            return RedirectToPage("./Index");
        }
    }
}
