repetir://label e goto
int adv;
Random aleatorio = new Random();
int random = aleatorio.Next(1,101);
System.Console.WriteLine("Tente adivinhar o número de 1-100.");
System.Console.WriteLine("Você só tem 3 chances. Escreva o número:\n");
int tentativa = 1;
int chances = 3;
do // faça -> enquanto (while)
  {  
    chances--;
    adv = int.Parse(Console.ReadLine());
    System.Console.WriteLine($"Você digitou: {adv}");
    if(adv > 100) {
      Console.WriteLine("Você digitou um número maior do que 100, escreva outro número.");
    }
    else {
    if (tentativa != 0)
    {
    if (adv > random) {
        System.Console.WriteLine("Errado. O número que você digitou é maior");
        if (chances == 0)
        {
            System.Console.WriteLine("Suas chances acabaram\n");
            break;
        }
        System.Console.WriteLine($"Tente novamente, você só tem mais {chances} chances!\n");
        tentativa++;
                      }
        else if (adv == random) {
        System.Console.WriteLine($"\aVocê acertou. O número era: {adv}!");
        }
        else {
        System.Console.WriteLine("Errado. O número que você digitou é menor");
        if (chances == 0)
        {
            System.Console.WriteLine($"Suas chances acabaram. O número era: {random}");
            break;
        }        
        System.Console.WriteLine($"Tente novamente, você só tem mais {chances} chances!\n");
        tentativa++;
            }
    }
    }
  } while(tentativa < 4 && adv != random);
System.Console.WriteLine("Aperte (Y) se você deseja continuar ou Enter se você deseja finalizar o programa.");
ConsoleKeyInfo tecla = Console.ReadKey();
if (tecla.Key == ConsoleKey.Y)
{
    Console.WriteLine();
    goto repetir;
}
else{}
