namespace SOLID.L_SubstituicaoDeLiskov
{
    public class Gerente : Funcionario
    {
        public override double CalcularSalario()
        {
            return salarioMinimo * 5;
        }
    }
}
