List<string> frutas = new() { "Maçã", "Pera", "Uva", "Mamão", "Kiwi", "Figo" };
var frutaContém = frutas.Find(Procura); //Procura a primeira ocorrência de acordo com o método
Console.WriteLine(frutaContém);

static bool Procura(string item) //O método precisa ser booleano para que se verifique se a condição é ou não é atendida
{
    return item.Contains('o'); //Contém
}
var frutaComeça = frutas.Find(Procura2);
Console.WriteLine(frutaComeça);
static bool Procura2(string item)
{
    return item.StartsWith('U'); //Começa com U
}
Console.WriteLine(frutas.Find(item => item.Contains('r'))); // Usando expressão Lambda para pular a etapa de criação de método.
var frutaUltimaOcorrencia = frutas.FindLast(item => item.Contains('a')); //Acha a ultima ocorrencia que contém 'a'
Console.WriteLine(frutaUltimaOcorrencia);

var frutaIndice = frutas.FindIndex(item => item.Contains('a'));//Acha o índice da primeira ocorrência que contém 'a'
Console.WriteLine($"Indice = {frutaIndice} Fruta = {frutas[frutaIndice]}");
var frutaUltimoIndice = frutas.FindLastIndex(item => item.Contains('a')); //Acha o índice da ultima ocorrência que contém 'a'
Console.WriteLine($"Indice = {frutaUltimoIndice} Fruta = {frutas[frutaUltimoIndice]}");

var frutaTodasQueContém = frutas.FindAll(item  => item.Contains('i')); //Acha todas as ocorrencias que contém 'i'
foreach(var fruta in frutaTodasQueContém)
{
    Console.Write(fruta+' ');
}


Console.ReadKey();