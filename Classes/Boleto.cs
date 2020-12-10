using System;
namespace ABS
{
    public class Boleto : Pagamento
    {
        private int codigoDeBarras = 40028922;
        public int CodigoDeBarras{
          get{return codigoDeBarras;}
        }
        public string mensagem;
        public void Registrar(){

        }  

         public override string Cancelar(){
                Console.ForegroundColor = ConsoleColor.Red;
                return "Operação Cancelada!!!";
          }

         public string PagarPorBoleto(){
           return "";
         }


  }
}