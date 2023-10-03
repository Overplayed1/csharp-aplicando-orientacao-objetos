Album albumDoQueen = new Album("A night at the opera");

Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Love Of My Life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();


/*Genero generoDoAlbumQueen = new Genero();
generoDoAlbumQueen.Nome = "PopRock";

generoDoAlbumQueen.AdicionarGenero(albumDoQueen);

generoDoAlbumQueen.ExibirGeneroAlbum();*/