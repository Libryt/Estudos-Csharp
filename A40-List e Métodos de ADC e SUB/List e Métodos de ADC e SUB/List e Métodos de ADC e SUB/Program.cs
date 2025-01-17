namespace List_e_Métodos_de_ADC_e_SUB
{
    using System;
    using System.Collections.Generic;
    class App
    {

        static void Main(string[] args)
        {
            List<double> lista = new() { 1, 2, 4, 5, 6 };
            ExibirLista(lista);//Retorna a lista(1,2,3,4,5)


            //### Métodos para adição de elementos

            lista.Add(7); //Adiciona ao final
            lista.Insert(2, 3); // Mesma coisa que o RemoveAt, adiciona na posição requerida do array.
            Console.WriteLine("");
            ExibirLista(lista);// retorna ( 1 2 3 4 5 6 7)
            double[] dezenas = { 10, 20, 30 };
            double[] nDecimal = { 2.15, 3.51, 2.13 };
            lista.AddRange(dezenas); // adiciona coleção(array) ao final
            lista.InsertRange(6, nDecimal); // adiciona coleção(array) na posição requerida
            Console.WriteLine("");
            ExibirLista(lista);//retorna ( 1 2 3 4 5 6 2.15 3.51 2.13 7 10 20 30)

            //### Métodos para remoção de elementos

            lista.Remove(30); // Remove a primeira ocorrência do elemento desejado
            lista.RemoveAt(0); // Remove o elemento na posição do vetor solicitado
            Console.WriteLine("");
            ExibirLista(lista);// retorna (2 3 4 5 6 2.15 3.51 2.13 7 10 20)
            lista.RemoveRange(2, 3); // Remove uma quantidade solicitada de elementos a partir da posição do vetor solicitada
            Console.WriteLine("");
            ExibirLista(lista);// retorna (2 3 2.15 3.51 2.13 7 10 20)

            // ### Métodos gerais
            Console.WriteLine($"\nExistem {lista.Count} elementos na lista"); // lista.Count() retorna a contagem de elementos dentro do array

            Console.WriteLine("Vetor 0 -> " + lista[0]);
            lista[0] = 100; // Atribui um novo valor ao vetor solicitado
            Console.WriteLine("Vetor 0 novo -> " + lista[0]);
            int x = 10; int y = 11;

            Console.WriteLine("Lista contem numero 10? " + lista.Contains(10)); // Verifica se a lista contém o elemento solicitado e retorna True ou false. R: True
            Console.WriteLine("Lista contem numero 11? " + lista.Contains(11)); // R: False
            lista.Clear(); // Zera a quantidade de elementos e a quantidade de vetores.
            lista.AddRange(dezenas); //Automaticamente adiciona a quantidade de vetores necessárias e os elementos solicitados
            Console.WriteLine("");
            Console.WriteLine("Array Novo");
            ExibirLista(lista);// retorna ( 10 20 30)
                               //Se eu tentar -> Console.Write(lista[3]); < VAI DAR ERRO por que nao existe posição de vetor 3
            lista.Reverse();
            Console.WriteLine("\nArray Reverse");
            ExibirLista(lista);
            lista.Sort(); // Organiza o array a partir de ordem alfabetica ou ordinal
            Console.WriteLine("\nArray Sort");
            ExibirLista(lista);
            static void ExibirLista(List<double> lista)
            {
                foreach (double number in lista)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
