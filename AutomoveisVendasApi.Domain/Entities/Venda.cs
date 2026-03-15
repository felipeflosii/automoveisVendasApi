namespace Projeto.Domain.Entities
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public Guid? CarroId { get; set; }
        public Carro? Carro { get; set; }
        public Guid? MotoId { get; set; }
        public Moto? Moto { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; } = "Pendente";
        public List<Pagamento> Pagamentos { get; set; } = new();

        public static Venda CriarVendaClienteCarro(Cliente cliente, Carro carro)
        {
            carro.Vendido = true;
            var venda = new Venda
            {
                VendaId = Guid.NewGuid(),
                ClienteId = cliente.ClienteId,
                Cliente = cliente,
                CarroId = carro.CarroId,
                Carro = carro,
                DataVenda = DateTime.Now,
                ValorTotal = carro.Valor,
                Status = "Pendente"
            };
            cliente.Vendas.Add(venda);
            carro.Vendas.Add(venda);
            return venda;
        }

        public static Venda CriarVendaClienteMoto(Cliente cliente, Moto moto)
        {
            moto.Vendida = true;
            var venda = new Venda
            {
                VendaId = Guid.NewGuid(),
                ClienteId = cliente.ClienteId,
                Cliente = cliente,
                MotoId = moto.MotoId,
                Moto = moto,
                DataVenda = DateTime.Now,
                ValorTotal = moto.Valor,
                Status = "Pendente"
            };
            cliente.Vendas.Add(venda);
            moto.Vendas.Add(venda);
            return venda;
        }
    }
}