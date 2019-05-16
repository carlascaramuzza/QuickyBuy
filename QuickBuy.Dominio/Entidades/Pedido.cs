using System;
using System.Collections.Generic


namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string Estado { get; set; }
        public string NumeroEndereco { get; set; }

        public ICollection<ItemPedido>ItensPedido { get; set; }           


    }
}
