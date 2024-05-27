namespace Estudo.AutoFac.Services;

public class SmsService : IMobileService
{
    public void Execute()=>Console.WriteLine("Executando servico de SMS...");
}
