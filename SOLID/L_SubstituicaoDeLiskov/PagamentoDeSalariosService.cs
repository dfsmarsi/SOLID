using System;
using System.Collections.Generic;

namespace SOLID.L_SubstituicaoDeLiskov
{
    public class PagamentoDeSalariosService
    {
        public void RealizarPagamentosDeSalario(List<Funcionario> listaDeFuncionarios)
        {
            foreach (var item in listaDeFuncionarios)
            {
                double valor = item.CalcularSalario();
                RealizarTransacaoBancaria(valor);
            }
        }

        private void RealizarTransacaoBancaria(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
