using System;
namespace ABS
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "40028922";

        public void Registrar(){

        }  

         public override string Cancelar(){
                Console.ForegroundColor = ConsoleColor.Red;
                return "Operação Cancelada!!!";
          }


  }
}