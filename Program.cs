using ScreenSoundApi.Modelo;
using System.Text.Json;
using ScreenSoundApi.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        Console.WriteLine("Iniciando requisição...");
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine("Resposta recebida");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Console.WriteLine($"Quantidade de músicas: {musicas.Count}");
        //Console.WriteLine("\nMostrando dados da música posição 240 na lista:");
        //musicas[240].ExibirFichaTecnica();
        //Console.WriteLine("\nMostrando todos os gêneros musicais:");
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos uma exceção: {ex.Message}");
    }
}