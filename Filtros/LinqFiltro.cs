using System.Linq;
using TreinoLinq.Modelos;

namespace TreinoLinq.Filtros
{
    internal class LinqFiltro
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica>musicas)
        {
            var TodosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in TodosOsGenerosMusicais)
            {
                System.Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo Os Artistas do Genero Musical -> {genero}");
            foreach (var artista in artistasPorGeneroMusical)
            {
                System.Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDoArtista(List<Musica>musicas, string nomeArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
            System.Console.WriteLine(nomeArtista);
            foreach (var musica in musicasDoArtista)
            {
                System.Console.WriteLine($"- {musica.Nome}");
            }
        }

        internal static void FiltrarMusicasEmCSharp(List<Musica>musicas)
        {
            var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
            Console.WriteLine("Músicas em C#: ");
            foreach ( var musica in musicasEmCSharp)
            {
                Console.WriteLine($"- {musica}");
            }
        }
    }
}