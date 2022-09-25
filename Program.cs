using System.Text;

namespace PasswordApp
{
    class Program
    {
        static void Main()
        {
            int qtdCaracteres;
            string caracteresPossiveis = "ABCDEFGHIJKLMNOPQRSTUWXYZ" + "ABCDEFGHIJKLMNOPQRSTUWXYZ".ToLower() + "!@#$%&*" + "1234567890";
            System.Console.WriteLine("Password generator by Alison\n");
            System.Console.WriteLine("Quantidade de caracteres: ");
            qtdCaracteres = Convert.ToInt32(Console.ReadLine());

            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();

            for (int i = 0; i < qtdCaracteres; i++)
            {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }
            System.Console.Write(password);
        }
    }
}