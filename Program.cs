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
        musicas[240].ExibirFichaTecnica();
        LinqFilter.ExibirTodasMusicasTonalidadeCSharp(musicas);
        //Console.WriteLine("\nMostrando todos os gêneros musicais:");
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //MusicasPreferidas musicasPreferidasGlauber = new MusicasPreferidas("Glauber");
        //musicasPreferidasGlauber.AdicionarMusicasFavoritas(musicas[0]);
        //musicasPreferidasGlauber.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidasGlauber.AdicionarMusicasFavoritas(musicas[45]);
        //musicasPreferidasGlauber.AdicionarMusicasFavoritas(musicas[67]);
        //musicasPreferidasGlauber.AdicionarMusicasFavoritas(musicas[90]);
        //musicasPreferidasGlauber.ExibirMusicaFavoritas();

        //MusicasPreferidas musicasPreferidasJeep = new MusicasPreferidas("Jeep");
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[32]);
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[55]);
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[675]);
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[777]);
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[899]);
        //musicasPreferidasJeep.AdicionarMusicasFavoritas(musicas[1345]);
        //musicasPreferidasJeep.ExibirMusicaFavoritas();

        //musicasPreferidasJeep.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos uma exceção: {ex.Message}");
    }
}