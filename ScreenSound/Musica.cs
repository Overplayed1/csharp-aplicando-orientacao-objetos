class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    //public Genero Genero { get; set; }
   /*Este => é utilizado em métodos que utilizam apenas leitura.*/ public string DescricaoResumida => 
        $"A música {Nome} pertence a banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus");
        }
        Console.WriteLine("\n");
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}