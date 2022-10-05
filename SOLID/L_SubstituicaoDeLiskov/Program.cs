using System.Collections.Generic;

namespace SOLID.L_SubstituicaoDeLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Joao = new Gerente();
            Funcionario Luiz = new Programador();

            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
            listaDeFuncionarios.Add(Joao);
            listaDeFuncionarios.Add(Luiz);

            PagamentoDeSalariosService pagamentoDeSalariosService = new PagamentoDeSalariosService();
            pagamentoDeSalariosService.RealizarPagamentosDeSalario(listaDeFuncionarios);
        }

    }
}
