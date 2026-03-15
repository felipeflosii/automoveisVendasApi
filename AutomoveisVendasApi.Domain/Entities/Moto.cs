namespace Projeto.Domain.Entities
{
    public class Moto
    {
        public Guid MotoId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public bool Vendida { get; set; } = false;
        public List<Venda> Vendas { get; set; } = new();

        public static List<Moto> MotosDisponiveis { get; } = new List<Moto>
        {
            new Moto
            {
                MotoId = Guid.NewGuid(),
                Modelo = "Ninja 400",
                Marca = "Kawasaki",
                Ano = 2022,
                Valor = 35000
            },
            new Moto
            {
                MotoId = Guid.NewGuid(),
                Modelo = "CB 500F",
                Marca = "Honda",
                Ano = 2023,
                Valor = 30000
            }
        };
    }
}