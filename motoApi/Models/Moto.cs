namespace motoApi.Models
{
    public class Moto
    {
        public int Id { get; set; } // Chave primaria
        public string Nome { get; set; } // Nome da moto
        public string Marca { get; set; } // Marca da moto
        public string Cilindrada { get; set; } // Cilindrada da moto
        public int Ano { get; set; } // Ano de fabricação
        public int Valor { get; set; }
    }
}
