int[] arraybrabo = { 10, 20, 30, 40, 50, 60, 70, 80 }; //Array só pra adicionar valores à lista
Numeros.lista.AddRange(arraybrabo);

Numeros numeros = new();//Criação da instância da classe

Console.WriteLine(numeros[8]); //Tenta Executar um número no limite do array R -> 0 , pois não foi criado e atribuido nenhum valor
numeros[8] = 9; //Cria e atribui o valor
Console.WriteLine(numeros[8]); //R -> 9
numeros[15] = 15; //R -> Erro, pois a borda até então é 8, logo não existe vetores de [9..15] sendo necessário adicionar-lós
Console.WriteLine(numeros[15]); //R -> Não é possível acessar o índice {15} sem preencher as posições anteriores.
class Numeros
{
    public static List<int> lista = new List<int>(); //Criação da lista
    public int this[int i] //Criação do índice
    {
        get //Propriedade de leitura
        {
            if (i >= 0 && i < lista.Count)
            {
                return lista[i];
            }
            return 0;
        }
        set //Propriedade de gravação
        {
            if (i >= 0 && i < lista.Count) //Se estiver dentro dos limites corretos retorna o valor
            {
                lista[i] = value;
            }
            else if (i == lista.Count) //Se indice for igual à quantidade de valores do array(Não de vetores), adiciona um valor.
            {
                lista.Add(value);
            }
            else
            {
                // Lança exceção se o índice for muito além do tamanho da lista
                Console.WriteLine($"Não é possível acessar o índice {i} sem preencher as posições anteriores.");
            }
        }

    }
}