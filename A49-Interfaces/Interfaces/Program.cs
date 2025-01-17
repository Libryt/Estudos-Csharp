SalvarXml salvarXml = new();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();
interface ISalvar
{
    public void Salvar();
    public void Compactar()
    {
        Console.WriteLine("Compactando arquivos");
    }
}
abstract class ArquivoBase
{
    public virtual void Nome()
    {
        Console.WriteLine("Definir o nome do arquivo");
    }
}
class SalvarXml : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo em XML");
    }
    public override void Nome()
    {
        Console.WriteLine("Definir nome XML");
    }
}
class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo em JSON");
    }
    public override void Nome()
    {
        Console.WriteLine("Definir nome JSON");
    }
}