Console.Clear();

int digitado;

Console.WriteLine("--- Numeros negativos ---");

Console.Write("Digite um numero: ");
digitado = Convert.ToInt32(Console.ReadLine());

if (digitado < 0)
{
   Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine("Você digitou um numero negativo");
   Console.ResetColor();
}


