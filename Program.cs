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
            
            B.Cancelar();
            B.Registrar();
            C.SalvarCartao();
            int senha1 = C.Senha;
            C.Pagar();
            Console.Clear();
            C.pagamento = "insira a senha para pagamento!!";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Bem vindo!!!");
            Console.WriteLine("----------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Pagar - [1]");
            Console.WriteLine("Cancelar - [2]");
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
                Console.WriteLine("senha incorreta!!!");
            }
            
           
            }
            
            break;

            case 2:
            {B.Cancelar();}
            break;

            default:
            break;
            }
            






        }
    }
}
