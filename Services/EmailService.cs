namespace Estudo.AutoFac.Services;

public class EmailService : IMailService
{
    public void Execute() => Console.WriteLine("Executando serviço de email...");
}
