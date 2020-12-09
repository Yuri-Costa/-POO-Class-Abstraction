namespace ABS
{
    public class Credito : Cartao
    {
        private float limite = 3000;
        private int senha = 4444;
        public string pagamento;
        public int Senha{
            get{return senha;}
        }
      

        public string Pagar(){
            return "insira sua senha para o pagamento!";
        }

           
    }
}