namespace Projeto.Domain.Entities
{
    public class Carro
    {
        public Guid CarroId { get; set; }
        public string Modelo { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public int Ano { get; set; }
        public decimal Valor { get; set; }
        public string Placa { get; set; } = string.Empty;
        public bool Vendido { get; set; } = false;
        public List<Venda> Vendas { get; set; } = new();

        public static List<Carro> CarrosDisponiveis { get; } = new List<Carro>
        {
            new Carro
            {
                CarroId = Guid.NewGuid(),
                Modelo = "Civic",
                Marca = "Honda",
                Ano = 2022,
                Valor = 95000,
                Placa = "ABC-1234"
            },
            new Carro
            {
                CarroId = Guid.NewGuid(),
                Modelo = "Corolla",
                Marca = "Toyota",
                Ano = 2023,
                Valor = 110000,
                Placa = "XYZ-5678"
            }
        };
    }
}