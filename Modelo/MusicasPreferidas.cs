namespace ScreenSoundApi.Modelo;

internal class MusicasPreferidas
{
    public string? Nome {  get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicaFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas do(a) {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"-> {musica.Artista} - {musica.Nome}");
        }
        Console.WriteLine();
    }
}
