using System;
using System.Collections.Generic;
using PrototipoMessier.Models;

namespace PrototipoMessier.Services
{
    public static class DataService
    {
        public static List<Game> Games { get; set; } = new List<Game>();
        public static List<Pacote> Pacotes { get; set; } = new List<Pacote>();
        public static List<Escola> Escolas { get; set; } = new List<Escola>();
        public static List<LogAcesso> Logs { get; set; } = new List<LogAcesso>();

        static DataService()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            // Jogos Padrão
            var g1 = new Game { Id = 1, Nome = "Matemática Divertida", Descricao = "Aprenda somar brincando", Tema = "Matemática", FaixaEtaria = "7-10", Ativo = true, ImagemCaminho = "jogo_matematica.png" };
            var g2 = new Game { Id = 2, Nome = "Gramática Master", Descricao = "Domine o português", Tema = "Português", FaixaEtaria = "10-14", Ativo = true, ImagemCaminho = "jogo_gramatica.png" };

            Games.AddRange(new[] { g1, g2 });

            // Pacote Padrão
            var p1 = new Pacote { Id = 1, Nome = "Pacote Acadêmico", LimiteAcessosMensal = 100, PrecoMensal = 150.00m };
            p1.Games.AddRange(new[] { g1, g2 });

            Pacotes.Add(p1);

            // Nenhuma escola pré-cadastrada conforme solicitado.
            // A validação agora é dinâmica no FormLoginEscola.
        }
    }
}
