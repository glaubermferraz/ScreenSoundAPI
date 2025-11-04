using ScreenSoundApi.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        Console.WriteLine("Iniciando requisição...");
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine("Resposta recebida");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine($"Quantidade de músicas: {musicas.Count}\n");
        musicas[240].ExibirFichaTecnica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos uma exceção: {ex.Message}");
    }
}