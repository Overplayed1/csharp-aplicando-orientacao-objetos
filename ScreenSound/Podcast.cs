class Podcast
{
    private List<Episodios> episodios = new List<Episodios>();
    public String Nome { get; }
    public String Host { get; }
    public int TotalEpisodios => episodios.Count;
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodios episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome}, apresentado por: {Host}\n");
        foreach(Episodios episodio in episodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine($"{episodio.ResumoEpisodio}");
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }


}
