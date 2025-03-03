namespace exercicios.exercicios.SomaMedia
{
    public class SomaMedia
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string num;
            do
            {
                Console.WriteLine("Digite a quantidade de números que deseja colocar: ");
                int n;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    decimal[] list = new decimal[n];
                    for (int i = 0; i < n; i++ )
                    { 
                        Console.WriteLine("Digite o valor entre 3 e 10: ");
                        num = Console.ReadLine();
                        if (decimal.TryParse(num, out decimal result)) { decimal.TryParse(num, out list[i]); } 
                        else Console.WriteLine("Numero invalido, digite de 3 a 10 ");
                    }
                    decimal soma = list.Sum();
                    decimal media = list.Average();
                    Console.WriteLine("Soma = " + soma);
                    Console.WriteLine("Media = " + media);
                    flag = false;
                }
            } while (!flag);
        }
    }
}