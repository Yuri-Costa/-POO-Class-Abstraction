using System;
namespace ABS
{
    public abstract class Cartao : Pagamento 
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        protected int senha = 4444;
        

        public string SalvarCartao(){
            return "cartão salvo";
        }
          public override string Cancelar(){
                return "";
          }
 

    }
}