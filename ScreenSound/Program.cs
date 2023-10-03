Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Banda queen = new Banda();
queen.Nome = "Queen";

Musica musica1 = new Musica(queen);
musica1.Nome = "Love Of My Life";
musica1.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);


queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();


/*Genero generoDoAlbumQueen = new Genero();
generoDoAlbumQueen.Nome = "PopRock";

generoDoAlbumQueen.AdicionarGenero(albumDoQueen);

generoDoAlbumQueen.ExibirGeneroAlbum();*/