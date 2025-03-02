namespace exercicios
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            bool flag = false;
            double num1, num2;
            int escolha;

            do
            {
                Console.Write("Digite o primeiro numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                num2 = double.Parse(Console.ReadLine());
                Console.Write("Digite 1 para somar, 2 para subtrair, 3 para multiplicar, 4 para dividir, 5 para resto da divisão, 6 para expoente: ");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 4 && num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Impossivel dividir por 0");
                }
                else
                {
                    switch (escolha)
                    {
                        case 0:
                            flag = true;
                            break;
                        case 1:
                            Console.WriteLine("Resultado de " + num1 + " + " + num2 + " = " + Soma(num1, num2));
                            break;
                        case 2:
                            Console.WriteLine("Resultado de " + num1 + " - " + num2 + " = " + Subtracao(num1, num2));
                            break;
                        case 3:
                            Console.WriteLine("Resultado de " + num1 + " * " + num2 + " = " + Multiplicacao(num1, num2));
                            break;
                        case 4:
                            Console.WriteLine("Resultado  de " + num1 + " / " + num2 + " = " + Division(num1, num2));
                            break;
                        case 5:
                            Console.WriteLine("Resultado  de " + num1 + " / " + num2 + " = " + DivisionInteiros(num1, num2));
                            Console.WriteLine("Resto de " + num1 + " % " + num2 + " = " + RestoDaDivision(num1, num2));
                            break;
                        case 6:
                            Console.WriteLine("Resultado expoente de " + num1 + "^" + num2 + " = " + Expoente(num1, num2));
                            break;
                    }
                }
            } while (!flag); 
            Console.WriteLine("Fim do programa!");
        }
        
        private static double Soma(double num1, double num2) => num1 + num2;
        private static double Subtracao(double num1, double num2) => num1 - num2;
        private static double Multiplicacao(double num1, double num2) => num1 * num2;
        private static double Division(double num1, double num2) => num1 / num2;
        private static int DivisionInteiros(double num1, double num2) => Convert.ToInt32(num1 / num2);
        private static double RestoDaDivision(double num1, double num2) => num1 % num2;
        private static double Expoente(double num1, double num2) => Math.Pow(num1, num2);
    }
}

