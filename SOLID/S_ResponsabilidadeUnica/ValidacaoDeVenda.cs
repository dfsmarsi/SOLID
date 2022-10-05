using System;

namespace SOLID.S_ResponsabilidadeUnica
{
    public class ValidacaoDeVenda
    {
        public bool ValidarVenda()
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
