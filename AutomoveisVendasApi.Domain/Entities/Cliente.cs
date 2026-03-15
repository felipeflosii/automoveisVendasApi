namespace Projeto.Domain.Entities
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public List<Venda> Vendas { get; set; } = new();

        public static Cliente Cadastrar(string nome, string email, string telefone)
        {
            return new Cliente
            {
                ClienteId = Guid.NewGuid(),
                Nome = nome,
                Email = email,
                Telefone = telefone
            };
        }
    }
}