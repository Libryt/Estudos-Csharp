using System.Collections;

//###SINTAXE BÁSICA###

ArrayList listaExemplo = new ArrayList(); //Cria uma arraylist
listaExemplo.Add(10); //Adiciona valores à arraylist
listaExemplo.Add("nome");


var lista = new ArrayList() { 10, 20, "string" }; //Cria uma ArrayList de modo simplificado
int[] numeros = { 1, 2, 3 };
int[] numeros2 = { 11, 12, 13 };

//###ADICIONAR ELEMENTOS###

lista.AddRange(numeros); // Adiciona o array ao final da lista {10, 20, "string", 1, 2, 3 }
Console.WriteLine(lista[5]);// Imprime o 3

lista.InsertRange(5, numeros2); //Adiciona o array na posição 5 do vetor { 10, 20, "string", 1, 2, 11, 12, 13, 3}
Console.WriteLine(lista[8]);
foreach (var num in lista)
{
    Console.Write(num + " ");
}

lista.Insert(2, "string"); // { 10, 20, "string", "string", 1, 2, 11, 12, 13, 3}

//###REMOVER ELEMENTOS

lista.Remove("string"); //o primeiro string encontrado é removido >> { 10, 20, "string", 1, 2, 11, 12, 13, 3}

lista.RemoveAt(0); //O valor na posição 0 é removido e outro valor vira 0 {20, "string", 1, 2, 11, 12, 13, 3}

lista.RemoveRange(1, 3); //{20, "string", 1, 2, 11, 12, 13, 3} os elementos na faixa de 1 e 3 são removidos >> {20, 11, 12, 13, 3}

//###MANIPULAR ELEMENTOS###

bool verificação = lista.Contains(11); Console.WriteLine($"\n{verificação}"); //>>Verifica se existe o elemento especificado no array >> True
bool verificação2 = lista.Contains(null); Console.WriteLine(verificação2); // >> False

