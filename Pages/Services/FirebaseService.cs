using Firebase.Database;
using System;
using System.Threading.Tasks;

public class FirebaseService
{
    private readonly string _firebaseBaseUrl;

    public FirebaseService(string firebaseBaseUrl)
    {
        _firebaseBaseUrl = firebaseBaseUrl;
    }

    public async Task SalvarUsuario(string nome, string cpf)
    {
        try
        {
            // Estabelece a conexão com o Firebase Realtime Database
            var firebase = new FirebaseClient(_firebaseBaseUrl);

            // Define o caminho para onde os dados serão salvos no Firebase
            var path = "usuarios";

            // Adiciona os dados do usuário ao Firebase
            await firebase.Child(path).PostAsync(new Usuario { Nome = nome, CPF = cpf });

            Console.WriteLine("Dados salvos com sucesso no Firebase!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar os dados no Firebase: {ex.Message}");
        }
    }
}

public class Usuario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
}
