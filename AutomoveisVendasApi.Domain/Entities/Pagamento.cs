namespace Projeto.Domain.Entities
{
    public class Pagamento
    {
        public Guid PagamentoId { get; set; }
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public static Pagamento CriarPagamento(Venda venda, string tipo, decimal valor)
        {
            var pagamento = new Pagamento
            {
                PagamentoId = Guid.NewGuid(),
                VendaId = venda.VendaId,
                Venda = venda,
                Tipo = tipo,
                Valor = valor,
                DataPagamento = DateTime.Now
            };
            venda.Pagamentos.Add(pagamento);
            if (venda.ValorTotal <= venda.Pagamentos.Sum(p => p.Valor))
                venda.Status = "Finalizada";
            return pagamento;
        }
    }
}