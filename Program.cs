using System;

namespace ABS
{
    class Program
    {
        private static string senha1;

        static void Main(string[] args)
        {
            Boleto B = new Boleto();
            Credito C =  new Credito();
            Debito D = new Debito();
        //-----------------------------------------------------//
            B.mensagem = "insira o codigo para pagar o boleto";
            B.Cancelar();
            B.Registrar();
            B.Data = DateTime.Now;
            C.SalvarCartao();
            C.Pagar();
            C.pagamento = "insira a senha para pagamento!!";
            D.pagamentoD="insira a senha para pagamento!!";
            int senha1 = C.Senha;
            int senhaDE = D.SenhaD;
            float codigoRamd = B.CodigoDeBarras;
            
        //------------------------------------------------------//

                        //------MENU------//
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Bem vindo!!!");
            Console.WriteLine("----------------");
            Console.WriteLine("digite o valor da compra");
            float valor = float.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("----------------");
            Console.WriteLine($"R${valor}");
            Console.WriteLine("escolha a forma de pagamento");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Pagar no Crédito - [1]");
            Console.WriteLine("Pagar no Débito - [2]");
            Console.WriteLine("Pagar com boleto - [3]");
            Console.WriteLine("cancelar - [4]");
            Console.WriteLine("--------------");
            int Opcao = int.Parse(Console.ReadLine());
            switch (Opcao)

           {
               //pagar no credito
            case 1:
             {Console.WriteLine("---------Crédito---------");
             Console.WriteLine("");
             Console.WriteLine("[1] - 1X - Juros de 5%");
             Console.WriteLine("[2] - 2X - Juros de 5%");
             Console.WriteLine("[3] - 3X - Juros de 7%");
             int juros = int.Parse(Console.ReadLine());
             Console.WriteLine(""+C.pagamento);
             int senha = int.Parse(Console.ReadLine());
             Console.ForegroundColor = ConsoleColor.Green;
             if (senha == senha1)
             {Console.WriteLine("senha correta!!!");
             Console.WriteLine($"pagamento concluido");   
             }else{
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("senha incorreta!!!");}}
            break;
            
                //pagar no debito
         case 2: {
         Console.WriteLine(""+D.pagamentoD);
         int senhaD = int.Parse(Console.ReadLine());
         Console.ForegroundColor = ConsoleColor.Green;
         if (senhaD == senhaDE)
         {Console.WriteLine("senha correta!!!");
         Console.WriteLine("pagamento concluido");   
         }else{
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("senha incorreta!!!");}}
         break;

                //pagar por boleto
            case 3:{  Console.WriteLine("-- BOLETO -- " );
                      B.Valor = valor;
                      B.GerarBoleto();
                      Console.WriteLine(""+B.mensagem);

                      int codigoB = int.Parse(Console.ReadLine());
                      if (codigoB == codigoRamd )
                     { 
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("Código Aceito!");
                     Console.WriteLine("pagamento por boleto concluido");
                     }else{  
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Codigo não indentificado, digite novamente!");
                     }}
            //cancelar
            break;
            case 4: 
            {B.Cancelar();}
            break;
            default:
            break;
           }
            






        }
    }
}
