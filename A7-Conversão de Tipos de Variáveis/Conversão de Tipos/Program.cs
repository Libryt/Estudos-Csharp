/* //Conversão de Tipos de Variáveis em outros Tipos
int inteiro = 10;
double real = 20.5;
bool @bool = true;


//Convertendo tipos de valores em strings
string s1 = @bool.ToString();
string s2 = inteiro.ToString();
string s3 = real.ToString();


//Convertendo tipos de valores em outros valores.

System.Console.WriteLine($"O Número inteiro convertido em booleano é {inteiro} e o valor booleano é: {Convert.ToBoolean(inteiro)}"); //Converte número inteiro em boolean
System.Console.WriteLine($"O Número inteiro convertido em real é: {Convert.ToDouble(inteiro)}"); // Converte número inteiro em real
System.Console.WriteLine($"O Número real convertido em inteiro é: {real} e o valor convertido fica {Convert.ToInt16(real)}");
*/

int valorInteiro = 10; 
string valorInteiroString = valorInteiro.ToString();
Console.WriteLine(Convert.ToBoolean(valorInteiro));
Console.WriteLine(Convert.ToDouble(valorInteiro));
Console.ReadKey();




Console.ReadKey();
