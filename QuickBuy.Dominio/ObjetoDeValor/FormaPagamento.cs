using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Enumerados;


namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao  { get; set; }
        public Boolean EhBoleto => Id = TipoFormaPagamentoEnum.Boleto;

    }
}
