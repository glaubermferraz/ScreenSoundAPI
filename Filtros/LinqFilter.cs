using ScreenSoundApi.Modelo;
namespace ScreenSoundApi.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => 
                musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
            foreach(var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }
        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            Console.WriteLine($"Música do Artista >>> {nomeDoArtista}");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
        public static void ExibirTodasMusicasTonalidadeCSharp(List<Musica> musicas)
        {
            var musicasTonalidadeCSharp = musicas
                .Where(musica => musica.Tonalidade!.Equals("C#"))
                .GroupBy(musica => new { musica.Artista, musica.Nome })
                .Select(g => g.First()) // Remove repetidos
                .OrderBy(musica => musica.Artista)
                .ThenBy(musica => musica.Nome) // Ordena por música após ordenar por artista
                .ToList();

            Console.WriteLine("Músicas com a Tonalidade C#:");
            foreach (var musica in musicasTonalidadeCSharp)
            {
                Console.WriteLine($"- {musica.Artista} - {musica.Nome}");
            }
        }
    }
}
