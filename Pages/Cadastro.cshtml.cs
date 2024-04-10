using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

public class CadastroModel : PageModel
{
    private readonly FirebaseService _firebaseService;

    public CadastroModel(FirebaseService firebaseService)
    {
        _firebaseService = firebaseService;
    }

    public void OnGet()
    {
        // Método chamado ao carregar a página de cadastro
    }

    public async Task<IActionResult> OnPostAsync(string nome, string cpf)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Salvando os dados no Firebase
        await _firebaseService.SalvarUsuario(nome, cpf);

        return RedirectToPage("/Index"); // Redireciona para a página inicial após o salvamento
    }
}
