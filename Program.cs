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
            

            B.mensagem = "insira o codigo para pagar por boleto";
            D.pagamentoD="insira a senha para pagamento!!";
            B.Cancelar();
            B.Registrar();
            C.SalvarCartao();
            int senha1 = C.Senha;
            int senhaDE = D.SenhaD;
            C.Pagar();
            int codigo1 = B.CodigoDeBarras;
            C.pagamento = "insira a senha para pagamento!!";
            //----------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Bem vindo!!!");
            Console.WriteLine("----------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Pagar no Crédito - [1]");
            Console.WriteLine("Pagar no Débito - [2]");
            Console.WriteLine("Pagar com boleto - [3]");
            Console.WriteLine("cancelar - [4]");
            Console.WriteLine("--------------");
            int Opcao = int.Parse(Console.ReadLine());
            switch (Opcao)
           {
            case 1:
            {Console.WriteLine(""+C.pagamento);
            int senha = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
             if (senha == senha1)
            {Console.WriteLine("senha correta!!!");
            Console.WriteLine("pagamento concluido");   
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("senha incorreta!!!");}}
            break;
            
             case 2: {Console.WriteLine(""+D.pagamentoD);
             int senhaD = int.Parse(Console.ReadLine());
              Console.ForegroundColor = ConsoleColor.Green;
             if (senhaD == senhaDE)
            {Console.WriteLine("senha correta!!!");
            Console.WriteLine("pagamento concluido");   
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("senha incorreta!!!");}}
            break;
            case 3:{ Console.WriteLine(""+B.mensagem);
            int codigoB = int.Parse(Console.ReadLine());
             if (codigoB == codigo1)
             { Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("Código Aceito!");
             Console.WriteLine("pagamento por boleto concluido");
             }else{
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Codigo não indentificado, digite novamente!");
             }
            }
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
