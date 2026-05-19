using System;
using System.Collections.Generic;

namespace PrototipoMessier.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tema { get; set; }
        public string FaixaEtaria { get; set; }
        public bool Ativo { get; set; }
        public string ImagemCaminho { get; set; } // Novo: Caminho para imagem do jogo

        public override string ToString() => Nome;
    }

    public class Pacote
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Game> Games { get; set; } = new List<Game>();
        public int LimiteAcessosMensal { get; set; }
        public decimal PrecoMensal { get; set; }

        public override string ToString() => Nome;
    }

    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; } // Para o login da escola
        public Pacote PacoteAdquirido { get; set; }
        public List<string> IPsAutorizados { get; set; } = new List<string>();
        public int ConsumoAtual { get; set; }

        public override string ToString() => Nome;
    }

    public class LogAcesso
    {
        public DateTime DataHora { get; set; }
        public string EscolaNome { get; set; }
        public string GameNome { get; set; }
        public string IP { get; set; }
        public bool Permitido { get; set; }
        public string MotivoBloqueio { get; set; }
    }
}
