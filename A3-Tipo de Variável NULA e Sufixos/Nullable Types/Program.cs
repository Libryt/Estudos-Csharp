//Tipos de Variáveis Nulas, ou Nullable Types

Nullable<int> grande = null; //É um tipo de variável que permite atribuição de um valor nulo a outro tipo de variável, a sintaxe é composta de -> Nullable + <tipodavariavel> + nomedavariavel + tipo de valor
//Sintaxe -> Nullable<T> nome = valor; Sendo <T> == int, double, float, bool, etc.
Console.WriteLine(grande);

int? i = null; // forma simplificada do nullable type



//Propriedades do Nullable Type (.HasValue e .Value)

double? @do = null;
if (@do.HasValue) {
Console.WriteLine($"A variável d não é  nula e seu valor é {@do.Value}");
}
else {
Console.WriteLine("A variável é nula");
}



//Como fazer com que não dê erro ao atribuir um NullableType à um tipo de valor

int? a = null; 
//int b = a -> Error
int? b = a ?? 0; //Se 'a' é nulo, vai retornar o tipo de valor declarado na variavel b, se não for nulo, a variável b vai receber o valor da variável 'a'
System.Console.WriteLine(b); //Resultado 0
int? c = 10;
int? d = c ?? 0;
System.Console.WriteLine(d); // Res: 10









Console.ReadKey();