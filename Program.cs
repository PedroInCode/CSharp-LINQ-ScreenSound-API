using System.Text.Json;
using TreinoLinq.Treino;
using TreinoLinq.Modelos;
using TreinoLinq.Filtros;

    using (HttpClient client = new HttpClient() )
    {
        try
        {
            string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
            LinqFiltro.FiltrarMusicasEmCSharp(musicas);
            //musicas[0].ExibirDetalhesDaMusica();
            //LinqFiltro.FiltrarTodosOsGenerosMusicais(musicas);
            //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
            //LinqFiltro.FiltrarArtistasPorGeneroMusical(musicas, "rock");
            //LinqFiltro.FiltrarMusicasDoArtista(musicas, "Michel Teló");

            //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
            //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
            //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
            //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
            //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
            //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

            //musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
            //musicasPreferidasDoDaniel.GerarArquivoJson();


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Temos um Problema: {ex.Message}");
        }
    }



