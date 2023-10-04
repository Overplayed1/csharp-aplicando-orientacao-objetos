class Episodios
{
    public int Numero { get; }
    public string Titulo { get; }
    public int Duracao { get;  }
    private List<string> convidados = new List<string>();
    public string ResumoEpisodio =>
        $"Número do episódio: {Numero}\nTítulo do episódio: {Titulo}\nDuração do episódio: {Duracao} min\nConvidado(s): {string.Join(", ", convidados)}\n";


    public Episodios(int numero, string titulo, int duracao)
    {
        Numero = numero;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}
