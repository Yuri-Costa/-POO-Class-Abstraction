using System;
namespace ABS
{
      public abstract class Pagamento
    {
       private DateTime data;
       protected float valor;

       public abstract string Cancelar();
    }
}
