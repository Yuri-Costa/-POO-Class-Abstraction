using System;
namespace ABS
{
    public class Boleto : Pagamento
    {
        private int codigoDeBarras;
        public float CodigoDeBarras{
          get{return codigoDeBarras;}
        }
        public string mensagem;
        public void Registrar(){
          Random randomico = new Random();
          this.codigoDeBarras = randomico.Next();

        }  

         public override string Cancelar(){
                Console.ForegroundColor = ConsoleColor.Red;
                return "Operação Cancelada!!!";
          }

         public string PagarPorBoleto(){
           return "";
         }
          public void GerarBoleto(){
            float total1 = this.Valor -(this.Valor * 0.05f);
         
            Console.WriteLine( $"O valor do Boleto -- R${this.Valor}");
            Console.WriteLine( $"Data -- {this.Data}");
            Console.WriteLine( $"Data de Vencimento -- {this.Data.AddDays(12)}");
            Console.WriteLine( $"Código do Boleto -- {this.CodigoDeBarras}");
          }


  }
}