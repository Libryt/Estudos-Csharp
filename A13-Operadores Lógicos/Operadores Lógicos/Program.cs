/*
Operador/Significado/x1 = true; x2 = false;/comportamento
  &&       AND = E      c1 && c2 --> false    (Todos são verdadeiros?) Retorna True somente se c1 E c2 forem do mesmo tipo
* ||       OR = OU      c1 || c2 --> true     (Algum deles são verdadeiros?) Retorna True quando pelo menos uma das variáveis for verdadeira.
! !        NOT = NÃO    !(c1 &&  c2 --> true  (Inverte) Retorna True se for Falso e Falso se for True.       
*/

bool v1 = false;
bool v2 = false;
bool resultado = v1 && v2; //v1 e v2 são os mesmos valores? se sim vai retornar os valores dois dois iguais
System.Console.WriteLine($"O valor && é: {resultado}"); //resulta em false pois os dois são falses, se os dois fossem true seria true, se fossem diferentes seriam false.
bool resultado2 = v1 || v2; // se qualquer um for True então vai retornar True
System.Console.WriteLine($"O valor || é: {resultado2}"); // resulta em false, pois nenhum dos dois é true.
System.Console.WriteLine($"O valor ! é: {!resultado}"); // inverte o valor de resultado, ou seja vai ser true.
Console.ReadKey();
