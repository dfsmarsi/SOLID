namespace SOLID.L_SubstituicaoDeLiskov
{
    class Programador : Funcionario
    {
        public override double CalcularSalario()
        {
            return salarioMinimo * 3;
        }
    }
}
