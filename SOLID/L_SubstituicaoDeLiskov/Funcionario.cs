namespace SOLID.L_SubstituicaoDeLiskov
{
    public abstract class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        protected const double salarioMinimo = 1.200;

        public abstract double CalcularSalario();
    }
}
