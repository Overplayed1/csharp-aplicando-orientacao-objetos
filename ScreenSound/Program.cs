Musica musica1 = new Musica();

musica1.Nome = "Freak on a Leash";
musica1.Artista = "KoRn";
musica1.Duracao = 280;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
//musica1.ExibirNomeEArtista();
//musica2.ExibirNomeEArtista();