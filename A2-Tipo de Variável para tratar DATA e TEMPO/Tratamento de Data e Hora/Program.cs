//Tratamento de Data e Hora

using System.ComponentModel;

DateTime dataatual = DateTime.Now;
Console.WriteLine(dataatual);


//criar uma data específica e hora usando formato do S.O em uso

Console.WriteLine("---Data Específica Criada---");

DateTime datahoje = new DateTime(2024, 03, 15);
Console.WriteLine(datahoje);

Console.WriteLine("---Data Específica com Hora");
DateTime datahojecomhora = new DateTime(2024, 03, 15, 13, 37, 30);

Console.WriteLine(datahojecomhora);

//extrair informações precisas da data que quero 

Console.WriteLine("---Extrair informações precisas da data que quero.");

DateTime dataagora = DateTime.Now;

Console.WriteLine("Ano -> " +dataagora.Year);
Console.WriteLine("Mês -> " + dataagora.Month);
Console.WriteLine("Dia -> " + dataagora.Day);
Console.WriteLine("Hora -> " + dataagora.Hour);
Console.WriteLine("Minuto -> " + dataagora.Minute);
Console.WriteLine("Segundo -> " + dataagora.Second);
Console.WriteLine("Milisegundo -> " + dataagora.Millisecond);

//adicionando valores às datas
System.Console.WriteLine($"---Adicionando valores às datas---");


System.Console.WriteLine("Data e Hora Base: " + dataagora);
Console.WriteLine("Adicionando Dias -> "+dataagora.AddDays(15));
Console.WriteLine("Adicionando Meses -> "+dataagora.AddMonths(2));
Console.WriteLine("Adicionando Anos -> "+dataagora.AddYears(2));
Console.WriteLine("Adicionando Horas -> "+dataagora.AddHours(10));
Console.WriteLine("Adicionando Minutos -> "+dataagora.AddMinutes(15));

//obtendo o dia da semana e do ano
System.Console.WriteLine("---Obtendo o dia da semana e do ano---");


Console.WriteLine("Este é o dia da semana da data atual: " + datahoje.DayOfWeek);
Console.WriteLine("Este é o dia do ano da data atual: " + datahoje.DayOfYear);

//obtendo o formato longo e curto da data
System.Console.WriteLine("---Obtendo o formato longo e curto da data---");

DateTime Datafictícia = new DateTime (2006,04,11, 14, 05, 20);
Console.WriteLine("Este é o formato de data longa: " + Datafictícia.ToLongDateString()); 
Console.WriteLine("Este é o formato de data curta: " + Datafictícia.ToShortDateString());
Console.WriteLine("Este é o formato de tempo longo: " + Datafictícia.ToLongTimeString());
Console.WriteLine("Este é o formato de tempo curto: " + Datafictícia.ToShortTimeString());

DateTime adiamento = DateTime.Now;
System.Console.WriteLine("DataAtual: " + adiamento);
System.Console.WriteLine("System.Console.WriteLine('A data atual com um adiamento de 10 dias é: ' + adiamento.AddDays(10));");
System.Console.WriteLine("A data atual com um adiamento de 10 dias é: " + adiamento.AddDays(10));

//tratando somente de horas

TimeSpan hora = new TimeSpan(10,20,30);
Console.WriteLine(hora);
System.Console.ReadKey();
