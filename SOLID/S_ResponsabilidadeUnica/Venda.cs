using System.Collections.Generic;

namespace SOLID.S_ResponsabilidadeUnica
{
    public class Venda
    {
        public string Vendedor;
        public string Cliente;
        public List<string> Produtos;
        public string ValorTotal;
        private ValidacaoDeVenda ValidarVenda = new ValidacaoDeVenda();
        private GravacaoDeVenda GravarVenda = new GravacaoDeVenda();
        private ImpressaoDeVenda ImprimirVenda = new ImpressaoDeVenda();

        public void RealizarVenda()
        {
            ValidarVenda.ValidarVenda();
            GravarVenda.GravarVenda();
            ImprimirVenda.ImprimirVenda();
        }
    }
}
